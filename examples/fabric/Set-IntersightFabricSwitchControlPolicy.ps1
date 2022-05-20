
#Get the FabricSwitchControlPolicy to Update
$FabricSwitchControlPolicy = Get-IntersightFabricSwitchControlPolicy -Name FabricSwitchControlPolicyName
$FabricSwitchControlPolicy | Set-IntersightFabricSwitchControlPolicy -Description 'Updated description'
