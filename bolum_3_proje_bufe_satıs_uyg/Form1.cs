namespace bolum_3_proje_bufe_satıs_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int kasatutar = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            int misir, su, bilet, cay, toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            su = Convert.ToInt16(txtsu.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            cay = Convert.ToInt16(txtcay.Text);


            toplam = misir * 20 + su * 5 + bilet * 50 + cay * 7;
            lbltoplam.Text = toplam.ToString() + " TL ";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + " TL ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtcay.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();
                
        }
    }
}