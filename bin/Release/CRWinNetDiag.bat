 chcp 1252
rem chcp 858
rem ReadMe:
rem WinNetDiag.exe Version 0.3.2
rem Beta Software
rem 
rem This program is still in the beta testing phase
rem Dieses Programm befindet sich zur Zeit noch in der Beta Test Phase.

rem A usage is permitted only for test purposes
rem At the usage of beta software wrong functions and data loss can occur
rem 
rem Eine Benutzung ist nur zu Testzwecken zugelassen.
rem Bei dem Einsatz solcher noch nicht zum Vertrieb freigegebener Software können 
rem Fehlfunktionen und sogar Datenverluste auftreten. 
rem 

rem This Batch starts the public beta sofztware CRWinNetDiag.exe  With this programm
rem it is possible to read the actual network configuration of windows host from all Windwos systems without the usage of privilege rights
 
rem Dieses Batch File startet das in der Public Beta Test Phase befindliche Programm CRWinNetDiag.exe.
rem Mit Hilfe dieses Programms ist es möglich die aktuelle Windowskonfiguration bezüglich der Netzwerkeinstellungen auszulesen

type Readme.txt


CRWinNetDiag.exe > output.txt
notepad output.txt

pause