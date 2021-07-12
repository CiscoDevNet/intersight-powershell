#Get the AdapterHostFcInterface by Name
$AdapterHostFcInterfaceByName = Get-IntersightAdapterHostFcInterface -Name AdapterHostFcInterfaceName

#Get the List of ServerProfiles
$AdapterHostFcInterfaceList = Get-IntersightAdapterHostFcInterface

#Get the list of AdapterHostFcInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AdapterHostFcInterfaceByOrg = Get-IntersightAdapterHostFcInterface -Organization $org

#Get the AdapterHostFcInterface based on query Parameter
$AdapterHostFcInterfaceByQueryParam = Get-IntersightAdapterHostFcInterface -Filter Name eq AdapterHostFcInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .