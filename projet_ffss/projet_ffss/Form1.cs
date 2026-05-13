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

        //Epreuves shorts courses
        string[] tab100o=new string[100];
        string[] tab100s=new string[100];
        string[] tab25=new string[100];
        string[] tab50c=new string[100];
        string[] tab50b=new string[100];
        string[] tab50m=new string[100];

        //Epreuves longues distances
        string[] tab200o=new string[100];
        string[] tab200s = new string[100];
        string[] tab50 = new string[100];
        string[] tab100c = new string[100];
        string[] tab100b = new string[100];
        string[] tab100m = new string[100];

        //Epreuves côtier
        string[] tabnage =new string[100];
        string[] tabplanche = new string[100];
        string[] tabkayak = new string[100];
        string[] tabocean = new string[100];
        string[] tabbeach = new string[100];
        string[] tabsprint = new string[100];

        int nbNageurs;


        private void Form1_Load(object sender, EventArgs e)
        {
            nbNageurs = 0;
            using (StreamReader info_nag = new StreamReader(@"info.txt"))
            {
                while (!info_nag.EndOfStream)
                {
                    //tabLicence[nbNageurs] = Convert.ToInt32(info_nag.ReadLine());
                    tabClub[nbNageurs] = info_nag.ReadLine();
                    tabNom[nbNageurs] = info_nag.ReadLine();
                    tabPrenom[nbNageurs] = info_nag.ReadLine();
                    nbNageurs++;
                }
            }
                
        }

        //A NE PAS UTILISER
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
            //@"C:/Users/BBARON/Documents/C#/app_ffss/
            StreamWriter info_nag = new StreamWriter("info.txt", true);
            info_nag.WriteLine(tabLicence[nbNageurs]);
            info_nag.WriteLine(tabClub[nbNageurs]);
            info_nag.WriteLine(tabNom[nbNageurs]);
            info_nag.Close();
            nbNageurs++;
        }
        //

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlaffichage.SelectedIndex= 1;
            labelElicence.Text = Convert.ToString(tabLicence[nbNageurs-1]);
            labelEclub.Text = tabClub[nbNageurs-1];
            labelEnom.Text = tabNom[nbNageurs-1];
            labelEprenom.Text = tabPrenom[nbNageurs-1];
            labelEnaissance.Text =tabDate[nbNageurs-1];
            labelEgenre.Text = tabSexe[nbNageurs-1];
            labelEcat.Text = tabCate[nbNageurs-1];
            groupBoxshort.Hide();
            groupBoxlong.Hide();

        }

        private void buttoncotier_Click(object sender, EventArgs e)
        {
            tabControlaffichage.SelectedIndex = 2;
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
            groupBoxshort.Show();
            groupBoxlong.Hide();
        }

        private void radioButtonLongues_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxshort.Hide();
            groupBoxlong.Show();
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
            //@"C:\Users \ BBARON \ Documents \ C#\app_ffss\
            
            using (StreamWriter info_nag = new StreamWriter("info.txt", true))
            {
                info_nag.WriteLine(tabLicence[nbNageurs]);
                info_nag.WriteLine(tabClub[nbNageurs]);
                info_nag.WriteLine(tabNom[nbNageurs]);
                info_nag.WriteLine(tabPrenom[nbNageurs]);
                info_nag.WriteLine(tabDate[nbNageurs]);
                info_nag.WriteLine(tabSexe[nbNageurs]);
                info_nag.WriteLine(tabCate[nbNageurs]);
            }
            

            nbNageurs++;
        }

        //AFFICHAGE DES RESULTATS

        private void buttonAffE_Click(object sender, EventArgs e)
        {
            tabControlaffichage.SelectedIndex = 3;
            labelAlicence.Text = Convert.ToString(tabLicence[nbNageurs - 1]);
            labelAclub.Text = tabClub[nbNageurs - 1];
            labelAnom.Text = tabNom[nbNageurs - 1];
            labelAprenom.Text = tabPrenom[nbNageurs - 1];
            labelAdate.Text = tabDate[nbNageurs - 1];
            labelAgenre.Text = tabSexe[nbNageurs - 1];
            labelAcat.Text = tabCate[nbNageurs - 1];
            groupBoxAffE.Show();
            groupBoxAffC.Hide();
            if (radioButtonShort.Checked)
            {
                groupBoxAs.Show();
                groupBoxAl.Hide();
                
            }
        }

        private void buttonAffc_Click(object sender, EventArgs e)
        {
            tabControlaffichage.SelectedIndex = 3;
            labelAlicence.Text = Convert.ToString(tabLicence[nbNageurs - 1]);
            labelAclub.Text = tabClub[nbNageurs - 1];
            labelAnom.Text = tabNom[nbNageurs - 1];
            labelAprenom.Text = tabPrenom[nbNageurs - 1];
            labelAdate.Text = tabDate[nbNageurs - 1];
            labelAgenre.Text = tabSexe[nbNageurs - 1];
            labelAcat.Text = tabCate[nbNageurs - 1];
            groupBoxAffE.Hide();
            groupBoxAffC.Show();
        }

        private void buttonAffichageN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nbNageurs; i++)
            {
                listBoxAffN.Items.Add(tabNom[i] + " " + tabPrenom[i]+ " " + tabClub[i]);
            }
        }
    }
}