$feature_limit_internal1 = Get-IntersightHyperflexFeaturelimitinternal -Moid '<Replace with Moid>'

$hxdp_versions1 = Get-IntersightHyperflexHxdpversion -Moid '<Replace with Moid>'

$hyperflex_capability_infos1 = Get-IntersightHyperflexCapabilityinfo -Moid '<Replace with Moid>'

$hyperflex_software_compatibility_infos1 = Get-IntersightHclHyperflexsoftwarecompatibilityinfo -Moid '<Replace with Moid>'

$server_firmware_version1 = Get-IntersightHyperflexServerfirmwareversion -Moid '<Replace with Moid>'

$server_model1 = Get-IntersightHyperflexServermodel -Moid '<Replace with Moid>'

$software_distributions1 = Get-IntersightHyperflexSoftwaredistributionentry -Moid '<Replace with Moid>'

$hyperflex_app_catalog1 = New-IntersightHyperflexAppCatalog -FeatureLimitInternal $feature_limit_internal1 -HxdpVersions $hxdp_versions1 -HyperflexCapabilityInfos $hyperflex_capability_infos1 -HyperflexSoftwareCompatibilityInfos $hyperflex_software_compatibility_infos1 -ServerFirmwareVersion $server_firmware_version1 -ServerModel $server_model1 -SoftwareDistributions $software_distributions1