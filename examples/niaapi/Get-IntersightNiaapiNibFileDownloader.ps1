#Get the NiaapiNibFileDownloader by Name
$NiaapiNibFileDownloaderByName = Get-IntersightNiaapiNibFileDownloader -Name NiaapiNibFileDownloaderName

#Get the List of ServerProfiles
$NiaapiNibFileDownloaderList = Get-IntersightNiaapiNibFileDownloader

#Get the list of NiaapiNibFileDownloader under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiNibFileDownloaderByOrg = Get-IntersightNiaapiNibFileDownloader -Organization $org

#Get the NiaapiNibFileDownloader based on query Parameter
$NiaapiNibFileDownloaderByQueryParam = Get-IntersightNiaapiNibFileDownloader -Filter Name eq NiaapiNibFileDownloaderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .