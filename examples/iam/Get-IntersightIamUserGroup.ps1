#Get the IamUserGroup by Name
$IamUserGroupByName = Get-IntersightIamUserGroup -Name IamUserGroupName

#Get the List of ServerProfiles
$IamUserGroupList = Get-IntersightIamUserGroup

#Get the list of IamUserGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamUserGroupByOrg = Get-IntersightIamUserGroup -Organization $org

#Get the IamUserGroup based on query Parameter
$IamUserGroupByQueryParam = Get-IntersightIamUserGroup -Filter Name eq IamUserGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .