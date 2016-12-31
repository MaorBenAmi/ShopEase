using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistanceCalculator;
using connectsql;
using GoogleMaps.LocationServices;

namespace ShoppingList
{
    public partial class FormBuy : Form
    {
        private dbconnect db = new dbconnect();
        private DataSet m_MyDataSet=new DataSet();
        private Client m_MyClient;
        private string m_ListName;

        public FormBuy()
        {
            InitializeComponent();
        }
        public FormBuy(Client i_client,string i_ListName)
        {
            InitializeComponent();
            m_MyClient = new Client();
            m_MyClient = i_client;
            m_ListName = i_ListName;
        }

        private void buttonHomeLocation_Click(object sender, EventArgs e)
        {
            double shoppingCenterLatitude = 0;
            double shoppingCenterLongitude = 0;
            double distance = 0;
            float clientID = m_MyClient.Id;
            db.GetShoppingCenter(ref m_MyDataSet, ref dataGridViewList, clientID, m_ListName);
            this.dataGridViewList.Columns["Lati"].Visible = false;
            this.dataGridViewList.Columns["Longi"].Visible=false;
            foreach (DataGridViewRow row in dataGridViewList.Rows)
            {
                shoppingCenterLatitude = double.Parse(row.Cells["Lati"].Value.ToString());
                shoppingCenterLongitude = double.Parse(row.Cells["Longi"].Value.ToString());
                distance=Distance.DistanceBetweenTwoLatLong(m_MyClient.Latitude, m_MyClient.Longitude, shoppingCenterLatitude, shoppingCenterLongitude);
                dataGridViewList.Rows[row.Index].Cells["Distance"].Value = distance;
            }
            dataGridViewList.Sort(dataGridViewList.Columns[4],ListSortDirection.Ascending);
        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                double latitude = double.Parse(dataGridViewList.Rows[e.RowIndex].Cells["Lati"].Value.ToString());
                double longitude = double.Parse(dataGridViewList.Rows[e.RowIndex].Cells["Longi"].Value.ToString());
                FormMaps maps = new FormMaps(m_MyClient, m_MyClient.Longitude,latitude,longitude);
                maps.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                string shoppingCenterName=dataGridViewList.Rows[e.RowIndex].Cells["ShoppingCenterName"].Value.ToString();
                db.FillQueryDataGrid(ref dataGridViewQueryAnswer, shoppingCenterName,m_MyClient,m_ListName);
                labelTiTle.Text = "Your Items At Stores:";
                dataGridViewQueryAnswer.Sort(dataGridViewQueryAnswer.Columns[0], ListSortDirection.Ascending);
            }
            else if (dataGridViewList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && e.ColumnIndex == 2)
            {
                string shoppingCenterName = dataGridViewList.Rows[e.RowIndex].Cells["ShoppingCenterName"].Value.ToString();
                db.FillQueryDataGridStores(ref dataGridViewQueryAnswer, shoppingCenterName);
                labelTiTle.Text = "The Stores At The Shopping Center :";
                dataGridViewQueryAnswer.Sort(dataGridViewQueryAnswer.Columns[2], ListSortDirection.Ascending);
            }
           
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu mainMenu = new FormMainMenu(m_MyClient);
            mainMenu.Show();
            this.Hide();

        }

        private void buttonCurrentLocation_Click(object sender, EventArgs e)
        {
            double currentLatitude = 32.016068;
            double currentLongitude = 34.7752771;
            double shoppingCenterLatitude = 0;
            double shoppingCenterLongitude = 0;
            double distance = 0;
            float clientID = m_MyClient.Id;
            db.GetShoppingCenter(ref m_MyDataSet, ref dataGridViewList, clientID, m_ListName);
            this.dataGridViewList.Columns["Lati"].Visible = false;
            this.dataGridViewList.Columns["Longi"].Visible = false;
            foreach (DataGridViewRow row in dataGridViewList.Rows)
            {
                shoppingCenterLatitude = double.Parse(row.Cells["Lati"].Value.ToString());
                shoppingCenterLongitude = double.Parse(row.Cells["Longi"].Value.ToString());
                distance = Distance.DistanceBetweenTwoLatLong(currentLatitude, currentLongitude, shoppingCenterLatitude, shoppingCenterLongitude);
                dataGridViewList.Rows[row.Index].Cells["Distance"].Value = distance;
            }
            dataGridViewList.Sort(dataGridViewList.Columns[4], ListSortDirection.Ascending);
        }


    }
}
