
#Get the StorageDiskGroupPolicy to delete
$StorageDiskGroupPolicy = Remove-IntersightStorageDiskGroupPolicy -Name StorageDiskGroupPolicyName
$StorageDiskGroupPolicy | Remove-IntersightStorageDiskGroupPolicy

#Remove the server profile by Moid.
Remove-IntersightStorageDiskGroupPolicy -Moid 123bc2222287wee
