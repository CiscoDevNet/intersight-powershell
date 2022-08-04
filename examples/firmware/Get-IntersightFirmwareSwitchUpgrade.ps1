#Get the FirmwareSwitchUpgrade by Name
$FirmwareSwitchUpgradeByName = Get-IntersightFirmwareSwitchUpgrade -Name FirmwareSwitchUpgradeName

#Get the List of ServerProfiles
$FirmwareSwitchUpgradeList = Get-IntersightFirmwareSwitchUpgrade

#Get the list of FirmwareSwitchUpgrade under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareSwitchUpgradeByOrg = Get-IntersightFirmwareSwitchUpgrade -Organization $org

#Get the FirmwareSwitchUpgrade based on query Parameter
$FirmwareSwitchUpgradeByQueryParam = Get-IntersightFirmwareSwitchUpgrade -Filter Name eq FirmwareSwitchUpgradeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .