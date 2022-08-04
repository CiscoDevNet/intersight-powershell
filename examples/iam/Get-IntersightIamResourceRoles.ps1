#Get the IamResourceRoles by Name
$IamResourceRolesByName = Get-IntersightIamResourceRoles -Name IamResourceRolesName

#Get the List of ServerProfiles
$IamResourceRolesList = Get-IntersightIamResourceRoles

#Get the list of IamResourceRoles under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamResourceRolesByOrg = Get-IntersightIamResourceRoles -Organization $org

#Get the IamResourceRoles based on query Parameter
$IamResourceRolesByQueryParam = Get-IntersightIamResourceRoles -Filter Name eq IamResourceRolesName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .