
#Get the VnicLanConnectivityPolicy to delete
$VnicLanConnectivityPolicy = Get-IntersightVnicLanConnectivityPolicy -Name VnicLanConnectivityPolicyName
$VnicLanConnectivityPolicy | Remove-IntersightVnicLanConnectivityPolicy

#Remove the VnicLanConnectivityPolicy by Moid.
Remove-IntersightVnicLanConnectivityPolicy -Moid '<Replace with Moid>'
