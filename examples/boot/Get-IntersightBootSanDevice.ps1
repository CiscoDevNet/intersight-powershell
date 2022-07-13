#Get the BootSanDevice by Name
$BootSanDeviceByName = Get-IntersightBootSanDevice -Name BootSanDeviceName

#Get the List of ServerProfiles
$BootSanDeviceList = Get-IntersightBootSanDevice

#Get the list of BootSanDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BootSanDeviceByOrg = Get-IntersightBootSanDevice -Organization $org

#Get the BootSanDevice based on query Parameter
$BootSanDeviceByQueryParam = Get-IntersightBootSanDevice -Filter Name eq BootSanDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .