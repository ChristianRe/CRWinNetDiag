## CRWinNetDiag
Version 0.24; Public Beta Test

##Licence
CRWinNetDiag; The Tool collects TCP/IP Information for futher Analysis

Copyright (C) 2015  Christian Reusch

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http:www.gnu.org/licenses/>.

Diese Datei ist Teil von CRWinNetDiag.

CRWinNetDiag ist Freie Software: Sie können es unter den Bedingungen
der GNU General Public License, wie von der Free Software Foundation,
Version 3 der Lizenz oder (nach Ihrer Wahl) jeder späteren
veröffentlichten Version, weiterverbreiten und/oder modifizieren.

CRWinNetDiag wird in der Hoffnung, dass es nützlich sein wird, aber
OHNE JEDE GEWAEHRLEISTUNG, bereitgestellt; sogar ohne die implizite
Gewährleistung der MARKTFAEHIGKEIT oder EIGNUNG FÜR EINEN BESTIMMTEN ZWECK.
Siehe die GNU General Public License für weitere Details.

## Start the programm
The executable resides here ./bin/Release/CRWinNetDiag.exe it needs at least .net3.5 to run.

##Sample Output provided by the Programm
``` 
Product Name: Windows 8.1 Pro
Current Version: 6.3
Build Lab: 9600.winblue_r9.150322-1500
SP laut .net: 
Plattform laut .net: Microsoft Windows NT 6.2.9200.0
====================================== TCPIP Konfig ============================
ICSDomain                               mshome.net
SyncDomainWithMembership                1
NV Hostname                             xxxxxxx-TP
DataBasePath                            C:\WINDOWS\System32\drivers\etc
NameServer                              
ForwardBroadcasts                       0
Domain                                  
Hostname                                xxxxxxx-TP
SearchList                              
UseDomainNameDevolution                 1
DeadGWDetectDefault                     1
DontAddDefaultGatewayDefault            0
IPEnableRouter                          0
EnableICMPRedirect                      1
ReservedPorts                           System.String[]
EnableWsd                               0
QualifyingDestinationThreshold          3
DhcpNameServer                          192.168.2.1
DhcpDomain                              Speedport_W_xxx_xxxxxxx3_00_005
      
====================================== New Adapter =============================
NIC-ID:                                 {0793D7FD-9CB7-4834-B59F-CC88F5809323}
NIC-Name:                               Lenovo Easyplus Hotspot

NIC-Typ:                                Wireless80211
NIC-Status:                             Down
NIC-Speed:                              0
--------------------------------- Adapter Settings --------------------
PortAuthSendControlState                2
PortAuthReceiveControlState             2
PortAuthSendAuthorizationState          1
PortAuthReceiveAuthorizationState       1
BusNumber                               0
Characteristics                         9
ComponentId                             {5d624f94-8850-40c3-a3fa-a4fd2080baf3}\vwifimp_sap
NetCfgInstanceId                        {0793D7FD-9CB7-4834-B59F-CC88F5809323}
InstallTimeStamp                        System.Byte[]
*IfType                                 71
IfTypePreStart                          71
*MediaType                              16
*PhysicalMediaType                      9
NetLuidIndex                            33
DeviceInstanceID                        {5D624F94-8850-40C3-A3FA-A4FD2080BAF3}\VWIFIMP_SAP\5&28757B00&0&07
InfPath                                 netvwifimp.inf
InfSection                              vwifimp_sap.ndi
ProviderName                            Microsoft
DriverDateData                          System.Byte[]
DriverDate                              6-21-2006
DriverVersion                           6.3.9600.16384
MatchingDeviceId                        {5d624f94-8850-40c3-a3fa-a4fd2080baf3}\vwifimp_sap
      
====================================== New Adapter =============================
NIC-ID:                                 {EBD86B8C-D29D-4E00-9523-B8EE43223DBA}
NIC-Name:                               Mobiles Breitband
NIC-Typ:                                243
NIC-Status:                             Down
NIC-Speed:                              0
--------------------------------- Adapter Settings --------------------
BusNumber                               0
AllowDriverToOverrideDeviceName         1
Characteristics                         132
ComponentId                             usb\ms_comp_mbim
NetCfgInstanceId                        {EBD86B8C-D29D-4E00-9523-B8EE43223DBA}
InstallTimeStamp                        System.Byte[]
*IfType                                 243
IfTypePreStart                          243
*SelectiveSuspend                       1
----------------------Values *SelectiveSuspend----------------------------------
      ParamDesc                         Selektives Energiesparen
      default                           1
      type                              enum
-----Enum (Werte die der Parameter - *SelectiveSuspend -annehmen kann!)---------
            0                           Deaktivieren
            1                           Aktivieren
--------------------------------------------------------------------------------
*SSIdleTimeout                          5
*MediaType                              9
*PhysicalMediaType                      8
EnableDhcp                              0
NetLuidIndex                            0
DeviceInstanceID                        USB\VID_1199&PID_A001&MI_00\6&1186B04&0&0000
Port                                    0
BusType                                 15
InfPath                                 netwmbclass.inf
IncludedInfs                            System.String[]
InfSection                              wmbclass.ndi
ProviderName                            Microsoft
DriverDateData                          System.Byte[]
DriverDate                              10-31-2013
DriverVersion                           6.3.9600.16453
MatchingDeviceId                        usb\ms_comp_mbim
DriverDesc                              Generischer Adapter für das mobile Breitband
RadioOff                                0
LastDNSv4                               193.189.244.206 193.189.244.225 
LastDNSv6                               
LastIPv4                                10.47.238.40/024 
LastIPv6                                
LastGWv4                                10.47.238.1 
      
====================================== New Adapter =============================
NIC-ID:                                 {305553EB-4754-4C31-AB2A-62ED6AA777C8}
NIC-Name:                               LAN-Verbindung* 1
NIC-Typ:                                Wireless80211
NIC-Status:                             Down
NIC-Speed:                              0
--------------------------------- Adapter Settings --------------------
PortAuthSendControlState                2
PortAuthReceiveControlState             2
PortAuthSendAuthorizationState          1
PortAuthReceiveAuthorizationState       1
BusNumber                               0
Characteristics                         9
ComponentId                             {5d624f94-8850-40c3-a3fa-a4fd2080baf3}\vwifimp_wfd
NetCfgInstanceId                        {305553EB-4754-4C31-AB2A-62ED6AA777C8}
InstallTimeStamp                        System.Byte[]
*IfType                                 71
IfTypePreStart                          71
*MediaType                              16
*PhysicalMediaType                      9
NetLuidIndex                            6
DeviceInstanceID                        {5D624F94-8850-40C3-A3FA-A4FD2080BAF3}\VWIFIMP_WFD\5&28757B00&0&02
InfPath                                 netvwifimp.inf
InfSection                              vwifimp_wfd.ndi
ProviderName                            Microsoft
DriverDateData                          System.Byte[]
DriverDate                              6-21-2006
DriverVersion                           6.3.9600.16384
MatchingDeviceId                        {5d624f94-8850-40c3-a3fa-a4fd2080baf3}\vwifimp_wfd
      
====================================== New Adapter =============================
NIC-ID:                                 {AA44EB49-8842-44BE-B95C-D3D960F02ED3}
NIC-Name:                               WiFi
NIC-Typ:                                Wireless80211
NIC-Status:                             Up
NIC-Speed:                              400000000
--------------------------------- Adapter Settings --------------------
PortAuthSendControlState                2
PortAuthReceiveControlState             2
PortAuthSendAuthorizationState          1
PortAuthReceiveAuthorizationState       1
ApsdTriggerQueues                       0
BTEnableFlags                           153
CardType                                2
CCXv4FeatureSet                         0
CcxSdkActive                            1
CcxVersion                              0
ConfigurationName                       
ConnectionPriority                      2
DesiredAuthenticationMode               1
DesiredCipher                           1
DesiredDefaultKeyId                     0
DesiredPortType                         1
DesiredPSKey1                           xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
DesiredPSKey2                           xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
DesiredPSKey3                           xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
DesiredPSKey4                           xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
ExternalImage                           0
FixedLongPreamble                       0
FixedSupportedRates                     4095
ModulationType                          2
NdisEnvironment                         0
NetType                                 WLAN
PibssShortSlot                          1
Provider                                Intel
RadioEnable                             1
RecommendedBeaconInterval               100
BTOnThreshold                           4
APMMode                                 0
AtomMaxDpcTime                          20
MaxDpcTime                              30
DuplicateRateSupported                  0
BaEnable                                1
PanTimeoutForResetTxFailCnt             100
AdapterModel                            Intel(R) Dual Band Wireless-AC 7260
DriverDesc                              Intel(R) Dual Band Wireless-AC 7260
SKU_CAP                                 15
PanEnabled                              1
RxStbc                                  1
GreenFieldCapable                       0
CalibOverrideBbFilter                   System.Byte[]
CalibOverrideRxDc                       System.Byte[]
CalibOverrideTxLo                       System.Byte[]
CalibOverrideTxIq                       System.Byte[]
CalibOverrideTxIqSkew                   System.Byte[]
CalibOverrideRxIq                       System.Byte[]
CalibOverrideRxIqSkew                   System.Byte[]
CalibOverrideXtal                       System.Byte[]
SystemAllowedAntennas                   771
CalibrationActive                       0
CalibrationActiveUcode                  0
BTDuration                              -1
FixedSupportedHtRates                   65535
CLSGUID                                 {6DB92573-C061-11E1-A839-441EA15FCEDE}
Characteristics                         132
ComponentId                             pci\ven_8086&dev_08b2&subsys_c2708086
NetCfgInstanceId                        {AA44EB49-8842-44BE-B95C-D3D960F02ED3}
InstallTimeStamp                        System.Byte[]
*IfType                                 71
IfTypePreStart                          71
*DeviceSleepOnDisconnect                0
----------------------Values *DeviceSleepOnDisconnect---------------------------
      ParamDesc                         Medientrennung beim Aufrechterhalten des Energiesparmodus von WoWLAN
      type                              enum
      default                           0
-----Enum (Werte die der Parameter - *DeviceSleepOnDisconnect -annehmen kann!)--
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*PMARPOffload                           1
----------------------Values *PMARPOffload--------------------------------------
      ParamDesc                         ARP-Offload für WoWLAN
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *PMARPOffload -annehmen kann!)-------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*PMNSOffload                            1
----------------------Values *PMNSOffload---------------------------------------
      ParamDesc                         NS-Offload für WoWLAN
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *PMNSOffload -annehmen kann!)--------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*PMWiFiRekeyOffload                     1
----------------------Values *PMWiFiRekeyOffload--------------------------------
      ParamDesc                         GTK führt Neuverschlüsselung für WoWLAN durch
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *PMWiFiRekeyOffload -annehmen kann!)-------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*WakeOnMagicPacket                      1
----------------------Values *WakeOnMagicPacket---------------------------------
      ParamDesc                         Aktivierung durch Magic Packet
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *WakeOnMagicPacket -annehmen kann!)--------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*WakeOnPattern                          1
----------------------Values *WakeOnPattern-------------------------------------
      ParamDesc                         Aktivierung durch Musterübereinstimmung
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *WakeOnPattern -annehmen kann!)------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
BT3HSMode                               1
----------------------Values BT3HSMode------------------------------------------
      ParamDesc                         Bluetooth(R) AMP
      Type                              enum
      Default                           1
      Optional                          0
-----Enum (Werte die der Parameter - BT3HSMode -annehmen kann!)-----------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
CtsToItself                             1
----------------------Values CtsToItself----------------------------------------
      ParamDesc                         Schutz f. gemischte Umgebungen
      Type                              enum
      Default                           1
      Optional                          0
-----Enum (Werte die der Parameter - CtsToItself -annehmen kann!)---------------
            0                           RTS/CTS aktiviert
            1                           'CTS-to-self' aktiviert
--------------------------------------------------------------------------------
IbssQosEnabled                          0
----------------------Values IbssQosEnabled-------------------------------------
      ParamDesc                         Ad-Hoc QoS-Modus
      Type                              enum
      Default                           0
      Optional                          0
-----Enum (Werte die der Parameter - IbssQosEnabled -annehmen kann!)------------
            0                           WMM deaktiviert
            1                           WMM aktiviert
--------------------------------------------------------------------------------
IbssTxPower                             100
----------------------Values IbssTxPower----------------------------------------
      ParamDesc                         Übertragungsleistung
      Type                              enum
      Default                           100
      Optional                          0
-----Enum (Werte die der Parameter - IbssTxPower -annehmen kann!)---------------
            0                           1. Am niedrigsten
            25                          2. Mittel-niedrig
            50                          3. Mittel
            75                          4. Mittel-hoch
            100                         5. Am höchsten
--------------------------------------------------------------------------------
IEEE11nMode                             2
----------------------Values IEEE11nMode----------------------------------------
      ParamDesc                         HT Modus
      Type                              enum
      Default                           2
      Optional                          0
-----Enum (Werte die der Parameter - IEEE11nMode -annehmen kann!)---------------
            0                           Deaktiviert
            1                           HT Modus
            2                           VHT Modus
--------------------------------------------------------------------------------
RecommendedChannel24                    1
----------------------Values RecommendedChannel24-------------------------------
      ParamDesc                         Ad-Hoc-Kanal 802.11b/g
      Type                              int
      Optional                          0
      Min                               1
      Step                              1
      Max                               11
--------------------------------------------------------------------------------
RoamAggressiveness                      2
----------------------Values RoamAggressiveness---------------------------------
      ParamDesc                         Roaming-Dynamik
      Type                              enum
      Default                           2
      Optional                          0
-----Enum (Werte die der Parameter - RoamAggressiveness -annehmen kann!)--------
            0                           1. Am niedrigsten
            1                           2. Mittel-niedrig
            2                           3. Mittel
            3                           4. Mittel-hoch
            4                           5. Am höchsten
--------------------------------------------------------------------------------
RoamingPreferredBandType                2
----------------------Values RoamingPreferredBandType---------------------------
      ParamDesc                         Bevorzugtes Band
      Type                              enum
      Default                           0
      Optional                          0
-----Enum (Werte die der Parameter - RoamingPreferredBandType -annehmen kann!)--
            0                           1. Keine Einstellung
            1                           2. 2,4-GHz-Band bevorzugen
            2                           3. 5,2-GHz-Band bevorzugen
--------------------------------------------------------------------------------
WirelessMode                            34
*MediaType                              16
*PhysicalMediaType                      9
NetLuidIndex                            0
DeviceInstanceID                        PCI\VEN_8086&DEV_08B2&SUBSYS_C2708086&REV_83\4&2FBE8BD8&0&00E1
BusType                                 5
InfPath                                 oem99.inf
IncludedInfs                            System.String[]
InfSection                              Install_MPCIEX_GENUINGFF_7260_AC_2x2_HMC_WINB_64_AC
ProviderName                            Intel
DriverDateData                          System.Byte[]
DriverDate                              12-8-2014
DriverVersion                           17.13.11.5
MatchingDeviceId                        pci\ven_8086&dev_08b2&subsys_c2708086
PnPCapabilities                         16
HardwareVersion                         2.1.77
UcodeVersion                            19.DD
uCodeTimeStamp                          05/12 11:47 
PBANumber                               7158009
*MiracastSupported                      1
SkipOverDtimEnable                      1
LprxEnable                              1
PanP2PGOFollowBssChannel                1
IoacHwCapability                        C:\Program Files (x86)\Intel\WiFi\bin\IWLANAPI.DLL
IoacDebugFlags                          1
vhtCapabilities                         58749218
*PacketCoalescing                       1
----------------------Values *PacketCoalescing----------------------------------
      ParamDesc                         Paketzusammenfügung
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *PacketCoalescing -annehmen kann!)---------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
FatChannelIntolerant                    0
----------------------Values FatChannelIntolerant-------------------------------
      ParamDesc                         Fat Kanal Intolerant
      Type                              enum
      Default                           0
      Optional                          0
-----Enum (Werte die der Parameter - FatChannelIntolerant -annehmen kann!)------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
DesiredSsid                             xxxxxx Network
MandatoryBssid                          
DesiredBand                             2
DesiredKeyLength                        0
1xEnable                                0
RogueEnable                             0
DontEncryptEAP                          0
CMinCMax                                0
CcxTPC                                  0
CcxApAssistedRoaming                    0
CcxQoSParamaterSetIE                    0
CcxCCKM                                 0
CcxRadioMeasurements                    0
MixedCellsEnabled                       0
ThroughputBoosterEnabled                1
----------------------Values ThroughputBoosterEnabled---------------------------
      ParamDesc                         Durchsatzbooster
      Type                              enum
      Default                           0
      Optional                          0
-----Enum (Werte die der Parameter - ThroughputBoosterEnabled -annehmen kann!)--
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
ChannelMaskBand52                       0
ChannelMaskBand52J                      0
ChannelMaskBand24B                      2047
ChannelMaskBand24G                      2047
SwRadioState                            1
ChannelWidth24                          1
----------------------Values ChannelWidth24-------------------------------------
      ParamDesc                         802.11n Kanalbreite für 2.4 GHz
      Type                              enum
      Default                           1
      Optional                          0
-----Enum (Werte die der Parameter - ChannelWidth24 -annehmen kann!)------------
            0                           20 MHz
            1                           Auto
--------------------------------------------------------------------------------
ChannelWidth52                          1
----------------------Values ChannelWidth52-------------------------------------
      ParamDesc                         802.11n Kanalbreite für 5.2 GHz
      Type                              enum
      Default                           1
      Optional                          0
-----Enum (Werte die der Parameter - ChannelWidth52 -annehmen kann!)------------
            0                           20 MHz
            1                           Auto
--------------------------------------------------------------------------------
uAPSDSupport                            0
----------------------Values uAPSDSupport---------------------------------------
      ParamDesc                         U-APSD-Unterstützung
      Type                              enum
      Optional                          0
      Default                           0
-----Enum (Werte die der Parameter - uAPSDSupport -annehmen kann!)--------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
TGeEnableBits                           55
      
====================================== New Adapter =============================
NIC-ID:                                 {F854964F-B5DB-4B9A-B292-6A1991FE10AA}
NIC-Name:                               Ethernet
NIC-Typ:                                Ethernet
NIC-Status:                             Down
NIC-Speed:                              1073741824
--------------------------------- Adapter Settings --------------------
ProcessLSCinWorkItem                    1
Enable9KJFTpt                           1
LinkNegotiationProcess                  1
----------------------Values LinkNegotiationProcess-----------------------------
      ParamDesc                         Kompatibilitätsmodus für ältere Switches
      default                           1
      type                              enum
-----Enum (Werte die der Parameter - LinkNegotiationProcess -annehmen kann!)----
            2                           Aktiviert
            1                           Deaktiviert
--------------------------------------------------------------------------------
EnableTss                               0
ReceiveScalingMode                      1
Characteristics                         132
ComponentId                             pci\ven_8086&dev_153a&subsys_221017aa
NetCfgInstanceId                        {F854964F-B5DB-4B9A-B292-6A1991FE10AA}
InstallTimeStamp                        System.Byte[]
*IfType                                 6
IfTypePreStart                          6
*FlowControl                            3
----------------------Values *FlowControl---------------------------------------
      ParamDesc                         Flusssteuerung
      default                           3
      type                              enum
-----Enum (Werte die der Parameter - *FlowControl -annehmen kann!)--------------
            0                           Deaktiviert
            1                           Tx aktiviert
            2                           Rx aktiviert
            3                           Rx und Tx aktiviert
--------------------------------------------------------------------------------
*InterruptModeration                    1
----------------------Values *InterruptModeration-------------------------------
      ParamDesc                         Interrupt-Drosselung
      default                           1
      type                              enum
-----Enum (Werte die der Parameter - *InterruptModeration -annehmen kann!)------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*IPChecksumOffloadIPv4                  3
----------------------Values *IPChecksumOffloadIPv4-----------------------------
      ParamDesc                         IPv4-Prüfsummen abladen
      default                           3
      type                              enum
-----Enum (Werte die der Parameter - *IPChecksumOffloadIPv4 -annehmen kann!)----
            0                           Deaktiviert
            1                           Tx aktiviert
            2                           Rx aktiviert
            3                           Rx und Tx aktiviert
--------------------------------------------------------------------------------
*JumboPacket                            1514
----------------------Values *JumboPacket---------------------------------------
      ParamDesc                         Jumbo Packet
      default                           1514
      type                              enum
-----Enum (Werte die der Parameter - *JumboPacket -annehmen kann!)--------------
            1514                        Deaktiviert
            4088                        4088 Byte
            9014                        9014 Byte
--------------------------------------------------------------------------------
*LsoV2IPv4                              1
----------------------Values *LsoV2IPv4-----------------------------------------
      ParamDesc                         Large-Send-Offload V2 (IPv4)
      default                           1
      type                              enum
-----Enum (Werte die der Parameter - *LsoV2IPv4 -annehmen kann!)----------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*LsoV2IPv6                              1
----------------------Values *LsoV2IPv6-----------------------------------------
      ParamDesc                         Large-Send-Offload V2 (IPv6)
      default                           1
      type                              enum
-----Enum (Werte die der Parameter - *LsoV2IPv6 -annehmen kann!)----------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*PMARPOffload                           1
----------------------Values *PMARPOffload--------------------------------------
      ParamDesc                         Protokoll-ARP-Abladung
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *PMARPOffload -annehmen kann!)-------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*PMNSOffload                            1
----------------------Values *PMNSOffload---------------------------------------
      ParamDesc                         Protokoll-NS-Abladung
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *PMNSOffload -annehmen kann!)--------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*PriorityVLANTag                        3
----------------------Values *PriorityVLANTag-----------------------------------
      ParamDesc                         Paketpriorität und VLAN
      default                           3
      type                              enum
-----Enum (Werte die der Parameter - *PriorityVLANTag -annehmen kann!)----------
            0                           Paketpriorität und VLAN deaktiviert
            1                           Paketpriorität aktiviert
            2                           VLAN aktiviert
            3                           Paketpriorität und VLAN aktiviert
--------------------------------------------------------------------------------
*ReceiveBuffers                         256
----------------------Values *ReceiveBuffers------------------------------------
      ParamDesc                         Empfangspuffer
      default                           256
      min                               80
      max                               2048
      step                              8
      Base                              10
      type                              int
--------------------------------------------------------------------------------
*RSS                                    1
----------------------Values *RSS-----------------------------------------------
      ParamDesc                         RSS (Empfangsseitige Skalierung)
      default                           1
      type                              enum
-----Enum (Werte die der Parameter - *RSS -annehmen kann!)----------------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*SpeedDuplex                            0
----------------------Values *SpeedDuplex---------------------------------------
      ParamDesc                         Geschwindigkeit & Duplex
      default                           0
      type                              enum
-----Enum (Werte die der Parameter - *SpeedDuplex -annehmen kann!)--------------
            0                           Automatische Aushandlung
            1                           10 Mbit/s Halbduplex
            2                           10 Mbit/s Vollduplex
            3                           100 Mbit/s Halbduplex
            4                           100 Mbit/s Vollduplex
            6                           1,0 Gbit/s Vollduplex
--------------------------------------------------------------------------------
*TCPChecksumOffloadIPv4                 3
----------------------Values *TCPChecksumOffloadIPv4----------------------------
      ParamDesc                         TCP-Prüfsummen abladen (IPv4)
      default                           3
      type                              enum
-----Enum (Werte die der Parameter - *TCPChecksumOffloadIPv4 -annehmen kann!)---
            0                           Deaktiviert
            1                           Tx aktiviert
            2                           Rx aktiviert
            3                           Rx und Tx aktiviert
--------------------------------------------------------------------------------
*TCPChecksumOffloadIPv6                 3
----------------------Values *TCPChecksumOffloadIPv6----------------------------
      ParamDesc                         TCP-Prüfsummen abladen (IPv6)
      default                           3
      type                              enum
-----Enum (Werte die der Parameter - *TCPChecksumOffloadIPv6 -annehmen kann!)---
            0                           Deaktiviert
            1                           Tx aktiviert
            2                           Rx aktiviert
            3                           Rx und Tx aktiviert
--------------------------------------------------------------------------------
*TransmitBuffers                        512
----------------------Values *TransmitBuffers-----------------------------------
      ParamDesc                         Übertragungspuffer
      default                           512
      min                               80
      max                               2048
      step                              8
      Base                              10
      type                              int
--------------------------------------------------------------------------------
*UDPChecksumOffloadIPv4                 3
----------------------Values *UDPChecksumOffloadIPv4----------------------------
      ParamDesc                         UDP-Prüfsummen abladen (IPv4)
      default                           3
      type                              enum
-----Enum (Werte die der Parameter - *UDPChecksumOffloadIPv4 -annehmen kann!)---
            0                           Deaktiviert
            1                           Tx aktiviert
            2                           Rx aktiviert
            3                           Rx und Tx aktiviert
--------------------------------------------------------------------------------
*UDPChecksumOffloadIPv6                 3
----------------------Values *UDPChecksumOffloadIPv6----------------------------
      ParamDesc                         UDP-Prüfsummen abladen (IPv6)
      default                           3
      type                              enum
-----Enum (Werte die der Parameter - *UDPChecksumOffloadIPv6 -annehmen kann!)---
            0                           Deaktiviert
            1                           Tx aktiviert
            2                           Rx aktiviert
            3                           Rx und Tx aktiviert
--------------------------------------------------------------------------------
AdaptiveIFS                             0
----------------------Values AdaptiveIFS----------------------------------------
      ParamDesc                         Adaptives Interframe-Spacing 
      default                           0
      type                              enum
-----Enum (Werte die der Parameter - AdaptiveIFS -annehmen kann!)---------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
ITR                                     65535
----------------------Values ITR------------------------------------------------
      ParamDesc                         Interrupt-Drosselungsrate
      default                           65535
      type                              enum
-----Enum (Werte die der Parameter - ITR -annehmen kann!)-----------------------
            65535                       Adaptiv
            3600                        Extrem
            2000                        Hoch
            950                         Mittel
            400                         Niedrig
            200                         Minimal
            0                           Aus
--------------------------------------------------------------------------------
LogLinkStateEvent                       51
----------------------Values LogLinkStateEvent----------------------------------
      ParamDesc                         Verbindungsereignis protokollieren
      Type                              enum
      Default                           51
-----Enum (Werte die der Parameter - LogLinkStateEvent -annehmen kann!)---------
            51                          Aktiviert
            16                          Deaktiviert
--------------------------------------------------------------------------------
MasterSlave                             0
----------------------Values MasterSlave----------------------------------------
      ParamDesc                         Gigabit Master/Slave-Modus
      Type                              enum
      Default                           0
-----Enum (Werte die der Parameter - MasterSlave -annehmen kann!)---------------
            0                           Automatische Erkennung
            1                           Mastermodus erzwingen
            2                           Slavemodus erzwingen
--------------------------------------------------------------------------------
WaitAutoNegComplete                     2
----------------------Values WaitAutoNegComplete--------------------------------
      ParamDesc                         Auf Verbindung warten
      default                           2
      type                              enum
-----Enum (Werte die der Parameter - WaitAutoNegComplete -annehmen kann!)-------
            0                           Aus
            1                           Ein
            2                           Automatische Erkennung
--------------------------------------------------------------------------------
*MediaType                              0
*PhysicalMediaType                      14
NetLuidIndex                            0
DeviceInstanceID                        PCI\VEN_8086&DEV_153A&SUBSYS_221017AA&REV_04\3&21436425&0&C8
BusType                                 5
InfPath                                 oem161.inf
IncludedInfs                            System.String[]
InfSection                              E153A.6.3.1
ProviderName                            Intel
DriverDateData                          System.Byte[]
DriverDate                              3-24-2015
DriverVersion                           12.12.80.1950
MatchingDeviceId                        pci\ven_8086&dev_153a&subsys_221017aa
DriverDesc                              Intel(R) Ethernet Connection I217-LM
NicCoPlugins                            System.String[]
CoInstallFlag                           136327425
EnablePME                               1
----------------------Values EnablePME------------------------------------------
      ParamDesc                         PME aktivieren
      Type                              enum
      Default                           1
-----Enum (Werte die der Parameter - EnablePME -annehmen kann!)-----------------
            1                           Aktiviert
            0                           Deaktiviert
--------------------------------------------------------------------------------
PciScanMethod                           3
TxIntDelay                              28
MulticastFilterType                     0
VlanFiltering                           0
EnableMSI                               1
AutoPowerSaveModeEnabled                0
----------------------Values AutoPowerSaveModeEnabled---------------------------
      ParamDesc                         Geschwindigkeits-Akkusparoption
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - AutoPowerSaveModeEnabled -annehmen kann!)--
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*LsoV1IPv4                              0
WakeOnSlot                              0
*DeviceSleepOnDisconnect                0
*NumRssQueues                           2
----------------------Values *NumRssQueues--------------------------------------
      ParamDesc                         Max. Anzahl RSS-Warteschlangen
      default                           2
      type                              enum
-----Enum (Werte die der Parameter - *NumRssQueues -annehmen kann!)-------------
            1                           1 Warteschlange
            2                           2 Warteschlangen
--------------------------------------------------------------------------------
*WakeOnMagicPacket                      1
----------------------Values *WakeOnMagicPacket---------------------------------
      ParamDesc                         Akt. über Magic Packet
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *WakeOnMagicPacket -annehmen kann!)--------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
*WakeOnPattern                          1
----------------------Values *WakeOnPattern-------------------------------------
      ParamDesc                         Akt. bei Musterübereinstimmung
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - *WakeOnPattern -annehmen kann!)------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
EEELinkAdvertisement                    1
----------------------Values EEELinkAdvertisement-------------------------------
      ParamDesc                         Energieeffizientes Ethernet
      type                              enum
      default                           1
-----Enum (Werte die der Parameter - EEELinkAdvertisement -annehmen kann!)------
            0                           Aus
            1                           Ein
--------------------------------------------------------------------------------
ReduceSpeedOnPowerDown                  1
----------------------Values ReduceSpeedOnPowerDown-----------------------------
      ParamDesc                         Geschw. beim Abschalten reduzieren
      Type                              enum
      Default                           1
-----Enum (Werte die der Parameter - ReduceSpeedOnPowerDown -annehmen kann!)----
            1                           Aktiviert
            0                           Deaktiviert
--------------------------------------------------------------------------------
SipsEnabled                             0
----------------------Values SipsEnabled----------------------------------------
      ParamDesc                         Systemleerlauf-Energiesparoption
      type                              enum
      default                           0
-----Enum (Werte die der Parameter - SipsEnabled -annehmen kann!)---------------
            0                           Deaktiviert
            1                           Aktiviert
--------------------------------------------------------------------------------
WakeOnLink                              0
BusNumber                               0
SlotNumber                              25
PnPCapabilities                         0
      
====================================== New Adapter =============================
NIC-ID:                                 {12C8908D-306B-4FC2-A8ED-325007ACEABE}
NIC-Name:                               VirtualBox Host-Only Network
NIC-Typ:                                Ethernet
NIC-Status:                             Up
NIC-Speed:                              100000000
--------------------------------- Adapter Settings --------------------
Characteristics                         1
ComponentId                             sun_vboxnetadp
NetCfgInstanceId                        {12C8908D-306B-4FC2-A8ED-325007ACEABE}
InstallTimeStamp                        System.Byte[]
*IfType                                 6
IfTypePreStart                          6
NetLuidIndex                            7
DeviceInstanceID                        ROOT\NET\0000
InfPath                                 oem71.inf
InfSection                              VBoxNetAdp.ndi
ProviderName                            Oracle Corporation
DriverDateData                          System.Byte[]
DriverDate                              3-16-2015
DriverVersion                           4.3.26.0
MatchingDeviceId                        sun_vboxnetadp
DriverDesc                              VirtualBox Host-Only Ethernet Adapter
MAC                                     08002700185f
      
====================================== New Adapter =============================
NIC-ID:                                 {BBED3E08-0B41-11E3-8249-806E6F6E6963}
NIC-Name:                               Loopback Pseudo-Interface 1
NIC-Typ:                                Loopback
NIC-Status:                             Up
NIC-Speed:                              1073741824
--------------------------------- Adapter Settings --------------------
      
====================================== netstat -e ==============================
Schnittstellenstatistik

                           Empfangen           Gesendet

Bytes                    1060028650        90286628
Unicastpakete                781880          437480
Nicht-Unicastpakete            8020          199784
Verworfen                         0               0
Fehler                            0               0
Unbekannte Protok.                0
________________________________________________________________________________


====================================== netstat -ano ============================

Aktive Verbindungen

  Proto  Lokale Adresse         Remoteadresse          Status           PID
  TCP    0.0.0.0:80             0.0.0.0:0              ABHÖREN         4
  TCP    0.0.0.0:135            0.0.0.0:0              ABHÖREN         624
  TCP    0.0.0.0:445            0.0.0.0:0              ABHÖREN         4
  TCP    0.0.0.0:554            0.0.0.0:0              ABHÖREN         1472
  TCP    0.0.0.0:623            0.0.0.0:0              ABHÖREN         2560
  TCP    0.0.0.0:1110           0.0.0.0:0              ABHÖREN         2588
  TCP    0.0.0.0:2869           0.0.0.0:0              ABHÖREN         4
  TCP    0.0.0.0:5366           0.0.0.0:0              ABHÖREN         5556
  TCP    0.0.0.0:6369           0.0.0.0:0              ABHÖREN         3484
  TCP    0.0.0.0:8080           0.0.0.0:0              ABHÖREN         4
  TCP    0.0.0.0:9191           0.0.0.0:0              ABHÖREN         4
  TCP    0.0.0.0:10243          0.0.0.0:0              ABHÖREN         4
  TCP    0.0.0.0:12321          0.0.0.0:0              ABHÖREN         2588
  TCP    0.0.0.0:16992          0.0.0.0:0              ABHÖREN         2560
  TCP    0.0.0.0:31067          0.0.0.0:0              ABHÖREN         2816
  TCP    0.0.0.0:49152          0.0.0.0:0              ABHÖREN         920
  TCP    0.0.0.0:49153          0.0.0.0:0              ABHÖREN         1216
  TCP    0.0.0.0:49154          0.0.0.0:0              ABHÖREN         1256
  TCP    0.0.0.0:49155          0.0.0.0:0              ABHÖREN         2068
  TCP    0.0.0.0:49159          0.0.0.0:0              ABHÖREN         992
  TCP    0.0.0.0:49166          0.0.0.0:0              ABHÖREN         984
  TCP    0.0.0.0:50182          0.0.0.0:0              ABHÖREN         3164
  TCP    127.0.0.1:515          0.0.0.0:0              ABHÖREN         7608
  TCP    127.0.0.1:1110         127.0.0.1:53588        HERGESTELLT     2588
  TCP    127.0.0.1:1110         127.0.0.1:53596        HERGESTELLT     2588
  TCP    127.0.0.1:1110         127.0.0.1:54386        HERGESTELLT     2588
  TCP    127.0.0.1:1110         127.0.0.1:54806        HERGESTELLT     2588
  TCP    127.0.0.1:1110         127.0.0.1:54994        HERGESTELLT     2588
  TCP    127.0.0.1:1110         127.0.0.1:54995        FIN_WARTEN_2    2588
  TCP    127.0.0.1:1110         127.0.0.1:55091        HERGESTELLT     2588
  TCP    127.0.0.1:2869         127.0.0.1:54989        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:54992        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:54998        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:54999        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55003        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55004        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55008        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55011        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55021        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55022        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55028        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55029        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55038        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55041        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55077        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55079        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55082        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55083        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55086        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55090        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55093        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55096        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55098        WARTEND         0
  TCP    127.0.0.1:2869         127.0.0.1:55099        WARTEND         0
  TCP    127.0.0.1:5354         0.0.0.0:0              ABHÖREN         2688
  TCP    127.0.0.1:5354         127.0.0.1:53494        HERGESTELLT     2688
  TCP    127.0.0.1:5354         127.0.0.1:53495        HERGESTELLT     2688
  TCP    127.0.0.1:5354         127.0.0.1:53548        HERGESTELLT     2688
  TCP    127.0.0.1:49397        0.0.0.0:0              ABHÖREN         2560
  TCP    127.0.0.1:53494        127.0.0.1:5354         HERGESTELLT     12276
  TCP    127.0.0.1:53495        127.0.0.1:5354         HERGESTELLT     12276
  TCP    127.0.0.1:53548        127.0.0.1:5354         HERGESTELLT     12276
  TCP    127.0.0.1:53588        127.0.0.1:1110         HERGESTELLT     8464
  TCP    127.0.0.1:53596        127.0.0.1:1110         HERGESTELLT     8464
  TCP    127.0.0.1:54386        127.0.0.1:1110         HERGESTELLT     11396
  TCP    127.0.0.1:54806        127.0.0.1:1110         HERGESTELLT     11396
  TCP    127.0.0.1:54962        127.0.0.1:1110         WARTEND         0
  TCP    127.0.0.1:54994        127.0.0.1:1110         HERGESTELLT     12600
  TCP    127.0.0.1:54995        127.0.0.1:1110         SCHLIESSEN_WARTEN    12600
  TCP    127.0.0.1:55091        127.0.0.1:1110         HERGESTELLT     8464
  TCP    192.168.2.104:55101    192.168.2.105:9080     WARTEND         0
  TCP    192.168.2.104:55102    192.168.2.105:38412    WARTEND         0
  TCP    [::]:80                [::]:0                 ABHÖREN         4
  TCP    [::]:135               [::]:0                 ABHÖREN         624
  TCP    [::]:445               [::]:0                 ABHÖREN         4
  TCP    [::]:554               [::]:0                 ABHÖREN         1472
  TCP    [::]:623               [::]:0                 ABHÖREN         2560
  TCP    [::]:1110              [::]:0                 ABHÖREN         2588
  TCP    [::]:2869              [::]:0                 ABHÖREN         4
  TCP    [::]:8080              [::]:0                 ABHÖREN         4
  TCP    [::]:9191              [::]:0                 ABHÖREN         4
  TCP    [::]:10243             [::]:0                 ABHÖREN         4
  TCP    [::]:12321             [::]:0                 ABHÖREN         2588
  TCP    [::]:16992             [::]:0                 ABHÖREN         2560
  TCP    [::]:49152             [::]:0                 ABHÖREN         920
  TCP    [::]:49153             [::]:0                 ABHÖREN         1216
  TCP    [::]:49154             [::]:0                 ABHÖREN         1256
  TCP    [::]:49155             [::]:0                 ABHÖREN         2068
  TCP    [::]:49159             [::]:0                 ABHÖREN         992
  TCP    [::]:49166             [::]:0                 ABHÖREN         984
  TCP    [::]:50182             [::]:0                 ABHÖREN         3164
  TCP    [::1]:1110             [::1]:53601            HERGESTELLT     2588
  TCP    [::1]:1110             [::1]:53605            HERGESTELLT     2588
  TCP    [::1]:49396            [::]:0                 ABHÖREN         6864
  TCP    [::1]:53449            [::1]:53451            HERGESTELLT     2560
  TCP    [::1]:53451            [::1]:53449            HERGESTELLT     2560
  TCP    [::1]:53601            [::1]:1110             HERGESTELLT     8464
  TCP    [::1]:53605            [::1]:1110             HERGESTELLT     8464
  TCP    [::1]:54896            [::1]:1110             WARTEND         0
  TCP    [::1]:54915            [::1]:1110             WARTEND         0
  TCP    [::1]:54933            [::1]:1110             WARTEND         0
  TCP    [::1]:54987            [::1]:1110             WARTEND         0
  UDP    0.0.0.0:68             *:*                                    1216
  UDP    0.0.0.0:123            *:*                                    1304
  UDP    0.0.0.0:500            *:*                                    1256
  UDP    127.0.0.1:1900         *:*                                    2112
  UDP    127.0.0.1:61353        *:*                                    2112
  UDP    [::]:123               *:*                                    1304
  UDP    [::]:500               *:*                                    1256
  UDP    [::]:1434              *:*                                    3628
  UDP    [::]:4500              *:*                                    1256
  UDP    [::]:5004              *:*                                    1472
  UDP    [::]:5005              *:*                                    1472
  UDP    [::]:5355              *:*                                    1904
  UDP    [::]:49402             *:*                                    2688
  UDP    [::1]:1900             *:*                                    2112
  UDP    [::1]:61350            *:*                                    2112
  UDP    [fe80::10b0:462e:c279:f46a%9]:546  *:*                                    1216
  UDP    [fe80::10b0:462e:c279:f46a%9]:1900  *:*                                    2112
  UDP    [fe80::10b0:462e:c279:f46a%9]:5353  *:*                                    2688
  UDP    [fe80::10b0:462e:c279:f46a%9]:61349  *:*                                    2112
  UDP    [fe80::40b6:2263:3153:b4ab%4]:1900  *:*                                    2112
  UDP    [fe80::40b6:2263:3153:b4ab%4]:61348  *:*                                    2112
________________________________________________________________________________


====================================== netstat -tn =============================

Aktive Verbindungen

  Proto. Lokale Adresse       Remoteadresse       Status       Abladungsstatus

  TCP    127.0.0.1:1110         127.0.0.1:53588        HERGESTELLT     InHost      
  TCP    127.0.0.1:1110         127.0.0.1:53596        HERGESTELLT     InHost      
  TCP    127.0.0.1:1110         127.0.0.1:54386        HERGESTELLT     InHost      
  TCP    127.0.0.1:1110         127.0.0.1:54806        HERGESTELLT     InHost      
  TCP    127.0.0.1:1110         127.0.0.1:54994        HERGESTELLT     InHost      
  TCP    127.0.0.1:1110         127.0.0.1:54995        FIN_WARTEN_2    InHost      
  TCP    127.0.0.1:1110         127.0.0.1:55091        HERGESTELLT     InHost      
  TCP    127.0.0.1:2869         127.0.0.1:54989        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:54992        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:54998        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:54999        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55003        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55004        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55008        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55011        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55021        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55022        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55028        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55029        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55038        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55041        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55077        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55079        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55082        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55083        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55086        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55090        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55093        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55096        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55098        WARTEND         InHost      
  TCP    127.0.0.1:2869         127.0.0.1:55099        WARTEND         InHost      
  TCP    127.0.0.1:5354         127.0.0.1:53494        HERGESTELLT     InHost      
  TCP    127.0.0.1:5354         127.0.0.1:53495        HERGESTELLT     InHost      
  TCP    127.0.0.1:5354         127.0.0.1:53548        HERGESTELLT     InHost      
  TCP    127.0.0.1:53494        127.0.0.1:5354         HERGESTELLT     InHost      
  TCP    127.0.0.1:53495        127.0.0.1:5354         HERGESTELLT     InHost      
  TCP    127.0.0.1:53548        127.0.0.1:5354         HERGESTELLT     InHost      
  TCP    127.0.0.1:53588        127.0.0.1:1110         HERGESTELLT     InHost      
  TCP    127.0.0.1:53596        127.0.0.1:1110         HERGESTELLT     InHost      
  TCP    127.0.0.1:54386        127.0.0.1:1110         HERGESTELLT     InHost      
  TCP    127.0.0.1:54806        127.0.0.1:1110         HERGESTELLT     InHost      
  TCP    127.0.0.1:54962        127.0.0.1:1110         WARTEND         InHost      
  TCP    127.0.0.1:54994        127.0.0.1:1110         HERGESTELLT     InHost      
  TCP    127.0.0.1:54995        127.0.0.1:1110         SCHLIESSEN_WARTEN    InHost      
  TCP    127.0.0.1:55091        127.0.0.1:1110         HERGESTELLT     InHost      
  TCP    192.168.2.104:55102    192.168.2.105:38412    WARTEND         InHost      
  TCP    [::1]:1110             [::1]:53601            HERGESTELLT     InHost      
  TCP    [::1]:1110             [::1]:53605            HERGESTELLT     InHost      
  TCP    [::1]:53449            [::1]:53451            HERGESTELLT     InHost      
  TCP    [::1]:53451            [::1]:53449            HERGESTELLT     InHost      
  TCP    [::1]:53601            [::1]:1110             HERGESTELLT     InHost      
  TCP    [::1]:53605            [::1]:1110             HERGESTELLT     InHost      
  TCP    [::1]:54896            [::1]:1110             WARTEND         InHost      
  TCP    [::1]:54915            [::1]:1110             WARTEND         InHost      
  TCP    [::1]:54933            [::1]:1110             WARTEND         InHost      
  TCP    [::1]:54987            [::1]:1110             WARTEND         InHost      
  TCP    [fe80::10b0:462e:c279:f46a%9]:49156  [fe80::10b0:462e:c279:f46a%9]:8080  HERGESTELLT     InHost      
________________________________________________________________________________


====================================== netstat -s ==============================

IPv4-Statistik

  Empfangene Pakete                    = 405661
  Empfangene Vorspannfehler            = 9561
  Empfangene Adressfehler              = 236
  Weitergeleitete Datagramme           = 0
  Empfangene unbekannte Protokolle     = 0
  Empfangene verworfene Pakete         = 77006
  Empfangene übermittelte Pakete       = 510996
  Ausgabeanforderungen                 = 603259
  Verworfene Routingpakete             = 0
  Verworfene Ausgabepakete             = 256
  Ausgabepakete ohne Routing           = 227
  Reassemblierung erforderlich         = 3393
  Reassemblierung erfolgreich          = 1677
  Reassemblierung erfolglos            = 0
  Erfolgreiche Datagrammfragmentierung = 0
  Erfolglose Datagrammfragmentierung   = 0
  Erzeugte Fragmente                   = 0

IPv6-Statistik

  Empfangene Pakete                    = 138091
  Empfangene Vorspannfehler            = 0
  Empfangene Adressfehler              = 7
  Weitergeleitete Datagramme           = 0
  Empfangene unbekannte Protokolle     = 0
  Empfangene verworfene Pakete         = 10382
  Empfangene übermittelte Pakete       = 143586
  Ausgabeanforderungen                 = 169025
  Verworfene Routingpakete             = 0
  Verworfene Ausgabepakete             = 64
  Ausgabepakete ohne Routing           = 76
  Reassemblierung erforderlich         = 0
  Reassemblierung erfolgreich          = 0
  Reassemblierung erfolglos            = 0
  Erfolgreiche Datagrammfragmentierung = 0
  Erfolglose Datagrammfragmentierung   = 0
  Erzeugte Fragmente                   = 0

ICMPv4-Statistik

                            Empfangen Gesendet
  Meldungen                 368         481       
  Fehler                    0           0         
  Ziel nicht erreichbar     368         479       
  Zeitüberschreitung        0           0         
  Parameterprobleme         0           0         
  Quelldrosselung           0           0         
  Umleitungen               0           0         
  Echoantworten             0           0         
  Echos                     0           2         
  Zeiteinträge              0           0         
  Zeiteintragantworten      0           0         
  Adressmasken              0           0         
  Adressmaskenantworten     0           0         
  Routeranfragen            0           0         
  Routerankündigungen       0           0         

ICMPv6-Statistik

                            Empfangen   Gesendet
  Meldungen                 8246        2150      
  Fehler                    0           0         
  Ziel nicht erreichbar     11          128       
  Paket zu groß             0           0         
  Zeitüberschreitung        0           0         
  Parameterprobleme         0           0         
  Echos                     0           0         
  Echoantworten             0           0         
  MLD-Abfragen              719         0         
  MLD-Berichte              1105        0         
  MLD-Beendigungen          0           0         
  Routeranfragen            0           52        
  Routerankündigungen       781         0         
  Nachbaranfragen           1518        678       
  Nachbarankündigungen      4112        1292      
  Umleitungen               0           0         
  Routerneunummerierungen    0           0         

TCP-Statistik für IPv4

  Aktiv geöffnet                      = 40587
  Passiv geöffnet                     = 18863
  Erfolglose Verbindungsversuche      = 1404
  Zurückgesetzte Verbindungen         = 2190
  Aktuelle Verbindungen               = 26
  Empfangene Segmente                 = 872808
  Gesendete Segmente                  = 759187
  Erneut übertragene Segmente         = 24298

TCP-Statistik für IPv6

  Aktiv geöffnet                      = 5798
  Passiv geöffnet                     = 3022
  Erfolglose Verbindungsversuche      = 66
  Zurückgesetzte Verbindungen         = 902
  Aktuelle Verbindungen               = 10
  Empfangene Segmente                 = 373777
  Gesendete Segmente                  = 319665
  Erneut übertragene Segmente         = 6414

UDP-Statistik für IPv4

  Empfangene Datagramme = 111840
  Keine Anschlüsse      = 76471
  Empfangsfehler        = 499
  Gesendete Datagramme  = 110345

UDP-Statistik für IPv6

  Empfangene Datagramme = 12986
  Keine Anschlüsse      = 9515
  Empfangsfehler        = 39
  Gesendete Datagramme  = 23181
________________________________________________________________________________


====================================== netstat -rn =============================
===========================================================================
Schnittstellenliste
 37...2a b2 bd a7 67 ff ......Von Microsoft gehosteter, virtueller Netzwerkadapter
  6...b0 85 b3 5d 5d 47 ......Sierra Wireless EM7345 4G LTE
  5...28 b2 bd a7 67 00 ......Virtueller Microsoft-Adapter für direktes WiFi
  4...28 b2 bd a7 67 ff ......Intel(R) Dual Band Wireless-AC 7260
  3...54 ee 75 26 66 a8 ......Intel(R) Ethernet Connection I217-LM
  9...08 00 27 00 18 5f ......VirtualBox Host-Only Ethernet Adapter
  1...........................Software Loopback Interface 1
===========================================================================

IPv4-Routentabelle
===========================================================================
Aktive Routen:
     Netzwerkziel    Netzwerkmaske          Gateway    Schnittstelle Metrik
          0.0.0.0          0.0.0.0      192.168.2.1    192.168.2.104     10
        127.0.0.0        255.0.0.0   Auf Verbindung         127.0.0.1    306
        127.0.0.1  255.255.255.255   Auf Verbindung         127.0.0.1    306
  127.255.255.255  255.255.255.255   Auf Verbindung         127.0.0.1    306
    192.168.2.104  255.255.255.255   Auf Verbindung     192.168.2.104    266
    192.168.2.255  255.255.255.255   Auf Verbindung     192.168.2.104    266
        224.0.0.0        240.0.0.0   Auf Verbindung         127.0.0.1    306
         224.0.0.0        240.0.0.0   Auf Verbindung     192.168.2.104    266
  255.255.255.255  255.255.255.255   Auf Verbindung         127.0.0.1    306
   255.255.255.255  255.255.255.255   Auf Verbindung     192.168.2.104    266
===========================================================================
Ständige Routen:
  Keine

IPv6-Routentabelle
===========================================================================
Aktive Routen:
 If Metrik Netzwerkziel             Gateway
  4    266 ::/0                     fe80::1
  1    306 ::1/128                  Auf Verbindung
 ===========================================================================
Ständige Routen:
  Keine
________________________________________________________________________________


====================================== ipconfig /all ===========================

Windows-IP-Konfiguration

   Hostname  . . . . . . . . . . . . : xxxxxxxxxx-TP
   Primäres DNS-Suffix . . . . . . . : 
   Knotentyp . . . . . . . . . . . . : Hybrid
   IP-Routing aktiviert  . . . . . . : Nein
   WINS-Proxy aktiviert  . . . . . . : Nein
   DNS-Suffixsuchliste . . . . . . . : Speedport_W_xxxx_xxxxxx_00_005

Drahtlos-LAN-Adapter Lenovo Easyplus Hotspot
:

   Medienstatus. . . . . . . . . . . : Medium getrennt
   Verbindungsspezifisches DNS-Suffix: 
   Beschreibung. . . . . . . . . . . : Von Microsoft gehosteter, virtueller Netzwerkadapter
   Physische Adresse . . . . . . . . : 2A-B2-BD-A7-67-FF
   DHCP aktiviert. . . . . . . . . . : Ja
   Autokonfiguration aktiviert . . . : Ja

Mobiler Breitbandadapter Mobiles Breitband:

   Medienstatus. . . . . . . . . . . : Medium getrennt
   Verbindungsspezifisches DNS-Suffix: 
   Beschreibung. . . . . . . . . . . : Sierra Wireless EM7345 4G LTE
   Physische Adresse . . . . . . . . : B0-85-B3-5D-5D-47
   DHCP aktiviert. . . . . . . . . . : Nein
   Autokonfiguration aktiviert . . . : Ja

Drahtlos-LAN-Adapter LAN-Verbindung* 1:

   Medienstatus. . . . . . . . . . . : Medium getrennt
   Verbindungsspezifisches DNS-Suffix: 
   Beschreibung. . . . . . . . . . . : Virtueller Microsoft-Adapter für direktes WiFi
   Physische Adresse . . . . . . . . : 28-B2-BD-A7-67-00
   DHCP aktiviert. . . . . . . . . . : Nein
   Autokonfiguration aktiviert . . . : Ja

Drahtlos-LAN-Adapter WiFi:

   Verbindungsspezifisches DNS-Suffix: Speedport_W_xxxxxxxxx_00_005
   Beschreibung. . . . . . . . . . . : Intel(R) Dual Band Wireless-AC 7260
   Physische Adresse . . . . . . . . : 28-B2-BD-A7-67-FF
   DHCP aktiviert. . . . . . . . . . : Ja
   Autokonfiguration aktiviert . . . : Ja
   IPv6-Adresse. . . . . . . . . . . : 
   IPv6-Adresse. . . . . . . . . . . :  
   Temporäre IPv6-Adresse. . . . . . : 
   Temporäre IPv6-Adresse. . . . . . :  
   Verbindungslokale IPv6-Adresse  . : fe80::40b6:2263:3153:b4ab%4(Bevorzugt) 
   IPv4-Adresse  . . . . . . . . . . : 192.168.2.104(Bevorzugt) 
   Subnetzmaske  . . . . . . . . . . : 255.255.255.0
   Lease erhalten. . . . . . . . . . : Montag, 18. Mai 2015 21:32:35
   Lease läuft ab. . . . . . . . . . : Montag, 8. Juni 2015 21:32:35
   Standardgateway . . . . . . . . . : fe80::1%4
                                       192.168.2.1
   DHCP-Server . . . . . . . . . . . : 192.168.2.1
   DHCPv6-IAID . . . . . . . . . . . : 69776061
   DHCPv6-Client-DUID. . . . . . . . : 00-01-00-01-1B-D1-FB-CC-54-EE-75-26-66-A8
   DNS-Server  . . . . . . . . . . . : fe80::1%4
                                       192.168.2.1
   NetBIOS über TCP/IP . . . . . . . : Deaktiviert

Ethernet-Adapter Ethernet:

   Medienstatus. . . . . . . . . . . : Medium getrennt
   Verbindungsspezifisches DNS-Suffix: Speedport_W_xxx_xxxxx_00_005
   Beschreibung. . . . . . . . . . . : Intel(R) Ethernet Connection I217-LM
   Physische Adresse . . . . . . . . : 54-EE-75-26-66-A8
   DHCP aktiviert. . . . . . . . . . : Nein
   Autokonfiguration aktiviert . . . : Ja

Ethernet-Adapter VirtualBox Host-Only Network:

   Verbindungsspezifisches DNS-Suffix: 
   Beschreibung. . . . . . . . . . . : VirtualBox Host-Only Ethernet Adapter
   Physische Adresse . . . . . . . . : 08-00-27-00-18-5F
   DHCP aktiviert. . . . . . . . . . : Ja
   Autokonfiguration aktiviert . . . : Ja
   Verbindungslokale IPv6-Adresse  . : fe80::10b0:462e:c279:f46a%9(Bevorzugt) 
   IPv4-Adresse (Auto. Konfiguration): 169.254.244.106(Bevorzugt) 
   Subnetzmaske  . . . . . . . . . . : 255.255.0.0
   Standardgateway . . . . . . . . . : 
   DHCPv6-IAID . . . . . . . . . . . : 151519271
   DHCPv6-Client-DUID. . . . . . . . : 00-01-00-01-1B-D1-FB-CC-54-EE-75-26-66-A8
   DNS-Server  . . . . . . . . . . . :  
   NetBIOS über TCP/IP . . . . . . . : Deaktiviert
________________________________________________________________________________


====================================== arp  -av ================================

Schnittstelle: 127.0.0.1 --- 0x1
  Internetadresse       Physische Adresse     Typ
  224.0.0.2                                   statisch  
  224.0.0.22                                  statisch  
  224.0.0.251                                 statisch  
  224.0.0.252                                 statisch  
  239.255.255.250                             statisch  

Schnittstelle: 0.0.0.0 --- 0xffffffff
  Internetadresse       Physische Adresse     Typ
  224.0.0.22            01-00-5e-00-00-16     statisch  

Schnittstelle: 192.168.2.104 --- 0x4
  Internetadresse       Physische Adresse     Typ
  10.56.35.1            00-00-00-00-00-00     ungültig  
  192.168.2.1           18-83-bf-23-09-e8     dynamisch 
  192.168.2.22          00-00-f0-a6-b2-d8     dynamisch 
  192.168.2.101         18-8e-d5-01-e0-c5     dynamisch 
  192.168.2.105         74-c2-46-41-78-54     dynamisch 
  192.168.2.113         00-26-bb-72-5d-32     dynamisch 
  224.0.0.22            01-00-5e-00-00-16     statisch  
  224.0.0.251           01-00-5e-00-00-fb     statisch  
  224.0.0.252           01-00-5e-00-00-fc     statisch  
 
Schnittstelle: 0.0.0.0 --- 0xffffffff
  Internetadresse       Physische Adresse     Typ
  224.0.0.2             01-00-5e-00-00-02     statisch  
  224.0.0.22            01-00-5e-00-00-16     statisch  
  224.0.0.252           01-00-5e-00-00-fc     statisch  
  239.255.255.250       01-00-5e-7f-ff-fa     statisch  

Schnittstelle: 0.0.0.0 --- 0xffffffff
  Internetadresse       Physische Adresse     Typ
  224.0.0.22            02-b0-ff-ff-00-30     statisch  

Schnittstelle: 169.254.244.106 --- 0x9
  Internetadresse       Physische Adresse     Typ
  224.0.0.22            01-00-5e-00-00-16     statisch  
  224.0.0.251           01-00-5e-00-00-fb     statisch  
  224.0.0.252           01-00-5e-00-00-fc     statisch  
  239.255.255.250       01-00-5e-7f-ff-fa     statisch  
  255.255.255.255       ff-ff-ff-ff-ff-ff     statisch  

Schnittstelle: 0.0.0.0 --- 0xffffffff
  Internetadresse       Physische Adresse     Typ
  224.0.0.2             01-00-5e-00-00-02     statisch  
  224.0.0.22            01-00-5e-00-00-16     statisch  
  224.0.0.252           01-00-5e-00-00-fc     statisch  
  239.255.255.250       01-00-5e-7f-ff-fa     statisch  
________________________________________________________________________________
```



