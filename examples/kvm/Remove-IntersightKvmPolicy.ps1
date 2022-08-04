
#Get the KvmPolicy to delete
$KvmPolicy = Get-IntersightKvmPolicy -Name KvmPolicyName
$KvmPolicy | Remove-IntersightKvmPolicy

#Remove the KvmPolicy by Moid.
Remove-IntersightKvmPolicy -Moid '<Replace with Moid>'
