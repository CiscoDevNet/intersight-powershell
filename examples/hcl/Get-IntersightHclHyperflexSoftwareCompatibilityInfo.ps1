#Get the HclHyperflexSoftwareCompatibilityInfo by Name
$HclHyperflexSoftwareCompatibilityInfoByName = Get-IntersightHclHyperflexSoftwareCompatibilityInfo -Name HclHyperflexSoftwareCompatibilityInfoName

#Get the List of ServerProfiles
$HclHyperflexSoftwareCompatibilityInfoList = Get-IntersightHclHyperflexSoftwareCompatibilityInfo

#Get the list of HclHyperflexSoftwareCompatibilityInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HclHyperflexSoftwareCompatibilityInfoByOrg = Get-IntersightHclHyperflexSoftwareCompatibilityInfo -Organization $org

#Get the HclHyperflexSoftwareCompatibilityInfo based on query Parameter
$HclHyperflexSoftwareCompatibilityInfoByQueryParam = Get-IntersightHclHyperflexSoftwareCompatibilityInfo -Filter Name eq HclHyperflexSoftwareCompatibilityInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .