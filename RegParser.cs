//CRWinNetDiag; The Tool collects TCP/IP Information for further Analysis 
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
//OHNE JEDE GEWÄHRLEISTUNG, bereitgestellt; sogar ohne die implizite
//Gewährleistung der MARKTFÄHIGKEIT oder EIGNUNG FÜR EINEN BESTIMMTEN ZWECK.
//Siehe die GNU General Public License für weitere Details.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Win32;

//Array redim:
//int[] eisregen = {2,3,4,5};
//Array.Resize(ref eisregen, eisregen.Length+1);


namespace WinNetDiag
{
    class RegParser
    {

        private string membStartKeyName;
        private RegistryKey membRegKey;
        private string membNameOfSubKeyByClass;
        private RegistryKey membRegSubKeyByClassType;
        private string membNetCfgID;
        private RegistryKey membRegSubKeyByNetCfgID;

        //private RegistryKey membSearchTree2;


        //Konstruktoren
        public RegParser() : this(null) { }

        public RegParser(string myStartKeyName) : this(myStartKeyName, null) { }

        public RegParser(string myStartKeyName, string myNameOfSubKeyByClass) : this(myStartKeyName, myNameOfSubKeyByClass, null) { }

        public RegParser(string myStartKeyName, string myNameOfSubKeyByClass, string myNetCfgID)
        {
            membStartKeyName = myStartKeyName;
            membRegKey = Registry.LocalMachine.OpenSubKey(membStartKeyName);
            if (myNameOfSubKeyByClass != null)
            {
                membNameOfSubKeyByClass = myNameOfSubKeyByClass;
                membRegSubKeyByClassType = searchRegSubKeyByValueName(membRegKey, "Class", myNameOfSubKeyByClass);
            }
            else
            {
                membNameOfSubKeyByClass = null;
                membRegSubKeyByClassType = null;
            }//endif

            if (myNameOfSubKeyByClass != null && myNetCfgID != null)
            {
                membNetCfgID = myNetCfgID;

                membRegSubKeyByNetCfgID = searchRegSubKeyByValueName(membRegSubKeyByClassType, "NetCfgInstanceId", myNetCfgID);
            } //if close

            else
            {
                membRegSubKeyByNetCfgID = null;
                membNetCfgID = null;
            }//endif

        }

        public RegistryKey searchRegSubKeyByValueName(RegistryKey myRegKey, string myNameOfValue, string mySearchValue)
        {
            Boolean found = false;

            //SubKey iteratiron
            string[] mySubKeyNames = myRegKey.GetSubKeyNames();
            for (int i = 0; i < myRegKey.SubKeyCount - 1; i++)
            {
                RegistryKey myRegKey1 = myRegKey.OpenSubKey(mySubKeyNames[i]);
                //Member Iteration
                string[] myValueNames1 = myRegKey1.GetValueNames();
                for (int j = 0; j <= myRegKey1.ValueCount - 1; j++)
                {
                    if (myValueNames1[j] == myNameOfValue)
                    {
                        if (myRegKey1.GetValue(myNameOfValue).ToString() == mySearchValue)
                        {
                            found = true;
                            return myRegKey1;
                        }
                    } //endif
                    if (found == true) { break; }


                } //end for
                if (found == true) { break; }

            }//end for
            return null;
        }//end func


