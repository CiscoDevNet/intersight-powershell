
#Get the FabricSwitchProfile to Update
$FabricSwitchProfile = Get-IntersightFabricSwitchProfile -Name FabricSwitchProfileName
$FabricSwitchProfile | Set-IntersightFabricSwitchProfile -Description 'Updated description'
