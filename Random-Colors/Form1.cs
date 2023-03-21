namespace Random_Colors
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            listView1.BackColor = Color.FromArgb(red, green, blue);

            generateBtn.Text = "#" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");
        }
    }
}