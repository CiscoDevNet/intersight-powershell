#Get the IqnpoolLease by Name
$IqnpoolLeaseByName = Get-IntersightIqnpoolLease -Name IqnpoolLeaseName

#Get the List of ServerProfiles
$IqnpoolLeaseList = Get-IntersightIqnpoolLease

#Get the list of IqnpoolLease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IqnpoolLeaseByOrg = Get-IntersightIqnpoolLease -Organization $org

#Get the IqnpoolLease based on query Parameter
$IqnpoolLeaseByQueryParam = Get-IntersightIqnpoolLease -Filter Name eq IqnpoolLeaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .