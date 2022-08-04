$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$config_result1 = Get-IntersightRecoveryBackupprofile -Moid '<Replace with Moid>'

$recovery_on_demand_backup1 = New-IntersightRecoveryOnDemandBackup -Organization $organization1 -ConfigResult $config_result1 -Name 'recovery_on_demand_backup1' -Description 'recovery_on_demand_backup' -FileNamePrefix 'file_name' -LocationType 'Network Storage' -RetentionCount 120 -Path 'path/to/backup' -Protocol 'SCP'