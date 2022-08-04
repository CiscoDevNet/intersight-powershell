
#Get the HyperflexNodeConfigPolicy to delete
$HyperflexNodeConfigPolicy = Get-IntersightHyperflexNodeConfigPolicy -Name HyperflexNodeConfigPolicyName
$HyperflexNodeConfigPolicy | Remove-IntersightHyperflexNodeConfigPolicy

#Remove the HyperflexNodeConfigPolicy by Moid.
Remove-IntersightHyperflexNodeConfigPolicy -Moid '<Replace with Moid>'
