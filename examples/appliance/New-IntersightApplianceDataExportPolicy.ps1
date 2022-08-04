$account = Get-IntersightIamaccount -Name 'admin'

$appliance_data_export_policy1 = New-IntersightApplianceDataExportPolicy -Account $account -Name 'appliance_data_export1'