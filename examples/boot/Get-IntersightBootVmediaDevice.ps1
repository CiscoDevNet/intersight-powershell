#Get the BootVmediaDevice by Name
$BootVmediaDeviceByName = Get-IntersightBootVmediaDevice -Name BootVmediaDeviceName

#Get the List of ServerProfiles
$BootVmediaDeviceList = Get-IntersightBootVmediaDevice

#Get the list of BootVmediaDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BootVmediaDeviceByOrg = Get-IntersightBootVmediaDevice -Organization $org

#Get the BootVmediaDevice based on query Parameter
$BootVmediaDeviceByQueryParam = Get-IntersightBootVmediaDevice -Filter Name eq BootVmediaDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .