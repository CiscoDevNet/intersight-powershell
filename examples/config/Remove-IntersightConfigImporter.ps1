
#Get the ConfigImporter to delete
$ConfigImporter = Remove-IntersightConfigImporter -Name ConfigImporterName
$ConfigImporter | Remove-IntersightConfigImporter

#Remove the server profile by Moid.
Remove-IntersightConfigImporter -Moid 123bc2222287wee
