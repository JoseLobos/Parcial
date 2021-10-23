using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Tarea_con_colores_5
{
    public partial class Fconsultaempleado : Form
    {
        public Fconsultaempleado()
        {
            InitializeComponent();
        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=base de datos mysql;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        public String connectionstring = "Database=base de datos mysql;Data Source=localhost;User Id=root;Password= ";

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Menú fm = new Menú(); fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {

                string consulta = "Select * from empleado where Id_Empleado ='" + textBox6.Text + "'";

                MySqlConnection con = new MySqlConnection(connectionstring);

                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, con);

                System.Data.DataSet ds = new System.Data.DataSet();

                comando.Fill(ds, "base de datos mysql");

                dataGridView1.DataSource = ds;

                dataGridView1.DataMember = "base de datos mysql";

            }

            catch (MySqlException k)

            {

                MessageBox.Show(k.ToString());

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               dataGridView1.CurrentRow.Cells[0].Value.ToString();
               dataGridView1.CurrentRow.Cells[1].Value.ToString();
               dataGridView1.CurrentRow.Cells[2].Value.ToString();
               dataGridView1.CurrentRow.Cells[3].Value.ToString();
               dataGridView1.CurrentRow.Cells[4].Value.ToString();
               dataGridView1.CurrentRow.Cells[5].Value.ToString();
               dataGridView1.CurrentRow.Cells[6].Value.ToString();
               dataGridView1.CurrentRow.Cells[7].Value.ToString();
               dataGridView1.CurrentRow.Cells[8].Value.ToString();
               dataGridView1.CurrentRow.Cells[9].Value.ToString();
               dataGridView1.CurrentRow.Cells[10].Value.ToString();
               dataGridView1.CurrentRow.Cells[11].Value.ToString();
               dataGridView1.CurrentRow.Cells[12].Value.ToString();
               dataGridView1.CurrentRow.Cells[13].Value.ToString();
               dataGridView1.CurrentRow.Cells[14].Value.ToString();
               dataGridView1.CurrentRow.Cells[15].Value.ToString();


            }
            catch
            {
            }
        }

        private void Fconsultaempleado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "Select* From empleado";
            MySqlCommand cdm = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cdm);
            da.Fill(dt);
            cn.Close();
            return dt;

        }
    }
}
