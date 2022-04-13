using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Text = this.Width + "x" + this.Height;
        }
    }
}