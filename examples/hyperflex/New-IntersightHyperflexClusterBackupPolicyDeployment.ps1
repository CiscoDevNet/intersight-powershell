$replication_schedule1 = Initialize-IntersightHyperflexReplicationschedule -BackupInterval 1440

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_cluster_backup_policy_deployment1 = New-IntersightHyperflexClusterBackupPolicyDeployment -ReplicationSchedule $replication_schedule1 -Organization $organization1 -Discovered 1 -SourceDetached 1 -TargetDetached 1