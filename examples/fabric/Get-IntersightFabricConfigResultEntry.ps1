#Get the FabricConfigResultEntry by Name
$FabricConfigResultEntryByName = Get-IntersightFabricConfigResultEntry -Name FabricConfigResultEntryName

#Get the List of ServerProfiles
$FabricConfigResultEntryList = Get-IntersightFabricConfigResultEntry

#Get the list of FabricConfigResultEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricConfigResultEntryByOrg = Get-IntersightFabricConfigResultEntry -Organization $org

#Get the FabricConfigResultEntry based on query Parameter
$FabricConfigResultEntryByQueryParam = Get-IntersightFabricConfigResultEntry -Filter Name eq FabricConfigResultEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .