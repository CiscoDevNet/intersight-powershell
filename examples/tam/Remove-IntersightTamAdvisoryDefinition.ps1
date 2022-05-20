#Get the TamAdvisoryDefinition to delete
$TamAdvisoryDefinition = Get-IntersightTamAdvisoryDefinition -Name TamAdvisoryDefinitionName
$TamAdvisoryDefinition | Remove-IntersightTamAdvisoryDefinition

#Remove the TamAdvisoryDefinition by Moid.
Remove-IntersightTamAdvisoryDefinition -Moid '<Replace with Moid>'