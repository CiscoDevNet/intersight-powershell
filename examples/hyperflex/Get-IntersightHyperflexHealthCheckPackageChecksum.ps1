#Get the HyperflexHealthCheckPackageChecksum by Name
$HyperflexHealthCheckPackageChecksumByName = Get-IntersightHyperflexHealthCheckPackageChecksum -Name HyperflexHealthCheckPackageChecksumName

#Get the List of ServerProfiles
$HyperflexHealthCheckPackageChecksumList = Get-IntersightHyperflexHealthCheckPackageChecksum

#Get the list of HyperflexHealthCheckPackageChecksum under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHealthCheckPackageChecksumByOrg = Get-IntersightHyperflexHealthCheckPackageChecksum -Organization $org

#Get the HyperflexHealthCheckPackageChecksum based on query Parameter
$HyperflexHealthCheckPackageChecksumByQueryParam = Get-IntersightHyperflexHealthCheckPackageChecksum -Filter Name eq HyperflexHealthCheckPackageChecksumName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .