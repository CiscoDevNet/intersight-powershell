#Get the NiatelemetryMsoSchemaDetails by Name
$NiatelemetryMsoSchemaDetailsByName = Get-IntersightNiatelemetryMsoSchemaDetails -Name NiatelemetryMsoSchemaDetailsName

#Get the List of ServerProfiles
$NiatelemetryMsoSchemaDetailsList = Get-IntersightNiatelemetryMsoSchemaDetails

#Get the list of NiatelemetryMsoSchemaDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryMsoSchemaDetailsByOrg = Get-IntersightNiatelemetryMsoSchemaDetails -Organization $org

#Get the NiatelemetryMsoSchemaDetails based on query Parameter
$NiatelemetryMsoSchemaDetailsByQueryParam = Get-IntersightNiatelemetryMsoSchemaDetails -Filter Name eq NiatelemetryMsoSchemaDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .