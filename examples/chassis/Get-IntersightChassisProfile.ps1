#Get the ChassisProfile by Name
$ChassisProfileByName = Get-IntersightChassisProfile -Name ChassisProfileName

#Get the List of ServerProfiles
$ChassisProfileList = Get-IntersightChassisProfile

#Get the list of ChassisProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ChassisProfileByOrg = Get-IntersightChassisProfile -Organization $org

#Get the ChassisProfile based on query Parameter
$ChassisProfileByQueryParam = Get-IntersightChassisProfile -Filter Name eq ChassisProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .