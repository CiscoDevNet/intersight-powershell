#Get the RecoveryOnDemandBackup by Name
$RecoveryOnDemandBackupByName = Get-IntersightRecoveryOnDemandBackup -Name RecoveryOnDemandBackupName

#Get the List of ServerProfiles
$RecoveryOnDemandBackupList = Get-IntersightRecoveryOnDemandBackup

#Get the list of RecoveryOnDemandBackup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecoveryOnDemandBackupByOrg = Get-IntersightRecoveryOnDemandBackup -Organization $org

#Get the RecoveryOnDemandBackup based on query Parameter
$RecoveryOnDemandBackupByQueryParam = Get-IntersightRecoveryOnDemandBackup -Filter Name eq RecoveryOnDemandBackupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .