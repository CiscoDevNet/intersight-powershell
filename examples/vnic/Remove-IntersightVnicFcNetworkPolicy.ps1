
#Get the VnicFcNetworkPolicy to delete
$VnicFcNetworkPolicy = Get-IntersightVnicFcNetworkPolicy -Name VnicFcNetworkPolicyName
$VnicFcNetworkPolicy | Remove-IntersightVnicFcNetworkPolicy

#Remove the VnicFcNetworkPolicy by Moid.
Remove-IntersightVnicFcNetworkPolicy -Moid '<Replace with Moid>'
