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
using GoogleMaps.LocationServices;
using connectsql;

namespace ShoppingList
{
    public partial class FormUpdateData : Form
    {
        private Client m_MyClient;
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlConnection Connection;
        private dbconnect db = new dbconnect();
        public FormUpdateData()
        {
            InitializeComponent();
            AutoCompleteText();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "shopease";
            uid = "root";
            password = "maor";

        }

        public FormUpdateData(Client i_MyClient)
        {

            InitializeComponent();
            AutoCompleteText();
            m_MyClient = new Client();
            m_MyClient = i_MyClient;
            textBoxFirstName.Text = m_MyClient.FirstName;
            textBoxLastName.Text = m_MyClient.LastName;
            textBoxPhone.Text = m_MyClient.Phone.ToString();
            textBoxShirtSize.Text = m_MyClient.Sizes.SizeOfShirt;
            textBoxPantsSize.Text = m_MyClient.Sizes.SizeOfPant;
            textBoxHatSize.Text = m_MyClient.Sizes.SizeOfHat;
            textBoxShoesSize.Text = m_MyClient.Sizes.SizeOfShoe;
            }
           
        
        void AutoCompleteText()
        {
            textBoxCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxStreet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxStreet.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection CityCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection StreetCollection = new AutoCompleteStringCollection();
            string MyConnection = string.Format("SERVER=localhost;DATABASE=shopease;UID=root;PASSWORD=maor;", server, database, uid, password);
            string CityQuery = "SELECT DISTINCT city from cities;";
            Connection = new MySqlConnection(MyConnection);
            MySqlCommand SelectCommand = new MySqlCommand(CityQuery, Connection);
            MySqlDataReader MyReader;
            try
            {
                Connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string city = MyReader.GetString("city");
                    CityCollection.Add(city);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBoxCity.AutoCompleteCustomSource = CityCollection;


        }
        private void textBoxStreet_Click(object sender, EventArgs e)
        {
            textBoxStreet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxStreet.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection StreetCollection = new AutoCompleteStringCollection();
            string MyConnection = string.Format("SERVER=localhost;DATABASE=shopease;UID=root;PASSWORD=maor;", server, database, uid, password);
            MySqlConnection Connection = new MySqlConnection(MyConnection);
            MySqlDataReader MyReader;
            string StreetQuery = "SELECT street from cities WHERE city='" + textBoxCity.Text + "';";
            MySqlCommand SelectCommand = new MySqlCommand(StreetQuery, Connection);
            try
            {
                Connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string street = MyReader.GetString("street");
                    StreetCollection.Add(street);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBoxStreet.AutoCompleteCustomSource = StreetCollection;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Size size = new Size();
            m_MyClient.FirstName = textBoxFirstName.Text;
            m_MyClient.LastName = textBoxLastName.Text;
            m_MyClient.Phone = float.Parse(textBoxPhone.Text);
            size.SizeOfShirt = this.textBoxShirtSize.Text;
            size.SizeOfPant = this.textBoxPantsSize.Text;
            size.SizeOfShoe = this.textBoxShoesSize.Text;
            size.SizeOfHat = this.textBoxHatSize.Text;
            if (m_MyClient.Gender == "Female")
            {
                size.SizeOfBra = this.comboBoxBraSize.Text + "-" + this.textBoxBra.Text;
            }
            if (!string.IsNullOrWhiteSpace(textBoxCity.Text) && !string.IsNullOrWhiteSpace(textBoxStreet.Text))
            {
                m_MyClient.Adress = textBoxCity.Text + "+," + textBoxStreet.Text;
                m_MyClient.CalculateAddress();
            }
            db.Update(m_MyClient);
            MessageBox.Show("Update Succeed !");
        }

        private void FormUpdateData_Load(object sender, EventArgs e)
        {
            if (m_MyClient.Gender == "Male")
            {
                label10.Visible = false;
                textBoxBra.Visible = false;
                comboBoxBraSize.Visible = false;
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu mainMenu = new FormMainMenu(m_MyClient);
            mainMenu.Show();
            this.Hide();
        }
    }
}
