$snmp_users1 = Initialize-IntersightSnmpUser -Name 'demouser' -PrivacyType 'AES' -SecurityLevel 'AuthPriv' -AuthType 'SHA' -AuthPassword 'dummyPassword' -PrivacyPassword 'dummyPrivatePassword'

$snmp_traps1 = Initialize-IntersightSnmpTrap -Destination '10.10.10.1' -Enabled 0 -Type 'Trap' -User 'demouser' -Port 660 -ObjectType 'SnmpTrap' -Version 'V3'

$profiles1 = Get-IntersightServerProfile -Moid '<Replace with Moid>'

$organization = Get-IntersightOrganizationOrganization -Name 'default'

$snmp1 = New-IntersightSnmpPolicy -SnmpUsers $snmp_users1 -SnmpTraps $snmp_traps1 -Profiles $profiles1 -Organization $organization -Name 'snmp1' -Description 'testing smtp policy' -Enabled 1 -SnmpPort 1983 -AccessCommunityString 'dummy123' -CommunityAccess 'Disabled' -TrapCommunity 'TrapCommunity' -SysContact 'aanimish' -SysLocation 'Karnataka' -EngineId 'vvb'