
#Get the VnicFcNetworkPolicy to delete
$VnicFcNetworkPolicy = Remove-IntersightVnicFcNetworkPolicy -Name VnicFcNetworkPolicyName
$VnicFcNetworkPolicy | Remove-IntersightVnicFcNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicFcNetworkPolicy -Moid 123bc2222287wee
