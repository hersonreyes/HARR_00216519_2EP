using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class DeleteDesigner : UserControl
    {
        public DeleteDesigner()
        {
            InitializeComponent();
        }

        private void DeleteDesigner_Load(object sender, EventArgs e)
        {
            var names = ConnectionDB.ExecuteQuery("SELECT idbusiness FROM BUSINESS");

            var namesCombo = new List<string>();
            foreach (DataRow dr in names.Rows)
            {
                namesCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = namesCombo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var names = ConnectionDB.ExecuteQuery($"SELECT name FROM PRODUCT WHERE idbusiness={comboBox1.SelectedItem}");

            var namesCombo = new List<string>();
            foreach (DataRow dr in names.Rows)
            {
                namesCombo.Add(dr[0].ToString());
            }

            comboBox2.DataSource = namesCombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idbusiness={comboBox1.SelectedItem} AND " +
                                             $"name='{comboBox2.SelectedItem}'");
                MessageBox.Show("Producto Eliminado");

            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha cocurrido un problema");
            }
        }
    }
}