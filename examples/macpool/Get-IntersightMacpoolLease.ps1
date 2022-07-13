#Get the MacpoolLease by Name
$MacpoolLeaseByName = Get-IntersightMacpoolLease -Name MacpoolLeaseName

#Get the List of ServerProfiles
$MacpoolLeaseList = Get-IntersightMacpoolLease

#Get the list of MacpoolLease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MacpoolLeaseByOrg = Get-IntersightMacpoolLease -Organization $org

#Get the MacpoolLease based on query Parameter
$MacpoolLeaseByQueryParam = Get-IntersightMacpoolLease -Filter Name eq MacpoolLeaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .