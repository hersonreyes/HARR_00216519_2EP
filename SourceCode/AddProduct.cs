using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var names = ConnectionDB.ExecuteQuery("SELECT idbusiness FROM BUSINESS");

            var namesCombo = new List<string>();
            foreach (DataRow dr in names.Rows)
            {
                namesCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = namesCombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery("INSERT INTO PRODUCT(idBusiness, name)" +
                                             $"VALUES({comboBox1.SelectedItem}, '{textBox2.Text}')");

                MessageBox.Show("Producto Añadido");
            }

            catch (Exception esg)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}