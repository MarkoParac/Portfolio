using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature
{
    public partial class Form1 : Form
    {
        private List<Measurement> mjere = new List<Measurement>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Measurement m = new Measurement(txtNaziv.Text, int.Parse(txtTemperatura.Text), dateTimePicker1.Value);
            mjere.Add(m);
            BindingSource bs = new BindingSource(mjere, null);
            dataGridView1.DataSource = bs;
            IzracunajTemp();

        }

        private void IzracunajTemp()
        {
            int suma = 0;
            int prosjek = 0;

            foreach (Measurement mes in mjere)
            {
                suma = suma + mes.Temperatura;
            }
            prosjek = suma / mjere.Count;

            if (prosjek > 0)
            {
                lblProsjecna.ForeColor = Color.Red;
                lblProsjecna.Text = prosjek.ToString();
            }
            else if (prosjek < 0)
            {
                lblProsjecna.ForeColor = Color.Blue;
                lblProsjecna.Text = prosjek.ToString();
            }
        }
    }
}
