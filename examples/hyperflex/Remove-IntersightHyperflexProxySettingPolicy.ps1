
#Get the HyperflexProxySettingPolicy to delete
$HyperflexProxySettingPolicy = Get-IntersightHyperflexProxySettingPolicy -Name HyperflexProxySettingPolicyName
$HyperflexProxySettingPolicy | Remove-IntersightHyperflexProxySettingPolicy

#Remove the HyperflexProxySettingPolicy by Moid.
Remove-IntersightHyperflexProxySettingPolicy -Moid '<Replace with Moid>'
