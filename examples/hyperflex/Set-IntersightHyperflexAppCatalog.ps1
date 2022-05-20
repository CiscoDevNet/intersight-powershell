
#Get the HyperflexAppCatalog to Update
$HyperflexAppCatalog = Get-IntersightHyperflexAppCatalog -Name HyperflexAppCatalogName
$HyperflexAppCatalog | Set-IntersightHyperflexAppCatalog -Description 'Updated description'
