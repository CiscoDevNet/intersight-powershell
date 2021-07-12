#Get the PortSubGroup by Name
$PortSubGroupByName = Get-IntersightPortSubGroup -Name PortSubGroupName

#Get the List of ServerProfiles
$PortSubGroupList = Get-IntersightPortSubGroup

#Get the list of PortSubGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$PortSubGroupByOrg = Get-IntersightPortSubGroup -Organization $org

#Get the PortSubGroup based on query Parameter
$PortSubGroupByQueryParam = Get-IntersightPortSubGroup -Filter Name eq PortSubGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .