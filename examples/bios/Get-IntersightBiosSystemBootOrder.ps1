#Get the BiosSystemBootOrder by Name
$BiosSystemBootOrderByName = Get-IntersightBiosSystemBootOrder -Name BiosSystemBootOrderName

#Get the List of ServerProfiles
$BiosSystemBootOrderList = Get-IntersightBiosSystemBootOrder

#Get the list of BiosSystemBootOrder under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BiosSystemBootOrderByOrg = Get-IntersightBiosSystemBootOrder -Organization $org

#Get the BiosSystemBootOrder based on query Parameter
$BiosSystemBootOrderByQueryParam = Get-IntersightBiosSystemBootOrder -Filter Name eq BiosSystemBootOrderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .