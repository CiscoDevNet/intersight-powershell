
#Get the HyperflexServerModel to delete
$HyperflexServerModel = Get-IntersightHyperflexServerModel -Name HyperflexServerModelName
$HyperflexServerModel | Remove-IntersightHyperflexServerModel

#Remove the HyperflexServerModel by Moid.
Remove-IntersightHyperflexServerModel -Moid '<Replace with Moid>'
