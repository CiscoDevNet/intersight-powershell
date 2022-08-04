#Get the FabricVsan by Name
$FabricVsanByName = Get-IntersightFabricVsan -Name FabricVsanName

#Get the List of ServerProfiles
$FabricVsanList = Get-IntersightFabricVsan

#Get the list of FabricVsan under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricVsanByOrg = Get-IntersightFabricVsan -Organization $org

#Get the FabricVsan based on query Parameter
$FabricVsanByQueryParam = Get-IntersightFabricVsan -Filter Name eq FabricVsanName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .