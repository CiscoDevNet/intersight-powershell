
#Get the UcsdBackupInfo to delete
$UcsdBackupInfo = Remove-IntersightUcsdBackupInfo -Name UcsdBackupInfoName
$UcsdBackupInfo | Remove-IntersightUcsdBackupInfo

#Remove the server profile by Moid.
Remove-IntersightUcsdBackupInfo -Moid 123bc2222287wee
