#Get the VnicFcAdapterPolicy by Name
$VnicFcAdapterPolicyByName = Get-IntersightVnicFcAdapterPolicy -Name VnicFcAdapterPolicyName

#Get the List of ServerProfiles
$VnicFcAdapterPolicyList = Get-IntersightVnicFcAdapterPolicy

#Get the list of VnicFcAdapterPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicFcAdapterPolicyByOrg = Get-IntersightVnicFcAdapterPolicy -Organization $org

#Get the VnicFcAdapterPolicy based on query Parameter
$VnicFcAdapterPolicyByQueryParam = Get-IntersightVnicFcAdapterPolicy -Filter Name eq VnicFcAdapterPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .