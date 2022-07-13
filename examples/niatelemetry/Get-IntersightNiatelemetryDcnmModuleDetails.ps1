#Get the NiatelemetryDcnmModuleDetails by Name
$NiatelemetryDcnmModuleDetailsByName = Get-IntersightNiatelemetryDcnmModuleDetails -Name NiatelemetryDcnmModuleDetailsName

#Get the List of ServerProfiles
$NiatelemetryDcnmModuleDetailsList = Get-IntersightNiatelemetryDcnmModuleDetails

#Get the list of NiatelemetryDcnmModuleDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryDcnmModuleDetailsByOrg = Get-IntersightNiatelemetryDcnmModuleDetails -Organization $org

#Get the NiatelemetryDcnmModuleDetails based on query Parameter
$NiatelemetryDcnmModuleDetailsByQueryParam = Get-IntersightNiatelemetryDcnmModuleDetails -Filter Name eq NiatelemetryDcnmModuleDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .