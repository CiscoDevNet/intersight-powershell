$config_context1 = Initialize-IntersightPolicyConfigcontext -ControlAction 'deploy'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$backup_config1 = Get-IntersightRecoveryBackupprofile -Moid '<Replace with Moid>'

$schedule_config1 = Get-IntersightRecoveryScheduleconfigpolicies -Moid '<Replace with Moid>'

$recovery_backup_profile1 = New-IntersightRecoveryBackupProfile -ConfigContext $config_context1 -Organization $organization1 -BackupConfig $backup_config1 -ScheduleConfig $schedule_config1 -Name 'recovery_backup_profile1' -Description 'recovery_backup_profile' -Type 'instance' -Enabled 1