#Get the VnicIscsiStaticTargetPolicy to delete
$VnicIscsiStaticTargetPolicy = Get-IntersightVnicIscsiStaticTargetPolicy -Name VnicIscsiStaticTargetPolicyName
$VnicIscsiStaticTargetPolicy | Remove-IntersightVnicIscsiStaticTargetPolicy

#Remove the VnicIscsiStaticTargetPolicy by Moid.
Remove-IntersightVnicIscsiStaticTargetPolicy -Moid '<Replace with Moid>'
