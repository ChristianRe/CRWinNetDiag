 chcp 1252
rem chcp 858
rem ReadMe:
rem WinNetDiag.exe Version 0.2.3
rem Beta Software
rem 
rem Dieses Programm befindet sich zur Zeit noch in der Beta Test Phase.

rem Eine Benutzung ist nur zu Testzwecken zugelassen.
rem Bei dem Einsatz solcher noch nicht zum Vertrieb freigegebener Software k�nnen 
rem Fehlfunktionen und sogar Datenverluste auftreten. 
rem 

rem Dieses Batch File startet das in der Public Beta Test Phase befindliche Programm WinNetDiag.exe.
rem Mit Hilfe dieses Programms ist es m�glich die aktuelle Windowskonfiguration bez�glich der Netzwerkeinstellungen auszulesen
rem Es empfiehlt sich die Standardausgabe mit Hilfe des [">" Operators]in eine Datei f�r die weitere Analyse umzuleiten

type Readme.txt


WinNetDiag.exe > output.txt
notepad output.txt

pause