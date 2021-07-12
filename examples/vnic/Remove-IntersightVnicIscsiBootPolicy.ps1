
#Get the VnicIscsiBootPolicy to delete
$VnicIscsiBootPolicy = Remove-IntersightVnicIscsiBootPolicy -Name VnicIscsiBootPolicyName
$VnicIscsiBootPolicy | Remove-IntersightVnicIscsiBootPolicy

#Remove the server profile by Moid.
Remove-IntersightVnicIscsiBootPolicy -Moid 123bc2222287wee
