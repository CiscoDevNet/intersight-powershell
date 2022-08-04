
#Get the CommHttpProxyPolicy to delete
$CommHttpProxyPolicy = Get-IntersightCommHttpProxyPolicy -Name CommHttpProxyPolicyName
$CommHttpProxyPolicy | Remove-IntersightCommHttpProxyPolicy

#Remove the CommHttpProxyPolicy by Moid.
Remove-IntersightCommHttpProxyPolicy -Moid '<Replace with Moid>'
