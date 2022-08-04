$parent1 = Get-IntersightIamPermission -Moid '<Replace with Moid>'

$permission1 = Get-IntersightIamPermission -Moid '<Replace with Moid>'

$resource1 = Get-IntersightOrganizationOrganization -Name 'default'

$roles1 = Get-IntersightIamRole -Moid '<Replace with Moid>'

$iam_resource_roles1 = New-IntersightIamResourceRoles -Parent $parent1 -Permission $permission1 -Resource $resource1 -Roles $roles1