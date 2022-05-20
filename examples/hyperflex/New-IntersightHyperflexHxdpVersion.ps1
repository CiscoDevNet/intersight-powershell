$app_catalog1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$parent1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$hyperflex_hxdp_version1 = New-IntersightHyperflexHxdpVersion -AppCatalog $app_catalog1 -Parent $parent1