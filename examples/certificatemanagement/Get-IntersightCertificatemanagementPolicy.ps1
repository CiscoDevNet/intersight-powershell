#Get the CertificatemanagementPolicy by Name
$CertificatemanagementPolicyByName = Get-IntersightCertificatemanagementPolicy -Name CertificatemanagementPolicyName

#Get the List of ServerProfiles
$CertificatemanagementPolicyList = Get-IntersightCertificatemanagementPolicy

#Get the list of CertificatemanagementPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CertificatemanagementPolicyByOrg = Get-IntersightCertificatemanagementPolicy -Organization $org

#Get the CertificatemanagementPolicy based on query Parameter
$CertificatemanagementPolicyByQueryParam = Get-IntersightCertificatemanagementPolicy -Filter Name eq CertificatemanagementPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .