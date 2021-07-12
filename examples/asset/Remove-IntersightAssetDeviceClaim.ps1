
#Get the AssetDeviceClaim to delete
$AssetDeviceClaim = Remove-IntersightAssetDeviceClaim -Name AssetDeviceClaimName
$AssetDeviceClaim | Remove-IntersightAssetDeviceClaim

#Remove the server profile by Moid.
Remove-IntersightAssetDeviceClaim -Moid 123bc2222287wee
