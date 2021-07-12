#Get the IppoolBlockLease by Name
$IppoolBlockLeaseByName = Get-IntersightIppoolBlockLease -Name IppoolBlockLeaseName

#Get the List of ServerProfiles
$IppoolBlockLeaseList = Get-IntersightIppoolBlockLease

#Get the list of IppoolBlockLease under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IppoolBlockLeaseByOrg = Get-IntersightIppoolBlockLease -Organization $org

#Get the IppoolBlockLease based on query Parameter
$IppoolBlockLeaseByQueryParam = Get-IntersightIppoolBlockLease -Filter Name eq IppoolBlockLeaseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .