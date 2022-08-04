#Get the CloudSkuInstanceType by Name
$CloudSkuInstanceTypeByName = Get-IntersightCloudSkuInstanceType -Name CloudSkuInstanceTypeName

#Get the List of ServerProfiles
$CloudSkuInstanceTypeList = Get-IntersightCloudSkuInstanceType

#Get the list of CloudSkuInstanceType under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CloudSkuInstanceTypeByOrg = Get-IntersightCloudSkuInstanceType -Organization $org

#Get the CloudSkuInstanceType based on query Parameter
$CloudSkuInstanceTypeByQueryParam = Get-IntersightCloudSkuInstanceType -Filter Name eq CloudSkuInstanceTypeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .