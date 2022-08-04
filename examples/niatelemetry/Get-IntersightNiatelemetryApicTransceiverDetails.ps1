#Get the NiatelemetryApicTransceiverDetails by Name
$NiatelemetryApicTransceiverDetailsByName = Get-IntersightNiatelemetryApicTransceiverDetails -Name NiatelemetryApicTransceiverDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicTransceiverDetailsList = Get-IntersightNiatelemetryApicTransceiverDetails

#Get the list of NiatelemetryApicTransceiverDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicTransceiverDetailsByOrg = Get-IntersightNiatelemetryApicTransceiverDetails -Organization $org

#Get the NiatelemetryApicTransceiverDetails based on query Parameter
$NiatelemetryApicTransceiverDetailsByQueryParam = Get-IntersightNiatelemetryApicTransceiverDetails -Filter Name eq NiatelemetryApicTransceiverDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .