$app_catalog1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$parent1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$constraint = Initialize-IntersightHyperflexAppSettingConstraint -HypervisorType ESXi -HxdpVersion "4.5" -MgmtPlatform FI -ServerModel 'HX' -DeploymentType Datacenter

$feature_limit_entries1 = Initialize-IntersightHyperflexFeaturelimitentry -Constraint $constraint -Name 'MAX_NODE' -Value '32'

$feature_limit_entries2 = Initialize-IntersightHyperflexFeaturelimitentry -Constraint $constraint -Name 'MAX_NODE' -Value '8'

$feature_limit_entries3 = Initialize-IntersightHyperflexFeaturelimitentry -Constraint $constraint -Name 'MAX_NODE' -Value '8' 

$hyperflex_feature_limit_internal1 = New-IntersightHyperflexFeatureLimitInternal -AppCatalog $app_catalog1 -Parent $parent1 -FeatureLimitEntries @($feature_limit_entries1,$feature_limit_entries2,$feature_limit_entries3)