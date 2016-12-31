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
using System.Net;

namespace ShoppingList
{
     public class Client
    {
        private double m_Latitude;

        public double Latitude
        {
            get 
            {
                return m_Latitude;
            }
            set 
            {
                m_Latitude = value;
            }
        }
        private double m_Longitude;

        public double Longitude
        {
            get 
            { 
                return m_Longitude;
            }
            set
            {
                m_Longitude = value;
            }
        }
        private Size m_sizes;

        internal Size Sizes
        {
            get 
            {
                return m_sizes; 
            }
            set
            {
                m_sizes = value; 
            }
        }
        private string m_FirstName;
        public string FirstName
        {
            get 
            { 
                return m_FirstName;
            }
            set 
            { 
                m_FirstName = value; 
            }
        }
        private string m_LastName;
        public string LastName
        {
            get 
            {
                return m_LastName;
            }
            set 
            { 
                m_LastName = value;
            }
        }
        private float m_Id;
        public float Id
        {
            get 
            { 
                return m_Id;
            }
            set 
            {
                m_Id = value; 
            }
        }
        private string m_DateOfBirth;
        public string DateOfBirth
        {
            get 
            { 
                return m_DateOfBirth; 
            }
            set 
            { 
                m_DateOfBirth = value;
            }
        }
        private string m_Gender;
        public string Gender
        {
            get 
            {
                return m_Gender; 
            }
            set 
            { 
                m_Gender = value; 
            }
        }
        private string m_Adress;
        public string Adress
        {
            get 
            { 
                return m_Adress; 
            }
            set 
            {
                m_Adress = value; 
            }
        }
        private float m_Phone;
        public float Phone
        {
            get 
            { 
                return m_Phone; 
            }
            set 
            {
                m_Phone = value; 
            }
        }
        public void CalculateAddress()
         {
                GoogleLocationService locationService = new GoogleLocationService();
                var point = locationService.GetLatLongFromAddress(m_Adress);
                Latitude = (double)point.Latitude;
                Longitude = (double)point.Longitude;
        }
    }
}
