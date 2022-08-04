
#Get the OsConfigurationFile to Update
$OsConfigurationFile = Get-IntersightOsConfigurationFile -Name OsConfigurationFileName
$OsConfigurationFile | Set-IntersightOsConfigurationFile -Description 'Updated description'