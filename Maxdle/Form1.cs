namespace Maxdle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(Top, Left);
            form2.ShowDialog();
            this.Close();            
        }
    }
}
