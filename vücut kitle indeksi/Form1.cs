namespace vücut_kitle_indeksi
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy,vci; 
                int kilo;
            
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToInt32(textBox2.Text);
            boy = boy / 100;
            vci = kilo / (boy * boy);
            textBox3.Text = Convert.ToString(vci);
            if (vci > 15 && vci<25)
            {
                textBox4.Text = "Normal  ";
            }
            else if (vci < 20) { textBox4.Text = "Zayıf"; }
            else textBox4.Text = "Obez";
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}