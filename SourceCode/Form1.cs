using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text.Equals("")|| textBox2.Text.Equals("")) throw new EmptyTextBoxes("No puede dejar informacion vacia");
                LogIn log = new LogIn();
                log.Login(textBox1.Text, textBox2.Text);
            }
            catch (EmptyTextBoxes esg)
            {
                MessageBox.Show(esg.Message);
            }
        }
    }
}