#Get the IamSession by Name
$IamSessionByName = Get-IntersightIamSession -Name IamSessionName

#Get the List of ServerProfiles
$IamSessionList = Get-IntersightIamSession

#Get the list of IamSession under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamSessionByOrg = Get-IntersightIamSession -Organization $org

#Get the IamSession based on query Parameter
$IamSessionByQueryParam = Get-IntersightIamSession -Filter Name eq IamSessionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .