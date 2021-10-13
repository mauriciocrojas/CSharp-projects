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
    public partial class FormSW : Form
    {

        private EjercitoImperial ejercitoImperial;
        public enum Tipos
        {

            Explorador,
            Arena,
            Asalto
        }
        public FormSW()
        {
            InitializeComponent();
            ejercitoImperial = new EjercitoImperial(10);
            ejercitoImperial += new TrooperAsalto(Blaster.EC17);
            RefrescarEjercito();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Tipos));
            //cmbTipo.Items.Add(); //con esto puedo agregar string facilmente


        }

        public void RefrescarEjercito()
        {
            lstEjercito.Items.Clear();
            foreach (Trooper item in this.ejercitoImperial.Troopers)
            {
                this.lstEjercito.Items.Add(item.InfoTrooper());
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ejercitoImperial += creacionTrooper();
            RefrescarEjercito();

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (!object.ReferenceEquals(this.cmbTipo.SelectedItem, null))
            {
                //lstEjercito.Items.RemoveAt(lstEjercito.SelectedIndex); //esto removeria segun indice del listado
                ejercitoImperial -= creacionTrooper();
                RefrescarEjercito();
            }
        }

        private Trooper creacionTrooper()
        {
            string typeSelected = cmbTipo.SelectedItem.ToString();
            Trooper auxTrooper;

            switch (typeSelected)
            {
                case "Arena":
                    //TrooperArena trooperArena = new TrooperArena(Blaster.EC17);
                    //lstEjercito.Items.Add(trooperArena.InfoTrooper());
                    auxTrooper = new TrooperArena(Blaster.EC17);
                    break;
                case "Asalto":
                    // TrooperAsalto trooperAsalto = new TrooperAsalto(Blaster.E11);
                    //  lstEjercito.Items.Add(trooperAsalto.InfoTrooper());
                    auxTrooper = new TrooperAsalto(Blaster.E11);
                    break;
                default:
                    {
                        auxTrooper = new TrooperExplorador("Moto"); break;
                    }
            }
            return auxTrooper;
        }
    }
}
