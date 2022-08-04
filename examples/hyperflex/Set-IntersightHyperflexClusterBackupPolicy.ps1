
#Get the HyperflexClusterBackupPolicy to Update
$HyperflexClusterBackupPolicy = Get-IntersightHyperflexClusterBackupPolicy -Name HyperflexClusterBackupPolicyName
$HyperflexClusterBackupPolicy | Set-IntersightHyperflexClusterBackupPolicy -Description 'Updated description'
