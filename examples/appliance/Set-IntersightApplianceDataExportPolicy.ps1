$account = Get-IntersightIamaccount -Name 'admin'

# Get the AccessPolicy to Update
$ApplianceDataExportPolicy = Get-IntersightApplianceDataExportPolicy -Name 'appliance_data_export1'

$ApplianceDataExportPolicy | Set-IntersightApplianceDataExportPolicy -Account $account

