#Get the ChassisConfigImport by Name
$ChassisConfigImportByName = Get-IntersightChassisConfigImport -Name ChassisConfigImportName

#Get the List of ServerProfiles
$ChassisConfigImportList = Get-IntersightChassisConfigImport

#Get the list of ChassisConfigImport under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ChassisConfigImportByOrg = Get-IntersightChassisConfigImport -Organization $org

#Get the ChassisConfigImport based on query Parameter
$ChassisConfigImportByQueryParam = Get-IntersightChassisConfigImport -Filter Name eq ChassisConfigImportName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .