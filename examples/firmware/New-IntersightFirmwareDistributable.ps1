$component_meta1 = Initialize-IntersightFirmwareComponentmeta -ComponentLabel 'UCS-FI-6454' -ComponentType 'NXOS' -Description 'Cisco UCS 6454 Fabric Interconnect' -Disruption 'EndpointReboot' -IsOobSupported 0 -Model 'UCS-FI-6454' -OobManageability @('Update', 'Inventory', 'Activate') -PackedVersion '7.0(3)N2(4.12S16)' -RedfishUrl '/path/to/redfish/url' -Vendor 'Cisco Systems Inc.'

$component_meta2 = Initialize-IntersightFirmwareComponentmeta -ComponentLabel 'UCS-IOM-2204XP' -ComponentType 'IOM' -Description 'Cisco UCS 2204XP' -Disruption 'EndpointReboot' -IsOobSupported 0 -Model 'UCS-IOM-2204XP' -OobManageability @('Update', 'Inventory', 'Activate') -PackedVersion '4.1(2S16)' -RedfishUrl '/path/to/redfish/url' -Vendor 'Cisco Systems Inc.'

$tags1 = Initialize-IntersightMoTag -Key 'cisco.meta.distributabletype' -Value 'IMMFABRIC'

$tags2 = Initialize-IntersightMoTag -Key 'cisco.meta.repositorytype' -Value 'IntersightCloud'

$firmware_distributable = New-IntersightFirmwareDistributable -ComponentMeta @($component_meta1,$component_meta2) -Tags @($tags1,$tags2) -Description 'Cisco Intersight Infrastructure Bundle' -ImageCategory 'Unknown' -ImportAction 'None' -Md5Sum 'f4906255ae8f57ab5990066adba9e2f3' -Mdfid 'IS-4GFI' -Name 'ucs-intersight-infra' -Origin 'System' -Size 1355933747 -Vendor 'Cisco' -SupportedModels @('UCS-FI-6454')