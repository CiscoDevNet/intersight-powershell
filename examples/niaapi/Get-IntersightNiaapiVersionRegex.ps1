#Get the NiaapiVersionRegex by Name
$NiaapiVersionRegexByName = Get-IntersightNiaapiVersionRegex -Name NiaapiVersionRegexName

#Get the List of ServerProfiles
$NiaapiVersionRegexList = Get-IntersightNiaapiVersionRegex

#Get the list of NiaapiVersionRegex under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiVersionRegexByOrg = Get-IntersightNiaapiVersionRegex -Organization $org

#Get the NiaapiVersionRegex based on query Parameter
$NiaapiVersionRegexByQueryParam = Get-IntersightNiaapiVersionRegex -Filter Name eq NiaapiVersionRegexName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .