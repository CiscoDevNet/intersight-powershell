$organization = Get-IntersightOrganizationOrganization -Name 'default'

$vnic_iscsi_adapter_policy = New-IntersightVnicIscsiAdapterPolicy -Organization $organization -Name 'vnic_iscsi_adapter_policy1' -Description 'vnic iscsi adapter policy' -DhcpTimeout 60 -LunBusyRetryCount 15 -ConnectionTimeOut 15