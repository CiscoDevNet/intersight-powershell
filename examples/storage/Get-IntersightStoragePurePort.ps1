#Get the StoragePurePort by Name
$StoragePurePortByName = Get-IntersightStoragePurePort -Name StoragePurePortName

#Get the List of ServerProfiles
$StoragePurePortList = Get-IntersightStoragePurePort

#Get the list of StoragePurePort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePurePortByOrg = Get-IntersightStoragePurePort -Organization $org

#Get the StoragePurePort based on query Parameter
$StoragePurePortByQueryParam = Get-IntersightStoragePurePort -Filter Name eq StoragePurePortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .