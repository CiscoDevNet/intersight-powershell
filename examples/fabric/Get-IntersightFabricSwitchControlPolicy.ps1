#Get the FabricSwitchControlPolicy by Name
$FabricSwitchControlPolicyByName = Get-IntersightFabricSwitchControlPolicy -Name FabricSwitchControlPolicyName

#Get the List of ServerProfiles
$FabricSwitchControlPolicyList = Get-IntersightFabricSwitchControlPolicy

#Get the list of FabricSwitchControlPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricSwitchControlPolicyByOrg = Get-IntersightFabricSwitchControlPolicy -Organization $org

#Get the FabricSwitchControlPolicy based on query Parameter
$FabricSwitchControlPolicyByQueryParam = Get-IntersightFabricSwitchControlPolicy -Filter Name eq FabricSwitchControlPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .