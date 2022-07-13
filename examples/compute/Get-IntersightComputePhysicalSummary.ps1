#Get the ComputePhysicalSummary by Name
$ComputePhysicalSummaryByName = Get-IntersightComputePhysicalSummary -Name ComputePhysicalSummaryName

#Get the List of ServerProfiles
$ComputePhysicalSummaryList = Get-IntersightComputePhysicalSummary

#Get the list of ComputePhysicalSummary under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ComputePhysicalSummaryByOrg = Get-IntersightComputePhysicalSummary -Organization $org

#Get the ComputePhysicalSummary based on query Parameter
$ComputePhysicalSummaryByQueryParam = Get-IntersightComputePhysicalSummary -Filter Name eq ComputePhysicalSummaryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .