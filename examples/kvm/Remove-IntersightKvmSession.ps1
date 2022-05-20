
#Get the KvmSession to delete
$KvmSession = Get-IntersightKvmSession -Name KvmSessionName
$KvmSession | Remove-IntersightKvmSession

#Remove the KvmSession by Moid.
Remove-IntersightKvmSession -Moid '<Replace with Moid>'
