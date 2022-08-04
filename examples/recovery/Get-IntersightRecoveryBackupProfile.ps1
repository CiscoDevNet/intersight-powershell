#Get the RecoveryBackupProfile by Name
$RecoveryBackupProfileByName = Get-IntersightRecoveryBackupProfile -Name RecoveryBackupProfileName

#Get the List of ServerProfiles
$RecoveryBackupProfileList = Get-IntersightRecoveryBackupProfile

#Get the list of RecoveryBackupProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$RecoveryBackupProfileByOrg = Get-IntersightRecoveryBackupProfile -Organization $org

#Get the RecoveryBackupProfile based on query Parameter
$RecoveryBackupProfileByQueryParam = Get-IntersightRecoveryBackupProfile -Filter Name eq RecoveryBackupProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .