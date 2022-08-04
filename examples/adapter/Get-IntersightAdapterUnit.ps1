#Get the AdapterUnit by Name
$AdapterUnitByName = Get-IntersightAdapterUnit -Name AdapterUnitName

#Get the List of ServerProfiles
$AdapterUnitList = Get-IntersightAdapterUnit

#Get the list of AdapterUnit under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AdapterUnitByOrg = Get-IntersightAdapterUnit -Organization $org

#Get the AdapterUnit based on query Parameter
$AdapterUnitByQueryParam = Get-IntersightAdapterUnit -Filter Name eq AdapterUnitName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .