#Get the RecoveryBackupConfigPolicy by Name
$RecoveryBackupConfigPolicyByName = Get-IntersightRecoveryBackupConfigPolicy -Name RecoveryBackupConfigPolicyName

#Get the List of ServerProfiles
$RecoveryBackupConfigPolicyList = Get-IntersightRecoveryBackupConfigPolicy

#Get the list of RecoveryBackupConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecoveryBackupConfigPolicyByOrg = Get-IntersightRecoveryBackupConfigPolicy -Organization $org

#Get the RecoveryBackupConfigPolicy based on query Parameter
$RecoveryBackupConfigPolicyByQueryParam = Get-IntersightRecoveryBackupConfigPolicy -Filter Name eq RecoveryBackupConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .