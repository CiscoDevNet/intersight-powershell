#Get the VnicFcNetworkPolicy by Name
$VnicFcNetworkPolicyByName = Get-IntersightVnicFcNetworkPolicy -Name VnicFcNetworkPolicyName

#Get the List of ServerProfiles
$VnicFcNetworkPolicyList = Get-IntersightVnicFcNetworkPolicy

#Get the list of VnicFcNetworkPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VnicFcNetworkPolicyByOrg = Get-IntersightVnicFcNetworkPolicy -Organization $org

#Get the VnicFcNetworkPolicy based on query Parameter
$VnicFcNetworkPolicyByQueryParam = Get-IntersightVnicFcNetworkPolicy -Filter Name eq VnicFcNetworkPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .