
using System;
using System.Collections.Generic;
using Android.App;
using Android.Content.PM;
using Android.OS;
using App1.Droid.Services;
using App1.Interfaces;
using Autofac_IoC.Interfaces;
using Xamarin.Forms.Xaml;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Dictionary<Type, Type> mappedTypes = new Dictionary<Type, Type>();
            mappedTypes.Add(typeof(StringProvider), typeof(IStringProvider));
            mappedTypes.Add(typeof(UUIDService), typeof(IUUIDService));

            var app = new App();
            app.LoadTypes(mappedTypes);

            LoadApplication(app);
        }
    }
}