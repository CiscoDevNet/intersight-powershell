#Get the VirtualizationVmwareDistributedSwitch by Name
$VirtualizationVmwareDistributedSwitchByName = Get-IntersightVirtualizationVmwareDistributedSwitch -Name VirtualizationVmwareDistributedSwitchName

#Get the List of ServerProfiles
$VirtualizationVmwareDistributedSwitchList = Get-IntersightVirtualizationVmwareDistributedSwitch

#Get the list of VirtualizationVmwareDistributedSwitch under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVmwareDistributedSwitchByOrg = Get-IntersightVirtualizationVmwareDistributedSwitch -Organization $org

#Get the VirtualizationVmwareDistributedSwitch based on query Parameter
$VirtualizationVmwareDistributedSwitchByQueryParam = Get-IntersightVirtualizationVmwareDistributedSwitch -Filter Name eq VirtualizationVmwareDistributedSwitchName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .