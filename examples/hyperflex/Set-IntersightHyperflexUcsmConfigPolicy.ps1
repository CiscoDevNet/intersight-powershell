
#Get the HyperflexUcsmConfigPolicy to Update
$HyperflexUcsmConfigPolicy = Get-IntersightHyperflexUcsmConfigPolicy -Name HyperflexUcsmConfigPolicyName
$HyperflexUcsmConfigPolicy | Set-IntersightHyperflexUcsmConfigPolicy -Description 'Updated description'
