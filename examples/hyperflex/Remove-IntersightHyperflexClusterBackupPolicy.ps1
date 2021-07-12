
#Get the HyperflexClusterBackupPolicy to delete
$HyperflexClusterBackupPolicy = Remove-IntersightHyperflexClusterBackupPolicy -Name HyperflexClusterBackupPolicyName
$HyperflexClusterBackupPolicy | Remove-IntersightHyperflexClusterBackupPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexClusterBackupPolicy -Moid 123bc2222287wee
