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
    public partial class FormLogIn : Form
    {
       private dbconnect db = new dbconnect();
        public FormLogIn()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            Client client = new Client();
            if(db.Validation(textBoxId.Text,ref client))
            {

                FormMainMenu main = new FormMainMenu(client);
                main.Show();
                this.Hide();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    db.InsertDataToTable(textBoxcenter.Text);
        //}

    }
}
