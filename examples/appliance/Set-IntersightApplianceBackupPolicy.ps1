
#Get the ApplianceBackupPolicy to Update
$ApplianceBackupPolicy = Get-IntersightApplianceBackupPolicy -Moid '<Replace with Moid>'

$ApplianceBackupPolicy | Set-IntersightApplianceBackupPolicy -Protocol 'sftp'