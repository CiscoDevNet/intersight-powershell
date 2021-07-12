#Get the IamCertificate by Name
$IamCertificateByName = Get-IntersightIamCertificate -Name IamCertificateName

#Get the List of ServerProfiles
$IamCertificateList = Get-IntersightIamCertificate

#Get the list of IamCertificate under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamCertificateByOrg = Get-IntersightIamCertificate -Organization $org

#Get the IamCertificate based on query Parameter
$IamCertificateByQueryParam = Get-IntersightIamCertificate -Filter Name eq IamCertificateName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .