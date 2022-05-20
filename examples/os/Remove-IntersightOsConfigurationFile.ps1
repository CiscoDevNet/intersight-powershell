
#Get the OsConfigurationFile to delete
$OsConfigurationFile = Get-IntersightOsConfigurationFile -Name OsConfigurationFileName
$OsConfigurationFile | Remove-IntersightOsConfigurationFile

#Remove the OsConfigurationFile by Moid.
Remove-IntersightOsConfigurationFile -Moid '<Replace with Moid>'
