$app_catalog1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$parent1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$capability_constraints1 = Initialize-IntersightHclConstraint -ConstraintName 'targetHxdpVersion' -ConstraintValue '^4\.0.*$|^4\.5.*$'

$capability_constraints2 = Initialize-IntersightHclConstraint -ConstraintName 'serverPlatform' -ConstraintValue 'M4|M5'

$capability_constraints3 = Initialize-IntersightHclConstraint -ConstraintName 'mgmtPlatform' -ConstraintValue 'FI|EDGE'

$hyperflex_capability_info1 = New-IntersightHyperflexCapabilityInfo -AppCatalog $app_catalog1 -Parent $parent1 -CapabilityConstraints @($capability_constraints1,$capability_constraints2,$capability_constraints3) -Name 'minUcsVersion'