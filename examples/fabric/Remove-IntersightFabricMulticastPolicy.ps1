
#Get the FabricMulticastPolicy to delete
$FabricMulticastPolicy = Get-IntersightFabricMulticastPolicy -Name FabricMulticastPolicyName
$FabricMulticastPolicy | Remove-IntersightFabricMulticastPolicy

#Remove the FabricMulticastPolicy by Moid.
Remove-IntersightFabricMulticastPolicy -Moid '<Replace with Moid>'
