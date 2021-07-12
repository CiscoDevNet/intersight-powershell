
#Get the HyperflexUcsmConfigPolicy to delete
$HyperflexUcsmConfigPolicy = Remove-IntersightHyperflexUcsmConfigPolicy -Name HyperflexUcsmConfigPolicyName
$HyperflexUcsmConfigPolicy | Remove-IntersightHyperflexUcsmConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexUcsmConfigPolicy -Moid 123bc2222287wee
