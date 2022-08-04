
#Get the HyperflexNodeConfigPolicy to Update
$HyperflexNodeConfigPolicy = Get-IntersightHyperflexNodeConfigPolicy -Name HyperflexNodeConfigPolicyName
$HyperflexNodeConfigPolicy | Set-IntersightHyperflexNodeConfigPolicy -Description 'Updated description'
