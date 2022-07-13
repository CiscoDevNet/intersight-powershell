#Get the EtherNetworkPort by Name
$EtherNetworkPortByName = Get-IntersightEtherNetworkPort -Name EtherNetworkPortName

#Get the List of ServerProfiles
$EtherNetworkPortList = Get-IntersightEtherNetworkPort

#Get the list of EtherNetworkPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EtherNetworkPortByOrg = Get-IntersightEtherNetworkPort -Organization $org

#Get the EtherNetworkPort based on query Parameter
$EtherNetworkPortByQueryParam = Get-IntersightEtherNetworkPort -Filter Name eq EtherNetworkPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .