
#Get the VnicSanConnectivityPolicy to delete
$VnicSanConnectivityPolicy = Remove-IntersightVnicSanConnectivityPolicy -Name VnicSanConnectivityPolicyName
$VnicSanConnectivityPolicy | Remove-IntersightVnicSanConnectivityPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicSanConnectivityPolicy -Moid 123bc2222287wee
