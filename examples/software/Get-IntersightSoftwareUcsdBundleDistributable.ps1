#Get the SoftwareUcsdBundleDistributable by Name
$SoftwareUcsdBundleDistributableByName = Get-IntersightSoftwareUcsdBundleDistributable -Name SoftwareUcsdBundleDistributableName

#Get the List of SoftwareUcsdBundleDistributable
$SoftwareUcsdBundleDistributableList = Get-IntersightSoftwareUcsdBundleDistributable

#Get the list of SoftwareUcsdBundleDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SoftwareUcsdBundleDistributableByOrg = Get-IntersightSoftwareUcsdBundleDistributable -Organization $org

#Get the SoftwareUcsdBundleDistributable based on query Parameter
$SoftwareUcsdBundleDistributableByQueryParam = Get-IntersightSoftwareUcsdBundleDistributable -Filter Name eq SoftwareUcsdBundleDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .