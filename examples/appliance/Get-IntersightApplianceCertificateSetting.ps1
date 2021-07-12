#Get the ApplianceCertificateSetting by Name
$ApplianceCertificateSettingByName = Get-IntersightApplianceCertificateSetting -Name ApplianceCertificateSettingName

#Get the List of ServerProfiles
$ApplianceCertificateSettingList = Get-IntersightApplianceCertificateSetting

#Get the list of ApplianceCertificateSetting under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceCertificateSettingByOrg = Get-IntersightApplianceCertificateSetting -Organization $org

#Get the ApplianceCertificateSetting based on query Parameter
$ApplianceCertificateSettingByQueryParam = Get-IntersightApplianceCertificateSetting -Filter Name eq ApplianceCertificateSettingName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .