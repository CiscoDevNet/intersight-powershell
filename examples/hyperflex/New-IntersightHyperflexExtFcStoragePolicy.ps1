$exta_traffic1 = Initialize-IntersightReplicationNamedvsan -Name 'exta_traffic1' -VsanId 100

$extb_traffic1 = Initialize-IntersightReplicationNamedvsan -Name 'extb_traffic1' -VsanId 200

$wwxn_prefix_range1 = Initialize-IntersightHyperflexWwxnprefixrange -EndAddr '20:00:00:25:B5:B5' -StartAddr '20:00:00:25:A5:10'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_ext_fc_storage_policy1 = New-IntersightHyperflexExtFcStoragePolicy -ExtaTraffic $exta_traffic1 -ExtbTraffic $extb_traffic1 -WwxnPrefixRange $wwxn_prefix_range1 -Organization $organization1 -Description 'hyperflex ext fc storage policy' -Name 'hyperflex_ext_fc_storage_policy1' -AdminState 1