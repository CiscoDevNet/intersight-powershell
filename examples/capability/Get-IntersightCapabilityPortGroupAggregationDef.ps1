#Get the CapabilityPortGroupAggregationDef by Name
$CapabilityPortGroupAggregationDefByName = Get-IntersightCapabilityPortGroupAggregationDef -Name CapabilityPortGroupAggregationDefName

#Get the List of ServerProfiles
$CapabilityPortGroupAggregationDefList = Get-IntersightCapabilityPortGroupAggregationDef

#Get the list of CapabilityPortGroupAggregationDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityPortGroupAggregationDefByOrg = Get-IntersightCapabilityPortGroupAggregationDef -Organization $org

#Get the CapabilityPortGroupAggregationDef based on query Parameter
$CapabilityPortGroupAggregationDefByQueryParam = Get-IntersightCapabilityPortGroupAggregationDef -Filter Name eq CapabilityPortGroupAggregationDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .