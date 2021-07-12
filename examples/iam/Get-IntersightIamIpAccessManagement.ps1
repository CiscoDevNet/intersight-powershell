#Get the IamIpAccessManagement by Name
$IamIpAccessManagementByName = Get-IntersightIamIpAccessManagement -Name IamIpAccessManagementName

#Get the List of ServerProfiles
$IamIpAccessManagementList = Get-IntersightIamIpAccessManagement

#Get the list of IamIpAccessManagement under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamIpAccessManagementByOrg = Get-IntersightIamIpAccessManagement -Organization $org

#Get the IamIpAccessManagement based on query Parameter
$IamIpAccessManagementByQueryParam = Get-IntersightIamIpAccessManagement -Filter Name eq IamIpAccessManagementName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .