
#Get the KvmSession to delete
$KvmSession = Remove-IntersightKvmSession -Name KvmSessionName
$KvmSession | Remove-IntersightKvmSession

#Remove the server profile by Moid.
Remove-IntersightKvmSession -Moid 123bc2222287wee
