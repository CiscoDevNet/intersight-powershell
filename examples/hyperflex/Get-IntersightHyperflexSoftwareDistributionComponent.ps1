#Get the HyperflexSoftwareDistributionComponent by Name
$HyperflexSoftwareDistributionComponentByName = Get-IntersightHyperflexSoftwareDistributionComponent -Name HyperflexSoftwareDistributionComponentName

#Get the List of ServerProfiles
$HyperflexSoftwareDistributionComponentList = Get-IntersightHyperflexSoftwareDistributionComponent

#Get the list of HyperflexSoftwareDistributionComponent under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexSoftwareDistributionComponentByOrg = Get-IntersightHyperflexSoftwareDistributionComponent -Organization $org

#Get the HyperflexSoftwareDistributionComponent based on query Parameter
$HyperflexSoftwareDistributionComponentByQueryParam = Get-IntersightHyperflexSoftwareDistributionComponent -Filter Name eq HyperflexSoftwareDistributionComponentName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .