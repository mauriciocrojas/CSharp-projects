using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rojas.Mauricio._2C;



namespace TestTroopers
{
    public partial class Form1 : Form
    {
        public enum Tipos
        {
          
            Explorador,
            Arena,
            Asalto
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Tipos));
            
            

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string typeSelected = cmbTipo.SelectedItem.ToString();

            switch (typeSelected)
            {
                case "Arena":
                    TrooperArena trooperArena = new TrooperArena(Blaster.EC17);
                    lstEjercito.Items.Add(trooperArena.InfoTrooper());
                    //ejercito + trooperArena;
                    break;
                case "Explorador":
                    TrooperExplorador trooperExplorador = new TrooperExplorador("Moto");
                    lstEjercito.Items.Add(trooperExplorador.InfoTrooper());
                    break;
                case "Asalto":
                    TrooperAsalto trooperAsalto = new TrooperAsalto(Blaster.E11);
                    lstEjercito.Items.Add(trooperAsalto.InfoTrooper());
                    break;
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            lstEjercito.Items.RemoveAt(lstEjercito.SelectedIndex);
        }
    }
}
