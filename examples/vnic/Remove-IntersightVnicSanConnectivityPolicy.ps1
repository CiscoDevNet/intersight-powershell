
#Get the VnicSanConnectivityPolicy to delete
$VnicSanConnectivityPolicy = Get-IntersightVnicSanConnectivityPolicy -Name VnicSanConnectivityPolicyName
$VnicSanConnectivityPolicy | Remove-IntersightVnicSanConnectivityPolicy

#Remove the VnicSanConnectivityPolicy by Moid.
Remove-IntersightVnicSanConnectivityPolicy -Moid '<Replace with Moid>'
