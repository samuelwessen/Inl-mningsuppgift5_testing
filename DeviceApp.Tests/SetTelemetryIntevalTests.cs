using DeviceApp.Services;
using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DeviceApp.Tests
{
    public class SetTelemetryIntevalTests
    {
        private DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=ec-win20-samuelw-iothub.azure-devices.net;DeviceId=Inlamningsuppgift5;SharedAccessKey=jlfiXyYmYZ91dLSZvLgaDHhTR/dNniRQB0b9rPuMDUI=", TransportType.Mqtt);

        

        [Theory]
        [InlineData("SetTelemetryInterval","10", 200)]
        [InlineData("SetInterval", "10", 501)]
        public void SetTelemetryInterval_ShouldChangeTheInterval(string methodName, string payload, int statusCode)
        {
            var response = DeviceService.SetTelemetryInterval(new MethodRequest(methodName), null).Result;
            Assert.Equal(statusCode, response.Status);

        }
    }

   // vi ska få in payload i MethodRequest delen, kolla inspelningen där vi använder MethodRequest
    
}
