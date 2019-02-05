using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFWeatherService
{
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        Double CelciusToFarenheit(double temp);
        [OperationContract]
        Double FarenheitToCelcius(double temp);
    }
}
