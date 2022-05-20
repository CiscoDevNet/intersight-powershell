
#Get the UcsdBackupInfo to delete
$UcsdBackupInfo = Get-IntersightUcsdBackupInfo -Name UcsdBackupInfoName
$UcsdBackupInfo | Remove-IntersightUcsdBackupInfo

#Remove the UcsdBackupInfo by Moid.
Remove-IntersightUcsdBackupInfo -Moid '<Replace with Moid>'
