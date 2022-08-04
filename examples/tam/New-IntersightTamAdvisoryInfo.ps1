$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$tam_advisory_info = New-IntersightTamAdvisoryInfo -Account $account1 -State 'active'