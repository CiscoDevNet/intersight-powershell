#Get the IamEndPointUser by Name
$IamEndPointUserByName = Get-IntersightIamEndPointUser -Name IamEndPointUserName

#Get the List of ServerProfiles
$IamEndPointUserList = Get-IntersightIamEndPointUser

#Get the list of IamEndPointUser under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamEndPointUserByOrg = Get-IntersightIamEndPointUser -Organization $org

#Get the IamEndPointUser based on query Parameter
$IamEndPointUserByQueryParam = Get-IntersightIamEndPointUser -Filter Name eq IamEndPointUserName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .