
#Get the MemoryPersistentMemoryPolicy to delete
$MemoryPersistentMemoryPolicy = Remove-IntersightMemoryPersistentMemoryPolicy -Name MemoryPersistentMemoryPolicyName
$MemoryPersistentMemoryPolicy | Remove-IntersightMemoryPersistentMemoryPolicy

#Remove the server profile by Moid.
Remove-IntersightMemoryPersistentMemoryPolicy -Moid 123bc2222287wee
