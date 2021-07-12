#Get the ApplianceBackupPolicy by Name
$ApplianceBackupPolicyByName = Get-IntersightApplianceBackupPolicy -Name ApplianceBackupPolicyName

#Get the List of ServerProfiles
$ApplianceBackupPolicyList = Get-IntersightApplianceBackupPolicy

#Get the list of ApplianceBackupPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceBackupPolicyByOrg = Get-IntersightApplianceBackupPolicy -Organization $org

#Get the ApplianceBackupPolicy based on query Parameter
$ApplianceBackupPolicyByQueryParam = Get-IntersightApplianceBackupPolicy -Filter Name eq ApplianceBackupPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .