
#Get the HclHyperflexSoftwareCompatibilityInfo to delete
$HclHyperflexSoftwareCompatibilityInfo = Remove-IntersightHclHyperflexSoftwareCompatibilityInfo -Name HclHyperflexSoftwareCompatibilityInfoName
$HclHyperflexSoftwareCompatibilityInfo | Remove-IntersightHclHyperflexSoftwareCompatibilityInfo

#Remove the server profile by Moid.
Remove-IntersightHclHyperflexSoftwareCompatibilityInfo -Moid 123bc2222287wee