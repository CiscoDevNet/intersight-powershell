
#Get the HyperflexVcenterConfigPolicy to Update
$HyperflexVcenterConfigPolicy = Get-IntersightHyperflexVcenterConfigPolicy -Name HyperflexVcenterConfigPolicyName
$HyperflexVcenterConfigPolicy | Set-IntersightHyperflexVcenterConfigPolicy -Description 'Updated description'
