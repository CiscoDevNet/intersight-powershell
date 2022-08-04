
#Get the NetworkconfigPolicy to delete
$NetworkconfigPolicy = Get-IntersightNetworkconfigPolicy -Name NetworkconfigPolicyName
$NetworkconfigPolicy | Remove-IntersightNetworkconfigPolicy

#Remove the NetworkconfigPolicy by Moid.
Remove-IntersightNetworkconfigPolicy -Moid '<Replace with Moid>'

