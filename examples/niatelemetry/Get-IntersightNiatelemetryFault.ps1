#Get the NiatelemetryFault by Name
$NiatelemetryFaultByName = Get-IntersightNiatelemetryFault -Name NiatelemetryFaultName

#Get the List of ServerProfiles
$NiatelemetryFaultList = Get-IntersightNiatelemetryFault

#Get the list of NiatelemetryFault under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryFaultByOrg = Get-IntersightNiatelemetryFault -Organization $org

#Get the NiatelemetryFault based on query Parameter
$NiatelemetryFaultByQueryParam = Get-IntersightNiatelemetryFault -Filter Name eq NiatelemetryFaultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .