#Get the VnicLanConnectivityPolicy by Name
$VnicLanConnectivityPolicyByName = Get-IntersightVnicLanConnectivityPolicy -Name VnicLanConnectivityPolicyName

#Get the List of ServerProfiles
$VnicLanConnectivityPolicyList = Get-IntersightVnicLanConnectivityPolicy

#Get the list of VnicLanConnectivityPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicLanConnectivityPolicyByOrg = Get-IntersightVnicLanConnectivityPolicy -Organization $org

#Get the VnicLanConnectivityPolicy based on query Parameter
$VnicLanConnectivityPolicyByQueryParam = Get-IntersightVnicLanConnectivityPolicy -Filter Name eq VnicLanConnectivityPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .