#Get the IamServiceProvider by Name
$IamServiceProviderByName = Get-IntersightIamServiceProvider -Name IamServiceProviderName

#Get the List of ServerProfiles
$IamServiceProviderList = Get-IntersightIamServiceProvider

#Get the list of IamServiceProvider under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamServiceProviderByOrg = Get-IntersightIamServiceProvider -Organization $org

#Get the IamServiceProvider based on query Parameter
$IamServiceProviderByQueryParam = Get-IntersightIamServiceProvider -Filter Name eq IamServiceProviderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .