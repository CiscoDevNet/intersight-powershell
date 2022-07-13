$id_blocks1 = Initialize-IntersightFcpoolBlock -From '50:00:00:00:00:00:00:00' -To '50:50:00:00:00:00:00:00' 

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$fcpool_pool1 = New-IntersightFcpoolPool -IdBlocks $id_blocks1 -Organization $organization1 -Name 'fcpool_pool1' -Description 'fcpool pool' -AssignmentOrder 'sequential' -PoolPurpose 'WWPN'