﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TremolZFP;

namespace KHtest
{
    class Program
    {
        static void Main(string[] args)
        {

            FP fP = new FP() { ServerAddress = "http://LocalHost:4444/" };
            fP.ServerSetDeviceTcpSettings("62.8.75.229", 8000, "Password");
          //  fP.ServerSetDeviceSerialPortSettings("COM/com", 115200);
            fP.OpenReceipt((OptionReiptceFormat)'1', "Password");
            fP.SellPLUfromExtDB("", OptionVATClass.VAT_Class_A, 1.29m, "", null, null, 8.9m, null, 34.2m);
            fP.ReadLastAndTotalReceiptNum();
            fP.CloseReceipt();
            Console.WriteLine();
        }
    }
}
