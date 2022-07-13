#Get the IamEndPointUserRole by Name
$IamEndPointUserRoleByName = Get-IntersightIamEndPointUserRole -Name IamEndPointUserRoleName

#Get the List of ServerProfiles
$IamEndPointUserRoleList = Get-IntersightIamEndPointUserRole

#Get the list of IamEndPointUserRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamEndPointUserRoleByOrg = Get-IntersightIamEndPointUserRole -Organization $org

#Get the IamEndPointUserRole based on query Parameter
$IamEndPointUserRoleByQueryParam = Get-IntersightIamEndPointUserRole -Filter Name eq IamEndPointUserRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .