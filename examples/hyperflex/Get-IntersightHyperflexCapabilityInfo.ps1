#Get the HyperflexCapabilityInfo by Name
$HyperflexCapabilityInfoByName = Get-IntersightHyperflexCapabilityInfo -Name HyperflexCapabilityInfoName

#Get the List of ServerProfiles
$HyperflexCapabilityInfoList = Get-IntersightHyperflexCapabilityInfo

#Get the list of HyperflexCapabilityInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexCapabilityInfoByOrg = Get-IntersightHyperflexCapabilityInfo -Organization $org

#Get the HyperflexCapabilityInfo based on query Parameter
$HyperflexCapabilityInfoByQueryParam = Get-IntersightHyperflexCapabilityInfo -Filter Name eq HyperflexCapabilityInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .