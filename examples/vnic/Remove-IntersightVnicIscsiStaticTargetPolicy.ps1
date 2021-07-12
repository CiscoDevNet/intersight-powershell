
#Get the VnicIscsiStaticTargetPolicy to delete
$VnicIscsiStaticTargetPolicy = Remove-IntersightVnicIscsiStaticTargetPolicy -Name VnicIscsiStaticTargetPolicyName
$VnicIscsiStaticTargetPolicy | Remove-IntersightVnicIscsiStaticTargetPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicIscsiStaticTargetPolicy -Moid 123bc2222287wee
