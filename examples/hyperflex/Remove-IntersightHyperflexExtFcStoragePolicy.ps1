
#Get the HyperflexExtFcStoragePolicy to delete
$HyperflexExtFcStoragePolicy = Get-IntersightHyperflexExtFcStoragePolicy -Name HyperflexExtFcStoragePolicyName
$HyperflexExtFcStoragePolicy | Remove-IntersightHyperflexExtFcStoragePolicy

#Remove the HyperflexExtFcStoragePolicy by Moid.
Remove-IntersightHyperflexExtFcStoragePolicy -Moid '<Replace with Moid>'
