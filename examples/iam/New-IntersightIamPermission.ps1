$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$roles1 = Get-IntersightIamRole -Moid '<Replace with Moid>'

$users1 = Get-IntersightIamUser -Moid '<Replace with Moid>'

$iam_permission1 = New-IntersightIamPermission -Account $account1 -Roles $roles1 -Users $users1 -Name 'Device Technician'