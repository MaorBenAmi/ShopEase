using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ShoppingList;
using System.Data;
using DistanceCalculator;
namespace connectsql
{
    class dbconnect
    {
        private MySqlDataReader MyReader;
        private MySqlCommand SelectCommand;
        private MySqlConnection connection;
        private MySqlDataAdapter MySqlDataAdapter;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public dbconnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "shopease";
            uid = "root";
            password = "ny290783";
            string MyConnection = string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};", server, database, uid, password);
            connection = new MySqlConnection(MyConnection);
        }
    
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        public void GetStyle(ComboBox i_MyBox, string i_Gender, string i_Catgory, string i_SubCatgory)
        {
            string query = string.Format("SELECT DISTINCT Model FROM item WHERE Gender='{0}' AND Type='{2}' AND Class='{1}'", i_Gender, i_Catgory, i_SubCatgory);
            SelectCommand = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string ItemsToAdd = MyReader.GetString("Model");
                    i_MyBox.Items.Add(ItemsToAdd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.CloseConnection();
        
        }

        public void GetShoppingCenter(ref DataSet i_MyDataSet,ref DataGridView i_MyDataGridView, float i_ClientID, string i_ListName)
        {
            string query = string.Format("select centerhasstore.ShoppingCenterName,ShoppingCenterCity as City,0 AS Distance,ShoppingCenterLatitude as Lati,ShoppingCenterLongitude as Longi from shoppingcenter,centerhasstore where centerhasstore.ShoppingCenterName=shoppingcenter.ShoppingCenterName AND centerhasstore.StoreName in (select StoreName from storeitem where storeitem.ItemCatalogNumber in (select ItemCatalogNumber AS ItemCatalog from item,shoppinglist where shoppinglist.ClientId='" + i_ClientID + "' and shoppinglist.ListName='" + i_ListName + "' and item.Model=shoppinglist.Model and item.Type=shoppinglist.Type and item.Gender=shoppinglist.Gender and item.Class=shoppinglist.Class  group by ItemCatalogNumber) group by StoreName) group by centerhasstore.ShoppingCenterName");
            try 
            {
                    MySqlDataAdapter = new MySqlDataAdapter(query, connection);
                    i_MyDataSet.Clear();
                    MySqlDataAdapter.Fill(i_MyDataSet);
                    i_MyDataGridView.DataSource = i_MyDataSet.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.CloseConnection();
        
        }
        public void GetCatgory(ComboBox i_MyBox,string i_Gender)
        {
            string query = string.Format("SELECT DISTINCT Class FROM item WHERE Gender='{0}';",i_Gender);
            SelectCommand = new MySqlCommand(query,connection);
            try 
            {
                connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string ItemsToAdd = MyReader.GetString("Class");
                    i_MyBox.Items.Add(ItemsToAdd);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.CloseConnection();
        
        }
        public void GetSubCatgory(ComboBox i_MyBox,string i_Gender,string i_Catgory)
        {
            string query = string.Format("SELECT DISTINCT Type from item WHERE Gender='{0}' AND Class='{1}';", i_Gender, i_Catgory);
            SelectCommand = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string ItemsToAdd = MyReader.GetString("Type");
                    i_MyBox.Items.Add(ItemsToAdd);
               
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.CloseConnection();
        }
        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void InsertClient(Client client)
        {
            string query = string.Format("INSERT INTO client(FirstName,LastName,ClientID,Gender,DateOfBirth,Phone,ClientLatitude,ClientLongitude,SizeOfShirt,SizeOfPants,SizeOfShoe,SizeOfHat,SizeOfBra) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}');",client.FirstName,client.LastName,client.Id,client.Gender,client.DateOfBirth,client.Phone,client.Latitude,client.Longitude,client.Sizes.SizeOfShirt,client.Sizes.SizeOfPant,client.Sizes.SizeOfShoe,client.Sizes.SizeOfHat,client.Sizes.SizeOfBra);

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(Client i_Client)
        {
            if(i_Client.Gender == "Male")
            {
                i_Client.Sizes.SizeOfBra = null;
            }
            string query = "UPDATE client SET FirstName='" + i_Client.FirstName + "', LastName='" + i_Client.LastName + "', Phone='" + i_Client.Phone + "',ClientLatitude='" + i_Client.Latitude + "' ,ClientLongitude='" + i_Client.Longitude + "',SizeOfShirt='" + i_Client.Sizes.SizeOfShirt + "',SizeOfPants='" + i_Client.Sizes.SizeOfPant + "',SizeOfHat='" + i_Client.Sizes.SizeOfHat + "',SizeOfShoe='" + i_Client.Sizes.SizeOfShoe + "',SizeOfBra='" + i_Client.Sizes.SizeOfBra + "' WHERE ClientID='" + i_Client.Id + "' ";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void GetShoppingCenter(ComboBox i_MyBox)
        {
            string query = string.Format("SELECT DISTINCT ShoppingCenterName FROM ShoppingCenter");
            SelectCommand = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string ItemsToAdd = MyReader.GetString("ShoppingCenterName");
                    i_MyBox.Items.Add(ItemsToAdd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.CloseConnection();

        }


        public void GetShoppingListName(ListBox i_MyListBox,Client i_MyClient)
        {
            string query = string.Format("SELECT DISTINCT ListName FROM shoppinglist WHERE ClientID='"+i_MyClient.Id+"'");
            SelectCommand = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while (MyReader.Read())
                {
                    string ItemsToAdd = MyReader.GetString("ListName");
                    i_MyListBox.Items.Add(ItemsToAdd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.CloseConnection();

        }

        public void LoadItemsTable(ref DataGridView i_MyTable,ref DataSet i_MyDataSet,int i_RowsInTheTable,params object [] varibles)
        {
            string query = string.Format("SELECT DISTINCT Gender,Class,Type,Model FROM item WHERE Gender='{0}' AND Type='{2}' AND Class='{1}' And Model='{3}'", varibles[0], varibles[1], varibles[2], varibles[3]);
            MySqlDataAdapter = new MySqlDataAdapter(query,connection);
            MySqlDataAdapter.Fill(i_MyDataSet);
            i_MyTable.DataSource = i_MyDataSet.Tables[0];
            this.CloseConnection();
        }

        public void ShowExistShoppingList(ref DataGridView i_MyTable, ref DataSet i_MyDataSet,string i_ListName,float i_ClientID)
        {
            string query = string.Format("SELECT Gender,Type,Class,Model FROM shoppinglist WHERE ClientID='{0}' AND ListName='{1}'",i_ClientID,i_ListName);
            MySqlDataAdapter = new MySqlDataAdapter(query, connection);
            MySqlDataAdapter.Fill(i_MyDataSet);
            i_MyTable.DataSource = i_MyDataSet.Tables[0];
            this.CloseConnection();
        }


       public void InsertShoppingList(float i_Id,string i_ListName, ref DataGridView i_ListToSave,bool i_IsOpenedByMainMenu)
        {
            string Gender = string.Empty;
            string Type = string.Empty;
            string Class = string.Empty;
            string Model = string.Empty;
            string query = string.Empty;
            connection.Open();
            if (i_IsOpenedByMainMenu == false)
            {
                query = string.Format("DELETE FROM shoppinglist WHERE ClientID='{0}' And ListName='{1}' ",i_Id,i_ListName);
                SelectCommand = new MySqlCommand(query, connection);
                SelectCommand.ExecuteNonQuery();
            }
            foreach (DataGridViewRow item in i_ListToSave.Rows)
            {
              Gender= item.Cells[0].Value.ToString();
              Type = item.Cells[1].Value.ToString();
              Class = item.Cells[2].Value.ToString();
              Model = item.Cells[3].Value.ToString();
              query = string.Format("INSERT INTO shoppinglist VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", i_ListName, i_Id,Gender,Class, Type, Model);
              SelectCommand = new MySqlCommand(query, connection);
              SelectCommand.ExecuteNonQuery();
            }
            this.CloseConnection();
        }
        public void CopyRowToGridView(DataGridView i_OutPutGrid,DataGridView i_InputGrid)
        {

            i_InputGrid.Rows.Add();
            i_InputGrid.Rows.Clear();
                foreach (DataGridViewRow item in i_OutPutGrid.Rows)
                {
                    int size = i_InputGrid.Rows.Add();
                    i_InputGrid.Rows[size].Cells[0].Value = item.Cells[0].Value.ToString();
                    i_InputGrid.Rows[size].Cells[1].Value = item.Cells[1].Value.ToString();
                    i_InputGrid.Rows[size].Cells[2].Value = item.Cells[2].Value.ToString();
                }
        
        }
        public bool Validation(string id,ref Client client)
        {
            client.Sizes = new Size();
            int count = 0;
            try
            {
                SelectCommand = new MySqlCommand("SELECT * from client WHERE ClientID='" + id +"';", connection);
                connection.Open();
                MyReader = SelectCommand.ExecuteReader();
                while(MyReader.Read())
                {
                    client.Id = float.Parse(MyReader.GetString("ClientID"));
                    client.FirstName=MyReader.GetString("FirstName");
                    client.LastName = MyReader.GetString("LastName");
                    client.Gender=MyReader.GetString("Gender");
                    client.DateOfBirth = MyReader.GetString("DateOfBirth");
                    client.Phone = float.Parse(MyReader.GetString("Phone"));
                    client.Latitude = double.Parse(MyReader.GetString("ClientLatitude"));
                    client.Longitude = double.Parse(MyReader.GetString("ClientLongitude"));
                    client.Sizes.SizeOfShirt = MyReader.GetString("SizeOfShirt");
                    client.Sizes.SizeOfPant = MyReader.GetString("SizeOfPants");
                    client.Sizes.SizeOfShoe = MyReader.GetString("SizeOfShoe");
                    client.Sizes.SizeOfHat = MyReader.GetString("SizeOfHat");
                    if (client.Gender == "Female")
                    {
                        client.Sizes.SizeOfBra = MyReader.GetString("SizeOfBra");
                    }
                    count++;
                }
                if(count==1)
                {
                    return true;
                }
                else 
                {
                    MessageBox.Show("ID Is Not Correct ! Please Try Again !");
                    connection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           // this.CloseConnection();
        }

        public void InsertDataToTable(string i_Center)
        {
            string[] Centers=new string[20];
            string[] Letters = new string[24]{ "Castro", "Zara", "Adidas", "Gali", "Golf", "Renuar", "Honigman", "Fox", "Bershka", "Pull&Bear", "Celio", "Zip", "Aldo", "Mega Sport", "Hamashbir", "Tamnon", "Nike", "Nako", "Afrodita", "Booknet", "Steimatzky","Delta","Top10","Mango"};
            string query=string.Empty;
            connection.Open();
            for (int i = 0,j=0; i < 24; i++,j++)
            {
                if(j==3)
                {
                    j = 0;
                }
                    query = string.Format("INSERT INTO centerhasstore VALUES ('{0}','{1}','{2}')", i_Center,Letters[i],j);
                    SelectCommand = new MySqlCommand(query, connection);
                    SelectCommand.ExecuteNonQuery();
                
            }
            this.CloseConnection();
        }

        public bool IsExistShoppingList(Client m_client)
        {
            string query = "SELECT COUNT(*) FROM shoppinglist WHERE ClientID='" + m_client.Id + "';";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
             this.CloseConnection();
            if (count == 0)
            {
               return false;
            }
            return true;
        }

        public void DeleteFromShoppingList(Client i_MyClient, string i_Gender, string i_Type, string i_Class, string i_Model)
        {
            
            string query = string.Format("DELETE FROM shoppinglist WHERE ClientID='{0}' AND Gender='{1}' And Type='{2}' AND Model='{3}' And Class='{4}'",i_MyClient.Id,i_Gender,i_Type,i_Model,i_Class);
            SelectCommand = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillQueryDataGrid(ref DataGridView i_MyDataGridView, string i_ShoppingCenterName,Client i_MyClient,string i_ListName)
        {

            DataSet ds = new DataSet();
            string query = string.Format(@"create or replace view MyCatlogNumbers as (select ItemCatalogNumber FROM shoppinglist,item where shoppinglist.ClientID='{0}' and shoppinglist.ListName='{1}' and item.Model=shoppinglist.Model and item.Type=shoppinglist.Type and item.Gender=shoppinglist.Gender and item.Class=shoppinglist.Class);
select centerhasstore.StoreName,Gender,Class,Type,Model,Size,Color,Units,price from item,storeitem,mycatlognumbers,centerhasstore where centerhasstore.ShoppingCenterName='{2}' and centerhasstore.StoreName=storeitem.StoreName and mycatlognumbers.ItemCatalogNumber=storeitem.ItemCatalogNumber and mycatlognumbers.ItemCatalogNumber=item.ItemCatalogNumber ", i_MyClient.Id, i_ListName, i_ShoppingCenterName);
            try
            {
                 MySqlDataAdapter = new MySqlDataAdapter(query, connection);
                 MySqlDataAdapter.Fill(ds);
                 i_MyDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            i_MyDataGridView.Columns[0].Width = 30;
            i_MyDataGridView.Columns[1].Width = 30;
            this.CloseConnection();
        }




        public void FillQueryDataGridStores(ref DataGridView i_MyDataGridView, string i_ShoppingCenterName)
        {
            DataSet ds = new DataSet();
            string query = string.Format(@"SELECT centerhasstore.StoreName,StoreType,StoreLocation from store,centerhasstore where centerhasstore.ShoppingCenterName='{0}' And store.StoreName=centerhasstore.StoreName",i_ShoppingCenterName);
            try
            {
                MySqlDataAdapter = new MySqlDataAdapter(query, connection);
                MySqlDataAdapter.Fill(ds);
                i_MyDataGridView.DataSource = null;
                i_MyDataGridView.Refresh();
                i_MyDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.CloseConnection();
        }
    }
    }

