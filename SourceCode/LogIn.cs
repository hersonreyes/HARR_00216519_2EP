using System;
using System.Windows.Forms;

namespace SourceCode
{
    public class LogIn
    {

        public LogIn()
        {
           
        }

        public void Login(string user,string password)
        {
            try
            {
            var dn = ConnectionDB.ExecuteQuery($"SELECT username FROM APPUSER WHERE username = '{user}'");
            var dr1 = dn.Rows[0];

            var dc2 = ConnectionDB.ExecuteQuery($"SELECT password FROM APPUSER WHERE username = '{user}'");
            var dr2 = dc2.Rows[0];


            if (dr1[0].ToString().Equals(user) && dr2[0].ToString().Equals(password))
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT usertype FROM APPUSER WHERE username='{user}'");
                var dr = dt.Rows[0];

                if (dr[0].ToString() == "True")
                {
                    FormAdmon frmA = new FormAdmon();
                    frmA.Show();
                }
                else if (dr[0].ToString() == "False")
                {
                    FormNoAdmon frmN = new FormNoAdmon(user);
                    frmN.Show();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
       catch (Exception ex)
        {
            MessageBox.Show("Ha ocurrido un error");
        }
        }
    }
}
