namespace projet_ffss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tabLicence = new int[100];
        string[]tabClub= new string[100];
        string[] tabNom= new string[100];
        string[] tabPrenom= new string[100];
        string[] tabDate= new string[100];
        string[] tabSexe=new string[100];
        string[] tabCate=new string[100];
        int nbNageurs;


        private void Form1_Load(object sender, EventArgs e)
        {
            nbNageurs = 0;
        }
        private void buttonPerf_Click(object sender, EventArgs e)
        {
            tabLicence[nbNageurs] = Convert.ToInt32(textBoxLicence.Text);
            tabClub[nbNageurs]=textBoxClub.Text;
            tabNom[nbNageurs] = textBoxNom.Text;
            tabPrenom[nbNageurs]= textBoxPrenom.Text;
            tabDate[nbNageurs] = textBoxNaissance.Text;
            tabCate[nbNageurs] = textBoxCate.Text;
            if (radioButtonFe.Checked)
            {
                tabSexe[nbNageurs] = "Femme";
            }
            else
            {
                tabSexe[nbNageurs] = "Homme";
            }
            nbNageurs++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex= 1;
            labelElicence.Text = Convert.ToString(tabLicence[nbNageurs-1]);
            labelEclub.Text = tabClub[nbNageurs-1];
            labelEnom.Text = tabNom[nbNageurs-1];
            labelEprenom.Text = tabPrenom[nbNageurs-1];
            labelEnaissance.Text =tabDate[nbNageurs-1];
            labelEgenre.Text = tabSexe[nbNageurs-1];
            labelEcat.Text = tabCate[nbNageurs-1];

        }

        private void buttoncotier_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            labelClicence.Text = Convert.ToString(tabLicence[nbNageurs - 1]);
            labelCclub.Text = tabClub[nbNageurs - 1];
            labelCnom.Text = tabNom[nbNageurs - 1];
            labelCprenom.Text = tabPrenom[nbNageurs - 1];
            labelCnaissance.Text = tabDate[nbNageurs - 1];
            labelCgenre.Text = tabSexe[nbNageurs - 1];
            labelCcat.Text = tabCate[nbNageurs - 1];
        }

        private void radioButtonShort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLongues_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonPerf_Click_1(object sender, EventArgs e)
        {
            tabLicence[nbNageurs] = Convert.ToInt32(textBoxLicence.Text);
            tabClub[nbNageurs] = textBoxClub.Text;
            tabNom[nbNageurs] = textBoxNom.Text;
            tabPrenom[nbNageurs] = textBoxPrenom.Text;
            tabDate[nbNageurs] = textBoxNaissance.Text;
            tabCate[nbNageurs] = textBoxCate.Text;
            if (radioButtonFe.Checked)
            {
                tabSexe[nbNageurs] = "Femme";
            }
            else
            {
                tabSexe[nbNageurs] = "Homme";
            }
            nbNageurs++;
        }

    }
}