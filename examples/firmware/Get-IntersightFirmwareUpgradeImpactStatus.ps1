#Get the FirmwareUpgradeImpactStatus by Name
$FirmwareUpgradeImpactStatusByName = Get-IntersightFirmwareUpgradeImpactStatus -Name FirmwareUpgradeImpactStatusName

#Get the List of ServerProfiles
$FirmwareUpgradeImpactStatusList = Get-IntersightFirmwareUpgradeImpactStatus

#Get the list of FirmwareUpgradeImpactStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareUpgradeImpactStatusByOrg = Get-IntersightFirmwareUpgradeImpactStatus -Organization $org

#Get the FirmwareUpgradeImpactStatus based on query Parameter
$FirmwareUpgradeImpactStatusByQueryParam = Get-IntersightFirmwareUpgradeImpactStatus -Filter Name eq FirmwareUpgradeImpactStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .