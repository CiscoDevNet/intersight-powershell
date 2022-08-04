
#Get the RecoveryBackupConfigPolicy to delete
$RecoveryBackupConfigPolicy = Get-IntersightRecoveryBackupConfigPolicy -Name RecoveryBackupConfigPolicyName
$RecoveryBackupConfigPolicy | Set-IntersightRecoveryBackupConfigPolicy -Description 'Updated description'