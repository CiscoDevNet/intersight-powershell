#Get the HyperflexSoftwareDistributionEntry by Name
$HyperflexSoftwareDistributionEntryByName = Get-IntersightHyperflexSoftwareDistributionEntry -Name HyperflexSoftwareDistributionEntryName

#Get the List of ServerProfiles
$HyperflexSoftwareDistributionEntryList = Get-IntersightHyperflexSoftwareDistributionEntry

#Get the list of HyperflexSoftwareDistributionEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexSoftwareDistributionEntryByOrg = Get-IntersightHyperflexSoftwareDistributionEntry -Organization $org

#Get the HyperflexSoftwareDistributionEntry based on query Parameter
$HyperflexSoftwareDistributionEntryByQueryParam = Get-IntersightHyperflexSoftwareDistributionEntry -Filter Name eq HyperflexSoftwareDistributionEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .