#Get the VnicFcIf by Name
$VnicFcIfByName = Get-IntersightVnicFcIf -Name VnicFcIfName

#Get the List of ServerProfiles
$VnicFcIfList = Get-IntersightVnicFcIf

#Get the list of VnicFcIf under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicFcIfByOrg = Get-IntersightVnicFcIf -Organization $org

#Get the VnicFcIf based on query Parameter
$VnicFcIfByQueryParam = Get-IntersightVnicFcIf -Filter Name eq VnicFcIfName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .