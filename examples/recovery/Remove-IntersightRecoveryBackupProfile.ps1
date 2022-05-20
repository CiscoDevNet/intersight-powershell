
#Get the RecoveryBackupProfile to delete
$RecoveryBackupProfile = Get-IntersightRecoveryBackupProfile -Name RecoveryBackupProfileName
$RecoveryBackupProfile | Remove-IntersightRecoveryBackupProfile

#Remove the RecoveryBackupProfile by Moid.
Remove-IntersightRecoveryBackupProfile -Moid '<Replace with Moid>'
