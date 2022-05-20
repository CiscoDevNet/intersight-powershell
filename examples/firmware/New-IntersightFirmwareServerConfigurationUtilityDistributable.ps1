$catalog1 = Get-IntersightSoftwarerepositoryCatalog -Moid '<Replace with Moid>'

$scu1 = New-IntersightFirmwareServerConfigurationUtilityDistributable -Catalog $catalog1 -Name 'SCU-6.0.4c nfs' -Vendor 'Cisco' -Description 'Cisco SCU-6.0(4c)' -SupportedModels @('C-series')