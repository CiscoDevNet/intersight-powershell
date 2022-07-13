#Get the IppoolPool by Name
$IppoolPoolByName = Get-IntersightIppoolPool -Name IppoolPoolName

#Get the List of ServerProfiles
$IppoolPoolList = Get-IntersightIppoolPool

#Get the list of IppoolPool under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IppoolPoolByOrg = Get-IntersightIppoolPool -Organization $org

#Get the IppoolPool based on query Parameter
$IppoolPoolByQueryParam = Get-IntersightIppoolPool -Filter Name eq IppoolPoolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .