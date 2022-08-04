$app_catalog1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$constraints1 = Initialize-IntersightHclConstraint -ConstraintName 'supportedOperations' -ConstraintValue 'UPGRADE'

$parent1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$hcl_hyperflex_software_compatibility_info1 = New-IntersightHclHyperflexSoftwareCompatibilityInfo -AppCatalog $app_catalog1 -Constraints $constraints1 -Parent $parent1 -HxdpVersion '4.5(1a)-39020' -HypervisorType 'ESXi' -HypervisorVersion 'HX-ESXi-7.0U1-17325551-Cisco-Custom-7.1.0.4' -ServerFwVersion '4.0(1a)'