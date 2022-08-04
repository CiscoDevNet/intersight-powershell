#Get the IamRole by Name
$IamRoleByName = Get-IntersightIamRole -Name IamRoleName

#Get the List of ServerProfiles
$IamRoleList = Get-IntersightIamRole

#Get the list of IamRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamRoleByOrg = Get-IntersightIamRole -Organization $org

#Get the IamRole based on query Parameter
$IamRoleByQueryParam = Get-IntersightIamRole -Filter Name eq IamRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .