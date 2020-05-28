using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class AddAdress : UserControl
    {
        private string user;
        public AddAdress()
        {
            InitializeComponent();
        }
        public AddAdress(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT iduser FROM APPUSER WHERE username='{user}'");
                var dr = dt.Rows[0];
                int id = Convert.ToInt32(dr[0]);

                ConnectionDB.ExecuteNonQuery("INSERT INTO ADDRESS(idUser, address) " +
                                             $"VALUES({id},'{textBox2.Text}')");

                MessageBox.Show("Direccion añadida");
            }
            catch (Exception esg)
            {
                MessageBox.Show("Ha ocurrido un error");
            }


        }
    }
}