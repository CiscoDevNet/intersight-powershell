#Get the SoftwareReleaseMeta by Name
$SoftwareReleaseMetaByName = Get-IntersightSoftwareReleaseMeta -Name SoftwareReleaseMetaName

#Get the List of ServerProfiles
$SoftwareReleaseMetaList = Get-IntersightSoftwareReleaseMeta

#Get the list of SoftwareReleaseMeta under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwareReleaseMetaByOrg = Get-IntersightSoftwareReleaseMeta -Organization $org

#Get the SoftwareReleaseMeta based on query Parameter
$SoftwareReleaseMetaByQueryParam = Get-IntersightSoftwareReleaseMeta -Filter Name eq SoftwareReleaseMetaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .