#Get the IamResourcePermission by Name
$IamResourcePermissionByName = Get-IntersightIamResourcePermission -Name IamResourcePermissionName

#Get the List of ServerProfiles
$IamResourcePermissionList = Get-IntersightIamResourcePermission

#Get the list of IamResourcePermission under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamResourcePermissionByOrg = Get-IntersightIamResourcePermission -Organization $org

#Get the IamResourcePermission based on query Parameter
$IamResourcePermissionByQueryParam = Get-IntersightIamResourcePermission -Filter Name eq IamResourcePermissionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .