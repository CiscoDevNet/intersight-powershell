#Get the CloudSkuContainerType by Name
$CloudSkuContainerTypeByName = Get-IntersightCloudSkuContainerType -Name CloudSkuContainerTypeName

#Get the List of ServerProfiles
$CloudSkuContainerTypeList = Get-IntersightCloudSkuContainerType

#Get the list of CloudSkuContainerType under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CloudSkuContainerTypeByOrg = Get-IntersightCloudSkuContainerType -Organization $org

#Get the CloudSkuContainerType based on query Parameter
$CloudSkuContainerTypeByQueryParam = Get-IntersightCloudSkuContainerType -Filter Name eq CloudSkuContainerTypeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .