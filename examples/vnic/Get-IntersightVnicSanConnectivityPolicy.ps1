#Get the VnicSanConnectivityPolicy by Name
$VnicSanConnectivityPolicyByName = Get-IntersightVnicSanConnectivityPolicy -Name VnicSanConnectivityPolicyName

#Get the List of ServerProfiles
$VnicSanConnectivityPolicyList = Get-IntersightVnicSanConnectivityPolicy

#Get the list of VnicSanConnectivityPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicSanConnectivityPolicyByOrg = Get-IntersightVnicSanConnectivityPolicy -Organization $org

#Get the VnicSanConnectivityPolicy based on query Parameter
$VnicSanConnectivityPolicyByQueryParam = Get-IntersightVnicSanConnectivityPolicy -Filter Name eq VnicSanConnectivityPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .