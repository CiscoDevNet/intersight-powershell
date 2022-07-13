#Get the BootDeviceBootSecurity by Name
$BootDeviceBootSecurityByName = Get-IntersightBootDeviceBootSecurity -Name BootDeviceBootSecurityName

#Get the List of ServerProfiles
$BootDeviceBootSecurityList = Get-IntersightBootDeviceBootSecurity

#Get the list of BootDeviceBootSecurity under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BootDeviceBootSecurityByOrg = Get-IntersightBootDeviceBootSecurity -Organization $org

#Get the BootDeviceBootSecurity based on query Parameter
$BootDeviceBootSecurityByQueryParam = Get-IntersightBootDeviceBootSecurity -Filter Name eq BootDeviceBootSecurityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .