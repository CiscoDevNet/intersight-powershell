$idpreference1 = Get-IntersightIamIdpreference -Moid '<Replace with Moid>'

$parent1 = Get-IntersightIamIdpreference -Moid '<Replace with Moid>'

$permissions1 = Get-IntersightIamPermission -Moid '<Replace with Moid>'

$iam_user1 = New-IntersightIamUser -Idpreference $idpreference1 -Parent $parent1 -Permissions $permissions1 -Email 'email@example.com' -UserIdOrEmail 'email@example.com'