$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$resource_groups1 = Get-IntersightResourceGroup -Moid '<Replace with Moid>'

$organization1 = New-IntersightOrganizationOrganization -Account $account1 -ResourceGroups $resource_groups1 -Name 'organization1'