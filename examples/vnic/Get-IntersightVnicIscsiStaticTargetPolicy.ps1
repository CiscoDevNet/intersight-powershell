#Get the VnicIscsiStaticTargetPolicy by Name
$VnicIscsiStaticTargetPolicyByName = Get-IntersightVnicIscsiStaticTargetPolicy -Name VnicIscsiStaticTargetPolicyName

#Get the List of VnicIscsiStaticTargetPolicy
$VnicIscsiStaticTargetPolicyList = Get-IntersightVnicIscsiStaticTargetPolicy

#Get the list of VnicIscsiStaticTargetPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicIscsiStaticTargetPolicyByOrg = Get-IntersightVnicIscsiStaticTargetPolicy -Organization $org

#Get the VnicIscsiStaticTargetPolicy based on query Parameter
$VnicIscsiStaticTargetPolicyByQueryParam = Get-IntersightVnicIscsiStaticTargetPolicy -Filter Name eq VnicIscsiStaticTargetPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .