
#Get the FabricSystemQosPolicy to delete
$FabricSystemQosPolicy = Get-IntersightFabricSystemQosPolicy -Name FabricSystemQosPolicyName
$FabricSystemQosPolicy | Remove-IntersightFabricSystemQosPolicy

#Remove the FabricSystemQosPolicy by Moid.
Remove-IntersightFabricSystemQosPolicy -Moid '<Replace with Moid>'
