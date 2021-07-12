#Get the IamAppRegistration by Name
$IamAppRegistrationByName = Get-IntersightIamAppRegistration -Name IamAppRegistrationName

#Get the List of ServerProfiles
$IamAppRegistrationList = Get-IntersightIamAppRegistration

#Get the list of IamAppRegistration under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamAppRegistrationByOrg = Get-IntersightIamAppRegistration -Organization $org

#Get the IamAppRegistration based on query Parameter
$IamAppRegistrationByQueryParam = Get-IntersightIamAppRegistration -Filter Name eq IamAppRegistrationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .