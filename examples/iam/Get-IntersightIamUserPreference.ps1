#Get the IamUserPreference by Name
$IamUserPreferenceByName = Get-IntersightIamUserPreference -Name IamUserPreferenceName

#Get the List of ServerProfiles
$IamUserPreferenceList = Get-IntersightIamUserPreference

#Get the list of IamUserPreference under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamUserPreferenceByOrg = Get-IntersightIamUserPreference -Organization $org

#Get the IamUserPreference based on query Parameter
$IamUserPreferenceByQueryParam = Get-IntersightIamUserPreference -Filter Name eq IamUserPreferenceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .