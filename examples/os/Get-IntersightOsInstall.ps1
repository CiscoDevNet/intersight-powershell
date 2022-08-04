#Get the OsInstall by Name
$OsInstallByName = Get-IntersightOsInstall -Name OsInstallName

#Get the List of ServerProfiles
$OsInstallList = Get-IntersightOsInstall

#Get the list of OsInstall under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$OsInstallByOrg = Get-IntersightOsInstall -Organization $org

#Get the OsInstall based on query Parameter
$OsInstallByQueryParam = Get-IntersightOsInstall -Filter Name eq OsInstallName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .