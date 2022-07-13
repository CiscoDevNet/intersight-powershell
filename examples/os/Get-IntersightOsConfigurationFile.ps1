#Get the OsConfigurationFile by Name
$OsConfigurationFileByName = Get-IntersightOsConfigurationFile -Name OsConfigurationFileName

#Get the List of ServerProfiles
$OsConfigurationFileList = Get-IntersightOsConfigurationFile

#Get the list of OsConfigurationFile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$OsConfigurationFileByOrg = Get-IntersightOsConfigurationFile -Organization $org

#Get the OsConfigurationFile based on query Parameter
$OsConfigurationFileByQueryParam = Get-IntersightOsConfigurationFile -Filter Name eq OsConfigurationFileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .