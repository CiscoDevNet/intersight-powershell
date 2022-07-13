$exta_traffic1 = Initialize-IntersightReplicationNamedvsan -Name 'exta_traffic1' -VlanId 100

$extb_traffic1 = Initialize-IntersightReplicationNamedvsan -Name 'extb_traffic1' -VlanId 200

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$hyperflex_ext_iscsi_storage_policy1 = New-IntersightHyperflexExtIscsiStoragePolicy -ExtaTraffic $exta_traffic1 -ExtbTraffic $extb_traffic1 -Organization $organization1 -Description 'hyperflex ext iscsi storage policy' -Name 'hyperflex_ext_iscsi_storage_policy1' -AdminState 1