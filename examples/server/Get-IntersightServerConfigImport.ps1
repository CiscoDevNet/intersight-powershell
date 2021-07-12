#Get the ServerConfigImport by Name
$ServerConfigImportByName = Get-IntersightServerConfigImport -Name ServerConfigImportName

#Get the List of ServerProfiles
$ServerConfigImportList = Get-IntersightServerConfigImport

#Get the list of ServerConfigImport under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ServerConfigImportByOrg = Get-IntersightServerConfigImport -Organization $org

#Get the ServerConfigImport based on query Parameter
$ServerConfigImportByQueryParam = Get-IntersightServerConfigImport -Filter Name eq ServerConfigImportName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .