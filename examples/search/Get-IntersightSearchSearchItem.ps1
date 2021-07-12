#Get the SearchSearchItem by Name
$SearchSearchItemByName = Get-IntersightSearchSearchItem -Name SearchSearchItemName

#Get the List of ServerProfiles
$SearchSearchItemList = Get-IntersightSearchSearchItem

#Get the list of SearchSearchItem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SearchSearchItemByOrg = Get-IntersightSearchSearchItem -Organization $org

#Get the SearchSearchItem based on query Parameter
$SearchSearchItemByQueryParam = Get-IntersightSearchSearchItem -Filter Name eq SearchSearchItemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .