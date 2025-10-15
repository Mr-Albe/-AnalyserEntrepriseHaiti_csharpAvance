/*
 * Created by SharpDevelop.
 * User: Albe
 * Date: 14/10/2025
 * Time: 18:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EntrepriseHaitien.Models
{
	/// <summary>
	/// Description of Entreprise.
	/// </summary>
	/// 
	
	
	 public abstract class Entreprise
	{
	 // Champs privés
        private int id;
        private string nom;
        private string adresse;
        private double revenu;
        private double depense;
        private string pdg;
        private DateTime dateCreation;

        // Constructeur
        public Entreprise(int id, string nom, string adresse, double revenu, double depense, string pdg, DateTime dateCreation)
        {
            this.id = id;
            this.nom = nom;
            this.adresse = adresse;
            this.revenu = revenu;
            this.depense = depense;
            this.pdg = pdg;
            this.dateCreation = dateCreation;
        }

        // Propriétés publiques (Encapsulation)
        public int Id { 
        	get { return id;}
        	set { id = value;}
        }
        
        public string Nom { 
        	get { return nom; }
        	set { nom = value;}
        }
        
        public string Adresse { 
        	get { return adresse; }
        	set { adresse = value; }
        }
        
        public double Revenu { 
        	get { return revenu; }
        	set { revenu = value; }
        }
        
        public double Depense { 
        	get { return depense; }
        	set { depense = value; }
        }
        
        public string PDG { 
        	get { return pdg; }
        	set { pdg = value; }
        }
        
        public DateTime DateCreation { 
        	get { return dateCreation; }
        	set { dateCreation = value; }
        }
    
}
}
