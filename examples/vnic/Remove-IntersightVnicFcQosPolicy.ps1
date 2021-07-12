
#Get the VnicFcQosPolicy to delete
$VnicFcQosPolicy = Remove-IntersightVnicFcQosPolicy -Name VnicFcQosPolicyName
$VnicFcQosPolicy | Remove-IntersightVnicFcQosPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicFcQosPolicy -Moid 123bc2222287wee
