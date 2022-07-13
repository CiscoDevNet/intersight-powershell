#Get the VnicEthQosPolicy by Name
$VnicEthQosPolicyByName = Get-IntersightVnicEthQosPolicy -Name VnicEthQosPolicyName

#Get the List of ServerProfiles
$VnicEthQosPolicyList = Get-IntersightVnicEthQosPolicy

#Get the list of VnicEthQosPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicEthQosPolicyByOrg = Get-IntersightVnicEthQosPolicy -Organization $org

#Get the VnicEthQosPolicy based on query Parameter
$VnicEthQosPolicyByQueryParam = Get-IntersightVnicEthQosPolicy -Filter Name eq VnicEthQosPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .