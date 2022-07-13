#Get the NiatelemetryApicNtpAuth by Name
$NiatelemetryApicNtpAuthByName = Get-IntersightNiatelemetryApicNtpAuth -Name NiatelemetryApicNtpAuthName

#Get the List of ServerProfiles
$NiatelemetryApicNtpAuthList = Get-IntersightNiatelemetryApicNtpAuth

#Get the list of NiatelemetryApicNtpAuth under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicNtpAuthByOrg = Get-IntersightNiatelemetryApicNtpAuth -Organization $org

#Get the NiatelemetryApicNtpAuth based on query Parameter
$NiatelemetryApicNtpAuthByQueryParam = Get-IntersightNiatelemetryApicNtpAuth -Filter Name eq NiatelemetryApicNtpAuthName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .