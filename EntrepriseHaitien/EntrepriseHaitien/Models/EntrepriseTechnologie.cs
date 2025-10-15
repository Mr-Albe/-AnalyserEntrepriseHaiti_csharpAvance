/*
 * Created by SharpDevelop.
 * User: Albe
 * Date: 14/10/2025
 * Time: 18:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EntrepriseHaitien.Models
{
	/// <summary>
	/// Description of EntrepriseTechnologie.
	/// </summary>
	public class EntrepriseTechnologie :Entreprise
	{
		private int nombreEmployesTech;
        private double budget;
        private int nombreBrevets;

        public EntrepriseTechnologie(int id, string nom, string adresse, double revenu, double depense, string pdg, DateTime dateCreation,
                                     int nombreEmployesTech, double budget, int nombreBrevets)
            : base(id, nom, adresse, revenu, depense, pdg, dateCreation)
        {
            this.nombreEmployesTech = nombreEmployesTech;
            this.budget = budget;
            this.nombreBrevets = nombreBrevets;
        }

        public int NombreEmployesTech {
			get { return nombreEmployesTech; }
			set { nombreEmployesTech = value; }
		}

		public double Budget {
			get { return budget; }
			set { budget = value; }
		}

		public int NombreBrevets {
			get { return nombreBrevets; }
			set { nombreBrevets = value; }
		}
	}
}
