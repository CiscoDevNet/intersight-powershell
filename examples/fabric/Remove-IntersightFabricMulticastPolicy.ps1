
#Get the FabricMulticastPolicy to delete
$FabricMulticastPolicy = Remove-IntersightFabricMulticastPolicy -Name FabricMulticastPolicyName
$FabricMulticastPolicy | Remove-IntersightFabricMulticastPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricMulticastPolicy -Moid 123bc2222287wee
