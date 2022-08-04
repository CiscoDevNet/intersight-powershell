#Get the FabricLinkControlPolicy by Name
$FabricLinkControlPolicyByName = Get-IntersightFabricLinkControlPolicy -Name FabricLinkControlPolicyName

#Get the List of ServerProfiles
$FabricLinkControlPolicyList = Get-IntersightFabricLinkControlPolicy

#Get the list of FabricLinkControlPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricLinkControlPolicyByOrg = Get-IntersightFabricLinkControlPolicy -Organization $org

#Get the FabricLinkControlPolicy based on query Parameter
$FabricLinkControlPolicyByQueryParam = Get-IntersightFabricLinkControlPolicy -Filter Name eq FabricLinkControlPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .