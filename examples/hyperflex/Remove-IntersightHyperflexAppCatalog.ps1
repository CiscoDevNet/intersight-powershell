
#Get the HyperflexAppCatalog to delete
$HyperflexAppCatalog = Get-IntersightHyperflexAppCatalog -Name HyperflexAppCatalogName
$HyperflexAppCatalog | Remove-IntersightHyperflexAppCatalog

#Remove the HyperflexAppCatalog by Moid.
Remove-IntersightHyperflexAppCatalog -Moid '<Replace with Moid>'
