
#Get the HyperflexClusterStoragePolicy to delete
$HyperflexClusterStoragePolicy = Remove-IntersightHyperflexClusterStoragePolicy -Name HyperflexClusterStoragePolicyName
$HyperflexClusterStoragePolicy | Remove-IntersightHyperflexClusterStoragePolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexClusterStoragePolicy -Moid 123bc2222287wee
