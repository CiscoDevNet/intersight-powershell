$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$m2_virtual_drive1 = Initialize-IntersightStorageM2Virtualdriveconfig -Enable 0

$tf_storage_policy = New-IntersightStorageStoragePolicy -Organization $organization -M2VirtualDrive $m2_virtual_drive1 -Name 'tf_storage_policy' -UseJbodForVdCreation 1 -Description 'storage policy test' -UnusedDisksState 'UnconfiguredGood' -GlobalHotSpares '3'