namespace net_hesaplama_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNethesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;

            double turkceYanlis, matYanlis;

            double turkceNet, matNet;

            turkceDogru = Convert.ToDouble(txtDogruM.Text);

            turkceYanlis = Convert.ToDouble(txtYanlisT.Text);

            turkceNet = (turkceDogru - (turkceYanlis / 4));

            txtNetT.Text = turkceNet.ToString();

            matDogru = Convert.ToDouble(txtDogruM.Text);

            matYanlis = Convert.ToDouble(txtYanlisM.Text);

            matNet = (matDogru - (matYanlis / 4));

            txtNetM.Text = matNet.ToString();
        }
    }
}