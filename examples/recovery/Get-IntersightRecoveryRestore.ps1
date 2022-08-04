#Get the RecoveryRestore by Name
$RecoveryRestoreByName = Get-IntersightRecoveryRestore -Name RecoveryRestoreName

#Get the List of ServerProfiles
$RecoveryRestoreList = Get-IntersightRecoveryRestore

#Get the list of RecoveryRestore under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecoveryRestoreByOrg = Get-IntersightRecoveryRestore -Organization $org

#Get the RecoveryRestore based on query Parameter
$RecoveryRestoreByQueryParam = Get-IntersightRecoveryRestore -Filter Name eq RecoveryRestoreName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .