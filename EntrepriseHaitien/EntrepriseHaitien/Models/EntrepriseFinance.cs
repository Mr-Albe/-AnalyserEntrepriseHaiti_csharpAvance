/*
 * Created by SharpDevelop.
 * User: Albe
 * Date: 14/10/2025
 * Time: 18:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EntrepriseHaitien.Models
{
	/// <summary>
	/// Description of EntrepriseFinance.
	/// </summary>
	public class EntrepriseFinance : Entreprise
	{
				/// <summary>
		///  CapitalSocial, NombreClients, RendementInvestissement
		/// </summary>
		/// 
	
		private double capitalSocial;
		private int nombreClients;
		private double rendementInvestissement;
	
	
		// constructeur 
		public EntrepriseFinance(int id, string nom, string adresse, double revenu, double depense, string pdg, DateTime dateCreation, double capitalSocial, int nombreClients, double rendementInvestissement )
		: base(id, nom, adresse, revenu, depense, pdg, dateCreation) {
			this.capitalSocial = capitalSocial;
			this.nombreClients = nombreClients;
			this.rendementInvestissement =rendementInvestissement;
		}
		
		public double CapitalSocial {
			get { return capitalSocial; }
			set { capitalSocial = value; }
		}

		public int NombreClients {
			get { return nombreClients; }
			set { nombreClients = value; }
		}

		public double RendementInvestissement {
			get { return rendementInvestissement; }
			set { rendementInvestissement = value; }
		}
	}
}
