
#Get the HyperflexNodeConfigPolicy to delete
$HyperflexNodeConfigPolicy = Remove-IntersightHyperflexNodeConfigPolicy -Name HyperflexNodeConfigPolicyName
$HyperflexNodeConfigPolicy | Remove-IntersightHyperflexNodeConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexNodeConfigPolicy -Moid 123bc2222287wee
