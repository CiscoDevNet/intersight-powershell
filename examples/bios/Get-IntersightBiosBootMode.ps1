#Get the BiosBootMode by Name
$BiosBootModeByName = Get-IntersightBiosBootMode -Name BiosBootModeName

#Get the List of ServerProfiles
$BiosBootModeList = Get-IntersightBiosBootMode

#Get the list of BiosBootMode under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BiosBootModeByOrg = Get-IntersightBiosBootMode -Organization $org

#Get the BiosBootMode based on query Parameter
$BiosBootModeByQueryParam = Get-IntersightBiosBootMode -Filter Name eq BiosBootModeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .