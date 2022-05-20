
#Get the HyperflexHealthCheckDefinition to delete
$HyperflexHealthCheckDefinition = Get-IntersightHyperflexHealthCheckDefinition -Name HyperflexHealthCheckDefinitionName
$HyperflexHealthCheckDefinition | Remove-IntersightHyperflexHealthCheckDefinition

#Remove the HyperflexHealthCheckDefinition by Moid.
Remove-IntersightHyperflexHealthCheckDefinition -Moid '<Replace with Moid>'
