#Get the StorageStoragePolicy to delete
$StorageStoragePolicy = Get-IntersightStorageStoragePolicy -Name StorageStoragePolicyName
$StorageStoragePolicy | Remove-IntersightStorageStoragePolicy

#Remove the StorageStoragePolicy by Moid.
Remove-IntersightStorageStoragePolicy -Moid '<Replace with Moid>'