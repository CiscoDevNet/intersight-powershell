$uuid_suffix_blocks1 = Initialize-IntersightUuidpoolUuidblock -ClassId 'UuidpoolUuidBlock' -From '123e-4567e89b42d3' -Size 10

$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$uuidpool_pool1 = New-IntersightUuidpoolPool -UuidSuffixBlocks $uuid_suffix_blocks1 -Organization $organization -Name 'uuidpool_pool1' -Description 'uuidpool_pool' -AssignmentOrder 'default' -Prefix '123e4567-e89b-42d3'