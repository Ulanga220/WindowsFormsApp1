using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
    {

    public partial class Form1 : Form
    {

        List<Programador> ListaProg = new List<Programador>();
        List<Defecto> ListaDef = new List<Defecto>();


        public Form1()


            
                    {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (int.Parse(txtid.Text) < 0)
            {
                MessageBox.Show("El Id debe ser mayor a 0");
               
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text))

            {
                MessageBox.Show("Debe escribir una descripción");
            }

            if (DateTime.Parse(txtFechaAlta.Text) > DateTime.Today)

            {
                MessageBox.Show("La fecha no puede ser futura");
            }

            else
            {
                ListaDef = Defecto.ObtenerD();

                ListaDef.Add(new Defecto { Id = int.Parse(txtid.Text), Descripcion = txtDesc.Text, FechaAlta = DateTime.Parse(txtFechaAlta.Text) });
            }
            
            /*if (!string.IsNullOrWhiteSpace(txtDesc.Text))

            {
                ListaDef = Defecto.ObtenerD();

                ListaDef.Add(new Defecto { Descripcion = txtDesc.Text });
            }

            else { MessageBox.Show("No has escrito la descripción"); }

            if (DateTime.Parse(txtFechaAlta.Text) <= DateTime.Today)

            {
                ListaDef = Defecto.ObtenerD();

                ListaDef.Add(new Defecto { FechaAlta = DateTime.Parse(txtFechaAlta.Text) });
            }
MessageBox.Show("Escogiste una fecha futura
            else { "); }*/


          foreach (var aux1 in ListaDef)

            
            {
                listSinResolver.Items.Add("Id" + "  " + "Descripcion" + "           " + "Fecha Alta");

                listSinResolver.Items.Add(aux1.Id + "  " + aux1.Descripcion + "  " + aux1.FechaAlta.ToString(("dd/MM/yyyy")));
                

            }



        }


           /*  if (int.Parse(txtid.Text) >= 1) 

            defecto1.Id = int.Parse(txtid.Text); 

            else { MessageBox.Show("El ID debe ser mayor a 1 y no debe repetirse"); }
            defecto1.Descripcion = (txtDesc.Text);
            defecto1.FechaAlta = DateTime.Parse(txtFechaAlta.Text); */
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
                ListaProg = Programador.ObtenerP();

                foreach (var aux in ListaProg)
                {

                listBox1.Items.Add(aux.nombre);
                }
            }
    }
}
