#Get the FabricConfigChangeDetail by Name
$FabricConfigChangeDetailByName = Get-IntersightFabricConfigChangeDetail -Name FabricConfigChangeDetailName

#Get the List of ServerProfiles
$FabricConfigChangeDetailList = Get-IntersightFabricConfigChangeDetail

#Get the list of FabricConfigChangeDetail under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricConfigChangeDetailByOrg = Get-IntersightFabricConfigChangeDetail -Organization $org

#Get the FabricConfigChangeDetail based on query Parameter
$FabricConfigChangeDetailByQueryParam = Get-IntersightFabricConfigChangeDetail -Filter Name eq FabricConfigChangeDetailName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .