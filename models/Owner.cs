using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIInterface.models;

internal class Owner
{
	public string CNI { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set;}
	public string Phone { get; set; }	
	public DateOnly DoB { get; set; }

	public Owner(string cNI, string firstName, string lastName, string phone, DateOnly doB)
	{
		CNI = cNI;
		FirstName = firstName;
		LastName = lastName;
		Phone = phone;
		DoB = doB;
	}

}
