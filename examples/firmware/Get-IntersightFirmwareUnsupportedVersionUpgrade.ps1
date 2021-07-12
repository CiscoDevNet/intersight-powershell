#Get the FirmwareUnsupportedVersionUpgrade by Name
$FirmwareUnsupportedVersionUpgradeByName = Get-IntersightFirmwareUnsupportedVersionUpgrade -Name FirmwareUnsupportedVersionUpgradeName

#Get the List of ServerProfiles
$FirmwareUnsupportedVersionUpgradeList = Get-IntersightFirmwareUnsupportedVersionUpgrade

#Get the list of FirmwareUnsupportedVersionUpgrade under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareUnsupportedVersionUpgradeByOrg = Get-IntersightFirmwareUnsupportedVersionUpgrade -Organization $org

#Get the FirmwareUnsupportedVersionUpgrade based on query Parameter
$FirmwareUnsupportedVersionUpgradeByQueryParam = Get-IntersightFirmwareUnsupportedVersionUpgrade -Filter Name eq FirmwareUnsupportedVersionUpgradeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .