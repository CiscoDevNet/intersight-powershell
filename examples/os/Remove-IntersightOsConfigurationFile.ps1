
#Get the OsConfigurationFile to delete
$OsConfigurationFile = Remove-IntersightOsConfigurationFile -Name OsConfigurationFileName
$OsConfigurationFile | Remove-IntersightOsConfigurationFile

#Remove the server profile by Moid.
Remove-IntersightOsConfigurationFile -Moid 123bc2222287wee
