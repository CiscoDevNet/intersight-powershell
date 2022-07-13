#Get the StorageSasExpander by Name
$StorageSasExpanderByName = Get-IntersightStorageSasExpander -Name StorageSasExpanderName

#Get the List of ServerProfiles
$StorageSasExpanderList = Get-IntersightStorageSasExpander

#Get the list of StorageSasExpander under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageSasExpanderByOrg = Get-IntersightStorageSasExpander -Organization $org

#Get the StorageSasExpander based on query Parameter
$StorageSasExpanderByQueryParam = Get-IntersightStorageSasExpander -Filter Name eq StorageSasExpanderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .