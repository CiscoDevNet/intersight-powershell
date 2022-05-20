$catalog1 = Get-IntersightSoftwarerepositoryCatalog -Moid '<Replace with Moid>'

$softwarerepository_release1 = New-IntersightSoftwarerepositoryRelease -Catalog $catalog1 -Type 'FabricSwitch'