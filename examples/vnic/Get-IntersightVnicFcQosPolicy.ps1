#Get the VnicFcQosPolicy by Name
$VnicFcQosPolicyByName = Get-IntersightVnicFcQosPolicy -Name VnicFcQosPolicyName

#Get the List of ServerProfiles
$VnicFcQosPolicyList = Get-IntersightVnicFcQosPolicy

#Get the list of VnicFcQosPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VnicFcQosPolicyByOrg = Get-IntersightVnicFcQosPolicy -Organization $org

#Get the VnicFcQosPolicy based on query Parameter
$VnicFcQosPolicyByQueryParam = Get-IntersightVnicFcQosPolicy -Filter Name eq VnicFcQosPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .