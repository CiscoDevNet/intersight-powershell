#Get the IamEndPointRole by Name
$IamEndPointRoleByName = Get-IntersightIamEndPointRole -Name IamEndPointRoleName

#Get the List of ServerProfiles
$IamEndPointRoleList = Get-IntersightIamEndPointRole

#Get the list of IamEndPointRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamEndPointRoleByOrg = Get-IntersightIamEndPointRole -Organization $org

#Get the IamEndPointRole based on query Parameter
$IamEndPointRoleByQueryParam = Get-IntersightIamEndPointRole -Filter Name eq IamEndPointRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .