﻿using System;
using System.IO.Ports;

namespace PortChat
{
    public static class Constants
    {
        public enum TransmissionMode { ASCII, HEX }

        public static string[] PortsNames = SerialPort.GetPortNames();

        public static string[] Baudrates = new string[] { "300", "600", "1200", "2400", "9600", "14400", "19200", "38400", "57600", "115200" };

        public static string[] Parities = Enum.GetNames(typeof(Parity));

        public static string[] DataBitsList => new string[] { "5", "6", "7", "8" };

        public static string[] StopBitsList => Enum.GetNames(typeof(StopBits));

        public static string[] TransmissionModesList => Enum.GetNames(typeof(TransmissionMode));

        public static string[] ValidationModesList => new string[] { "None" };

    }
}