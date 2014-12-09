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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }
        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

            if (tbNombre.Text != null)
            {
                if (tbNombre.Text == "") { tbNombre.Clear(); } //Vide la textbox

                //Fonction magique 

                int nombre = 0;
                //Déclaration des variables
                if (tbNombre.Text == "")
                {
                    nombre = 0;
                }
                else
                {
                    tbNombre.MaxLength = 9;
                    try
                    {
                        nombre = Convert.ToInt32(tbNombre.Text);

                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message); 
                    }
                }
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
                tbResultat.Text = r;
            }
        }
        
    }
}
