$organizations1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$resource_group1 = New-IntersightResourceGroup -Organizations $organizations1 -Name 'resource_group1' -Qualifier AllowSelectors