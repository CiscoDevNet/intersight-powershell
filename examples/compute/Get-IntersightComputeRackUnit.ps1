#Get the ComputeRackUnit by Name
$ComputeRackUnitByName = Get-IntersightComputeRackUnit -Name ComputeRackUnitName

#Get the List of ServerProfiles
$ComputeRackUnitList = Get-IntersightComputeRackUnit

#Get the list of ComputeRackUnit under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ComputeRackUnitByOrg = Get-IntersightComputeRackUnit -Organization $org

#Get the ComputeRackUnit based on query Parameter
$ComputeRackUnitByQueryParam = Get-IntersightComputeRackUnit -Filter Name eq ComputeRackUnitName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .