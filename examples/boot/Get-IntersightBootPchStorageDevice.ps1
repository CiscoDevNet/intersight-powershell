#Get the BootPchStorageDevice by Name
$BootPchStorageDeviceByName = Get-IntersightBootPchStorageDevice -Name BootPchStorageDeviceName

#Get the List of ServerProfiles
$BootPchStorageDeviceList = Get-IntersightBootPchStorageDevice

#Get the list of BootPchStorageDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BootPchStorageDeviceByOrg = Get-IntersightBootPchStorageDevice -Organization $org

#Get the BootPchStorageDevice based on query Parameter
$BootPchStorageDeviceByQueryParam = Get-IntersightBootPchStorageDevice -Filter Name eq BootPchStorageDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .