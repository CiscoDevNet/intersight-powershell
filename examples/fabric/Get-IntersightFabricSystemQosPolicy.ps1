#Get the FabricSystemQosPolicy by Name
$FabricSystemQosPolicyByName = Get-IntersightFabricSystemQosPolicy -Name FabricSystemQosPolicyName

#Get the List of ServerProfiles
$FabricSystemQosPolicyList = Get-IntersightFabricSystemQosPolicy

#Get the list of FabricSystemQosPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricSystemQosPolicyByOrg = Get-IntersightFabricSystemQosPolicy -Organization $org

#Get the FabricSystemQosPolicy based on query Parameter
$FabricSystemQosPolicyByQueryParam = Get-IntersightFabricSystemQosPolicy -Filter Name eq FabricSystemQosPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .