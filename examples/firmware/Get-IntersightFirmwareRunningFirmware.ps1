#Get the FirmwareRunningFirmware by Name
$FirmwareRunningFirmwareByName = Get-IntersightFirmwareRunningFirmware -Name FirmwareRunningFirmwareName

#Get the List of ServerProfiles
$FirmwareRunningFirmwareList = Get-IntersightFirmwareRunningFirmware

#Get the list of FirmwareRunningFirmware under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareRunningFirmwareByOrg = Get-IntersightFirmwareRunningFirmware -Organization $org

#Get the FirmwareRunningFirmware based on query Parameter
$FirmwareRunningFirmwareByQueryParam = Get-IntersightFirmwareRunningFirmware -Filter Name eq FirmwareRunningFirmwareName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .