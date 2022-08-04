#Get the CloudSkuDatabaseType by Name
$CloudSkuDatabaseTypeByName = Get-IntersightCloudSkuDatabaseType -Name CloudSkuDatabaseTypeName

#Get the List of ServerProfiles
$CloudSkuDatabaseTypeList = Get-IntersightCloudSkuDatabaseType

#Get the list of CloudSkuDatabaseType under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CloudSkuDatabaseTypeByOrg = Get-IntersightCloudSkuDatabaseType -Organization $org

#Get the CloudSkuDatabaseType based on query Parameter
$CloudSkuDatabaseTypeByQueryParam = Get-IntersightCloudSkuDatabaseType -Filter Name eq CloudSkuDatabaseTypeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .