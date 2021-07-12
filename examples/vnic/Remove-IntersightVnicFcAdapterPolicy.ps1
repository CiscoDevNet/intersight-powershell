
#Get the VnicFcAdapterPolicy to delete
$VnicFcAdapterPolicy = Remove-IntersightVnicFcAdapterPolicy -Name VnicFcAdapterPolicyName
$VnicFcAdapterPolicy | Remove-IntersightVnicFcAdapterPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicFcAdapterPolicy -Moid 123bc2222287wee
