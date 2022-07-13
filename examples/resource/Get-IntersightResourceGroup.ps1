#Get the ResourceGroup by Name
$ResourceGroupByName = Get-IntersightResourceGroup -Name ResourceGroupName

#Get the List of ServerProfiles
$ResourceGroupList = Get-IntersightResourceGroup

#Get the list of ResourceGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ResourceGroupByOrg = Get-IntersightResourceGroup -Organization $org

#Get the ResourceGroup based on query Parameter
$ResourceGroupByQueryParam = Get-IntersightResourceGroup -Filter Name eq ResourceGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .