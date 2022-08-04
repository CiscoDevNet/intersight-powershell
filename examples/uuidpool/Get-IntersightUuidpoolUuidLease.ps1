#Get the UuidpoolUuidLease by Name
$UuidpoolUuidLeaseByName = Get-IntersightUuidpoolUuidLease -Name UuidpoolUuidLeaseName

#Get the List of ServerProfiles
$UuidpoolUuidLeaseList = Get-IntersightUuidpoolUuidLease

#Get the list of UuidpoolUuidLease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$UuidpoolUuidLeaseByOrg = Get-IntersightUuidpoolUuidLease -Organization $org

#Get the UuidpoolUuidLease based on query Parameter
$UuidpoolUuidLeaseByQueryParam = Get-IntersightUuidpoolUuidLease -Filter Name eq UuidpoolUuidLeaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .