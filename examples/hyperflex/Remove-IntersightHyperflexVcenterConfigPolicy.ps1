
#Get the HyperflexVcenterConfigPolicy to delete
$HyperflexVcenterConfigPolicy = Get-IntersightHyperflexVcenterConfigPolicy -Name HyperflexVcenterConfigPolicyName
$HyperflexVcenterConfigPolicy | Remove-IntersightHyperflexVcenterConfigPolicy

#Remove the HyperflexVcenterConfigPolicy by Moid.
Remove-IntersightHyperflexVcenterConfigPolicy -Moid '<Replace with Moid>'
