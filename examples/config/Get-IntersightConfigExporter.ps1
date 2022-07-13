#Get the ConfigExporter by Name
$ConfigExporterByName = Get-IntersightConfigExporter -Name ConfigExporterName

#Get the List of ServerProfiles
$ConfigExporterList = Get-IntersightConfigExporter

#Get the list of ConfigExporter under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ConfigExporterByOrg = Get-IntersightConfigExporter -Organization $org

#Get the ConfigExporter based on query Parameter
$ConfigExporterByQueryParam = Get-IntersightConfigExporter -Filter Name eq ConfigExporterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .