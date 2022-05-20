$capabilities1 = Get-IntersightCapabilitySiocmodulemanufacturingdef -Moid '<Replace with Moid>'

$capabilities1 = Get-IntersightCapabilitySiocmodulecapabilitydef -Moid '<Replace with Moid>'

$capability_sioc_module_descriptor1 = New-IntersightCapabilitySiocModuleDescriptor -Capabilities @($capabilities1,$capabilities2) -Description 'capability of sioc module descriptor' -Model 'UCS-S3260-PCISIOC' -Revision '0' -Vendor 'Cisco Systems Inc'