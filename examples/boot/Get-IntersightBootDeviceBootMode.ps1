#Get the BootDeviceBootMode by Name
$BootDeviceBootModeByName = Get-IntersightBootDeviceBootMode -Name BootDeviceBootModeName

#Get the List of ServerProfiles
$BootDeviceBootModeList = Get-IntersightBootDeviceBootMode

#Get the list of BootDeviceBootMode under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BootDeviceBootModeByOrg = Get-IntersightBootDeviceBootMode -Organization $org

#Get the BootDeviceBootMode based on query Parameter
$BootDeviceBootModeByQueryParam = Get-IntersightBootDeviceBootMode -Filter Name eq BootDeviceBootModeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .