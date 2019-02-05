using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFHostedWindowsService
{
    partial class WeatherWindowService : ServiceBase
    {
        ServiceHost serviceHost;
        public WeatherWindowService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            serviceHost = new ServiceHost(typeof(WCFWeatherService.WeatherService));
            //Open the Servicehost to start listening for messages.  
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
