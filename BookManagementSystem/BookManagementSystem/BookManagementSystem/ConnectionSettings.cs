using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ConnectionSettings
    {
        public static AppSettingsReader aps = new AppSettingsReader();
        public static string connectionStr = aps.GetValue("myconnection",typeof(string)).ToString();
    }
}
