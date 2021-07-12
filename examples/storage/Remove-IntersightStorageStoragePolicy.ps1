
#Get the StorageStoragePolicy to delete
$StorageStoragePolicy = Remove-IntersightStorageStoragePolicy -Name StorageStoragePolicyName
$StorageStoragePolicy | Remove-IntersightStorageStoragePolicy

#Remove the server profile by Moid.
Remove-IntersightStorageStoragePolicy -Moid 123bc2222287wee
