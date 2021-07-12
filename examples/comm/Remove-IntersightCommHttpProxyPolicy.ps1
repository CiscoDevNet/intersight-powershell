
#Get the CommHttpProxyPolicy to delete
$CommHttpProxyPolicy = Remove-IntersightCommHttpProxyPolicy -Name CommHttpProxyPolicyName
$CommHttpProxyPolicy | Remove-IntersightCommHttpProxyPolicy

#Remove the server profile by Moid.
Remove-IntersightCommHttpProxyPolicy -Moid 123bc2222287wee
