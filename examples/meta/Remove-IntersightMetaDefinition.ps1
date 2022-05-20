
#Get the MetaDefinition to delete
$MetaDefinition = Get-IntersightMetaDefinition -Name MetaDefinitionName
$MetaDefinition | Remove-IntersightMetaDefinition

#Remove the MetaDefinition by Moid.
Remove-IntersightMetaDefinition -Moid '<Replace with Moid>'

