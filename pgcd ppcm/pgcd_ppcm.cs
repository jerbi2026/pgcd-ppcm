using System.Security.Cryptography.X509Certificates;

namespace pgcd_ppcm
{
    public partial class pgcd_ppcm : Form
    {
        public pgcd_ppcm()
        {
            InitializeComponent();
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            n1.Text = "";
            n2.Text = "";
            pgcd_txt.Text = "";
            ppcm_txt.Text = "";
        }
        static int prcd(int x , int y)
        {
            
            while (x != y)
            {
                if (x > y)
                    x= x - y;
                else
                    y = y - x;
            }
            return x;
        }
        static int prcm(int a , int b)
        {
            int p = a * b;
            while (a != b)
                if (a < b)
                    b -= a;
                else a -= b;
            return p / a;
        }

        private void pgcd_Click(object sender, EventArgs e)
        {
            int nb1, nb2;
            nb1 = int.Parse(n1.Text);
            nb2 = int.Parse(n2.Text);
            int v = nb1 * nb2;
            if (v == 0 )
            {
                pgcd_txt.Text = "pas de pgcd";
            }
            int pg;
            pg= prcd(nb1, nb2);
            if (pg != 1)
                pgcd_txt.Text = pg.ToString();
            else
                pgcd_txt.Text = "premier entre eux";
        }

        private void ppcm_Click(object sender, EventArgs e)
        {
            int nb1, nb2, pp;
            nb1 = int.Parse(n1.Text);
            nb2 = int.Parse(n2.Text);
            pp = prcm(nb1, nb2);
            ppcm_txt.Text = pp.ToString();
        }
    }
}