#Get the VnicIscsiAdapterPolicy by Name
$VnicIscsiAdapterPolicyByName = Get-IntersightVnicIscsiAdapterPolicy -Name VnicIscsiAdapterPolicyName

#Get the List of ServerProfiles
$VnicIscsiAdapterPolicyList = Get-IntersightVnicIscsiAdapterPolicy

#Get the list of VnicIscsiAdapterPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicIscsiAdapterPolicyByOrg = Get-IntersightVnicIscsiAdapterPolicy -Organization $org

#Get the VnicIscsiAdapterPolicy based on query Parameter
$VnicIscsiAdapterPolicyByQueryParam = Get-IntersightVnicIscsiAdapterPolicy -Filter Name eq VnicIscsiAdapterPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .