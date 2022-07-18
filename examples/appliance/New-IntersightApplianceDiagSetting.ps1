$account1 = Get-IntersightIamaccount -Name 'admin'

$appliance_diag_setting1 = New-IntersightApplianceDiagSetting -Account $account1 -Password 'ChangeMe'