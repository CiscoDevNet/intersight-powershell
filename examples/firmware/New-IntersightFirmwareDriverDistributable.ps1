$component_meta1 = Initialize-IntersightFirmwareComponentmeta -ComponentLabel 'UCS-IOM-2204XP' -Model 'UCS-IOM-2204XP' -PackedVersion '4.1(2S16)' -RedfishUrl '/path/to/redfish/url' -Vendor 'Cisco Systems Inc.' -ComponentType 'ALL' -Description 'firmware meta component' -IsOobSupported 0 -OobManageability @('Update', 'Inventory', 'Activate')

$catalog1 = Get-IntersightSoftwarerepositoryCatalog -Moid '<Replace with Moid>'

$firmware_driver_distributable1 = New-IntersightFirmwareDriverDistributable -ComponentMeta $component_meta1 -Catalog $catalog1 -Description 'firmware driver distributable' -ImportAction 'Extract' -Name 'firmware_driver_distributable1' -Category 'Win64'