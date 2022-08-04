
#Get the HyperflexCapabilityInfo to delete
$HyperflexCapabilityInfo = Get-IntersightHyperflexCapabilityInfo -Name HyperflexCapabilityInfoName
$HyperflexCapabilityInfo | Remove-IntersightHyperflexCapabilityInfo

#Remove the HyperflexCapabilityInfo by Moid.
Remove-IntersightHyperflexCapabilityInfo -Moid '<Replace with Moid>'
