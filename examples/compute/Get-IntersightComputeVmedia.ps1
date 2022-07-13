#Get the ComputeVmedia by Name
$ComputeVmediaByName = Get-IntersightComputeVmedia -Name ComputeVmediaName

#Get the List of ServerProfiles
$ComputeVmediaList = Get-IntersightComputeVmedia

#Get the list of ComputeVmedia under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ComputeVmediaByOrg = Get-IntersightComputeVmedia -Organization $org

#Get the ComputeVmedia based on query Parameter
$ComputeVmediaByQueryParam = Get-IntersightComputeVmedia -Filter Name eq ComputeVmediaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .