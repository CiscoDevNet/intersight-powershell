
#Get the VnicIscsiBootPolicy to delete
$VnicIscsiBootPolicy = Get-IntersightVnicIscsiBootPolicy -Name VnicIscsiBootPolicyName
$VnicIscsiBootPolicy | Remove-IntersightVnicIscsiBootPolicy

#Remove the VnicIscsiBootPolicy by Moid.
Remove-IntersightVnicIscsiBootPolicy -Moid '<Replace with Moid>'
