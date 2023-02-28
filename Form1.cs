using GUIInterface.Config;
using GUIInterface.models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUIInterface;

public partial class Form1 : Form
{
	private static Db db;
	private int ownerId;
	private int carId;

	private Boolean owner_exist = false;
	private String filter = "";


	public Form1()
	{
		InitializeComponent();
		db = Db.GetInstance();
		Affichage(filter:filter);

	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{

	}

	private void label3_Click(object sender, EventArgs e)
	{

	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{

	}

	private void label6_Click(object sender, EventArgs e)
	{

	}

	private void Form1_Load(object sender, EventArgs e)
	{

	}

	private void wfSubmit_Click(object sender, EventArgs e)
	{

		String _CNI = wfCNI.Text;
		String _FIRST_NAME = wfFirstName.Text;
		String _LAST_NAME = wfLastName.Text;
		String _PHONE = wfPhone.Text;
		String _DoB = wfDoB.Text;


		if (AllFieldsIsNotEmpty() == false)
		{
			MessageBox.Show("/!\\ All fields is required!");
			return;
		}

		if (VerifCNI(_CNI) == false)
		{
			MessageBox.Show("/!\\ CNI must be at least 13 characters long and start with 1 or 2 (1: male, 2: female)");
			return;
		}

		if (VerifFirstAndLastName(_FIRST_NAME) == false)
		{
			MessageBox.Show("/!\\ Firstname must be at least 2 caracters");
			return;
		}

		if (VerifFirstAndLastName(_LAST_NAME) == false)
		{
			MessageBox.Show("/!\\ Lastname must be at least 2 caracters");
			return;
		}

		if (VerifPhone(_PHONE) == false)
		{
			MessageBox.Show("/!\\ PHONE field is required 9 caracters and startwidth 7");
			return;
		}

		DateOnly date = DateOnly.Parse(_DoB);
		int oYear = date.Year;
		if (VerifDoB(oYear) == false)
		{
			MessageBox.Show("/!\\ Illegal to those under 18");
			return;
		}



		Owner ow = new(_CNI, _FIRST_NAME, _LAST_NAME, _PHONE, DateOnly.Parse(_DoB));
		try
		{
			if (owner_exist == false) {
				ownerId = AddOwnerReturnId(ow);
			}
			else {
				string sql = "SELECT OWNER_ID FROM auto_owners WHERE CNI=@CNI";
				db.InitParams();
				db.addParametre("@CNI", _CNI, SqlDbType.NVarChar);
				ownerId = db.executeUpdateReturnId(sql,1) ;
			}
		}
		catch (Exception ex) {
			Console.WriteLine(ex.Message);
			MessageBox.Show(ex.Message);
			return;
		}

		try
		{
			String _MATRICULE = wfMatricule.Text;
			String _MARQUE = wfMarque.Text;
			String _MODEL = wfModel.Text;
			String _TRANSMISSION = wfTransmission.Text;
			int _YEAR = Convert.ToInt32(wfYear.Text);

			Car cr = new(_MATRICULE, _MARQUE, _MODEL, _TRANSMISSION, _YEAR, ownerId);
			carId = AddCar(cr);
			Clear();
			Affichage(filter);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			MessageBox.Show(ex.Message);
			return;
		}

		MessageBox.Show(carId == 0 ? "Not Inserted" : "Inserted");

	}

	private void wfCancel_Click(object sender, EventArgs e)
	{
		Clear();
	}



	SqlDataReader GetOwnerByCNI(String cni)
	{
		string sql = "SELECT FIRST_NAME,LAST_NAME,PHONE,DOB FROM auto_owners WHERE CNI=@CNI";
		db.InitParams();
		db.addParametre("@CNI", cni, SqlDbType.NVarChar);
		SqlDataReader dr = db.executeSelect(sql, 1);

		return dr;
	}


		int AddOwner(Owner o) {
			int row = 0;
			string sql = "Insert into auto_owners values (@FIRST_NAME,@LAST_NAME,@PHONE,@CNI,@DOB)";
			db.InitParams();
			db.addParametre("@FIRST_NAME", o.FirstName, SqlDbType.NVarChar);
			db.addParametre("@LAST_NAME", o.LastName, SqlDbType.NVarChar);
			db.addParametre("@PHONE", o.Phone + "", SqlDbType.NVarChar);
			db.addParametre("@CNI", o.CNI, SqlDbType.NVarChar);
			db.addParametre("@DOB", o.DoB + "", SqlDbType.Date);

			row = db.executeUpdate(sql, 1);
			return row;
		}


		int AddOwnerReturnId(Owner o)
		{
			string sql = "INSERT INTO auto_owners (FIRST_NAME, LAST_NAME, PHONE, CNI, DOB) OUTPUT INSERTED.OWNER_ID VALUES (@FIRST_NAME,@LAST_NAME,@PHONE,@CNI,@DOB)";
			db.InitParams();
			db.addParametre("@FIRST_NAME", o.FirstName, SqlDbType.NVarChar);
			db.addParametre("@LAST_NAME", o.LastName, SqlDbType.NVarChar);
			db.addParametre("@PHONE", o.Phone, SqlDbType.NVarChar);
			db.addParametre("@CNI", o.CNI, SqlDbType.NVarChar);
			db.addParametre("@DOB", o.DoB + "", SqlDbType.Date);


			return db.executeUpdateReturnId(sql, 1);
		}


		int AddCar(Car c)
		{
			int row = 0;
			string sql = "Insert into auto_cars values (@MATRICULE,@MARQUE,@MODEL,@TRANSMISSION,@YEAR,@OWNER_ID)";
			db.InitParams();
			db.addParametre("@MATRICULE", c.Matricule, SqlDbType.NVarChar);
			db.addParametre("@MARQUE", c.Marque, SqlDbType.NVarChar);
			db.addParametre("@MODEL", c.Model + "", SqlDbType.NVarChar);
			db.addParametre("@TRANSMISSION", c.Transmission, SqlDbType.NVarChar);
			db.addParametre("@YEAR", c.Year + "", SqlDbType.Int);
			db.addParametre("@OWNER_ID", c.OwnerId + "", SqlDbType.Int);


			row = db.executeUpdate(sql, 1);

			return row;
		}



		Boolean AllFieldsIsNotEmpty()
		{
			return !(
				wfCNI.Text.Trim().IsNullOrEmpty() || 
				wfFirstName.Text.Trim().IsNullOrEmpty() ||
				wfLastName.Text.Trim().IsNullOrEmpty() ||
				wfPhone.Text.Trim().IsNullOrEmpty() ||
				wfDoB.Text.Trim().IsNullOrEmpty() || 

				wfMatricule.Text.Trim().IsNullOrEmpty() ||
				wfMarque.Text.Trim().IsNullOrEmpty() ||
				wfModel.Text.Trim().IsNullOrEmpty() ||
				wfTransmission.Text.Trim().IsNullOrEmpty() ||
				wfYear.Text.IsNullOrEmpty()
			);
		}
		Boolean VerifCNI(String cni)
		{
			return cni.Length == 13 && (cni.StartsWith("1") || cni.StartsWith("2"));
		}
		Boolean VerifFirstAndLastName(String name)
		{
			return name.Length >= 2;
		}
		Boolean VerifPhone(String phone)
		{
			return phone.Length == 9 && phone.StartsWith('7');
		}

		Boolean VerifDoB(int dob)
		{
			DateTime CurrentYear = DateTime.Now;
			int year = CurrentYear.Year;

			return (year - dob) >= 18;
		}



		void Clear()
		{
			wfCNI.Text = "esgfhjkhgfhjk";
			wfFirstName.Text = "";
			wfLastName.Text = "";
			wfPhone.Text = "";
			wfDoB.Text = null;

			wfMatricule.Text = "";
			wfMarque.Text = "";
			wfModel.Text = "";
			wfTransmission.Text = "";
			wfYear.Text = "2023";
		}



	private void wfCNI_Leave(object sender, EventArgs e)
	{
		String cni = wfCNI.Text.Trim();
		SqlDataReader dr = GetOwnerByCNI(cni);

		try
		{
			if(dr.Read()) {
				// 1234567891234
				wfFirstName.Text = dr[0].ToString();
				wfLastName.Text = dr[1].ToString();
				wfPhone.Text = dr[2].ToString();
				wfDoB.Text = dr[3].ToString();

				owner_exist= true;

			} else {
				//MessageBox.Show("ABRACADABRA!!!!");
			}
		} catch(Exception err) {
			MessageBox.Show(err.Message);
		}
		finally { dr.Close(); }
	}


	private SqlDataReader SetTable(SqlDataReader dr)
	{
		try
		{
			wfDataTable.Rows.Clear();
			do
			{
				while (dr.Read())
				{
					wfDataTable.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
				}
			} while (dr.NextResult());
			return dr;
		}
		catch
		{
			return null;
		}
		finally { dr.Close(); }
	}

	void Affichage(String filter) {
		db.GetConnexion();

		wfDataTable.ColumnCount = 6;
		wfDataTable.Columns[0].Name = "CNI";
		wfDataTable.Columns[1].Name = "FIRST_NAME";
		wfDataTable.Columns[2].Name = "LAST_NAME";
		wfDataTable.Columns[3].Name = "PHONE";
		wfDataTable.Columns[4].Name = "BRAND";
		wfDataTable.Columns[5].Name = "YEAR";

		String sql;
		SqlDataReader dr;

		switch (filter) {
			case "Male":
				sql = "SELECT CNI,FIRST_NAME,LAST_NAME,PHONE,MARQUE,ANNEE FROM auto_owners, auto_cars WHERE auto_owners.OWNER_ID=auto_cars.OWNER_ID AND auto_owners.CNI LIKE '1%'";
				dr = db.executeSelect(sql);
				SetTable(dr);
				break;

			case "Female":
				sql = "SELECT CNI,FIRST_NAME,LAST_NAME,PHONE,MARQUE,ANNEE FROM auto_owners, auto_cars WHERE auto_owners.OWNER_ID=auto_cars.OWNER_ID AND auto_owners.cni like '2%'";
				dr = db.executeSelect(sql);
				SetTable(dr);
				break;

			default:
				sql = "SELECT CNI,FIRST_NAME,LAST_NAME,PHONE,MARQUE,ANNEE FROM auto_owners, auto_cars WHERE auto_owners.OWNER_ID=auto_cars.OWNER_ID";
				dr = db.executeSelect(sql);
				SetTable(dr);
				break;
		}


	}

	private void filterByGender_ValueChanged(object sender, EventArgs e)
	{
		filter = filterByGender.Text.Trim();
		// MessageBox.Show(g);
		Affichage(filter);
	}
}