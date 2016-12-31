using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculator
{
    public class Distance
    {
        public static double DistanceBetweenTwoLatLong(double i_LatitudeClient, double i_LongitudeClient, double i_LatitudeShoppingCenter, double i_LongitudeShoppingCenter)
        {
            double angle =Math.Abs( i_LongitudeClient - i_LongitudeShoppingCenter);
            double distance = Math.Sin(deg2rad(i_LatitudeClient)) * Math.Sin(deg2rad(i_LatitudeShoppingCenter)) + Math.Cos(deg2rad(i_LatitudeClient)) * Math.Cos(deg2rad(i_LatitudeShoppingCenter)) * Math.Cos(deg2rad(angle));
            distance = Math.Acos(distance);
            distance = rad2deg(distance);
            distance = distance * 60 * 1.1515;
            distance = distance * 1.609344;
            return Math.Round(distance,3);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts decimal degrees to radians             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private static double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts radians to decimal degrees             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private static double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }

    }
}
