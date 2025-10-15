/*
 * Created by SharpDevelop.
 * User: Albe
 * Date: 14/10/2025
 * Time: 18:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EntrepriseHaitien.Models
{
	/// <summary>
	/// Description of EntrepriseSante.
	/// </summary>
	public class EntrepriseSante : Entreprise
	{
		// NombreLaboratoires, CertificationSanitaire
		
		private int nombreLaboratoire;
		private string certificatioSanitaire;
		
		// Constructeur
		public EntrepriseSante(int id, string nom, string adresse, double revenu, double depense, string pdg, DateTime dateCreation,int nombreLaboratoire, string certificatioSanitaire)
			: base(id, nom, adresse, revenu, depense, pdg, dateCreation) {
			this.nombreLaboratoire = nombreLaboratoire;
			this.certificatioSanitaire = certificatioSanitaire;
		}
		
		
		public int NombreLaboratoire {
			get { return nombreLaboratoire; }
			set { nombreLaboratoire = value; }
		}

		public string CertificatioSanitaire {
			get { return certificatioSanitaire; }
			set { certificatioSanitaire = value; }
		}
	}
}
