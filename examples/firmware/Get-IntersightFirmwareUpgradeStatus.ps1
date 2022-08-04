#Get the FirmwareUpgradeStatus by Name
$FirmwareUpgradeStatusByName = Get-IntersightFirmwareUpgradeStatus -Name FirmwareUpgradeStatusName

#Get the List of ServerProfiles
$FirmwareUpgradeStatusList = Get-IntersightFirmwareUpgradeStatus

#Get the list of FirmwareUpgradeStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareUpgradeStatusByOrg = Get-IntersightFirmwareUpgradeStatus -Organization $org

#Get the FirmwareUpgradeStatus based on query Parameter
$FirmwareUpgradeStatusByQueryParam = Get-IntersightFirmwareUpgradeStatus -Filter Name eq FirmwareUpgradeStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .