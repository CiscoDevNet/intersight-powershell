#Get the CloudSkuNetworkType by Name
$CloudSkuNetworkTypeByName = Get-IntersightCloudSkuNetworkType -Name CloudSkuNetworkTypeName

#Get the List of ServerProfiles
$CloudSkuNetworkTypeList = Get-IntersightCloudSkuNetworkType

#Get the list of CloudSkuNetworkType under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CloudSkuNetworkTypeByOrg = Get-IntersightCloudSkuNetworkType -Organization $org

#Get the CloudSkuNetworkType based on query Parameter
$CloudSkuNetworkTypeByQueryParam = Get-IntersightCloudSkuNetworkType -Filter Name eq CloudSkuNetworkTypeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .