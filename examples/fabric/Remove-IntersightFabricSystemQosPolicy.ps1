
#Get the FabricSystemQosPolicy to delete
$FabricSystemQosPolicy = Remove-IntersightFabricSystemQosPolicy -Name FabricSystemQosPolicyName
$FabricSystemQosPolicy | Remove-IntersightFabricSystemQosPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricSystemQosPolicy -Moid 123bc2222287wee
