
#Get the KvmPolicy to delete
$KvmPolicy = Get-IntersightKvmPolicy -Name KvmPolicyName
$KvmPolicy | Set-IntersightKvmPolicy -Description 'Updated description'
