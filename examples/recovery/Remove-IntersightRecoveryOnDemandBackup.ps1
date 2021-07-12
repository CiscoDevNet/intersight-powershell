
#Get the RecoveryOnDemandBackup to delete
$RecoveryOnDemandBackup = Remove-IntersightRecoveryOnDemandBackup -Name RecoveryOnDemandBackupName
$RecoveryOnDemandBackup | Remove-IntersightRecoveryOnDemandBackup

#Remove the server profile by Moid.
Remove-IntersightRecoveryOnDemandBackup -Moid 123bc2222287wee
