
#Get the VnicEthQosPolicy to delete
$VnicEthQosPolicy = Get-IntersightVnicEthQosPolicy -Name VnicEthQosPolicyName
$VnicEthQosPolicy | Remove-IntersightVnicEthQosPolicy

#Remove the VnicEthQosPolicy by Moid.
Remove-IntersightVnicEthQosPolicy -Moid '<Replace with Moid>'

