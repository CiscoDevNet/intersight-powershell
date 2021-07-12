#Get the VnicIscsiBootPolicy by Name
$VnicIscsiBootPolicyByName = Get-IntersightVnicIscsiBootPolicy -Name VnicIscsiBootPolicyName

#Get the List of ServerProfiles
$VnicIscsiBootPolicyList = Get-IntersightVnicIscsiBootPolicy

#Get the list of VnicIscsiBootPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VnicIscsiBootPolicyByOrg = Get-IntersightVnicIscsiBootPolicy -Organization $org

#Get the VnicIscsiBootPolicy based on query Parameter
$VnicIscsiBootPolicyByQueryParam = Get-IntersightVnicIscsiBootPolicy -Filter Name eq VnicIscsiBootPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .