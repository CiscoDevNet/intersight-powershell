
#Get the RecoveryScheduleConfigPolicy to delete
$RecoveryScheduleConfigPolicy = Get-IntersightRecoveryScheduleConfigPolicy -Name RecoveryScheduleConfigPolicyName
$RecoveryScheduleConfigPolicy | Set-IntersightRecoveryScheduleConfigPolicy -Description 'Updated description'
