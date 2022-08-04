
#Get the RecoveryOnDemandBackup to delete
$RecoveryOnDemandBackup = Get-IntersightRecoveryOnDemandBackup -Name RecoveryOnDemandBackupName
$RecoveryOnDemandBackup | Set-IntersightRecoveryOnDemandBackup -Description 'Updated description'
