
#Get the HyperflexClusterStoragePolicy to delete
$HyperflexClusterStoragePolicy = Get-IntersightHyperflexClusterStoragePolicy -Name HyperflexClusterStoragePolicyName
$HyperflexClusterStoragePolicy | Remove-IntersightHyperflexClusterStoragePolicy

#Remove the HyperflexClusterStoragePolicy by Moid.
Remove-IntersightHyperflexClusterStoragePolicy -Moid '<Replace with Moid>'
