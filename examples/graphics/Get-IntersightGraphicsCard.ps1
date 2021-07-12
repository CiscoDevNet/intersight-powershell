#Get the GraphicsCard by Name
$GraphicsCardByName = Get-IntersightGraphicsCard -Name GraphicsCardName

#Get the List of ServerProfiles
$GraphicsCardList = Get-IntersightGraphicsCard

#Get the list of GraphicsCard under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$GraphicsCardByOrg = Get-IntersightGraphicsCard -Organization $org

#Get the GraphicsCard based on query Parameter
$GraphicsCardByQueryParam = Get-IntersightGraphicsCard -Filter Name eq GraphicsCardName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .