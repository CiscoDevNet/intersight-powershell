
#Get the FabricMulticastPolicy to Update
$FabricMulticastPolicy = Get-IntersightFabricMulticastPolicy -Name FabricMulticastPolicyName
$FabricMulticastPolicy | Set-IntersightFabricMulticastPolicy -Description 'Updated description'
