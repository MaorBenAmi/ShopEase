using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleMaps.LocationServices;

namespace ShoppingList
{
    public partial class FormMaps : Form
    {
        private Client m_MyClient;
        private StringBuilder QueryAddress;
        private string m_ShoppingCenterLatitude;
        private string m_ShoppingCenterLongitude;
        public FormMaps()
        {
            InitializeComponent();
        }
        public FormMaps(Client i_Client,params double [] m_TheLatLong)
        {
            m_MyClient = new Client();
            m_MyClient = i_Client;
           m_ShoppingCenterLatitude = m_TheLatLong[0].ToString();
           m_ShoppingCenterLongitude = m_TheLatLong[1].ToString();
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string street = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string state = "ישראל";
            string streetnumber = textBoxStreetNumber.Text;
            try 
            {
                StringBuilder QueryAddress = new StringBuilder();
                QueryAddress.Append("http://google.co.il/maps/place/");
                if (state != string.Empty)
                {
                    QueryAddress.Append(state + "," + "+");
                }
                if (city != string.Empty)
                {
                    QueryAddress.Append(city + "," + "+");
                }
                if (street != string.Empty)
                {
                    QueryAddress.Append(street + "," + "+");
                }
                if (streetnumber != string.Empty)
                {
                    QueryAddress.Append(streetnumber + ",");
                }
             //   string temp = "https://www.google.co.il/maps/dir/32.017471,34.795578/32.0181505,34.7912256";
                webBrowserMaps.Navigate(QueryAddress.ToString());
                //webBrowser1.Navigate(temp);
               var address = city+"+,"+street;

               GoogleLocationService locationService = new GoogleLocationService();
                var point = locationService.GetLatLongFromAddress(address);
               
               var latitude = point.Latitude;
                var longitude = point.Longitude;
               // MessageBox.Show("the latitude is"+latitude.ToString());
               // MessageBox.Show("the longitude is" + longitude.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void buttonHomeLocation_Click(object sender, EventArgs e)
        {
            double latitude = m_MyClient.Latitude;
            double longitude = m_MyClient.Longitude;
            StringBuilder QueryAddress = new StringBuilder();
            QueryAddress.Append("https://www.google.co.il/maps/dir/");
            QueryAddress.Append(latitude.ToString() + ","+ longitude.ToString());
            QueryAddress.Append("/32.0181505,34.7912256");
            webBrowserMaps.Navigate(QueryAddress.ToString());
        }

        private void FormMaps_Load(object sender, EventArgs e)
        {
            QueryAddress = new StringBuilder();
            QueryAddress.Append("https://www.google.co.il/maps/dir/");
            QueryAddress.Append(m_MyClient.Latitude.ToString() + "," + m_MyClient.Longitude.ToString());
            QueryAddress.Append("/" + m_ShoppingCenterLatitude + "," + m_ShoppingCenterLongitude + "/@32.0000458,34.8319154,14z/data=!4m2!4m1!3e0");
            webBrowserMaps.Navigate(QueryAddress.ToString());
           // InitializeComponent();
        }
    }
}
