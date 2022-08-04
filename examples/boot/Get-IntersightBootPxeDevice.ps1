#Get the BootPxeDevice by Name
$BootPxeDeviceByName = Get-IntersightBootPxeDevice -Name BootPxeDeviceName

#Get the List of ServerProfiles
$BootPxeDeviceList = Get-IntersightBootPxeDevice

#Get the list of BootPxeDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BootPxeDeviceByOrg = Get-IntersightBootPxeDevice -Organization $org

#Get the BootPxeDevice based on query Parameter
$BootPxeDeviceByQueryParam = Get-IntersightBootPxeDevice -Filter Name eq BootPxeDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .