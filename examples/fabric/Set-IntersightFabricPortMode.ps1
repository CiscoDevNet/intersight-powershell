
#Get the FabricPortMode to Update
$FabricPortMode = Get-IntersightFabricPortMode -Name FabricPortModeName
$FabricPortMode | Set-IntersightFabricPortMode -Description 'Updated description'
