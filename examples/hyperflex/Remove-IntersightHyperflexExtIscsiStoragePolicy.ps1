
#Get the HyperflexExtIscsiStoragePolicy to delete
$HyperflexExtIscsiStoragePolicy = Get-IntersightHyperflexExtIscsiStoragePolicy -Name HyperflexExtIscsiStoragePolicyName
$HyperflexExtIscsiStoragePolicy | Remove-IntersightHyperflexExtIscsiStoragePolicy

#Remove the HyperflexExtIscsiStoragePolicy by Moid.
Remove-IntersightHyperflexExtIscsiStoragePolicy -Moid '<Replace with Moid>'
