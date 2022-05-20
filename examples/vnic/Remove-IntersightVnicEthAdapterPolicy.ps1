
#Get the VnicEthAdapterPolicy to delete
$VnicEthAdapterPolicy = Get-IntersightVnicEthAdapterPolicy -Name VnicEthAdapterPolicyName
$VnicEthAdapterPolicy | Remove-IntersightVnicEthAdapterPolicy

#Remove the VnicEthAdapterPolicy by Moid.
Remove-IntersightVnicEthAdapterPolicy -Moid '<Replace with Moid>'
