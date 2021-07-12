
#Get the HyperflexSysConfigPolicy to delete
$HyperflexSysConfigPolicy = Remove-IntersightHyperflexSysConfigPolicy -Name HyperflexSysConfigPolicyName
$HyperflexSysConfigPolicy | Remove-IntersightHyperflexSysConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexSysConfigPolicy -Moid 123bc2222287wee
