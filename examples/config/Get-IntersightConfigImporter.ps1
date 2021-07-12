#Get the ConfigImporter by Name
$ConfigImporterByName = Get-IntersightConfigImporter -Name ConfigImporterName

#Get the List of ServerProfiles
$ConfigImporterList = Get-IntersightConfigImporter

#Get the list of ConfigImporter under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ConfigImporterByOrg = Get-IntersightConfigImporter -Organization $org

#Get the ConfigImporter based on query Parameter
$ConfigImporterByQueryParam = Get-IntersightConfigImporter -Filter Name eq ConfigImporterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .