using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32;

namespace MerchantQRPortalCore.Constants
{
    public static class RegistryReader
    {
        public static string ReadString(string key)
        {
            var registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\MerchantQR", false);

            if (registryKey is null) return string.Empty;

            var value = Convert.ToString(registryKey.GetValue(key, string.Empty));

            return value;
        }

        public static string ReadConnectionString()
        {
            var value = ReadString("ConnectionString");

            return value;
        }

        public static string BaseURL()
        {
            var value = ReadString("BaseUrl");

            return value;
        }

        public static string PostMerchantURL()
        {
            var value = ReadString("PostMerchantURL");

            return value;
        }

        public static string GetMerchantURL()
        {
            var value = ReadString("GetMerchantURL");

            return value;
        }
        
    }

    
}
