using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac_IoC.Interfaces;
using Java.Util;

namespace App1.Droid.Services
{
    public class UUIDService : IUUIDService
    {
        public UUIDService()
        {
            
        }

        public string GetUUID()
        {
            return "From UUID Service";
        }
    }
}