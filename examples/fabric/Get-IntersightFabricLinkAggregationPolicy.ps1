#Get the FabricLinkAggregationPolicy by Name
$FabricLinkAggregationPolicyByName = Get-IntersightFabricLinkAggregationPolicy -Name FabricLinkAggregationPolicyName

#Get the List of ServerProfiles
$FabricLinkAggregationPolicyList = Get-IntersightFabricLinkAggregationPolicy

#Get the list of FabricLinkAggregationPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricLinkAggregationPolicyByOrg = Get-IntersightFabricLinkAggregationPolicy -Organization $org

#Get the FabricLinkAggregationPolicy based on query Parameter
$FabricLinkAggregationPolicyByQueryParam = Get-IntersightFabricLinkAggregationPolicy -Filter Name eq FabricLinkAggregationPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .