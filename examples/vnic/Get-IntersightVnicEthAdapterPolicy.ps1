#Get the VnicEthAdapterPolicy by Name
$VnicEthAdapterPolicyByName = Get-IntersightVnicEthAdapterPolicy -Name VnicEthAdapterPolicyName

#Get the List of ServerProfiles
$VnicEthAdapterPolicyList = Get-IntersightVnicEthAdapterPolicy

#Get the list of VnicEthAdapterPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VnicEthAdapterPolicyByOrg = Get-IntersightVnicEthAdapterPolicy -Organization $org

#Get the VnicEthAdapterPolicy based on query Parameter
$VnicEthAdapterPolicyByQueryParam = Get-IntersightVnicEthAdapterPolicy -Filter Name eq VnicEthAdapterPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .