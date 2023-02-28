using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIInterface.models;

internal class Car
{
	public string Matricule { get; set; }
	public string Marque { get; set; }
	public string Model { get; set; }	
	public string Transmission { get; set; }
	public int Year { get; set; }
	public int OwnerId { get; set; }


	public Car(string matricule, string marque, string model, string transmission, int year, int ownerId)
	{
		Matricule = matricule;
		Marque = marque;
		Model = model;
		Transmission = transmission;
		Year = year;
		OwnerId = ownerId;
	}
}
