$replication_schedule1 = Initialize-IntersightHyperflexReplicationschedule -BackupInterval 1440

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_cluster_backup_policy1 = New-IntersightHyperflexClusterBackupPolicy -ReplicationSchedule $replication_schedule1 -Organization $organization1 -Description 'hyperflex cluster backup policy' -Name 'hyperflex_cluster_backup_policy1'