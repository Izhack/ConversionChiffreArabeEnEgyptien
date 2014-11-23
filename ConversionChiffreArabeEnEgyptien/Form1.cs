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
            //Déclaration des variables
            int nombre = Convert.ToInt32(tbNombre.Text);
            //int nombre = 1234567;
            string r = "";
            //int nb1, nb10, nb100, nb1000, nb10000, nb100000, nb1000000;
            int resulat;
            //Opération de recuperation des nombres


            for (int i = 1000000; i >= 1; i = i / 10)
            {
                resulat = nombre / i;
                nombre = nombre % i;



                r = r + "Il y 'a " + resulat + " hommes \r\n";
            }



            //Affichage du resultat
            //r = "Il y 'a " + nb1000000 + " hommes \r\n" + nb100000 + "crapeau";
            tbResultat.Text = r; 
        }
    }
}
