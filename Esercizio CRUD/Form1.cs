using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_CRUD
{

    public partial class Form1 : Form
    {
        public struct PrezzoProdotto
        {
            public string nome;
            public double prezzo;
        }
        public PrezzoProdotto[] p = new PrezzoProdotto[2];
        public int dim =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aggiunta();
        }
        public void Aggiunta()
        {
            p[dim].nome = Prodotto.Text;
            p[dim].prezzo = double.Parse(Prezzo.Text);
            dim++;
        }

        private void Visualizza(object sender, EventArgs e)
        {
            Listaprod.Items.Clear();
            for (int i = 0;i<dim;i++)
            {
                Listaprod.Items.Add("Oggetto: " + p[i].nome+" Prezzo: " + p[i].prezzo);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
