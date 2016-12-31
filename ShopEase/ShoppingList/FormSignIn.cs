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


namespace ShoppingList
{
    public partial class FormSignIn : Form
    {
        Client client = new Client();
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlConnection Connection;
        public FormSignIn()
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


        private void buttonNext_Click(object sender, EventArgs e)
        {
            client.FirstName = textBoxFirstName.Text;
            client.LastName = textBoxLastName.Text;
            client.DateOfBirth = dateTimePicker1.Text;
            client.Adress = textBoxCity.Text+"+,"+textBoxStreet.Text;
            client.Id = float.Parse(textBoxId.Text);
            client.Phone = float.Parse(textBoxPhone.Text);
            if (radioButtonMale.Checked)
            {
                client.Gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                client.Gender = "Female";
            }
            else
            {
                MessageBox.Show("Please Choose Gender");
            }
            client.CalculateAddress();
            FormSignInContinue ContinueSignIn = new FormSignInContinue(client);
            ContinueSignIn.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // this.dateTimePicker1.Value.ToShortTimeString();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            //  DataView DV = new DataView();
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
        
        private void textBoxStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void textBoxStreet_MouseClick(object sender, MouseEventArgs e)
        {
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
    }
}
