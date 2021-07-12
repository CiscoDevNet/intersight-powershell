#Get the BootSdDevice by Name
$BootSdDeviceByName = Get-IntersightBootSdDevice -Name BootSdDeviceName

#Get the List of ServerProfiles
$BootSdDeviceList = Get-IntersightBootSdDevice

#Get the list of BootSdDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BootSdDeviceByOrg = Get-IntersightBootSdDevice -Organization $org

#Get the BootSdDevice based on query Parameter
$BootSdDeviceByQueryParam = Get-IntersightBootSdDevice -Filter Name eq BootSdDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .