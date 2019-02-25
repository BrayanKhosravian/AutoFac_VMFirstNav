using System;
using System.Collections.Generic;
using App1.Interfaces;
using App1.Services;
using App1.ViewModels;
using App1.Views;
using Autofac;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// using Microsoft.Practices.ServiceLocation;

using Autofac_IoC.Bootstrapper;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        private readonly IStringProvider _stringProvider;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void LoadTypes(Dictionary<Type,Type> mappedTypes)
        {
            var bootStrapper = new Bootstrapper(this);
            bootStrapper.RunWithMappedTypes(mappedTypes);
        }
    }
}
