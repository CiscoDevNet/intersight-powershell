
#Get the TamAdvisoryDefinition to delete
$TamAdvisoryDefinition = Remove-IntersightTamAdvisoryDefinition -Name TamAdvisoryDefinitionName
$TamAdvisoryDefinition | Remove-IntersightTamAdvisoryDefinition

#Remove the server profile by Moid.
Remove-IntersightTamAdvisoryDefinition -Moid 123bc2222287wee
