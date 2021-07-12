#Get the ComputeMapping by Name
$ComputeMappingByName = Get-IntersightComputeMapping -Name ComputeMappingName

#Get the List of ServerProfiles
$ComputeMappingList = Get-IntersightComputeMapping

#Get the list of ComputeMapping under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ComputeMappingByOrg = Get-IntersightComputeMapping -Organization $org

#Get the ComputeMapping based on query Parameter
$ComputeMappingByQueryParam = Get-IntersightComputeMapping -Filter Name eq ComputeMappingName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .