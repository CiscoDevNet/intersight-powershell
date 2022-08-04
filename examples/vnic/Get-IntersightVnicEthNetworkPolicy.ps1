#Get the VnicEthNetworkPolicy by Name
$VnicEthNetworkPolicyByName = Get-IntersightVnicEthNetworkPolicy -Name VnicEthNetworkPolicyName

#Get the List of ServerProfiles
$VnicEthNetworkPolicyList = Get-IntersightVnicEthNetworkPolicy

#Get the list of VnicEthNetworkPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicEthNetworkPolicyByOrg = Get-IntersightVnicEthNetworkPolicy -Organization $org

#Get the VnicEthNetworkPolicy based on query Parameter
$VnicEthNetworkPolicyByQueryParam = Get-IntersightVnicEthNetworkPolicy -Filter Name eq VnicEthNetworkPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .