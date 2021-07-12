#Get the NiatelemetryApicDbgexpRsExportDest by Name
$NiatelemetryApicDbgexpRsExportDestByName = Get-IntersightNiatelemetryApicDbgexpRsExportDest -Name NiatelemetryApicDbgexpRsExportDestName

#Get the List of ServerProfiles
$NiatelemetryApicDbgexpRsExportDestList = Get-IntersightNiatelemetryApicDbgexpRsExportDest

#Get the list of NiatelemetryApicDbgexpRsExportDest under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryApicDbgexpRsExportDestByOrg = Get-IntersightNiatelemetryApicDbgexpRsExportDest -Organization $org

#Get the NiatelemetryApicDbgexpRsExportDest based on query Parameter
$NiatelemetryApicDbgexpRsExportDestByQueryParam = Get-IntersightNiatelemetryApicDbgexpRsExportDest -Filter Name eq NiatelemetryApicDbgexpRsExportDestName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .