#Get the GraphicsController by Name
$GraphicsControllerByName = Get-IntersightGraphicsController -Name GraphicsControllerName

#Get the List of ServerProfiles
$GraphicsControllerList = Get-IntersightGraphicsController

#Get the list of GraphicsController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$GraphicsControllerByOrg = Get-IntersightGraphicsController -Organization $org

#Get the GraphicsController based on query Parameter
$GraphicsControllerByQueryParam = Get-IntersightGraphicsController -Filter Name eq GraphicsControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .