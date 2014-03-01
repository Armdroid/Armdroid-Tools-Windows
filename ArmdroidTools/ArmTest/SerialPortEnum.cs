using System;
using System.Collections.Generic;

using Microsoft.Win32;

namespace ArmdroidTools.ArmTest
{
    public class SerialPortEnum
    {
        private const string SERIAL_DEVICEMAP_KEY = "HARDWARE\\DEVICEMAP\\SERIALCOMM";

        public static string[] AvailablePorts()
        {
            List<string> devices = new List<string>();
            RegistryKey serialDeviceMap = null;
            try
            {
                serialDeviceMap = Registry.LocalMachine.OpenSubKey(SERIAL_DEVICEMAP_KEY);
                if (serialDeviceMap != null)
                {
                    string[] deviceInstances = serialDeviceMap.GetValueNames();
                    foreach (string deviceInstance in deviceInstances)
                    {
                        string deviceName = (string) serialDeviceMap.GetValue(deviceInstance);
                        if (deviceName != null)
                            devices.Add(deviceName);
                    }
                }
            }
            finally
            {
                if (serialDeviceMap != null)
                    serialDeviceMap.Close();
            }
            return devices.ToArray();
        }
    }
}
