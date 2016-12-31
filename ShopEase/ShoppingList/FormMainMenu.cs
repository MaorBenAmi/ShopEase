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
    public partial class FormMainMenu : Form
    {
        private Client m_client;
        private dbconnect m_DB;
        public FormMainMenu()
        {
            InitializeComponent();
        }
        public FormMainMenu(Client i_client)
        {
            InitializeComponent();
            m_client = i_client;
        }

        private void buttonCreateShoppingList_Click(object sender, EventArgs e)
        {
            FormCreateNewList newlist = new FormCreateNewList(m_client);
            newlist.Show();
            this.Hide();

        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            FormUpdateData update = new FormUpdateData(m_client);
            update.Show();
            this.Hide();
        }
        private void buttonExistShoppingList_Click(object sender, EventArgs e)
        {
            m_DB=new dbconnect();
            if (m_DB.IsExistShoppingList(m_client))
            {
                FormExistShoppingList exist = new FormExistShoppingList(m_client);
                exist.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("You Dont Have An Exist ShoppingList,Please Create One");
            }
        }
    }
}
