
#Get the FabricLinkAggregationPolicy to delete
$FabricLinkAggregationPolicy = Remove-IntersightFabricLinkAggregationPolicy -Name FabricLinkAggregationPolicyName
$FabricLinkAggregationPolicy | Remove-IntersightFabricLinkAggregationPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricLinkAggregationPolicy -Moid 123bc2222287wee
