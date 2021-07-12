#Get the FabricElementIdentity by Name
$FabricElementIdentityByName = Get-IntersightFabricElementIdentity -Name FabricElementIdentityName

#Get the List of ServerProfiles
$FabricElementIdentityList = Get-IntersightFabricElementIdentity

#Get the list of FabricElementIdentity under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricElementIdentityByOrg = Get-IntersightFabricElementIdentity -Organization $org

#Get the FabricElementIdentity based on query Parameter
$FabricElementIdentityByQueryParam = Get-IntersightFabricElementIdentity -Filter Name eq FabricElementIdentityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .