#Get the FcpoolLease by Name
$FcpoolLeaseByName = Get-IntersightFcpoolLease -Name FcpoolLeaseName

#Get the List of ServerProfiles
$FcpoolLeaseList = Get-IntersightFcpoolLease

#Get the list of FcpoolLease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FcpoolLeaseByOrg = Get-IntersightFcpoolLease -Organization $org

#Get the FcpoolLease based on query Parameter
$FcpoolLeaseByQueryParam = Get-IntersightFcpoolLease -Filter Name eq FcpoolLeaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .