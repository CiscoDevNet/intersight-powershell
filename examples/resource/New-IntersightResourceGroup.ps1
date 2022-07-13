$organizations1 = Get-IntersightOrganizationOrganization -Name 'default'

$resource_group1 = New-IntersightResourceGroup -Organizations $organizations1 -Name 'resource_group1' -Qualifier AllowSelectors