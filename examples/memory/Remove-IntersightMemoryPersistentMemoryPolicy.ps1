
#Get the MemoryPersistentMemoryPolicy to delete
$MemoryPersistentMemoryPolicy = Get-IntersightMemoryPersistentMemoryPolicy -Name MemoryPersistentMemoryPolicyName
$MemoryPersistentMemoryPolicy | Remove-IntersightMemoryPersistentMemoryPolicy

#Remove the MemoryPersistentMemoryPolicy by Moid.
Remove-IntersightMemoryPersistentMemoryPolicy -Moid '<Replace with Moid>'

