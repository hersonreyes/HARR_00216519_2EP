using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            var names = ConnectionDB.ExecuteQuery("SELECT username FROM APPUSER");

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

            string nonQuery = $"DELETE FROM APPUSER WHERE username='{comboBox1.SelectedItem.ToString()}'";

           ConnectionDB.ExecuteNonQuery(nonQuery);
            MessageBox.Show("Usuario Eliminado");
            }
              catch (Exception ex)
              {
                  MessageBox.Show("Ha ocurrido un error!");
              }
        }
    }
}