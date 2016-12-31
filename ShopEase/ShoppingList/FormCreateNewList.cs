using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using connectsql;

namespace ShoppingList
{
    public partial class FormCreateNewList : Form
    {
        private Client m_MyClient;
        private int RowsInTheTable = 0;
        private DataSet m_DataSet=new DataSet();
        private dbconnect db = new dbconnect();
        private string m_ListName = string.Empty;
        private bool m_IsOpenedFromMainMenu=true;
        public FormCreateNewList()
        {
            InitializeComponent();
        }
        public FormCreateNewList(Client i_client)
        {
            m_MyClient = i_client;
            InitializeComponent();
            m_IsOpenedFromMainMenu = true;
         }
        public FormCreateNewList(Client i_client,string i_ListName)
        {
            InitializeComponent();
            m_MyClient = i_client;
            m_ListName = i_ListName;
            textBoxListName.Text = i_ListName;
            m_IsOpenedFromMainMenu = false;
            db.ShowExistShoppingList(ref dataGridViewDB, ref m_DataSet,m_ListName,m_MyClient.Id);
        }
        private void Initialize()
        {
        }
        private void comboBoxCatgory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxSubCatgory.Items.Clear();
            db.GetSubCatgory(comboBoxSubCatgory,comboBoxGender.Text,comboBoxCatgory.Text);
        }

        private void comboBoxGender_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxCatgory.Items.Clear();
          db.GetCatgory(comboBoxCatgory,comboBoxGender.Text);
        }

        private void comboBoxSubCatgory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxStyle.Items.Clear();
            db.GetStyle(comboBoxStyle, comboBoxGender.Text, comboBoxCatgory.Text, comboBoxSubCatgory.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            db.LoadItemsTable(ref dataGridViewDB,ref m_DataSet,RowsInTheTable,comboBoxGender.Text, comboBoxCatgory.Text, comboBoxSubCatgory.Text, comboBoxStyle.Text);
            RowsInTheTable++;
        }

        private void dataGridViewDB_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //db.CopyRowToGridView(dataGridViewDB,dataGridViewList);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxListName.Text))
            {
                string ListName = textBoxListName.Text;
                float Id = m_MyClient.Id;
                db.InsertShoppingList(Id, ListName, ref dataGridViewDB,m_IsOpenedFromMainMenu);
                MessageBox.Show("Saved !");
            }
            else
            {
                MessageBox.Show("You Must Enter Name For The List !");
            }
            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
                foreach (DataGridViewRow row in dataGridViewDB.Rows)
                {
                    if (row.Selected == true)
                    {
                        if (m_IsOpenedFromMainMenu == false)
                        {
                            string Gender = row.Cells[0].Value.ToString();
                            string Type = row.Cells[1].Value.ToString();
                            string Class = row.Cells[2].Value.ToString();
                            string Model = row.Cells[3].Value.ToString();
                            db.DeleteFromShoppingList(m_MyClient,Gender, Type, Class, Model);
                        }
                            this.dataGridViewDB.Rows.RemoveAt(row.Index);
                            break;
                    }
                }
            
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu menu = new FormMainMenu(m_MyClient);
            menu.Show();
            this.Hide();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            string listName = textBoxListName.Text;
            FormBuy buy = new FormBuy(m_MyClient,listName);
            buy.Show();
            this.Hide();
        }
    }
}
