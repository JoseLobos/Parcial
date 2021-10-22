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
            button9.Visible = true;
            button4.Visible = true;
            button1.Visible = true;
            button8.Visible = true;
            button3.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox6.Clear();
            this.comboBox2.Text = "";
            this.comboBox1.Text = "";
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
            string insertar = "INSERT INTO empleado (ID_EMPLEADO,NOMBRES,APELLIDOS,FECHA_DE_NACIMIENTO,TELEFONO,DIRECCION,SEXO,PUESTO_DE_TRABAJO,SUELDO,OBSERVACIONES)values(@id_empleado,@nombres,@apellidos,@fecha_de_nacimiento,@telefono,@direccion,@sexo,@puesto_de_trabajo,@sueldo,@observaciones)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@id_empleado", textBox1.Text);
            cmd.Parameters.AddWithValue("@nombres", textBox2.Text);
            cmd.Parameters.AddWithValue("@apellidos", textBox3.Text);
            cmd.Parameters.AddWithValue("@fecha_de_nacimiento", textBox4.Text);
            cmd.Parameters.AddWithValue("@telefono", textBox5.Text);
            cmd.Parameters.AddWithValue("@direccion", textBox7.Text);
            cmd.Parameters.AddWithValue("@sexo", comboBox2.Text);
            cmd.Parameters.AddWithValue("@puesto_de_trabajo", comboBox1.Text);
            cmd.Parameters.AddWithValue("@sueldo", textBox8.Text);
            cmd.Parameters.AddWithValue("@observaciones", textBox9.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("El empleado ah sido agregado con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox2.Text = "Seleccione el sexo";
            comboBox1.Text = "Seleccione el puesto de trabajo";
            textBox1.Focus();
            button5.Visible = false;
            button1.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            
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
                comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            catch
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cn.Open();
            string eliminar = "DELETE FROM empleado WHERE ID_EMPLEADO=@ID_EMPLEADO";
            MySqlCommand cmd = new MySqlCommand(eliminar, cn);

            cmd.Parameters.AddWithValue("@Id_Empleado", textBox1.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(" El empleado fue eliminado  con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox2.Text = "Seleccione el sexo";
            comboBox1.Text = "Seleccione el puesto de trabajo";
            textBox1.Focus();
            button5.Visible = false;
            button6.Visible = false;
            button9.Visible = false;
            button7.Visible = false;
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
            this.comboBox2.Text = "";
            this.comboBox1.Text = "";
            comboBox1.Select();
            textBox4.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            this.comboBox2.Text = "";
            this.comboBox1.Text = "";

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

        private void button9_Click(object sender, EventArgs e)
        {
            cn.Open();
            string actualizar = "UPDATE empleado SET ID_EMPLEADO=@id_empleado,NOMBRES=@nombres,APELLIDOS=@apellidos,FECHA_DE_NACIMIENTO=@fecha_de_nacimiento,TELEFONO=@telefono,DIRECCION=@direccion,SEXO=@sexo,PUESTO_DE_TRABAJO=@puesto_de_trabajo,SUELDO=@sueldo,OBSERVACIONES=@observaciones WHERE ID_EMPLEADO=@id_empleado";
            MySqlCommand cmd = new MySqlCommand(actualizar, cn);

            cmd.Parameters.AddWithValue("@id_empleado", textBox1.Text);
            cmd.Parameters.AddWithValue("@nombres", textBox2.Text);
            cmd.Parameters.AddWithValue("@apellidos", textBox3.Text);
            cmd.Parameters.AddWithValue("@fecha_de_nacimiento", textBox4.Text);
            cmd.Parameters.AddWithValue("@telefono", textBox5.Text);
            cmd.Parameters.AddWithValue("@direccion", textBox7.Text);
            cmd.Parameters.AddWithValue("@sexo", comboBox2.Text);
            cmd.Parameters.AddWithValue("@puesto_de_trabajo", comboBox1.Text);
            cmd.Parameters.AddWithValue("@sueldo", textBox8.Text);
            cmd.Parameters.AddWithValue("@observaciones", textBox9.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("El empleado ah sido modificado con exito");
            dataGridView1.DataSource = llenar_grid();
        }
    }
}
    


