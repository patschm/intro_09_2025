namespace Gafisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"{e.Location.X}, {e.Location.Y}";
        }
    }
}
