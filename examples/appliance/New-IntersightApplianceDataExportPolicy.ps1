$account = Get-IntersightIamaccount -Moid '<Replace with Moid>'

$appliance_data_export_policy1 = New-IntersightApplianceDataExportPolicy -Account $account -Name 'appliance_data_export1'