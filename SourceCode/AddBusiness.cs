using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddBusiness : UserControl
    {
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals("") ||
                textBox2.Equals(""))

            {
                MessageBox.Show("No puede dejar los campos vacios!");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery(
                        $"INSERT INTO BUSINESS(name, description) VALUES(" +
                                                        $"'{textBox1.Text}'," +
                                                        $"'{textBox2.Text}')");

                                                 MessageBox.Show("Negocio Añadido");
                }
                catch (Exception esg)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void AddBusiness_Load(object sender, EventArgs e)
        {
           
        }
    }
}