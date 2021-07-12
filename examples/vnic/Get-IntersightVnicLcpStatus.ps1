#Get the VnicLcpStatus by Name
$VnicLcpStatusByName = Get-IntersightVnicLcpStatus -Name VnicLcpStatusName

#Get the List of ServerProfiles
$VnicLcpStatusList = Get-IntersightVnicLcpStatus

#Get the list of VnicLcpStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VnicLcpStatusByOrg = Get-IntersightVnicLcpStatus -Organization $org

#Get the VnicLcpStatus based on query Parameter
$VnicLcpStatusByQueryParam = Get-IntersightVnicLcpStatus -Filter Name eq VnicLcpStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .