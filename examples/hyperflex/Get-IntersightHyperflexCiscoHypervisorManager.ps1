#Get the HyperflexCiscoHypervisorManager by Name
$HyperflexCiscoHypervisorManagerByName = Get-IntersightHyperflexCiscoHypervisorManager -Name HyperflexCiscoHypervisorManagerName

#Get the List of ServerProfiles
$HyperflexCiscoHypervisorManagerList = Get-IntersightHyperflexCiscoHypervisorManager

#Get the list of HyperflexCiscoHypervisorManager under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexCiscoHypervisorManagerByOrg = Get-IntersightHyperflexCiscoHypervisorManager -Organization $org

#Get the HyperflexCiscoHypervisorManager based on query Parameter
$HyperflexCiscoHypervisorManagerByQueryParam = Get-IntersightHyperflexCiscoHypervisorManager -Filter Name eq HyperflexCiscoHypervisorManagerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .