#Get the VirtualizationVmwareVirtualSwitch by Name
$VirtualizationVmwareVirtualSwitchByName = Get-IntersightVirtualizationVmwareVirtualSwitch -Name VirtualizationVmwareVirtualSwitchName

#Get the List of ServerProfiles
$VirtualizationVmwareVirtualSwitchList = Get-IntersightVirtualizationVmwareVirtualSwitch

#Get the list of VirtualizationVmwareVirtualSwitch under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareVirtualSwitchByOrg = Get-IntersightVirtualizationVmwareVirtualSwitch -Organization $org

#Get the VirtualizationVmwareVirtualSwitch based on query Parameter
$VirtualizationVmwareVirtualSwitchByQueryParam = Get-IntersightVirtualizationVmwareVirtualSwitch -Filter Name eq VirtualizationVmwareVirtualSwitchName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .