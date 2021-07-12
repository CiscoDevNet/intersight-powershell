
#Get the RecoveryScheduleConfigPolicy to delete
$RecoveryScheduleConfigPolicy = Remove-IntersightRecoveryScheduleConfigPolicy -Name RecoveryScheduleConfigPolicyName
$RecoveryScheduleConfigPolicy | Remove-IntersightRecoveryScheduleConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightRecoveryScheduleConfigPolicy -Moid 123bc2222287wee
