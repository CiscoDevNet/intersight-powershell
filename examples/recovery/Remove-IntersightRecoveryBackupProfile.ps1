
#Get the RecoveryBackupProfile to delete
$RecoveryBackupProfile = Remove-IntersightRecoveryBackupProfile -Name RecoveryBackupProfileName
$RecoveryBackupProfile | Remove-IntersightRecoveryBackupProfile

#Remove the server profile by Moid.
Remove-IntersightRecoveryBackupProfile -Moid 123bc2222287wee
