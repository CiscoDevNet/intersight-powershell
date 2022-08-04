#Get the BiosPolicy by Name
$BiosPolicyByName = Get-IntersightBiosPolicy -Name BiosPolicyName

#Get the List of ServerProfiles
$BiosPolicyList = Get-IntersightBiosPolicy

#Get the list of BiosPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$BiosPolicyByOrg = Get-IntersightBiosPolicy -Organization $org

#Get the BiosPolicy based on query Parameter
$BiosPolicyByQueryParam = Get-IntersightBiosPolicy -Filter Name eq BiosPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .