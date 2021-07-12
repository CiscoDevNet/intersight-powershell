#Get the FirmwareUpgrade by Name
$FirmwareUpgradeByName = Get-IntersightFirmwareUpgrade -Name FirmwareUpgradeName

#Get the List of ServerProfiles
$FirmwareUpgradeList = Get-IntersightFirmwareUpgrade

#Get the list of FirmwareUpgrade under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareUpgradeByOrg = Get-IntersightFirmwareUpgrade -Organization $org

#Get the FirmwareUpgrade based on query Parameter
$FirmwareUpgradeByQueryParam = Get-IntersightFirmwareUpgrade -Filter Name eq FirmwareUpgradeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .