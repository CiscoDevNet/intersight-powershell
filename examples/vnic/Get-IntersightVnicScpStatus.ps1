#Get the VnicScpStatus by Name
$VnicScpStatusByName = Get-IntersightVnicScpStatus -Name VnicScpStatusName

#Get the List of ServerProfiles
$VnicScpStatusList = Get-IntersightVnicScpStatus

#Get the list of VnicScpStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VnicScpStatusByOrg = Get-IntersightVnicScpStatus -Organization $org

#Get the VnicScpStatus based on query Parameter
$VnicScpStatusByQueryParam = Get-IntersightVnicScpStatus -Filter Name eq VnicScpStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .