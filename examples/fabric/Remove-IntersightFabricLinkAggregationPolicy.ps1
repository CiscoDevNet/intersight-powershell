
#Get the FabricLinkAggregationPolicy to delete
$FabricLinkAggregationPolicy = Get-IntersightFabricLinkAggregationPolicy -Name FabricLinkAggregationPolicyName
$FabricLinkAggregationPolicy | Remove-IntersightFabricLinkAggregationPolicy

#Remove the FabricLinkAggregationPolicy by Moid.
Remove-IntersightFabricLinkAggregationPolicy -Moid '<Replace with Moid>'
