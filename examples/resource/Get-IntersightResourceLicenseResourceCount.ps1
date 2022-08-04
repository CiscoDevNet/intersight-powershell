#Get the ResourceLicenseResourceCount by Name
$ResourceLicenseResourceCountByName = Get-IntersightResourceLicenseResourceCount -Name ResourceLicenseResourceCountName

#Get the List of ServerProfiles
$ResourceLicenseResourceCountList = Get-IntersightResourceLicenseResourceCount

#Get the list of ResourceLicenseResourceCount under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ResourceLicenseResourceCountByOrg = Get-IntersightResourceLicenseResourceCount -Organization $org

#Get the ResourceLicenseResourceCount based on query Parameter
$ResourceLicenseResourceCountByQueryParam = Get-IntersightResourceLicenseResourceCount -Filter Name eq ResourceLicenseResourceCountName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .