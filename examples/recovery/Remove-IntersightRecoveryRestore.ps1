
#Get the RecoveryRestore to delete
$RecoveryRestore = Remove-IntersightRecoveryRestore -Name RecoveryRestoreName
$RecoveryRestore | Remove-IntersightRecoveryRestore

#Remove the RecoveryRestore by Moid.
Remove-IntersightRecoveryRestore -Moid '<Replace with Moid>'
