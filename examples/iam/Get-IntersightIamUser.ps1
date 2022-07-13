#Get the IamUser by Name
$IamUserByName = Get-IntersightIamUser -Name IamUserName

#Get the List of ServerProfiles
$IamUserList = Get-IntersightIamUser

#Get the list of IamUser under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamUserByOrg = Get-IntersightIamUser -Organization $org

#Get the IamUser based on query Parameter
$IamUserByQueryParam = Get-IntersightIamUser -Filter Name eq IamUserName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .