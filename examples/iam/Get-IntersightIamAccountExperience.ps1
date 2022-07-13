#Get the IamAccountExperience by Name
$IamAccountExperienceByName = Get-IntersightIamAccountExperience -Name IamAccountExperienceName

#Get the List of ServerProfiles
$IamAccountExperienceList = Get-IntersightIamAccountExperience

#Get the list of IamAccountExperience under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamAccountExperienceByOrg = Get-IntersightIamAccountExperience -Organization $org

#Get the IamAccountExperience based on query Parameter
$IamAccountExperienceByQueryParam = Get-IntersightIamAccountExperience -Filter Name eq IamAccountExperienceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .