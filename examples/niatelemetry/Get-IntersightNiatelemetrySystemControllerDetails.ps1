#Get the NiatelemetrySystemControllerDetails by Name
$NiatelemetrySystemControllerDetailsByName = Get-IntersightNiatelemetrySystemControllerDetails -Name NiatelemetrySystemControllerDetailsName

#Get the List of ServerProfiles
$NiatelemetrySystemControllerDetailsList = Get-IntersightNiatelemetrySystemControllerDetails

#Get the list of NiatelemetrySystemControllerDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetrySystemControllerDetailsByOrg = Get-IntersightNiatelemetrySystemControllerDetails -Organization $org

#Get the NiatelemetrySystemControllerDetails based on query Parameter
$NiatelemetrySystemControllerDetailsByQueryParam = Get-IntersightNiatelemetrySystemControllerDetails -Filter Name eq NiatelemetrySystemControllerDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .