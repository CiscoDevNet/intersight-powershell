
#Get the KvmPolicy to delete
$KvmPolicy = Remove-IntersightKvmPolicy -Name KvmPolicyName
$KvmPolicy | Remove-IntersightKvmPolicy

#Remove the server profile by Moid.
Remove-IntersightKvmPolicy -Moid 123bc2222287wee
