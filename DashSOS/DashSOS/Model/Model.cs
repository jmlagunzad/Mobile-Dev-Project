﻿using System;
using System.Collections.Generic;
using System.Text;
using DashSOS.ViewModel;
using SQLite;
namespace DashSOS.Model
{
    public class LocationModel
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Location { get; set; }
    }
    public class Emergency
    {

        //   public int EmergencyId { get; set; }
        [PrimaryKey]
        public string EmergencyName { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string MessageTemplate { get; set; }
    }
   public class Profile
    {
        [PrimaryKey,AutoIncrement]
        public int ProfileId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Barangay { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public DateTime Birthdate { get; set; }
        public string BloodGroup { get; set; }
        public string OtherInfo { get; set; }
    }

}
