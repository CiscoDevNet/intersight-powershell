
#Get the FabricServerRole to Update
$FabricServerRole = Get-IntersightFabricServerRole -Name FabricServerRoleName
$FabricServerRole | Set-IntersightFabricServerRole -Description 'Updated description'
