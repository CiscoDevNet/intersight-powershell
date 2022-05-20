
#Get the RecoveryScheduleConfigPolicy to delete
$RecoveryScheduleConfigPolicy = Get-IntersightRecoveryScheduleConfigPolicy -Name RecoveryScheduleConfigPolicyName
$RecoveryScheduleConfigPolicy | Remove-IntersightRecoveryScheduleConfigPolicy

#Remove the RecoveryScheduleConfigPolicy by Moid.
Remove-IntersightRecoveryScheduleConfigPolicy -Moid '<Replace with Moid>'
