
#Get the AdapterConfigPolicy to delete
$AdapterConfigPolicy = Get-IntersightAdapterConfigPolicy -Name AdapterConfigPolicyName
$AdapterConfigPolicy | Remove-IntersightAdapterConfigPolicy

#Remove the AdapterConfigPolicy by Moid.
Remove-IntersightAdapterConfigPolicy -Moid '<Replace with Moid>'
