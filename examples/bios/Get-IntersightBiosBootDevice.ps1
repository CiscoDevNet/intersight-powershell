#Get the BiosBootDevice by Name
$BiosBootDeviceByName = Get-IntersightBiosBootDevice -Name BiosBootDeviceName

#Get the List of ServerProfiles
$BiosBootDeviceList = Get-IntersightBiosBootDevice

#Get the list of BiosBootDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BiosBootDeviceByOrg = Get-IntersightBiosBootDevice -Organization $org

#Get the BiosBootDevice based on query Parameter
$BiosBootDeviceByQueryParam = Get-IntersightBiosBootDevice -Filter Name eq BiosBootDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .