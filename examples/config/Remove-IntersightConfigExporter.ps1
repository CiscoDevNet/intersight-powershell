
#Get the ConfigExporter to delete
$ConfigExporter = Remove-IntersightConfigExporter -Name ConfigExporterName
$ConfigExporter | Remove-IntersightConfigExporter

#Remove the server profile by Moid.
Remove-IntersightConfigExporter -Moid 123bc2222287wee
