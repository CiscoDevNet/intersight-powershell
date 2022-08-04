#Get the InventoryDeviceInfo by Name
$InventoryDeviceInfoByName = Get-IntersightInventoryDeviceInfo -Name InventoryDeviceInfoName

#Get the List of ServerProfiles
$InventoryDeviceInfoList = Get-IntersightInventoryDeviceInfo

#Get the list of InventoryDeviceInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$InventoryDeviceInfoByOrg = Get-IntersightInventoryDeviceInfo -Organization $org

#Get the InventoryDeviceInfo based on query Parameter
$InventoryDeviceInfoByQueryParam = Get-IntersightInventoryDeviceInfo -Filter Name eq InventoryDeviceInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .