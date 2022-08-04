#Get the BootCddDevice by Name
$BootCddDeviceByName = Get-IntersightBootCddDevice -Name BootCddDeviceName

#Get the List of ServerProfiles
$BootCddDeviceList = Get-IntersightBootCddDevice

#Get the list of BootCddDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BootCddDeviceByOrg = Get-IntersightBootCddDevice -Organization $org

#Get the BootCddDevice based on query Parameter
$BootCddDeviceByQueryParam = Get-IntersightBootCddDevice -Filter Name eq BootCddDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .