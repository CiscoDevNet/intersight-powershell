
#Get the OprsDeployment to delete
$OprsDeployment = Remove-IntersightOprsDeployment -Name OprsDeploymentName
$OprsDeployment | Remove-IntersightOprsDeployment

#Remove the server profile by Moid.
Remove-IntersightOprsDeployment -Moid 123bc2222287wee
