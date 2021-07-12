
#Get the AdapterConfigPolicy to delete
$AdapterConfigPolicy = Remove-IntersightAdapterConfigPolicy -Name AdapterConfigPolicyName
$AdapterConfigPolicy | Remove-IntersightAdapterConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightAdapterConfigPolicy -Moid 123bc2222287wee
