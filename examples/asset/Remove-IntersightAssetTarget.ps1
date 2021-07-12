
#Get the AssetTarget to delete
$AssetTarget = Remove-IntersightAssetTarget -Name AssetTargetName
$AssetTarget | Remove-IntersightAssetTarget

#Remove the server profile by Moid.
Remove-IntersightAssetTarget -Moid 123bc2222287wee
