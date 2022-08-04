$idp1 = Get-IntersightIamIdp -Moid '<Replace with Moid>'

$permissions1 = Get-IntersightIamPermission -Moid '<Replace with Moid>'

$iam_user_group1 = New-IntersightIamUserGroup -Idp $idp1 -Permissions $permissions1 -Name 'iam_user_group1'