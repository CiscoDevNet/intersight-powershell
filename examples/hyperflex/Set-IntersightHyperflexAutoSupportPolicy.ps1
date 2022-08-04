
#Get the HyperflexAutoSupportPolicy to Update
$HyperflexAutoSupportPolicy = Get-IntersightHyperflexAutoSupportPolicy -Name HyperflexAutoSupportPolicyName
$HyperflexAutoSupportPolicy | Set-IntersightHyperflexAutoSupportPolicy -Description 'Updated description'
