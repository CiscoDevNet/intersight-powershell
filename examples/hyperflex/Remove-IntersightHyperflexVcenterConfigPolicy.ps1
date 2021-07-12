
#Get the HyperflexVcenterConfigPolicy to delete
$HyperflexVcenterConfigPolicy = Remove-IntersightHyperflexVcenterConfigPolicy -Name HyperflexVcenterConfigPolicyName
$HyperflexVcenterConfigPolicy | Remove-IntersightHyperflexVcenterConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexVcenterConfigPolicy -Moid 123bc2222287wee
