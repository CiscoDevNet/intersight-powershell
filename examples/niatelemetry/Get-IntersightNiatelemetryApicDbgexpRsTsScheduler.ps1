#Get the NiatelemetryApicDbgexpRsTsScheduler by Name
$NiatelemetryApicDbgexpRsTsSchedulerByName = Get-IntersightNiatelemetryApicDbgexpRsTsScheduler -Name NiatelemetryApicDbgexpRsTsSchedulerName

#Get the List of ServerProfiles
$NiatelemetryApicDbgexpRsTsSchedulerList = Get-IntersightNiatelemetryApicDbgexpRsTsScheduler

#Get the list of NiatelemetryApicDbgexpRsTsScheduler under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryApicDbgexpRsTsSchedulerByOrg = Get-IntersightNiatelemetryApicDbgexpRsTsScheduler -Organization $org

#Get the NiatelemetryApicDbgexpRsTsScheduler based on query Parameter
$NiatelemetryApicDbgexpRsTsSchedulerByQueryParam = Get-IntersightNiatelemetryApicDbgexpRsTsScheduler -Filter Name eq NiatelemetryApicDbgexpRsTsSchedulerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .