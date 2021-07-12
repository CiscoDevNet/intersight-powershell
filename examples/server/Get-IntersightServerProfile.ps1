#Get the ServerProfile by Name
$ServerProfileByName = Get-IntersightServerProfile -Name ServerProfileName

#Get the List of ServerProfiles
$ServerProfileList = Get-IntersightServerProfile

#Get the list of ServerProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ServerProfileByOrg = Get-IntersightServerProfile -Organization $org

#Get the ServerProfile based on query Parameter
$ServerProfileByQueryParam = Get-IntersightServerProfile -Filter Name eq ServerProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .