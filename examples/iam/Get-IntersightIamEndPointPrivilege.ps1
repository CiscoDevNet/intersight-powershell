#Get the IamEndPointPrivilege by Name
$IamEndPointPrivilegeByName = Get-IntersightIamEndPointPrivilege -Name IamEndPointPrivilegeName

#Get the List of ServerProfiles
$IamEndPointPrivilegeList = Get-IntersightIamEndPointPrivilege

#Get the list of IamEndPointPrivilege under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamEndPointPrivilegeByOrg = Get-IntersightIamEndPointPrivilege -Organization $org

#Get the IamEndPointPrivilege based on query Parameter
$IamEndPointPrivilegeByQueryParam = Get-IntersightIamEndPointPrivilege -Filter Name eq IamEndPointPrivilegeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .