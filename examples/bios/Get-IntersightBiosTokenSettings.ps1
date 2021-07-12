#Get the BiosTokenSettings by Name
$BiosTokenSettingsByName = Get-IntersightBiosTokenSettings -Name BiosTokenSettingsName

#Get the List of ServerProfiles
$BiosTokenSettingsList = Get-IntersightBiosTokenSettings

#Get the list of BiosTokenSettings under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BiosTokenSettingsByOrg = Get-IntersightBiosTokenSettings -Organization $org

#Get the BiosTokenSettings based on query Parameter
$BiosTokenSettingsByQueryParam = Get-IntersightBiosTokenSettings -Filter Name eq BiosTokenSettingsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .