
#Get the FabricPortPolicy to Update
$FabricPortPolicy = Get-IntersightFabricPortPolicy -Name FabricPortPolicyName
$FabricPortPolicy | Set-IntersightFabricPortPolicy -Description 'Updated description'
