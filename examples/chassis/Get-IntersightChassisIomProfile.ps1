#Get the ChassisIomProfile by Name
$ChassisIomProfileByName = Get-IntersightChassisIomProfile -Name ChassisIomProfileName

#Get the List of ServerProfiles
$ChassisIomProfileList = Get-IntersightChassisIomProfile

#Get the list of ChassisIomProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ChassisIomProfileByOrg = Get-IntersightChassisIomProfile -Organization $org

#Get the ChassisIomProfile based on query Parameter
$ChassisIomProfileByQueryParam = Get-IntersightChassisIomProfile -Filter Name eq ChassisIomProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .