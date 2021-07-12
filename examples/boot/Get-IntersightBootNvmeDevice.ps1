#Get the BootNvmeDevice by Name
$BootNvmeDeviceByName = Get-IntersightBootNvmeDevice -Name BootNvmeDeviceName

#Get the List of ServerProfiles
$BootNvmeDeviceList = Get-IntersightBootNvmeDevice

#Get the list of BootNvmeDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BootNvmeDeviceByOrg = Get-IntersightBootNvmeDevice -Organization $org

#Get the BootNvmeDevice based on query Parameter
$BootNvmeDeviceByQueryParam = Get-IntersightBootNvmeDevice -Filter Name eq BootNvmeDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .