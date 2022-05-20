$app_catalog1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$constraint = Initialize-IntersightHyperflexAppSettingConstraint -HypervisorType ESXi -HxdpVersion "4.5" -MgmtPlatform FI -ServerModel 'HX' -DeploymentType Datacenter

$feature_limit_entries1 = Initialize-IntersightHyperflexFeaturelimitentry -Constraint $constraint -Name 'MAX_EXT_NODE' -Value '34'

$parent1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$hyperflex_feature_limit_external1 = New-IntersightHyperflexFeatureLimitExternal -AppCatalog $app_catalog1 -FeatureLimitEntries $feature_limit_entries1 -Parent $parent1