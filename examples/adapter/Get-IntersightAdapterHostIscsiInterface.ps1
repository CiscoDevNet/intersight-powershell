#Get the AdapterHostIscsiInterface by Name
$AdapterHostIscsiInterfaceByName = Get-IntersightAdapterHostIscsiInterface -Name AdapterHostIscsiInterfaceName

#Get the List of ServerProfiles
$AdapterHostIscsiInterfaceList = Get-IntersightAdapterHostIscsiInterface

#Get the list of AdapterHostIscsiInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AdapterHostIscsiInterfaceByOrg = Get-IntersightAdapterHostIscsiInterface -Organization $org

#Get the AdapterHostIscsiInterface based on query Parameter
$AdapterHostIscsiInterfaceByQueryParam = Get-IntersightAdapterHostIscsiInterface -Filter Name eq AdapterHostIscsiInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .