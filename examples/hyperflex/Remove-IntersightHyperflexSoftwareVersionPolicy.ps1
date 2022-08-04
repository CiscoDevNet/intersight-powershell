
#Get the HyperflexSoftwareVersionPolicy to delete
$HyperflexSoftwareVersionPolicy = Get-IntersightHyperflexSoftwareVersionPolicy -Name HyperflexSoftwareVersionPolicyName
$HyperflexSoftwareVersionPolicy | Remove-IntersightHyperflexSoftwareVersionPolicy

#Remove the HyperflexSoftwareVersionPolicy by Moid.
Remove-IntersightHyperflexSoftwareVersionPolicy -Moid '<Replace with Moid>'
