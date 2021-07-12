
#Get the VnicEthAdapterPolicy to delete
$VnicEthAdapterPolicy = Remove-IntersightVnicEthAdapterPolicy -Name VnicEthAdapterPolicyName
$VnicEthAdapterPolicy | Remove-IntersightVnicEthAdapterPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicEthAdapterPolicy -Moid 123bc2222287wee
