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
    public partial class FormExistShoppingList : Form
    {
        private dbconnect db;
        private Client m_MyClient;
        public FormExistShoppingList(Client i_MyClient)
        {
            InitializeComponent();
            m_MyClient = new Client();
            m_MyClient = i_MyClient;
            db = new dbconnect();
            db.GetShoppingListName(listBoxListsName,m_MyClient);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            FormCreateNewList newList = new FormCreateNewList(m_MyClient, listBoxListsName.Text);
            newList.Show();
            this.Hide();
        }


    }
}
