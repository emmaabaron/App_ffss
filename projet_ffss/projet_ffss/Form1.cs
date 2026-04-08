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
        int[] tabDate= new int[100];
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
            tabDate[nbNageurs] = Convert.ToInt32(textBoxNaissance.Text);
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
        }

        private void buttoncotier_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void radioButtonShort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLongues_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}