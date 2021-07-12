#Get the FirmwareChassisUpgrade by Name
$FirmwareChassisUpgradeByName = Get-IntersightFirmwareChassisUpgrade -Name FirmwareChassisUpgradeName

#Get the List of ServerProfiles
$FirmwareChassisUpgradeList = Get-IntersightFirmwareChassisUpgrade

#Get the list of FirmwareChassisUpgrade under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareChassisUpgradeByOrg = Get-IntersightFirmwareChassisUpgrade -Organization $org

#Get the FirmwareChassisUpgrade based on query Parameter
$FirmwareChassisUpgradeByQueryParam = Get-IntersightFirmwareChassisUpgrade -Filter Name eq FirmwareChassisUpgradeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .