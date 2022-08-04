
#Get the HyperflexProxySettingPolicy to Update
$HyperflexProxySettingPolicy = Get-IntersightHyperflexProxySettingPolicy -Name HyperflexProxySettingPolicyName
$HyperflexProxySettingPolicy | Set-IntersightHyperflexProxySettingPolicy -Description 'Updated description'
