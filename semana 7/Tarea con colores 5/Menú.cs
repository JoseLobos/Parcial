using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_con_colores_5 
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

      

        private void computadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void laptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void celularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por visitarnos, lo esperamos pronto", "Tecnology Center",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
           Application.Exit();
        }

        private void formularioDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioDeVentas = new Ventas();
            formularioDeVentas.Show();
        }

      

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        

        private void ayudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form AYUDA = new Ayuda2();
                AYUDA.Show();
            }
        }

        private void enQuePodemosAyudarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ayudas = new Ayuda();
           ayudas.Show();
        }

        private void laptopsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form laptops = new Laptops();
            laptops.Show();
        }

        private void celularesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Celulares = new Celulares();
            Celulares.Show();
        }

        private void computadorasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Acerca_de = new AboutBox1();
            Acerca_de.Show();
        }

        private void computadorasDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Computadorasdisponibles = new Computadoras();
            Computadorasdisponibles.Show();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form integrantesdeequipo = new Integrantes();
            integrantesdeequipo.Show();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fempleados = new fempleados();
            fempleados.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Fconsultaempleado = new Fconsultaempleado();
            Fconsultaempleado.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Fconsultausuario = new Fconsultausuario();
            Fconsultausuario.Show();
        }

        private void registroEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fregistro fm = new fregistro(); fm.Show();
        }
    }
    }

