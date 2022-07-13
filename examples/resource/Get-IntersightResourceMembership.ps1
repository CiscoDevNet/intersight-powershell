#Get the ResourceMembership by Name
$ResourceMembershipByName = Get-IntersightResourceMembership -Name ResourceMembershipName

#Get the List of ServerProfiles
$ResourceMembershipList = Get-IntersightResourceMembership

#Get the list of ResourceMembership under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ResourceMembershipByOrg = Get-IntersightResourceMembership -Organization $org

#Get the ResourceMembership based on query Parameter
$ResourceMembershipByQueryParam = Get-IntersightResourceMembership -Filter Name eq ResourceMembershipName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .