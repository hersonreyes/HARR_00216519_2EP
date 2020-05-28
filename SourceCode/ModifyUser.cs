using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class ModifyUser : UserControl
    {
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                
            {
                MessageBox.Show("No puede dejar los campos vacios");
            }
            else
            {

                try
                {

                    string nonQuery = $"UPDATE APPUSER set password='{textBox1.Text}'" +
                                      $"WHERE username='{comboBox1.SelectedItem.ToString()}'";

                    ConnectionDB.ExecuteNonQuery(nonQuery);
                    MessageBox.Show("Usuario Modificado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            var names = ConnectionDB.ExecuteQuery("SELECT username FROM APPUSER");

            var namesCombo = new List<string>();
            foreach (DataRow dr in names.Rows)
            {
                namesCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = namesCombo;
        }
    }
}