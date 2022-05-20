
#Get the VnicFcQosPolicy to delete
$VnicFcQosPolicy = Get-IntersightVnicFcQosPolicy -Name VnicFcQosPolicyName
$VnicFcQosPolicy | Remove-IntersightVnicFcQosPolicy

#Remove the VnicFcQosPolicy by Moid.
Remove-IntersightVnicFcQosPolicy -Moid '<Replace with Moid>'

