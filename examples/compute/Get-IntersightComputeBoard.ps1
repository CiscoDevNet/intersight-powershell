#Get the ComputeBoard by Name
$ComputeBoardByName = Get-IntersightComputeBoard -Name ComputeBoardName

#Get the List of ServerProfiles
$ComputeBoardList = Get-IntersightComputeBoard

#Get the list of ComputeBoard under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ComputeBoardByOrg = Get-IntersightComputeBoard -Organization $org

#Get the ComputeBoard based on query Parameter
$ComputeBoardByQueryParam = Get-IntersightComputeBoard -Filter Name eq ComputeBoardName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .