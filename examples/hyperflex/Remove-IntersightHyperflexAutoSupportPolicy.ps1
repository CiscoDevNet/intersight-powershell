
#Get the HyperflexAutoSupportPolicy to delete
$HyperflexAutoSupportPolicy = Remove-IntersightHyperflexAutoSupportPolicy -Name HyperflexAutoSupportPolicyName
$HyperflexAutoSupportPolicy | Remove-IntersightHyperflexAutoSupportPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexAutoSupportPolicy -Moid 123bc2222287wee
