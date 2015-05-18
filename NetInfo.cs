//CRWinNetDiag; The Tool collects TCP/IP Information for futher Analysis
//Copyright (C) 2015  Christian Reusch

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.



//Diese Datei ist Teil von CRWinNetDiag.

//CRWinNetDiag ist Freie Software: Sie können es unter den Bedingungen
//der GNU General Public License, wie von der Free Software Foundation,
//Version 3 der Lizenz oder (nach Ihrer Wahl) jeder späteren
//veröffentlichten Version, weiterverbreiten und/oder modifizieren.

//CRWinNetDiag wird in der Hoffnung, dass es nützlich sein wird, aber
//OHNE JEDE GEWAEHRLEISTUNG, bereitgestellt; sogar ohne die implizite
//Gewährleistung der MARKTFAEHIGKEIT oder EIGNUNG FÜR EINEN BESTIMMTEN ZWECK.
//Siehe die GNU General Public License für weitere Details.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;


using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace WinNetDiag
{
    class NetInfo
    {
        const string LocalSystemKey = "SYSTEM\\CurrentControlSet\\Control\\Class";
        const string LocalSystemKey1 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters";

        //private RegistryKey myRegKey;
        private string mySearchKey;
        private NetworkInterface[] nics;
        string myNetworkInfo;

        public NetInfo()
        {
            nics = NetworkInterface.GetAllNetworkInterfaces();
        }

        public string getInfo()
        {
          myNetworkInfo = "";

            myNetworkInfo = myNetworkInfo + fillStringwWithChars("=", 38, "=") + fillStringwWithChars(" TCPIP Konfig ", 42, "=") + "\r\n";
            RegParser myParser1 = new RegParser(LocalSystemKey1, "Parameters");
            myNetworkInfo = myNetworkInfo + myParser1.WriteAllParms();
            myNetworkInfo = myNetworkInfo + "      " + "\r\n";

  

            foreach (NetworkInterface myNic in nics)
            {
                myNetworkInfo = myNetworkInfo + fillStringwWithChars("=", 38, "=") + fillStringwWithChars(" New Adapter ", 42, "=") + "\r\n";
                myNetworkInfo = myNetworkInfo + fillStringwWithSpaces("NIC-ID:", 40) + myNic.Id + "\r\n";
                mySearchKey = myNic.Id;
                myNetworkInfo = myNetworkInfo + fillStringwWithSpaces("NIC-Name:", 40) + myNic.Name + "\r\n";
                myNetworkInfo = myNetworkInfo + fillStringwWithSpaces("NIC-Typ: ", 40) + myNic.NetworkInterfaceType.ToString() + "\r\n";
                myNetworkInfo = myNetworkInfo + fillStringwWithSpaces("NIC-Status:", 40) + myNic.OperationalStatus.ToString() + "\r\n";
                myNetworkInfo = myNetworkInfo + fillStringwWithSpaces("NIC-Speed:", 40) + myNic.Speed.ToString() + "\r\n";
                myNetworkInfo = myNetworkInfo + fillStringwWithChars("-", 33, "-") + fillStringwWithChars(" Adapter Settings ", 38, "-") + "\r\n";

                RegParser myParser = new RegParser(LocalSystemKey, "Net", mySearchKey);
                myNetworkInfo = myNetworkInfo + myParser.WriteNetwork();
                myNetworkInfo = myNetworkInfo + "      " + "\r\n";

            }//endfor

            Encoding myENC = Encoding.GetEncoding(850);

           Console.OutputEncoding = myENC;

            // ParameterizedThreadStart pts1 = new ParameterizedThreadStart(this.consoleCommandReadOutput);
            Thread t1 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-e", ref myNetworkInfo); });
            //myNetworkInfo = myNetworkInfo + fillStringwWithChars("_", 33, "_") + fillStringwWithChars("_", 38, "_") + "\r\n\r\n\r\n";
            Thread t2 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-ano", ref myNetworkInfo); });
       //     Thread t3 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-x", ref myNetworkInfo); });

          //  Thread t4 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-yn", ref myNetworkInfo); });
            Thread t5 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-tn", ref myNetworkInfo); });
            Thread t6 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-s", ref myNetworkInfo); });
            Thread t7 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-rn", ref myNetworkInfo); });
            Thread t8 = new Thread(delegate() { this.consoleCommandReadOutput("ipconfig", "/all", ref myNetworkInfo); });
            Thread t9 = new Thread(delegate() { this.consoleCommandReadOutput("arp ", "-av", ref myNetworkInfo); });
            //Thread t9 = new Thread(delegate() { this.consoleCommandReadOutput("ipconfig", "/allcompartments /all", ref myNetworkInfo); });
            t1.Start();
            t1.Join();

            t2.Start();
            t2.Join();

         //   t3.Start();
         //   t3.Join();


            //t4.Start();
            //t4.Join();

            t5.Start();
            t5.Join();

            t6.Start();
            t6.Join();

            t7.Start();
            t7.Join();

            t8.Start();
            t8.Join();

            t9.Start();
            t9.Join();





            //Hauptprogramm wartet bis die Threads beendet sind


            myENC = Encoding.GetEncoding(1252);

      
            Console.OutputEncoding = myENC;

    

            return myNetworkInfo;
        }


        //private Task <string> consoleCommandReadOutput(string myCommand, string myCommandParameter)
        private void consoleCommandReadOutput(string myCommand, string myCommandParameter, ref string myString)
        {
          
            Process p = new Process();
            ProcessStartInfo pStartInfo = new ProcessStartInfo(myCommand, myCommandParameter);



            Console.Error.WriteLine("Bitte Warten! " + myCommand + " " + myCommandParameter + " Wird ausgeführt!");
          
            string myConsoleOutput;
            pStartInfo.RedirectStandardOutput = true;
            pStartInfo.UseShellExecute = false;

            p.StartInfo = pStartInfo;
            p.Start();
            System.Object lockThis = new System.Object();

      
            // Erzwingt einheitlichen Programmoutput
            lock (lockThis)
            {


                myConsoleOutput = p.StandardOutput.ReadToEnd();

                p.WaitForExit();
                p.Close();



                myString = myString + fillStringwWithChars("=", 38, "=") + fillStringwWithChars(" " + myCommand + " " + myCommandParameter + " ", 42, "=") + "\r\n";
                myString = myString + myConsoleOutput;
                myString = myString + fillStringwWithChars("_", 38, "_") + fillStringwWithChars("_", 42, "_") + "\r\n\r\n\r\n";


            }

        }




        private string fillStringwWithSpaces(string myStringToFill, int myNewLength)
        {
            for (long i = myStringToFill.Length; i <= myNewLength; i = myStringToFill.Length + 1)
            {
                if (5 < myStringToFill.Length - i)
                {
                    myStringToFill = myStringToFill + "     ";
                }
                else
                {
                    myStringToFill = myStringToFill + " ";
                }//endif

            }//endfor
            return myStringToFill;
        }//end func

        private string fillStringwWithChars(string myStringToFill, int myNewLength, string myFilling)
        {
            for (long i = myStringToFill.Length; i <= myNewLength; i = myStringToFill.Length + 1)
            {
                if (5 < myStringToFill.Length - i)
                { myStringToFill = myStringToFill + myFilling + myFilling + myFilling + myFilling + myFilling; }
                else { myStringToFill = myStringToFill + myFilling; }//endif
            }//endfor
            return myStringToFill;
        }//end func


    }
}
