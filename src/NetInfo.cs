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
        const string LocalSystemKey2 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip6\\Parameters";
        const string LocalSystemKey3 = "SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters";

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


            myNetworkInfo = myNetworkInfo + fillStringwWithChars("=", 38, "=") + fillStringwWithChars(" TCPIP6 Konfig ", 42, "=") + "\r\n";
            RegParser myParser2 = new RegParser(LocalSystemKey2, "Parameters");
            myNetworkInfo = myNetworkInfo + myParser2.WriteAllParms();
            myNetworkInfo = myNetworkInfo + "      " + "\r\n";

            myNetworkInfo = myNetworkInfo + fillStringwWithChars("=", 38, "=") + fillStringwWithChars(" AFD Params ", 42, "=") + "\r\n";
            RegParser myParser3 = new RegParser(LocalSystemKey3, "Parameters");
            myNetworkInfo = myNetworkInfo + myParser2.WriteAllParms();
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
            Thread t1 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-e \t", ref myNetworkInfo); });
            //myNetworkInfo = myNetworkInfo + fillStringwWithChars("_", 33, "_") + fillStringwWithChars("_", 38, "_") + "\r\n\r\n\r\n";
            Thread t2 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-ano \t", ref myNetworkInfo); });
            //     Thread t3 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-x", ref myNetworkInfo); });

            //  Thread t4 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-yn", ref myNetworkInfo); });
            Thread t5 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-tn \t", ref myNetworkInfo); });
            Thread t6 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-s \t", ref myNetworkInfo); });
            Thread t7 = new Thread(delegate() { this.consoleCommandReadOutput("netstat", "-rn \t", ref myNetworkInfo); });
            Thread t8 = new Thread(delegate() { this.consoleCommandReadOutput("ipconfig", "/all \t", ref myNetworkInfo); });
            Thread t9 = new Thread(delegate() { this.consoleCommandReadOutput("arp ", "-av \t", ref myNetworkInfo); });
            Thread t10 = new Thread(delegate() { this.consoleCommandReadOutput("net ", "stats srv \t", ref myNetworkInfo); });
            Thread t11 = new Thread(delegate() { this.consoleCommandReadOutput("net ", "stats work ", ref myNetworkInfo); });
            Thread t12 = new Thread(delegate() { this.consoleCommandReadOutput("tasklist ", "/V \t", ref myNetworkInfo); });
            Thread t13 = new Thread(delegate() { this.consoleCommandReadOutput("tasklist ", "/V /FO LIST", ref myNetworkInfo); });
            Thread t14 = new Thread(delegate() { this.consoleCommandReadOutput("tasklist ", "/SVC \t", ref myNetworkInfo); });
            Thread t15 = new Thread(delegate() { this.consoleCommandReadOutput("tasklist ", "/SVC /FO LIST ", ref myNetworkInfo); });
            Thread t16 = new Thread(delegate() { this.consoleCommandReadOutput("netsh ", "int tcp show global", ref myNetworkInfo); });
            Thread t17 = new Thread(delegate() { this.consoleCommandReadOutput("netsh ", "int tcp show heuristics", ref myNetworkInfo); });
            Thread t18 = new Thread(delegate() { this.consoleCommandReadOutput("netsh ", "int ip show global", ref myNetworkInfo); });
            Thread t19 = new Thread(delegate() { this.consoleCommandReadOutput("netsh ", "int ipv4 show global", ref myNetworkInfo); });
            Thread t20 = new Thread(delegate() { this.consoleCommandReadOutput("netsh ", "int ipv6 show global", ref myNetworkInfo); });
            Thread t21 = new Thread(delegate() { this.consoleCommandReadOutput("netsh ", "dump", ref myNetworkInfo); });
            int myOSVersion = System.Environment.OSVersion.Version.Major;

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
            if (myOSVersion >= 5)
            {
                t10.Start();
                t10.Join();

                t11.Start();
                t11.Join();



                t12.Start();
                t12.Join();

                t13.Start();
                t13.Join();

                t14.Start();
                t14.Join();

                t15.Start();
                t15.Join();


                if (myOSVersion > 5)
                {
                    t16.Start();
                    t16.Join();
                    t17.Start();
                    t17.Join();

                    t18.Start();
                    t18.Join();
                    t19.Start();
                    t19.Join();

                    t20.Start();
                    t20.Join();
                    t21.Start();
                    t21.Join();
                }// endif
            }// endif
            //t16.Start();
            //t16.Join();





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



            Console.Error.WriteLine("Please Wait!\t" + myCommand + " " + myCommandParameter + "\t will be executed!");

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
