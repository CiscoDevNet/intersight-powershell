
#Get the AssetDeploymentDevice to delete
$AssetDeploymentDevice = Remove-IntersightAssetDeploymentDevice -Name AssetDeploymentDeviceName
$AssetDeploymentDevice | Remove-IntersightAssetDeploymentDevice

#Remove the server profile by Moid.
Remove-IntersightAssetDeploymentDevice -Moid 123bc2222287wee
