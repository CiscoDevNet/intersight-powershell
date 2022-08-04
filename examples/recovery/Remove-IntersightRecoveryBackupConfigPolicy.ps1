
#Get the RecoveryBackupConfigPolicy to delete
$RecoveryBackupConfigPolicy = Get-IntersightRecoveryBackupConfigPolicy -Name RecoveryBackupConfigPolicyName
$RecoveryBackupConfigPolicy | Remove-IntersightRecoveryBackupConfigPolicy

#Remove the RecoveryBackupConfigPolicy by Moid.
Remove-IntersightRecoveryBackupConfigPolicy -Moid '<Replace with Moid>'
