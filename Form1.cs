namespace FormlarArasiGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifre;
            string kullaniciad;
            kullaniciad = Convert.ToString(textBox1.Text);
            sifre= Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                Form2 yeni = new Form2(); //form2'yi �a��rma kodu
                yeni.Show(); //burda form2 yi g�sterdim
                this.Hide(); // form1 kapand�.
            }
            else
            {
                MessageBox.Show("Hatal� Giri� Yapt�n�z!");
            }
        }
    }
}