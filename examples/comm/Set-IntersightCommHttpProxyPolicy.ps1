
#Get the CommHttpProxyPolicy to Update
$CommHttpProxyPolicy = Get-IntersightCommHttpProxyPolicy -Name CommHttpProxyPolicyName
$CommHttpProxyPolicy | Set-IntersightCommHttpProxyPolicy -Description 'Updated description'