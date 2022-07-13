#Get the SearchTagItem by Name
$SearchTagItemByName = Get-IntersightSearchTagItem -Name SearchTagItemName

#Get the List of ServerProfiles
$SearchTagItemList = Get-IntersightSearchTagItem

#Get the list of SearchTagItem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SearchTagItemByOrg = Get-IntersightSearchTagItem -Organization $org

#Get the SearchTagItem based on query Parameter
$SearchTagItemByQueryParam = Get-IntersightSearchTagItem -Filter Name eq SearchTagItemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .