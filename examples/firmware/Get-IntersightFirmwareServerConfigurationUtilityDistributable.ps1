#Get the FirmwareServerConfigurationUtilityDistributable by Name
$FirmwareServerConfigurationUtilityDistributableByName = Get-IntersightFirmwareServerConfigurationUtilityDistributable -Name FirmwareServerConfigurationUtilityDistributableName

#Get the List of ServerProfiles
$FirmwareServerConfigurationUtilityDistributableList = Get-IntersightFirmwareServerConfigurationUtilityDistributable

#Get the list of FirmwareServerConfigurationUtilityDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareServerConfigurationUtilityDistributableByOrg = Get-IntersightFirmwareServerConfigurationUtilityDistributable -Organization $org

#Get the FirmwareServerConfigurationUtilityDistributable based on query Parameter
$FirmwareServerConfigurationUtilityDistributableByQueryParam = Get-IntersightFirmwareServerConfigurationUtilityDistributable -Filter Name eq FirmwareServerConfigurationUtilityDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .