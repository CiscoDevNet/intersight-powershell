
#Get the HyperflexAutoSupportPolicy to delete
$HyperflexAutoSupportPolicy = Get-IntersightHyperflexAutoSupportPolicy -Name HyperflexAutoSupportPolicyName
$HyperflexAutoSupportPolicy | Remove-IntersightHyperflexAutoSupportPolicy

#Remove the HyperflexAutoSupportPolicy by Moid.
Remove-IntersightHyperflexAutoSupportPolicy -Moid '<Replace with Moid>'
