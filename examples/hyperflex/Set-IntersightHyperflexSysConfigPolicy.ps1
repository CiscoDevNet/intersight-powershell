
#Get the HyperflexSysConfigPolicy to Update
$HyperflexSysConfigPolicy = Get-IntersightHyperflexSysConfigPolicy -Name HyperflexSysConfigPolicyName
$HyperflexSysConfigPolicy | Set-IntersightHyperflexSysConfigPolicy -Description 'Updated description'
