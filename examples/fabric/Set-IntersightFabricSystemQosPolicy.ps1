
#Get the FabricSystemQosPolicy to Update
$FabricSystemQosPolicy = Get-IntersightFabricSystemQosPolicy -Name FabricSystemQosPolicyName
$FabricSystemQosPolicy | Set-IntersightFabricSystemQosPolicy -Description 'Updated description'
