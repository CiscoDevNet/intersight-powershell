
#Get the NetworkconfigPolicy to delete
$NetworkconfigPolicy = Remove-IntersightNetworkconfigPolicy -Name NetworkconfigPolicyName
$NetworkconfigPolicy | Remove-IntersightNetworkconfigPolicy

#Remove the server profile by Moid.
Remove-IntersightNetworkconfigPolicy -Moid 123bc2222287wee
