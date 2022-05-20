
#Get the ApplianceBackup to delete
$ApplianceBackup = Get-IntersightApplianceBackup -Name ApplianceBackupName
$ApplianceBackup | Remove-IntersightApplianceBackup

#Remove the ApplianceBackup by Moid.
Remove-IntersightApplianceBackup -Moid '<Replace with Moid>'
