
#Get the HyperflexExtFcStoragePolicy to delete
$HyperflexExtFcStoragePolicy = Remove-IntersightHyperflexExtFcStoragePolicy -Name HyperflexExtFcStoragePolicyName
$HyperflexExtFcStoragePolicy | Remove-IntersightHyperflexExtFcStoragePolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexExtFcStoragePolicy -Moid 123bc2222287wee
