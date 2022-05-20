$app_catalog1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$parent1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$constraint = Initialize-IntersightHyperflexAppSettingConstraint -HypervisorType ESXi -HxdpVersion "4.5" -MgmtPlatform FI -ServerModel 'HX' -DeploymentType Datacenter

$server_model_entries1 = Initialize-IntersightHyperflexServermodelentry -Constraint $constraint -Name 'SERVER_MODEL' -Value '^HX'

$server_model_entries2 = Initialize-IntersightHyperflexServermodelentry -Constraint $constraint -Name 'SERVER_MODEL' -Value 'HX.*M(4|5).*' 

$hyperflex_server_model1 = New-IntersightHyperflexServerModel -AppCatalog $app_catalog1 -Parent $parent1 -ServerModelEntries @($server_model_entries1,$server_model_entries2)