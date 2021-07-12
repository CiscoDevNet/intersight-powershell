
#Get the AssetSubscriptionAccount to delete
$AssetSubscriptionAccount = Remove-IntersightAssetSubscriptionAccount -Name AssetSubscriptionAccountName
$AssetSubscriptionAccount | Remove-IntersightAssetSubscriptionAccount

#Remove the server profile by Moid.
Remove-IntersightAssetSubscriptionAccount -Moid 123bc2222287wee
