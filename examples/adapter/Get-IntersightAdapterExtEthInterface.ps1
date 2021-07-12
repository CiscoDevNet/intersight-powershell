#Get the AdapterExtEthInterface by Name
$AdapterExtEthInterfaceByName = Get-IntersightAdapterExtEthInterface -Name AdapterExtEthInterfaceName

#Get the List of ServerProfiles
$AdapterExtEthInterfaceList = Get-IntersightAdapterExtEthInterface

#Get the list of AdapterExtEthInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AdapterExtEthInterfaceByOrg = Get-IntersightAdapterExtEthInterface -Organization $org

#Get the AdapterExtEthInterface based on query Parameter
$AdapterExtEthInterfaceByQueryParam = Get-IntersightAdapterExtEthInterface -Filter Name eq AdapterExtEthInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .