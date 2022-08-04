#Get the HyperflexHxapVirtualMachine by Name
$HyperflexHxapVirtualMachineByName = Get-IntersightHyperflexHxapVirtualMachine -Name HyperflexHxapVirtualMachineName

#Get the List of ServerProfiles
$HyperflexHxapVirtualMachineList = Get-IntersightHyperflexHxapVirtualMachine

#Get the list of HyperflexHxapVirtualMachine under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHxapVirtualMachineByOrg = Get-IntersightHyperflexHxapVirtualMachine -Organization $org

#Get the HyperflexHxapVirtualMachine based on query Parameter
$HyperflexHxapVirtualMachineByQueryParam = Get-IntersightHyperflexHxapVirtualMachine -Filter Name eq HyperflexHxapVirtualMachineName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .