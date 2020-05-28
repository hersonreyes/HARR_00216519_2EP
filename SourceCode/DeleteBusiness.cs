using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class DeleteBusiness : UserControl
    {
        public DeleteBusiness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE idBusiness = {comboBox1.SelectedItem}");
                MessageBox.Show("Negocio Eliminado");

            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha cocurrido un problema");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT * FROM BUSINESS WHERE idbusiness={comboBox1.SelectedItem}");
                dataGridView1.DataSource = dt;
            
            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha cocurrido un problema");
            }
        }

        private void DeleteBusiness_Load(object sender, EventArgs e)
        {
            var names = ConnectionDB.ExecuteQuery("SELECT idbusiness FROM BUSINESS");

            var namesCombo = new List<string>();
            foreach (DataRow dr in names.Rows)
            {
                namesCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = namesCombo;
        }
    }
}