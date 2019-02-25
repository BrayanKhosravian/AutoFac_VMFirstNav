using System.Runtime.InteropServices;
using App1.Interfaces;

namespace App1.Droid.Services
{
    public class StringProvider : IStringProvider
    {
        public StringProvider()
        {

        }

        public string GetString()
        {
            return "from stringprovider";
        }
    }
}