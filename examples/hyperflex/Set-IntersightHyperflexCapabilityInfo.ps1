
#Get the HyperflexCapabilityInfo to Update
$HyperflexCapabilityInfo = Get-IntersightHyperflexCapabilityInfo -Name HyperflexCapabilityInfoName
$HyperflexCapabilityInfo | Set-IntersightHyperflexCapabilityInfo -Description 'Updated description'
