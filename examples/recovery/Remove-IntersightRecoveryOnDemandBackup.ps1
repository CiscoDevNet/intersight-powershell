
#Get the RecoveryOnDemandBackup to delete
$RecoveryOnDemandBackup = Get-IntersightRecoveryOnDemandBackup -Name RecoveryOnDemandBackupName
$RecoveryOnDemandBackup | Remove-IntersightRecoveryOnDemandBackup

#Remove the RecoveryOnDemandBackup by Moid.
Remove-IntersightRecoveryOnDemandBackup -Moid '<Replace with Moid>'
