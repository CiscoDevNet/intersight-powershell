
#Get the VnicIscsiAdapterPolicy to delete
$VnicIscsiAdapterPolicy = Remove-IntersightVnicIscsiAdapterPolicy -Name VnicIscsiAdapterPolicyName
$VnicIscsiAdapterPolicy | Remove-IntersightVnicIscsiAdapterPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicIscsiAdapterPolicy -Moid 123bc2222287wee
