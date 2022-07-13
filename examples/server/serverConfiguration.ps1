
# Get organization 

$organization1 = Get-IntersightOrganizationOrganization -Name 'default' | Get-IntersightMoMoRef

# create a couple of server policies
# Creating NTP policy

$ntp1 = New-IntersightNtpPolicy -Organization $organization1 -Name 'ntp1' -Description 'test policy' -Enabled 1 -NtpServers @('ntp.esl.cisco.com', 'time-a-g.nist.gov', 'time-b-g.nist.gov')

# Creating SMTP policy

$smtp1 = New-IntersightSmtpPolicy -Organization $organization1 -Enabled 0 -Name 'smtp1' -Description 'testing smtp policy' -SmtpPort 32 -MinSeverity 'critical' -SmtpServer '10.10.10.1' -SenderEmail 'IMCSQAAutomation@cisco.com' -SmtpRecipients @('aw@cisco.com', 'cy@cisco.com', 'dz@cisco.com')

# Creating SNMP policy

$snmp_users1 = Initialize-IntersightSnmpUser -Name 'demouser' -PrivacyType 'AES' -SecurityLevel 'AuthPriv' -AuthType 'SHA' -AuthPassword 'dummyPassword' -PrivacyPassword 'dummyPrivatePassword'

$snmp_traps1 = Initialize-IntersightSnmpTrap -Destination '10.10.10.1' -Enabled 0 -Type 'Trap' -User 'demouser' -Port 660 -ObjectType 'SnmpTrap' -Version 'V3'

$snmp1 = New-IntersightSnmpPolicy -SnmpUsers $snmp_users1 -SnmpTraps $snmp_traps1 -Organization $organization1 -Name 'snmp1' -Description 'testing smtp policy' -Enabled 1 -SnmpPort 1983 -AccessCommunityString 'dummy123' -CommunityAccess 'Disabled' -TrapCommunity 'TrapCommunity' -SysContact 'aanimish' -SysLocation 'Karnataka' -EngineId 'vvb'

# Get the server
$server1 = Get-IntersightComputeRackunit -Moid '<Replace with Moid>'
$server1Ref = $server1 | Get-IntersightMoMoRef

# Create a server profile & attach the policies and server
$tags1 = Initialize-IntersightMoTag -Key 'server' -Value 'demo'

$ntp1Ref = $ntp1 | Get-IntersightMoMoRef
$smtp1Ref = $smtp1 | Get-IntersightMoMoRef
$snmp1Ref = $snmp1 | Get-IntersightMoMoRef

New-IntersightServerProfile -Description "A sample server profile" -Name "ss_server_profile1" -Organization $Organization1 -Tags $tags1 -TargetPlatform "Standalone" -PolicyBucket @($ntp1Ref, $smtp1Ref, $snmp1Ref) -AssignedServer $server1Ref -Action 'Deploy'
