#Get the ApplianceDeviceCertificate by Name
$ApplianceDeviceCertificateByName = Get-IntersightApplianceDeviceCertificate -Name ApplianceDeviceCertificateName

#Get the List of ServerProfiles
$ApplianceDeviceCertificateList = Get-IntersightApplianceDeviceCertificate

#Get the list of ApplianceDeviceCertificate under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceDeviceCertificateByOrg = Get-IntersightApplianceDeviceCertificate -Organization $org

#Get the ApplianceDeviceCertificate based on query Parameter
$ApplianceDeviceCertificateByQueryParam = Get-IntersightApplianceDeviceCertificate -Filter Name eq ApplianceDeviceCertificateName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .