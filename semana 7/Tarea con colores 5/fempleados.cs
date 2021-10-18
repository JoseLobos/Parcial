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
    public partial class fempleados : Form
    {
        public fempleados()
        {
            InitializeComponent();
        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=base de datos mysql;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        public String connectionstring = "Database=base de datos mysql;Data Source=localhost;User Id=root;Password= ";

        private void button4_Click(object sender, EventArgs e)
        {

            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button3.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            this.comboBox2.Text = "";
        }

        private void fempleados_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            string insertar = "INSERT INTO empleado (ID EMPLEADO,NOMBRES,APELLIDOS,CELULAR,CORREO,SEXO)values(@id empleado,@nombres,@apellidos,@celular,@correo,,@sexo)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@id empleado", textBox1.Text);
            cmd.Parameters.AddWithValue("@nombres", textBox2.Text);
            cmd.Parameters.AddWithValue("@apellidos", textBox3.Text);
            cmd.Parameters.AddWithValue("@celular", textBox4.Text);
            cmd.Parameters.AddWithValue("@correo", textBox5.Text);
             cmd.Parameters.AddWithValue("@sexo", comboBox2.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("El empleado ah sido agregado con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cn.Open();
            string actualizar = "UPDATE empleado SET ID EMPLEADO=@id empleado,NOMBRES=@nombres,APELLIDOS=@apellidos,CELULAR=@celular,CORREO=@correo,SEXO=@sexo WHERE CODIGO=@id empleado";
            MySqlCommand cmd = new MySqlCommand(actualizar, cn);

            cmd.Parameters.AddWithValue("@id empleado", textBox1.Text);
            cmd.Parameters.AddWithValue("@nombres", textBox2.Text);
            cmd.Parameters.AddWithValue("@apellidos", textBox3.Text);
            cmd.Parameters.AddWithValue("@celular", textBox4.Text);
            cmd.Parameters.AddWithValue("@correo", textBox5.Text);
            
            cmd.Parameters.AddWithValue("@sexo", comboBox2.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("El empleado ah sido modificado con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            string eliminar = "DELETE FROM empleado WHERE ID EMPLEADO=@ID EMPLEADO";
            MySqlCommand cmd = new MySqlCommand(eliminar, cn);

            cmd.Parameters.AddWithValue("@Id Empleado", textBox1.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" El empleado fue eliminado  con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "Seleccione nivel";
            textBox1.Focus();
            button5.Visible = false;
            button1.Visible = true;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox7.Clear();
            comboBox2.Select();
            textBox4.Clear();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            this.comboBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {

                string consulta = "Select * from empleado where Id Empleado='" + textBox6.Text + "'";

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
    }
}
    


