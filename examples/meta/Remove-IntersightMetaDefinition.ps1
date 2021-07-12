
#Get the MetaDefinition to delete
$MetaDefinition = Remove-IntersightMetaDefinition -Name MetaDefinitionName
$MetaDefinition | Remove-IntersightMetaDefinition

#Remove the server profile by Moid.
Remove-IntersightMetaDefinition -Moid 123bc2222287wee
