#Get the ServerProfileTemplate by Name
$ServerProfileTemplateByName = Get-IntersightServerProfileTemplate -Name ServerProfileTemplateName

#Get the List of ServerProfiles
$ServerProfileTemplateList = Get-IntersightServerProfileTemplate

#Get the list of ServerProfileTemplate under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ServerProfileTemplateByOrg = Get-IntersightServerProfileTemplate -Organization $org

#Get the ServerProfileTemplate based on query Parameter
$ServerProfileTemplateByQueryParam = Get-IntersightServerProfileTemplate -Filter Name eq ServerProfileTemplateName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .