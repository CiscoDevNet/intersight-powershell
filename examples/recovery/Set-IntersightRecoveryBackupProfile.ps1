
#Get the RecoveryBackupProfile to delete
$RecoveryBackupProfile = Get-IntersightRecoveryBackupProfile -Name RecoveryBackupProfileName
$RecoveryBackupProfile | Set-IntersightRecoveryBackupProfile -Description 'Updated description'