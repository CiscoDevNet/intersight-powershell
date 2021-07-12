
#Get the VnicLanConnectivityPolicy to delete
$VnicLanConnectivityPolicy = Remove-IntersightVnicLanConnectivityPolicy -Name VnicLanConnectivityPolicyName
$VnicLanConnectivityPolicy | Remove-IntersightVnicLanConnectivityPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicLanConnectivityPolicy -Moid 123bc2222287wee