        public string WriteNetwork()
        {
            string[] myTMPStringField;
            bool found = false;

            string myString = null;
            string[,] myValues;
            string[,] mySpecificParamValues;
            string[,] myEnumValues;

            string[] mySpecificParamValueNames;
            string[] myValueNames;
            string[] myEnumValueNames;
            RegistryKey myParams;
            RegistryKey mySpecificParam = null;
            RegistryKey myEnum;

            Console.Error.WriteLine("Bitte Warten! Netzwerkkonfiguration wird gelesen!");

            if (membRegSubKeyByNetCfgID != null)
            {
                myParams = membRegSubKeyByNetCfgID.OpenSubKey("Ndi");
                myParams = myParams.OpenSubKey("Params");

                myValueNames = membRegSubKeyByNetCfgID.GetValueNames();
                myValues = new string[membRegSubKeyByNetCfgID.ValueCount, 2];


                for (int i = 0; i < membRegSubKeyByNetCfgID.ValueCount - 1; i++)
                {
                    myValues[i, 0] = myValueNames[i];
                    myValues[i, 1] = membRegSubKeyByNetCfgID.GetValue(myValueNames[i]).ToString();
                    myString = myString + fillStringwWithSpaces(myValues[i, 0] + "      ", 40) + myValues[i, 1] + "\r\n";
                    if (myParams != null)
                    {
                        myTMPStringField = myParams.GetSubKeyNames();

                        found = false;

                        for (int k = 0; k < myParams.SubKeyCount - 1; k++)
                        {
                            if (myTMPStringField[k] == myValueNames[i]) { found = true; }
                        } // endfor




                        if (found == true)
                        {
                            mySpecificParam = myParams.OpenSubKey(myValueNames[i]);
                            mySpecificParamValueNames = mySpecificParam.GetValueNames();
                            mySpecificParamValues = new string[mySpecificParam.ValueCount, 2];

                            myString = myString + fillStringwWithChars("----------------------Values " + myValueNames[i], 80, "-") + "\r\n";

                            for (int n = 0; n <= mySpecificParam.ValueCount - 1; n++)
                            {
                                mySpecificParamValues[n, 0] = mySpecificParamValueNames[n];
                                mySpecificParamValues[n, 1] = mySpecificParam.GetValue(mySpecificParamValueNames[n]).ToString();
                                myString = myString + fillStringwWithSpaces(" ", 6) + fillStringwWithSpaces(mySpecificParamValues[n, 0], 34) + mySpecificParamValues[n, 1] + "\r\n";
                            } //endfor





                            myEnum = mySpecificParam.OpenSubKey("Enum");
                            if (myEnum != null)
                            {
                                myString = myString + fillStringwWithChars("-----Enum (Werte die der Parameter - " + myValueNames[i] + " -annehmen kann!)", 80, "-") + "\r\n";
                                myEnumValueNames = myEnum.GetValueNames();
                                myEnumValues = new string[myEnum.ValueCount, 2];


                                for (int m = 0; m <= myEnum.ValueCount - 1; m++)
                                {
                                    myEnumValues[m, 0] = myEnumValueNames[m];
                                    myEnumValues[m, 1] = myEnum.GetValue(myEnumValueNames[m]).ToString();
                                    myString = myString + fillStringwWithSpaces(" ", 12) + fillStringwWithSpaces(myEnumValues[m, 0], 28) + myEnumValues[m, 1] + "\r\n";
                                } //endfor
                            }//endif


                            myString = myString + fillStringwWithChars("---------------", 80, "-") + "\r\n";






                        } //endif

                    }//endif
                } //endfor

            }//endif


            return myString;
        }//end func


        public string WriteAllParms()
        {

            string myString = null;
            string[,] myValues;

            string[] myValueNames;

            Console.Error.WriteLine("Bitte Warten! Konfiguration wird gelesen!");


            myValueNames = membRegKey.GetValueNames();
            myValues = new string[membRegKey.ValueCount, 2];


            for (int i = 0; i < membRegKey.ValueCount; i++)
            {
                myValues[i, 0] = myValueNames[i];
                myValues[i, 1] = membRegKey.GetValue(myValueNames[i]).ToString();
                myString = myString + fillStringwWithSpaces(myValues[i, 0] + "      ", 40) + myValues[i, 1] + "\r\n";
            } //endfor



            return myString;
        }//end func


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
                myStringToFill = myStringToFill + myFilling;

            }//endfor
            return myStringToFill;
        }//end func










    }
}
