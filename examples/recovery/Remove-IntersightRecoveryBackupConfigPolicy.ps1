
#Get the RecoveryBackupConfigPolicy to delete
$RecoveryBackupConfigPolicy = Remove-IntersightRecoveryBackupConfigPolicy -Name RecoveryBackupConfigPolicyName
$RecoveryBackupConfigPolicy | Remove-IntersightRecoveryBackupConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightRecoveryBackupConfigPolicy -Moid 123bc2222287wee
