#Get the NiatelemetryMsoContractDetails by Name
$NiatelemetryMsoContractDetailsByName = Get-IntersightNiatelemetryMsoContractDetails -Name NiatelemetryMsoContractDetailsName

#Get the List of ServerProfiles
$NiatelemetryMsoContractDetailsList = Get-IntersightNiatelemetryMsoContractDetails

#Get the list of NiatelemetryMsoContractDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryMsoContractDetailsByOrg = Get-IntersightNiatelemetryMsoContractDetails -Organization $org

#Get the NiatelemetryMsoContractDetails based on query Parameter
$NiatelemetryMsoContractDetailsByQueryParam = Get-IntersightNiatelemetryMsoContractDetails -Filter Name eq NiatelemetryMsoContractDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .