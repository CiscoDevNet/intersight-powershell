
#Get the FabricSwitchClusterProfile to Update
$FabricSwitchClusterProfile = Get-IntersightFabricSwitchClusterProfile -Name FabricSwitchClusterProfileName
$FabricSwitchClusterProfile | Set-IntersightFabricSwitchClusterProfile -Description 'Updated description'
