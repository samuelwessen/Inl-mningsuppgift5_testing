using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;

namespace DeviceApp.Services
{
    public class DeviceService
    {
        public static Task<MethodResponse> SetTelemetryInterval(MethodRequest methodRequest, object userContext)
        {
            throw new NotImplementedException();
        }
    }
}
