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
    public partial class Fconsultausuario : Form
    {
        public Fconsultausuario()
        {
            InitializeComponent();
        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=agenda;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        public String connectionstring = "Database=agenda;Data Source=localhost;User Id=root;Password= ";


        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Menú fm = new Menú(); fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {

                string consulta = "Select * from contactos where codigo ='" + textBox6.Text + "'";

                MySqlConnection con = new MySqlConnection(connectionstring);

                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, con);

                System.Data.DataSet ds = new System.Data.DataSet();

                comando.Fill(ds, "agenda");

                dataGridView1.DataSource = ds;

                dataGridView1.DataMember = "agenda";

            }

            catch (MySqlException k)

            {

                MessageBox.Show(k.ToString());

            }
        }

        private void Fconsultausuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "Select* From contactos";
            MySqlCommand cdm = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cdm);
            da.Fill(dt);
            cn.Close();
            return dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 dataGridView1.CurrentRow.Cells[0].Value.ToString();
                 dataGridView1.CurrentRow.Cells[3].Value.ToString();
                 dataGridView1.CurrentRow.Cells[1].Value.ToString();
                 dataGridView1.CurrentRow.Cells[2].Value.ToString();
                 dataGridView1.CurrentRow.Cells[5].Value.ToString();
                 dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
            }
        }
    }

}
