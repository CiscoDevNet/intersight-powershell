#Get the StorageDriveGroup to delete
$StorageDriveGroup = Get-IntersightStorageDriveGroup -Name StorageDriveGroupName
$StorageDriveGroup | Remove-IntersightStorageDriveGroup

#Remove the StorageDriveGroup by Moid.
Remove-IntersightStorageDriveGroup -Moid '<Replace with Moid>'