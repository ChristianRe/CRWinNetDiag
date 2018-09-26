
﻿//CRWinNetDiag; The Tool collects TCP/IP Information for further Analysis 
//Copyright (C) 2015  Christian Reusch   
//This file is part of CRWinNetDiag.

//CRWinNetDiag is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//CRWinNetDiag is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

//Diese Datei ist Teil von CRWinNetDiag.

//CRWinNetDiag ist Freie Software: Sie können es unter den Bedingungen
//der GNU General Public License, wie von der Free Software Foundation,
//Version 3 der Lizenz oder (nach Ihrer Wahl) jeder späteren
//veröffentlichten Version, weiterverbreiten und/oder modifizieren.

//CRWinNetDiag wird in der Hoffnung, dass es nützlich sein wird, aber
//OHNE JEDE GEWÄHRLEISTUNG, bereitgestellt; sogar ohne die implizite
//Gewährleistung der MARKTFÄHIGKEIT oder EIGNUNG FÜR EINEN BESTIMMTEN ZWECK.
//Siehe die GNU General Public License für weitere Details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Net.NetworkInformation;

using Microsoft.Win32;


namespace WinNetDiag
{
    class Program
    {
        static void Main(string[] args)
        {
            const String VER = "0.33";

            if (System.Environment.OSVersion.Version.Major >= 2)
            {
                Encoding myENC = Encoding.GetEncoding(1252   );
                
              //if (Console.IsOutputRedirected == true)
              //  {
              //    myENC=  Encoding.GetEncoding(1252);
              //  }
                
              Console.InputEncoding = myENC;
                Console.OutputEncoding = myENC;
          


                RegistryKey myOsKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");


                if (myOsKey != null)
                {
                    Console.WriteLine("===============================================================");
                    Console.WriteLine("");
                    Console.WriteLine("CRWinNetDiag             Version: " + VER + "");
                    Console.WriteLine("DownloadLocation:        https://github.com/ChristianRe/CRWinNetDiag");
                    Console.WriteLine("");
                    Console.WriteLine("Date of Execution: " + System.DateTime.Now.ToLocalTime());
                    Console.WriteLine("===============================================================");


                    Console.WriteLine("Product Name: " + myOsKey.GetValue("ProductName"));
                    Console.WriteLine("Current Version: " + myOsKey.GetValue("CurrentVersion"));
                    Console.WriteLine("Build Lab: " + myOsKey.GetValue("BuildLab"));
                }
                string myOS = System.Environment.OSVersion.ServicePack;
                Console.WriteLine("SP laut .net: " + myOS);
                myOS = System.Environment.OSVersion.VersionString;
                Console.WriteLine("Plattform laut .net: " + myOS);









                string myString;
                NetInfo myNetInfo = new NetInfo();
                myString = myNetInfo.getInfo();
                Console.Write(myString);
         //       Console.ReadKey();
  
            }//endif
        }
    }
}
