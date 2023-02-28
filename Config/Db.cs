using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIInterface.Config;

internal class Db
{
	private SqlConnection cn;
	private SqlCommand cmd;
	private SqlDataAdapter da;
	private List<SqlParameter> parametres;
	private static Db db;

	public static Db GetInstance()
	{
		return db ?? (db = new Db());
	}

	public void InitParams()
	{
		parametres = new List<SqlParameter>();
	}
	public void GetConnexion()
	{

		if (cn == null || cn.State == System.Data.ConnectionState.Closed)
		{
			cn = new SqlConnection();
			//cn.ConnectionString = @"data source=DESKTOP-AKM4GES\user;initial catalog=automobile;integrated security=True;MultipleActiveResultSets=True";
			cn.ConnectionString = @"Data Source=DESKTOP-AKM4GES;initial catalog=automobile;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			try
			{
				cn.Open();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw ex;
			}
		}
	}
	// fonction pour ajouter un parametre dans la liste
	public void addParametre(string paramName, string paramValue, SqlDbType paramType)
	{
		var param = new SqlParameter();
		param.ParameterName = paramName;
		param.Value = paramValue;
		param.SqlDbType = paramType;
		parametres.Add(param);
	}

	// fonction pour executer les requetes MAJ (insert, update, delete, ...)
	public int executeUpdate(string sql, int option = 0)
	{
		var n = 0;
		try
		{
			GetConnexion();
			// preparation de l'execution de requete (on definit la requete et la connexion)
			cmd = new SqlCommand(sql, cn);
			// si c'est une requete parametrée
			if (option == 1)
			{
				foreach (SqlParameter par in parametres)
				{
					cmd.Parameters.Add(par);
				}
				parametres = new List<SqlParameter>();
			}
			// execute la requete sql et renvoie le nombre de lignes mises à jour
			n = cmd.ExecuteNonQuery();

		}
		catch (Exception ex)
		{
			throw ex;
		}
		return n;
	}
	// fonction pour executer les requetes MAJ (insert, update, delete, ...)
	public int executeUpdateReturnId(string sql, int option = 0)
	{
		var n = -1;
		try
		{
			GetConnexion();
			// preparation de l'execution de requete (on definit la requete et la connexion)
			cmd = new SqlCommand(sql, cn);
			// si c'est une requete parametrée
			if (option == 1)
			{
				foreach (SqlParameter par in parametres)
				{
					cmd.Parameters.Add(par);
				}
				parametres = new List<SqlParameter>();
			}
			// execute la requete sql et renvoie le nombre de lignes mises à jour
			n = (int)cmd.ExecuteScalar();

		}
		catch (Exception ex)
		{
			throw ex;
		}
		return n;
	}

	// fonction qui execute un select et qui revoie un datareader
	public SqlDataReader executeSelect(string sql, int option = 0)
	{
		SqlDataReader dr = null;
		try
		{
			GetConnexion();
			// preparation de l'execution de requete (on definit la requete et la connexion)
			cmd = new SqlCommand(sql, cn);
			// si c'est une requete parametrée
			if (option == 1)
			{
				foreach (SqlParameter par in parametres)
				{
					cmd.Parameters.Add(par);
				}
				parametres = new List<SqlParameter>();
			}
			// executer la requete
			dr = cmd.ExecuteReader();
		}
		catch (Exception ex)
		{
			throw ex;
		}
		return dr;
	}
	public void fermerconnexion()
	{
		try
		{
			if (cn.State == System.Data.ConnectionState.Open)
				cn.Close();
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public int count_select(String sql)
	{
		try
		{
			SqlCommand cmd = new SqlCommand(sql, cn);
			int count = (int)cmd.ExecuteScalar();
			return count;
		}catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
			return -1;
		}
	}

	/*public int GetOwnerIdByCNI(string cni)
	{
		string sql = "SELECT OWNER_ID FROM auto_owners WHERE CNI = @CNI";
		db.InitParams();
		db.addParametre("@CNI", cni, SqlDbType.NVarChar);

		return this.executeSelectReturnId(sql);
	}*/

	/*public void executeVersDataSet(string sql, DataSet ds, string table, int option = 0)
	{
		try
		{
			GetConnexion();
			// préparer l'execution de la requete
			da = new SqlDataAdapter(sql, cn);
			// executer et charger les données dans le dataset
			// si c'est une requete parametrée
			if (option == 1)
			{
				foreach (SqlParameter par in parametres)
				{
					da.SelectCommand.Parameters.Add(par);
				}
				parametres = new List<SqlParameter>();
			}
			da.Fill(ds, table);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}*/
}

