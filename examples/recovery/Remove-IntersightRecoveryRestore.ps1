
#Get the RecoveryRestore to delete
$RecoveryRestore = Remove-IntersightRecoveryRestore -Name RecoveryRestoreName
$RecoveryRestore | Remove-IntersightRecoveryRestore

#Remove the server profile by Moid.
Remove-IntersightRecoveryRestore -Moid 123bc2222287wee
