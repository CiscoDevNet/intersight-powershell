$component_meta1 = Initialize-IntersightFirmwareComponentmeta -ClassId 'FirmwareComponentMeta' -ComponentLabel 'BIOS' -IsOobSupported 0

$release1 = Get-IntersightSoftwarerepositoryRelease -Moid '<Replace with Moid>'

$catalog1 = Get-IntersightSoftwarerepositoryCatalog -Moid '<Replace with Moid>'

$distributable_metas1 = Initialize-IntersightFirmwareDistributablemeta -ClassId 'FirmwareDistributableMeta'

$software_solution_distributable1 = New-IntersightSoftwareSolutionDistributable -ComponentMeta $component_meta1 -Release $release1 -Catalog $catalog1 -DistributableMetas $distributable_metas1 -Name 'software_solution_distributable1' -Sha512Sum '<sha_512_checksum>' -Size 7471044747 -Model '' -Mdfid '' -Vendor 'Cisco' -SubType 'osimage' -SolutionName 'IKS' -SupportedModels @('HyperFlex Data Platform')