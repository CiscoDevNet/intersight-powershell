#Get the IamIpAddress by Name
$IamIpAddressByName = Get-IntersightIamIpAddress -Name IamIpAddressName

#Get the List of ServerProfiles
$IamIpAddressList = Get-IntersightIamIpAddress

#Get the list of IamIpAddress under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamIpAddressByOrg = Get-IntersightIamIpAddress -Organization $org

#Get the IamIpAddress based on query Parameter
$IamIpAddressByQueryParam = Get-IntersightIamIpAddress -Filter Name eq IamIpAddressName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .