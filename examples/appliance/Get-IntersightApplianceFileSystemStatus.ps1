#Get the ApplianceFileSystemStatus by Name
$ApplianceFileSystemStatusByName = Get-IntersightApplianceFileSystemStatus -Name ApplianceFileSystemStatusName

#Get the List of ServerProfiles
$ApplianceFileSystemStatusList = Get-IntersightApplianceFileSystemStatus

#Get the list of ApplianceFileSystemStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ApplianceFileSystemStatusByOrg = Get-IntersightApplianceFileSystemStatus -Organization $org

#Get the ApplianceFileSystemStatus based on query Parameter
$ApplianceFileSystemStatusByQueryParam = Get-IntersightApplianceFileSystemStatus -Filter Name eq ApplianceFileSystemStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .