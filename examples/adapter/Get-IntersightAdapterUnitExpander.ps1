#Get the AdapterUnitExpander by Name
$AdapterUnitExpanderByName = Get-IntersightAdapterUnitExpander -Name AdapterUnitExpanderName

#Get the List of ServerProfiles
$AdapterUnitExpanderList = Get-IntersightAdapterUnitExpander

#Get the list of AdapterUnitExpander under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AdapterUnitExpanderByOrg = Get-IntersightAdapterUnitExpander -Organization $org

#Get the AdapterUnitExpander based on query Parameter
$AdapterUnitExpanderByQueryParam = Get-IntersightAdapterUnitExpander -Filter Name eq AdapterUnitExpanderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .