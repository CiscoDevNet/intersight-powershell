$key_spec1 = Initialize-IntersightPkixRsaalgorithm 

$parent1 = Get-IntersightIamUser -Moid '<Replace with Moid>'

$permission1 = Get-IntersightIamPermission -Moid '<Replace with Moid>'

$user1 = Get-IntersightIamUser -Moid '<Replace with Moid>'

$iam_api_key1 = New-IntersightIamApiKey -KeySpec $key_spec1 -Parent $parent1 -Permission $permission1 -User $user1 -HashAlgorithm SHA256 -Purpose 'admin api' -SigningAlgorithm RSASSAPKCS1V15 