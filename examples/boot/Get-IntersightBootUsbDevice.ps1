#Get the BootUsbDevice by Name
$BootUsbDeviceByName = Get-IntersightBootUsbDevice -Name BootUsbDeviceName

#Get the List of ServerProfiles
$BootUsbDeviceList = Get-IntersightBootUsbDevice

#Get the list of BootUsbDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BootUsbDeviceByOrg = Get-IntersightBootUsbDevice -Organization $org

#Get the BootUsbDevice based on query Parameter
$BootUsbDeviceByQueryParam = Get-IntersightBootUsbDevice -Filter Name eq BootUsbDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .