
#Get the FabricLinkAggregationPolicy to Update
$FabricLinkAggregationPolicy = Get-IntersightFabricLinkAggregationPolicy -Name FabricLinkAggregationPolicyName
$FabricLinkAggregationPolicy | Set-IntersightFabricLinkAggregationPolicy -Description 'Updated description'
