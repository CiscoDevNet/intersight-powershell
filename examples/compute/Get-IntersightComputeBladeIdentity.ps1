#Get the ComputeBladeIdentity by Name
$ComputeBladeIdentityByName = Get-IntersightComputeBladeIdentity -Name ComputeBladeIdentityName

#Get the List of ServerProfiles
$ComputeBladeIdentityList = Get-IntersightComputeBladeIdentity

#Get the list of ComputeBladeIdentity under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ComputeBladeIdentityByOrg = Get-IntersightComputeBladeIdentity -Organization $org

#Get the ComputeBladeIdentity based on query Parameter
$ComputeBladeIdentityByQueryParam = Get-IntersightComputeBladeIdentity -Filter Name eq ComputeBladeIdentityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .