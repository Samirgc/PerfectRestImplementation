﻿using ListView_Sample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListView_Sample
{
	public partial class App : Application
	{


        public static ItemsManager MYitemsManager { get; private set; }

        public App ()
		{
			//InitializeComponent();
            MYitemsManager = new ItemsManager(new RestService());
            MainPage = new ListView_Sample.MainPage();
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
