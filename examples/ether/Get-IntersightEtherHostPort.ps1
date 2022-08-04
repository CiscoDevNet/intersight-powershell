#Get the EtherHostPort by Name
$EtherHostPortByName = Get-IntersightEtherHostPort -Name EtherHostPortName

#Get the List of ServerProfiles
$EtherHostPortList = Get-IntersightEtherHostPort

#Get the list of EtherHostPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EtherHostPortByOrg = Get-IntersightEtherHostPort -Organization $org

#Get the EtherHostPort based on query Parameter
$EtherHostPortByQueryParam = Get-IntersightEtherHostPort -Filter Name eq EtherHostPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .