#Get the ApplianceBackup by Name
$ApplianceBackupByName = Get-IntersightApplianceBackup -Name ApplianceBackupName

#Get the List of ServerProfiles
$ApplianceBackupList = Get-IntersightApplianceBackup

#Get the list of ApplianceBackup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceBackupByOrg = Get-IntersightApplianceBackup -Organization $org

#Get the ApplianceBackup based on query Parameter
$ApplianceBackupByQueryParam = Get-IntersightApplianceBackup -Filter Name eq ApplianceBackupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .