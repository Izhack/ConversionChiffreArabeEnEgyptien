using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConversionChiffreArabeEnEgyptien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnValider_Click(object sender, EventArgs e)
        {
            /*r//Déclaration des variables
            int nombre = Convert.ToInt32(tbNombre.Text);
            //int nombre = 1234567;
            string r = "";
            int resulat;
            string images = "";

            //----------------------------
            
            //Opération de recuperation des nombres


            for (int i = 1000000; i >= 1; i = i / 10)
            {
                resulat = nombre / i;
                nombre = nombre % i;

                switch (i)
                {
                    case 1000000: images = "Homme(s)";
                        break;
                    case 100000: images = "Grenouille(s)";
                        break;
                    case 10000: images = "Doight(s)";
                        break;
                    case 1000: images = "Fleure(s)";
                        break;
                    case 100: images = "Spirale(s)";
                        break;
                    case 10: images = "Pont(s)";
                        break;
                    case 1: images = "Barre(s)";
                        break;
                }


                r = r + "Il y 'a " + resulat + " " + images +" \r\n";
            }



            //Affichage du resultat
            //r = "Il y 'a " + nb1000000 + " hommes \r\n" + nb100000 + "crapeau";
            tbResultat.Text = r; */
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            
            //Déclaration des variables
            int nombre = Convert.ToInt32(tbNombre.Text);
            //int nombre = 1234567;
            string r = "";
            int resulat;
            string images = "";

            //----------------------------

            //Opération de recuperation des nombres


            for (int i = 1000000; i >= 1; i = i / 10)
            {
                resulat = nombre / i;
                nombre = nombre % i;

                switch (i)
                {
                    case 1000000: images = "Homme(s)";
                        break;
                    case 100000: images = "Grenouille(s)";
                        break;
                    case 10000: images = "Doight(s)";
                        break;
                    case 1000: images = "Fleure(s)";
                        break;
                    case 100: images = "Spirale(s)";
                        break;
                    case 10: images = "Pont(s)";
                        break;
                    case 1: images = "Barre(s)";
                        break;
                }


                r = r + "Il y 'a " + resulat + " " + images + " \r\n";
            }



            //Affichage du resultat
            //r = "Il y 'a " + nb1000000 + " hommes \r\n" + nb100000 + "crapeau";
            tbResultat.Text = r; 
        }

        
    }
}
