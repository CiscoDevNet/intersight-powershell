
#Get the VnicFcAdapterPolicy to delete
$VnicFcAdapterPolicy = Get-IntersightVnicFcAdapterPolicy -Name VnicFcAdapterPolicyName
$VnicFcAdapterPolicy | Remove-IntersightVnicFcAdapterPolicy

#Remove the VnicFcAdapterPolicy by Moid.
Remove-IntersightVnicFcAdapterPolicy -Moid '<Replace with Moid>'
