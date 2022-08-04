$iqn_suffix_blocks1 = Initialize-IntersightIqnpoolIqnSuffixBlock -Suffix 'alphadc-1'

$iqnpool_pool1 = New-IntersightIqnpoolPool -IqnSuffixBlocks $iqn_suffix_blocks1 -Name 'ippool_pool1' -Description 'ippool pool' -AssignmentOrder 'sequential' -Prefix 'iqn1.alpha.com'