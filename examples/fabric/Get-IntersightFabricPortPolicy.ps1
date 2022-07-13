#Get the FabricPortPolicy by Name
$FabricPortPolicyByName = Get-IntersightFabricPortPolicy -Name FabricPortPolicyName

#Get the List of ServerProfiles
$FabricPortPolicyList = Get-IntersightFabricPortPolicy

#Get the list of FabricPortPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricPortPolicyByOrg = Get-IntersightFabricPortPolicy -Organization $org

#Get the FabricPortPolicy based on query Parameter
$FabricPortPolicyByQueryParam = Get-IntersightFabricPortPolicy -Filter Name eq FabricPortPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .