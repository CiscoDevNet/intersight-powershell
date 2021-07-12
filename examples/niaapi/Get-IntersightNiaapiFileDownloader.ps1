#Get the NiaapiFileDownloader by Name
$NiaapiFileDownloaderByName = Get-IntersightNiaapiFileDownloader -Name NiaapiFileDownloaderName

#Get the List of ServerProfiles
$NiaapiFileDownloaderList = Get-IntersightNiaapiFileDownloader

#Get the list of NiaapiFileDownloader under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiFileDownloaderByOrg = Get-IntersightNiaapiFileDownloader -Organization $org

#Get the NiaapiFileDownloader based on query Parameter
$NiaapiFileDownloaderByQueryParam = Get-IntersightNiaapiFileDownloader -Filter Name eq NiaapiFileDownloaderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .