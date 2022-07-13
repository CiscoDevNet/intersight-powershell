#Get the KvmTunnel by Name
$KvmTunnelByName = Get-IntersightKvmTunnel -Name KvmTunnelName

#Get the List of ServerProfiles
$KvmTunnelList = Get-IntersightKvmTunnel

#Get the list of KvmTunnel under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KvmTunnelByOrg = Get-IntersightKvmTunnel -Organization $org

#Get the KvmTunnel based on query Parameter
$KvmTunnelByQueryParam = Get-IntersightKvmTunnel -Filter Name eq KvmTunnelName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .