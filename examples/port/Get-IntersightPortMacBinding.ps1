#Get the PortMacBinding by Name
$PortMacBindingByName = Get-IntersightPortMacBinding -Name PortMacBindingName

#Get the List of ServerProfiles
$PortMacBindingList = Get-IntersightPortMacBinding

#Get the list of PortMacBinding under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$PortMacBindingByOrg = Get-IntersightPortMacBinding -Organization $org

#Get the PortMacBinding based on query Parameter
$PortMacBindingByQueryParam = Get-IntersightPortMacBinding -Filter Name eq PortMacBindingName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .