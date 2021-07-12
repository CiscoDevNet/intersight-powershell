
#Get the AssetSubscription to delete
$AssetSubscription = Remove-IntersightAssetSubscription -Name AssetSubscriptionName
$AssetSubscription | Remove-IntersightAssetSubscription

#Remove the server profile by Moid.
Remove-IntersightAssetSubscription -Moid 123bc2222287wee
