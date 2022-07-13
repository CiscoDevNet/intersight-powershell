#Get the IamCertificateRequest by Name
$IamCertificateRequestByName = Get-IntersightIamCertificateRequest -Name IamCertificateRequestName

#Get the List of ServerProfiles
$IamCertificateRequestList = Get-IntersightIamCertificateRequest

#Get the list of IamCertificateRequest under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamCertificateRequestByOrg = Get-IntersightIamCertificateRequest -Organization $org

#Get the IamCertificateRequest based on query Parameter
$IamCertificateRequestByQueryParam = Get-IntersightIamCertificateRequest -Filter Name eq IamCertificateRequestName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .