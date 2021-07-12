#Get the ApplianceRemoteFileImport by Name
$ApplianceRemoteFileImportByName = Get-IntersightApplianceRemoteFileImport -Name ApplianceRemoteFileImportName

#Get the List of ServerProfiles
$ApplianceRemoteFileImportList = Get-IntersightApplianceRemoteFileImport

#Get the list of ApplianceRemoteFileImport under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceRemoteFileImportByOrg = Get-IntersightApplianceRemoteFileImport -Organization $org

#Get the ApplianceRemoteFileImport based on query Parameter
$ApplianceRemoteFileImportByQueryParam = Get-IntersightApplianceRemoteFileImport -Filter Name eq ApplianceRemoteFileImportName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .