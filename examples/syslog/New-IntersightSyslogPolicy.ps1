$local_clients1 = Initialize-IntersightSyslogLocalfileloggingclient -MinSeverity 'emergency'

$profiles1 = Get-IntersightServerProfile -Moid '<Replace with Moid>'

$organization = Get-IntersightOrganizationOrganization -Name 'default'

$remote_clients1 = Initialize-IntersightSyslogRemoteloggingclient -Enabled 1 -Hostname '10.10.10.10' -Port 514 -Protocol 'tcp' -MinSeverity 'emergency'

$remote_clients2 = Initialize-IntersightSyslogRemoteloggingclient -Enabled 1 -Hostname '2001:0db8:0a0b:12f0:0000:0000:0000:0004' -Port 64000 -Protocol 'udp' -MinSeverity 'emergency'

$syslog1 = New-IntersightSyslogPolicy -LocalClients $local_clients1 -Profiles $profiles1 -Organization $organization -RemoteClients @($remote_clients1,$remote_clients2) -Name 'syslog1' -Description 'demo syslog policy'