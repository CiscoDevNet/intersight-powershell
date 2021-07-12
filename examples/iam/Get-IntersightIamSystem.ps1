#Get the IamSystem by Name
$IamSystemByName = Get-IntersightIamSystem -Name IamSystemName

#Get the List of ServerProfiles
$IamSystemList = Get-IntersightIamSystem

#Get the list of IamSystem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamSystemByOrg = Get-IntersightIamSystem -Organization $org

#Get the IamSystem based on query Parameter
$IamSystemByQueryParam = Get-IntersightIamSystem -Filter Name eq IamSystemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .