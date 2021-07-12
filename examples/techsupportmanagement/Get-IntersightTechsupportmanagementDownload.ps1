#Get the TechsupportmanagementDownload by Name
$TechsupportmanagementDownloadByName = Get-IntersightTechsupportmanagementDownload -Name TechsupportmanagementDownloadName

#Get the List of ServerProfiles
$TechsupportmanagementDownloadList = Get-IntersightTechsupportmanagementDownload

#Get the list of TechsupportmanagementDownload under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$TechsupportmanagementDownloadByOrg = Get-IntersightTechsupportmanagementDownload -Organization $org

#Get the TechsupportmanagementDownload based on query Parameter
$TechsupportmanagementDownloadByQueryParam = Get-IntersightTechsupportmanagementDownload -Filter Name eq TechsupportmanagementDownloadName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .