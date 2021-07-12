#Get the VrfVrf by Name
$VrfVrfByName = Get-IntersightVrfVrf -Name VrfVrfName

#Get the List of ServerProfiles
$VrfVrfList = Get-IntersightVrfVrf

#Get the list of VrfVrf under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VrfVrfByOrg = Get-IntersightVrfVrf -Organization $org

#Get the VrfVrf based on query Parameter
$VrfVrfByQueryParam = Get-IntersightVrfVrf -Filter Name eq VrfVrfName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .