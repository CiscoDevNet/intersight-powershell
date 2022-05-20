
#Get the VnicEthNetworkPolicy to delete
$VnicEthNetworkPolicy = Get-IntersightVnicEthNetworkPolicy -Name VnicEthNetworkPolicyName
$VnicEthNetworkPolicy | Remove-IntersightVnicEthNetworkPolicy

#Remove the VnicEthNetworkPolicy by Moid.
Remove-IntersightVnicEthNetworkPolicy -Moid '<Replace with Moid>'
