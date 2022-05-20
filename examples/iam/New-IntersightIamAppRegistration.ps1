$roles1 = Get-IntersightIamRole -Moid '<Replace with Moid>'

$permission1 = Get-IntersightIamPermission -Moid '<Replace with Moid>'

$iam_app_registration1 = New-IntersightIamAppRegistration -Roles $roles1 -Permission $permission1 -ClientName 'name1' -ClientType Confidential -Revoke 1 -RenewClientSecret 1