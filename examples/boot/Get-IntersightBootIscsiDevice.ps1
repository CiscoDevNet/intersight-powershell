#Get the BootIscsiDevice by Name
$BootIscsiDeviceByName = Get-IntersightBootIscsiDevice -Name BootIscsiDeviceName

#Get the List of ServerProfiles
$BootIscsiDeviceList = Get-IntersightBootIscsiDevice

#Get the list of BootIscsiDevice under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BootIscsiDeviceByOrg = Get-IntersightBootIscsiDevice -Organization $org

#Get the BootIscsiDevice based on query Parameter
$BootIscsiDeviceByQueryParam = Get-IntersightBootIscsiDevice -Filter Name eq BootIscsiDeviceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .