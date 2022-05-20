
#Get the HyperflexLocalCredentialPolicy to delete
$HyperflexLocalCredentialPolicy = Get-IntersightHyperflexLocalCredentialPolicy -Name HyperflexLocalCredentialPolicyName
$HyperflexLocalCredentialPolicy | Remove-IntersightHyperflexLocalCredentialPolicy

#Remove the HyperflexLocalCredentialPolicy by Moid.
Remove-IntersightHyperflexLocalCredentialPolicy -Moid '<Replace with Moid>'
