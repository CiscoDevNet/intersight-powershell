#Get the OsSupportedVersion by Name
$OsSupportedVersionByName = Get-IntersightOsSupportedVersion -Name OsSupportedVersionName

#Get the List of ServerProfiles
$OsSupportedVersionList = Get-IntersightOsSupportedVersion

#Get the list of OsSupportedVersion under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$OsSupportedVersionByOrg = Get-IntersightOsSupportedVersion -Organization $org

#Get the OsSupportedVersion based on query Parameter
$OsSupportedVersionByQueryParam = Get-IntersightOsSupportedVersion -Filter Name eq OsSupportedVersionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .