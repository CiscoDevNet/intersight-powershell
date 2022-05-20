$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$backup_profiles1 = Get-IntersightRecoveryBackupprofile -Moid '<Replace with Moid>'

$schedule1 = Initialize-IntersightRecoveryBackupschedule -FrequencyUnit 'Daily' -Hours '8'

$recovery_schedule_config_policy1 = New-IntersightRecoveryScheduleConfigPolicy -Organization $organization1 -BackupProfiles $backup_profiles1 -Schedule $schedule1 -Name 'recovery_schedule_config_policy1' -Description 'recovery_schedule_config_policy'