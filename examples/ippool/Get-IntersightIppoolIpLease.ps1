#Get the IppoolIpLease by Name
$IppoolIpLeaseByName = Get-IntersightIppoolIpLease -Name IppoolIpLeaseName

#Get the List of ServerProfiles
$IppoolIpLeaseList = Get-IntersightIppoolIpLease

#Get the list of IppoolIpLease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IppoolIpLeaseByOrg = Get-IntersightIppoolIpLease -Organization $org

#Get the IppoolIpLease based on query Parameter
$IppoolIpLeaseByQueryParam = Get-IntersightIppoolIpLease -Filter Name eq IppoolIpLeaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .