#Get the NiatelemetryEpg by Name
$NiatelemetryEpgByName = Get-IntersightNiatelemetryEpg -Name NiatelemetryEpgName

#Get the List of ServerProfiles
$NiatelemetryEpgList = Get-IntersightNiatelemetryEpg

#Get the list of NiatelemetryEpg under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryEpgByOrg = Get-IntersightNiatelemetryEpg -Organization $org

#Get the NiatelemetryEpg based on query Parameter
$NiatelemetryEpgByQueryParam = Get-IntersightNiatelemetryEpg -Filter Name eq NiatelemetryEpgName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .