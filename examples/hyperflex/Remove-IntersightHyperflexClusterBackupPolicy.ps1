
#Get the HyperflexClusterBackupPolicy to delete
$HyperflexClusterBackupPolicy = Get-IntersightHyperflexClusterBackupPolicy -Name HyperflexClusterBackupPolicyName
$HyperflexClusterBackupPolicy | Remove-IntersightHyperflexClusterBackupPolicy

#Remove the HyperflexClusterBackupPolicy by Moid.
Remove-IntersightHyperflexClusterBackupPolicy -Moid '<Replace with Moid>'
