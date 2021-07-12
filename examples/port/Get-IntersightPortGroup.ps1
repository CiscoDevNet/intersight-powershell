#Get the PortGroup by Name
$PortGroupByName = Get-IntersightPortGroup -Name PortGroupName

#Get the List of ServerProfiles
$PortGroupList = Get-IntersightPortGroup

#Get the list of PortGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$PortGroupByOrg = Get-IntersightPortGroup -Organization $org

#Get the PortGroup based on query Parameter
$PortGroupByQueryParam = Get-IntersightPortGroup -Filter Name eq PortGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .