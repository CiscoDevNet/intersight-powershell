
#Get the HyperflexProxySettingPolicy to delete
$HyperflexProxySettingPolicy = Remove-IntersightHyperflexProxySettingPolicy -Name HyperflexProxySettingPolicyName
$HyperflexProxySettingPolicy | Remove-IntersightHyperflexProxySettingPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexProxySettingPolicy -Moid 123bc2222287wee
