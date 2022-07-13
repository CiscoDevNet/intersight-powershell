#Get the NiatelemetryLc by Name
$NiatelemetryLcByName = Get-IntersightNiatelemetryLc -Name NiatelemetryLcName

#Get the List of ServerProfiles
$NiatelemetryLcList = Get-IntersightNiatelemetryLc

#Get the list of NiatelemetryLc under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryLcByOrg = Get-IntersightNiatelemetryLc -Organization $org

#Get the NiatelemetryLc based on query Parameter
$NiatelemetryLcByQueryParam = Get-IntersightNiatelemetryLc -Filter Name eq NiatelemetryLcName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .