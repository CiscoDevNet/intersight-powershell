#Get the NiatelemetryApicSysLogGrp by Name
$NiatelemetryApicSysLogGrpByName = Get-IntersightNiatelemetryApicSysLogGrp -Name NiatelemetryApicSysLogGrpName

#Get the List of ServerProfiles
$NiatelemetryApicSysLogGrpList = Get-IntersightNiatelemetryApicSysLogGrp

#Get the list of NiatelemetryApicSysLogGrp under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryApicSysLogGrpByOrg = Get-IntersightNiatelemetryApicSysLogGrp -Organization $org

#Get the NiatelemetryApicSysLogGrp based on query Parameter
$NiatelemetryApicSysLogGrpByQueryParam = Get-IntersightNiatelemetryApicSysLogGrp -Filter Name eq NiatelemetryApicSysLogGrpName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .