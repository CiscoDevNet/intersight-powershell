#Get the IamPrivilege by Name
$IamPrivilegeByName = Get-IntersightIamPrivilege -Name IamPrivilegeName

#Get the List of ServerProfiles
$IamPrivilegeList = Get-IntersightIamPrivilege

#Get the list of IamPrivilege under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamPrivilegeByOrg = Get-IntersightIamPrivilege -Organization $org

#Get the IamPrivilege based on query Parameter
$IamPrivilegeByQueryParam = Get-IntersightIamPrivilege -Filter Name eq IamPrivilegeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .