#Get the IqnpoolPool by Name
$IqnpoolPoolByName = Get-IntersightIqnpoolPool -Name IqnpoolPoolName

#Get the List of ServerProfiles
$IqnpoolPoolList = Get-IntersightIqnpoolPool

#Get the list of IqnpoolPool under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IqnpoolPoolByOrg = Get-IntersightIqnpoolPool -Organization $org

#Get the IqnpoolPool based on query Parameter
$IqnpoolPoolByQueryParam = Get-IntersightIqnpoolPool -Filter Name eq IqnpoolPoolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .