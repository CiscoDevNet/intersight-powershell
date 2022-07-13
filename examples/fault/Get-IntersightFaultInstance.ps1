#Get the FaultInstance by Name
$FaultInstanceByName = Get-IntersightFaultInstance -Name FaultInstanceName

#Get the List of ServerProfiles
$FaultInstanceList = Get-IntersightFaultInstance

#Get the list of FaultInstance under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FaultInstanceByOrg = Get-IntersightFaultInstance -Organization $org

#Get the FaultInstance based on query Parameter
$FaultInstanceByQueryParam = Get-IntersightFaultInstance -Filter Name eq FaultInstanceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .