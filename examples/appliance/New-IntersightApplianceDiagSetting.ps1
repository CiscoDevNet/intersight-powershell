$account1 = Get-IntersightIamaccount -Moid '<Replace with Moid>'

$appliance_diag_setting1 = New-IntersightApplianceDiagSetting -Account $account1 -Password 'ChangeMe'