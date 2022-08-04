#Get the NiatelemetryPasswordStrengthCheck by Name
$NiatelemetryPasswordStrengthCheckByName = Get-IntersightNiatelemetryPasswordStrengthCheck -Name NiatelemetryPasswordStrengthCheckName

#Get the List of ServerProfiles
$NiatelemetryPasswordStrengthCheckList = Get-IntersightNiatelemetryPasswordStrengthCheck

#Get the list of NiatelemetryPasswordStrengthCheck under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryPasswordStrengthCheckByOrg = Get-IntersightNiatelemetryPasswordStrengthCheck -Organization $org

#Get the NiatelemetryPasswordStrengthCheck based on query Parameter
$NiatelemetryPasswordStrengthCheckByQueryParam = Get-IntersightNiatelemetryPasswordStrengthCheck -Filter Name eq NiatelemetryPasswordStrengthCheckName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .