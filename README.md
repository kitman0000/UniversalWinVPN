# UniversalWinVPN
     C# GUI and CLI app to create L2TP or PPTP VPN connections - Win Vista, 7, 8, 10

# Functionality
     This application will configure BOTH PPTP and L2TP connections
     GUI for manual configuration or command line options, it will work as a login script or GPO push with minimal annoyance to your users
     The flags that this applications requires look like this "VpnCreator.exe VpnName DestAddress L2TPKey(Or 1 for PPTP) UseCurrentCreds(true or false)"

# Technical Details
     This application Requires .Net 4.0 to be installed on the client computer
     To compile you must have the DotRas SDK installed

# Usage
     For PPTP:
          The format for the command line instructions to create a PPTP Connection is as follows "VpnCreator.exe VpnName DestAddress 1"
          Example: " VpnCreator.exe "Connection Name" Hostname 1 true " | This will create a perfectly PPTP connection that uses windows login credentials

     For L2TP
          The format for the command line instructions to create an L2TP Connection is as follows "VpnCreator.exe VpnName DestAddress PresharedKey"
          Example: " VpnCreator.exe "Connection Name" Hostname L2TPKey false " | This will create a valid L2TP connection that does not use the windows login credentials

