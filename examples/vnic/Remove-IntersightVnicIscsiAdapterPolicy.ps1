
#Get the VnicIscsiAdapterPolicy to delete
$VnicIscsiAdapterPolicy = Get-IntersightVnicIscsiAdapterPolicy -Name VnicIscsiAdapterPolicyName
$VnicIscsiAdapterPolicy | Remove-IntersightVnicIscsiAdapterPolicy

#Remove the VnicIscsiAdapterPolicy by Moid.
Remove-IntersightVnicIscsiAdapterPolicy -Moid '<Replace with Moid>'

