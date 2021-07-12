
#Get the HyperflexCapabilityInfo to delete
$HyperflexCapabilityInfo = Remove-IntersightHyperflexCapabilityInfo -Name HyperflexCapabilityInfoName
$HyperflexCapabilityInfo | Remove-IntersightHyperflexCapabilityInfo

#Remove the server profile by Moid.
Remove-IntersightHyperflexCapabilityInfo -Moid 123bc2222287wee
