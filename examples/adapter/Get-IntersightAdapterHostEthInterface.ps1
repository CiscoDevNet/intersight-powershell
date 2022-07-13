#Get the AdapterHostEthInterface by Name
$AdapterHostEthInterfaceByName = Get-IntersightAdapterHostEthInterface -Name AdapterHostEthInterfaceName

#Get the List of ServerProfiles
$AdapterHostEthInterfaceList = Get-IntersightAdapterHostEthInterface

#Get the list of AdapterHostEthInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AdapterHostEthInterfaceByOrg = Get-IntersightAdapterHostEthInterface -Organization $org

#Get the AdapterHostEthInterface based on query Parameter
$AdapterHostEthInterfaceByQueryParam = Get-IntersightAdapterHostEthInterface -Filter Name eq AdapterHostEthInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .