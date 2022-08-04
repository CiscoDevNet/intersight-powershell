#Get the ResourceMembershipHolder by Name
$ResourceMembershipHolderByName = Get-IntersightResourceMembershipHolder -Name ResourceMembershipHolderName

#Get the List of ServerProfiles
$ResourceMembershipHolderList = Get-IntersightResourceMembershipHolder

#Get the list of ResourceMembershipHolder under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ResourceMembershipHolderByOrg = Get-IntersightResourceMembershipHolder -Organization $org

#Get the ResourceMembershipHolder based on query Parameter
$ResourceMembershipHolderByQueryParam = Get-IntersightResourceMembershipHolder -Filter Name eq ResourceMembershipHolderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .