#Get the VmediaPolicy by Name
$VmediaPolicyByName = Get-IntersightVmediaPolicy -Name VmediaPolicyName

#Get the List of VmediaPolicy
$VmediaPolicyList = Get-IntersightVmediaPolicy

#Get the list of VmediaPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VmediaPolicyByOrg = Get-IntersightVmediaPolicy -Organization $org

#Get the VmediaPolicy based on query Parameter
$VmediaPolicyByQueryParam = Get-IntersightVmediaPolicy -Filter Name eq VmediaPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .