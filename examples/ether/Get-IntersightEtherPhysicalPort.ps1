#Get the EtherPhysicalPort by Name
$EtherPhysicalPortByName = Get-IntersightEtherPhysicalPort -Name EtherPhysicalPortName

#Get the List of ServerProfiles
$EtherPhysicalPortList = Get-IntersightEtherPhysicalPort

#Get the list of EtherPhysicalPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EtherPhysicalPortByOrg = Get-IntersightEtherPhysicalPort -Organization $org

#Get the EtherPhysicalPort based on query Parameter
$EtherPhysicalPortByQueryParam = Get-IntersightEtherPhysicalPort -Filter Name eq EtherPhysicalPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .