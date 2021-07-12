#Get the NiatelemetryApicSysLogSrc by Name
$NiatelemetryApicSysLogSrcByName = Get-IntersightNiatelemetryApicSysLogSrc -Name NiatelemetryApicSysLogSrcName

#Get the List of ServerProfiles
$NiatelemetryApicSysLogSrcList = Get-IntersightNiatelemetryApicSysLogSrc

#Get the list of NiatelemetryApicSysLogSrc under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryApicSysLogSrcByOrg = Get-IntersightNiatelemetryApicSysLogSrc -Organization $org

#Get the NiatelemetryApicSysLogSrc based on query Parameter
$NiatelemetryApicSysLogSrcByQueryParam = Get-IntersightNiatelemetryApicSysLogSrc -Filter Name eq NiatelemetryApicSysLogSrcName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .