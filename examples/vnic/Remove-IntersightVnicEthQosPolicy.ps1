
#Get the VnicEthQosPolicy to delete
$VnicEthQosPolicy = Remove-IntersightVnicEthQosPolicy -Name VnicEthQosPolicyName
$VnicEthQosPolicy | Remove-IntersightVnicEthQosPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicEthQosPolicy -Moid 123bc2222287wee
