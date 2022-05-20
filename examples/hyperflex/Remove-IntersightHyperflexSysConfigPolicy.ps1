
#Get the HyperflexSysConfigPolicy to delete
$HyperflexSysConfigPolicy = Get-IntersightHyperflexSysConfigPolicy -Name HyperflexSysConfigPolicyName
$HyperflexSysConfigPolicy | Remove-IntersightHyperflexSysConfigPolicy

#Remove the HyperflexSysConfigPolicy by Moid.
Remove-IntersightHyperflexSysConfigPolicy -Moid '<Replace with Moid>'
