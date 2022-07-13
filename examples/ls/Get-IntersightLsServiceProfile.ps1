#Get the LsServiceProfile by Name
$LsServiceProfileByName = Get-IntersightLsServiceProfile -Name LsServiceProfileName

#Get the List of ServerProfiles
$LsServiceProfileList = Get-IntersightLsServiceProfile

#Get the list of LsServiceProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$LsServiceProfileByOrg = Get-IntersightLsServiceProfile -Organization $org

#Get the LsServiceProfile based on query Parameter
$LsServiceProfileByQueryParam = Get-IntersightLsServiceProfile -Filter Name eq LsServiceProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .