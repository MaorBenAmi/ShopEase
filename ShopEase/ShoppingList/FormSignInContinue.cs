using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connectsql;

namespace ShoppingList
{
    public partial class FormSignInContinue : Form
    {
        private Client m_MyClient;
        public FormSignInContinue()
        {
            InitializeComponent();
        }
        private void Initialize()
        {


        }
        public FormSignInContinue(Client i_client)
        {
            InitializeComponent();
            m_MyClient =i_client;
            label1.Text = m_MyClient.FirstName + " " + label1.Text;


        }
            private void SignInContinue_Load(object sender, EventArgs e)
              {
                  if (m_MyClient.Gender == "Male")
            {
                label6.Visible = false;
                textBoxBra.Visible = false;
                comboBoxBraSize.Visible = false;
            }
             }

            private void buttonFinish_Click(object sender, EventArgs e)
            {
                
                Size size = new Size();
                size.SizeOfShirt =this.comboBoxShirt.Text;
                size.SizeOfPant = this.textBoxPens.Text;
                size.SizeOfShoe = this.textBoxShoe.Text;
                size.SizeOfHat = this.textBoxHat.Text;
                if (m_MyClient.Gender == "Female")
                {
                    size.SizeOfBra = this.comboBoxBraSize.Text+"-"+this.textBoxBra.Text;
                }
                m_MyClient.Sizes = size;
                dbconnect db = new dbconnect();
                db.InsertClient(m_MyClient);
                FormMainMenu main = new FormMainMenu(m_MyClient);
                main.Show();
                this.Hide();
            }
    }
}
