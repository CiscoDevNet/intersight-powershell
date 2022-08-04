
#Get the HyperflexExtFcStoragePolicy to Update
$HyperflexExtFcStoragePolicy = Get-IntersightHyperflexExtFcStoragePolicy -Name HyperflexExtFcStoragePolicyName
$HyperflexExtFcStoragePolicy | Set-IntersightHyperflexExtFcStoragePolicy -Description 'Updated description'
