using System;
using System.Windows.Forms;

namespace SourceCode
{
  
    public partial class FormAdmon : Form
    {
        private UserControl current = null;
        public FormAdmon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new NewUser();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteUser();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new AllUsers();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new AddBusiness();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteBusiness();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new AddProduct();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteDesigner();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new ViewOrders();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new ModifyUser();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,5,0);
            tableLayoutPanel1.SetRowSpan(current, 5);
        }
    }
}