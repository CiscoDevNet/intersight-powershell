#Get the NiatelemetryDcnmTransceiverDetails by Name
$NiatelemetryDcnmTransceiverDetailsByName = Get-IntersightNiatelemetryDcnmTransceiverDetails -Name NiatelemetryDcnmTransceiverDetailsName

#Get the List of ServerProfiles
$NiatelemetryDcnmTransceiverDetailsList = Get-IntersightNiatelemetryDcnmTransceiverDetails

#Get the list of NiatelemetryDcnmTransceiverDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryDcnmTransceiverDetailsByOrg = Get-IntersightNiatelemetryDcnmTransceiverDetails -Organization $org

#Get the NiatelemetryDcnmTransceiverDetails based on query Parameter
$NiatelemetryDcnmTransceiverDetailsByQueryParam = Get-IntersightNiatelemetryDcnmTransceiverDetails -Filter Name eq NiatelemetryDcnmTransceiverDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .