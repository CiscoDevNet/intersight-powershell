$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$vnic_iscsi_boot_policy = New-IntersightVnicIscsiBootPolicy -Organization $organization -Name 'vnic_iscsi_boot_policy1' -Description 'vnic iscsi boot policy' -InitiatorIpSource 'DHCP' -TargetSourceType 'Auto' -InitiatorStaticIpV4Address '10.1.1.1' -AutoTargetvendorName 'dummy'