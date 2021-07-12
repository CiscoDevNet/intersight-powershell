
#Get the HyperflexAppCatalog to delete
$HyperflexAppCatalog = Remove-IntersightHyperflexAppCatalog -Name HyperflexAppCatalogName
$HyperflexAppCatalog | Remove-IntersightHyperflexAppCatalog

#Remove the server profile by Moid.
Remove-IntersightHyperflexAppCatalog -Moid 123bc2222287wee
