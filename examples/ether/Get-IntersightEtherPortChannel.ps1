#Get the EtherPortChannel by Name
$EtherPortChannelByName = Get-IntersightEtherPortChannel -Name EtherPortChannelName

#Get the List of ServerProfiles
$EtherPortChannelList = Get-IntersightEtherPortChannel

#Get the list of EtherPortChannel under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EtherPortChannelByOrg = Get-IntersightEtherPortChannel -Organization $org

#Get the EtherPortChannel based on query Parameter
$EtherPortChannelByQueryParam = Get-IntersightEtherPortChannel -Filter Name eq EtherPortChannelName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .