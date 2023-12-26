﻿namespace ElectronicDevices
{
    public class SmartphoneFactory : IDeviceFactory
    {
        public IDevice CreateDevice()
        {
            return new Smartphone();
        }
    }
}
