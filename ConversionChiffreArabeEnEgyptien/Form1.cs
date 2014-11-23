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
        private Bitmap MyImage;
        private void btnValider_Click(object sender, EventArgs e)
        {
            //Déclaration des variables
            int nombre = Convert.ToInt32(tbNombre.Text);
            //int nombre = 1234567;
            string r = "";
            int resulat;

            //----------------------------
            
            //Opération de recuperation des nombres


            for (int i = 1000000; i >= 1; i = i / 10)
            {
                resulat = nombre / i;
                nombre = nombre % i;

                //Afficahge des images
                //Image newImage = Image.FromFile(image1.png); 
                //MyImage = new Bitmap('C:\Users\Faize\Desktop\ConversionChiffreArabeEnEgyptien');
                //pbResultat.Image = 


                r = r + "Il y 'a " + resulat + " hommes \r\n";
            }



            //Affichage du resultat
            //r = "Il y 'a " + nb1000000 + " hommes \r\n" + nb100000 + "crapeau";
            tbResultat.Text = r; 
        }

        
    }
}
