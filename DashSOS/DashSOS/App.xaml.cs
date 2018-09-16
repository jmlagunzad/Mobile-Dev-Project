﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DashSOS.Database;
using DashSOS.Interface;
using DashSOS.View;
using DashSOS.Model;
namespace DashSOS
{
	public partial class App : Application
	{
        public static MasterDetailPage MasterDetail { get; set; }
        static ProfileDatabase profileDatabase;
        static EmergencyDatabase emergencyDatabase;
        public async static Task NavigateMasterDetail(Page page)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(page);
        }

		public App ()
		{
			InitializeComponent();
            if (!ProfileDatabase.CheckProfile())
            {
                MainPage = new NavigationPage(new EditProfileView("create"))
                {
                    BarBackgroundColor = Color.FromHex("#34495e")
                };
            }
            else
            {
                MainPage = new DashSOS.View.MainPage();
            }
        }

        public static ProfileDatabase ProfileDatabase
        {
            get
            {
                if (profileDatabase == null)
                {
                    profileDatabase = new ProfileDatabase();
                    
                }                 
                return profileDatabase;
            }
        }

        public static EmergencyDatabase EmergencyDatabase
        {
            get
            {
                if (emergencyDatabase == null)
                {
                    emergencyDatabase = new EmergencyDatabase();
                    //initialize medical
                    var Emergency = new Emergency()
                    {
                        EmergencyName = "Medical"
                    };
                    emergencyDatabase.AddEmergency(Emergency);
                    Emergency = new Emergency()
                    {
                        EmergencyName = "Security"
                    };
                    emergencyDatabase.AddEmergency(Emergency);
                    Emergency = new Emergency()
                    {
                        EmergencyName = "Fire"
                    };
                    emergencyDatabase.AddEmergency(Emergency);
                    Emergency = new Emergency()
                    {
                        EmergencyName = "Family"
                    };
                    emergencyDatabase.AddEmergency(Emergency);
                } 
                return emergencyDatabase;
            }
        }


        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
