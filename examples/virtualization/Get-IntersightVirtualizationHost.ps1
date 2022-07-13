#Get the VirtualizationHost by Name
$VirtualizationHostByName = Get-IntersightVirtualizationHost -Name VirtualizationHostName

#Get the List of ServerProfiles
$VirtualizationHostList = Get-IntersightVirtualizationHost

#Get the list of VirtualizationHost under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationHostByOrg = Get-IntersightVirtualizationHost -Organization $org

#Get the VirtualizationHost based on query Parameter
$VirtualizationHostByQueryParam = Get-IntersightVirtualizationHost -Filter Name eq VirtualizationHostName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .