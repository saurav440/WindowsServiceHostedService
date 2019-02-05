﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherServiceClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWeatherService")]
    public interface IWeatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/CelciusToFarenheit", ReplyAction="http://tempuri.org/IWeatherService/CelciusToFarenheitResponse")]
        double CelciusToFarenheit(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/CelciusToFarenheit", ReplyAction="http://tempuri.org/IWeatherService/CelciusToFarenheitResponse")]
        System.Threading.Tasks.Task<double> CelciusToFarenheitAsync(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/FarenheitToCelcius", ReplyAction="http://tempuri.org/IWeatherService/FarenheitToCelciusResponse")]
        double FarenheitToCelcius(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/FarenheitToCelcius", ReplyAction="http://tempuri.org/IWeatherService/FarenheitToCelciusResponse")]
        System.Threading.Tasks.Task<double> FarenheitToCelciusAsync(double temp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServiceChannel : WeatherServiceClient.ServiceReference1.IWeatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceClient : System.ServiceModel.ClientBase<WeatherServiceClient.ServiceReference1.IWeatherService>, WeatherServiceClient.ServiceReference1.IWeatherService {
        
        public WeatherServiceClient() {
        }
        
        public WeatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CelciusToFarenheit(double temp) {
            return base.Channel.CelciusToFarenheit(temp);
        }
        
        public System.Threading.Tasks.Task<double> CelciusToFarenheitAsync(double temp) {
            return base.Channel.CelciusToFarenheitAsync(temp);
        }
        
        public double FarenheitToCelcius(double temp) {
            return base.Channel.FarenheitToCelcius(temp);
        }
        
        public System.Threading.Tasks.Task<double> FarenheitToCelciusAsync(double temp) {
            return base.Channel.FarenheitToCelciusAsync(temp);
        }
    }
}