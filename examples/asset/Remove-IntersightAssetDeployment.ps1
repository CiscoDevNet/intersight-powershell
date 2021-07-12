
#Get the AssetDeployment to delete
$AssetDeployment = Remove-IntersightAssetDeployment -Name AssetDeploymentName
$AssetDeployment | Remove-IntersightAssetDeployment

#Remove the server profile by Moid.
Remove-IntersightAssetDeployment -Moid 123bc2222287wee
