#Get the VnicEthIf by Name
$VnicEthIfByName = Get-IntersightVnicEthIf -Name VnicEthIfName

#Get the List of ServerProfiles
$VnicEthIfList = Get-IntersightVnicEthIf

#Get the list of VnicEthIf under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VnicEthIfByOrg = Get-IntersightVnicEthIf -Organization $org

#Get the VnicEthIf based on query Parameter
$VnicEthIfByQueryParam = Get-IntersightVnicEthIf -Filter Name eq VnicEthIfName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .