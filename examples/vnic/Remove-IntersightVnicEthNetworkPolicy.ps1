
#Get the VnicEthNetworkPolicy to delete
$VnicEthNetworkPolicy = Remove-IntersightVnicEthNetworkPolicy -Name VnicEthNetworkPolicyName
$VnicEthNetworkPolicy | Remove-IntersightVnicEthNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicEthNetworkPolicy -Moid 123bc2222287wee
