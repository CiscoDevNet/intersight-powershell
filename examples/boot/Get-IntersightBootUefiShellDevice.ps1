#Get the BootUefiShellDevice by Name
$BootUefiShellDeviceByName = Get-IntersightBootUefiShellDevice -Name BootUefiShellDeviceName

#Get the List of ServerProfiles
$BootUefiShellDeviceList = Get-IntersightBootUefiShellDevice

#Get the list of BootUefiShellDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BootUefiShellDeviceByOrg = Get-IntersightBootUefiShellDevice -Organization $org

#Get the BootUefiShellDevice based on query Parameter
$BootUefiShellDeviceByQueryParam = Get-IntersightBootUefiShellDevice -Filter Name eq BootUefiShellDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .