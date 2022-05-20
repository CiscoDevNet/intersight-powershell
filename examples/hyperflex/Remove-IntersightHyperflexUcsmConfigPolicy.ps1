
#Get the HyperflexUcsmConfigPolicy to delete
$HyperflexUcsmConfigPolicy = Get-IntersightHyperflexUcsmConfigPolicy -Name HyperflexUcsmConfigPolicyName
$HyperflexUcsmConfigPolicy | Remove-IntersightHyperflexUcsmConfigPolicy

#Remove the HyperflexUcsmConfigPolicy by Moid.
Remove-IntersightHyperflexUcsmConfigPolicy -Moid '<Replace with Moid>'
