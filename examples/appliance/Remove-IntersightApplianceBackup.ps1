
#Get the ApplianceBackup to delete
$ApplianceBackup = Remove-IntersightApplianceBackup -Name ApplianceBackupName
$ApplianceBackup | Remove-IntersightApplianceBackup

#Remove the server profile by Moid.
Remove-IntersightApplianceBackup -Moid 123bc2222287wee
