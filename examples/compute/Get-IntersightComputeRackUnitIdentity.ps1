#Get the ComputeRackUnitIdentity by Name
$ComputeRackUnitIdentityByName = Get-IntersightComputeRackUnitIdentity -Name ComputeRackUnitIdentityName

#Get the List of ServerProfiles
$ComputeRackUnitIdentityList = Get-IntersightComputeRackUnitIdentity

#Get the list of ComputeRackUnitIdentity under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ComputeRackUnitIdentityByOrg = Get-IntersightComputeRackUnitIdentity -Organization $org

#Get the ComputeRackUnitIdentity based on query Parameter
$ComputeRackUnitIdentityByQueryParam = Get-IntersightComputeRackUnitIdentity -Filter Name eq ComputeRackUnitIdentityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .