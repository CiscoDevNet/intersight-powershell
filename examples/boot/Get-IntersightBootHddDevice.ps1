#Get the BootHddDevice by Name
$BootHddDeviceByName = Get-IntersightBootHddDevice -Name BootHddDeviceName

#Get the List of ServerProfiles
$BootHddDeviceList = Get-IntersightBootHddDevice

#Get the list of BootHddDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BootHddDeviceByOrg = Get-IntersightBootHddDevice -Organization $org

#Get the BootHddDevice based on query Parameter
$BootHddDeviceByQueryParam = Get-IntersightBootHddDevice -Filter Name eq BootHddDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .