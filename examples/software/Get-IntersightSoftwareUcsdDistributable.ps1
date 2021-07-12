#Get the SoftwareUcsdDistributable by Name
$SoftwareUcsdDistributableByName = Get-IntersightSoftwareUcsdDistributable -Name SoftwareUcsdDistributableName

#Get the List of ServerProfiles
$SoftwareUcsdDistributableList = Get-IntersightSoftwareUcsdDistributable

#Get the list of SoftwareUcsdDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwareUcsdDistributableByOrg = Get-IntersightSoftwareUcsdDistributable -Organization $org

#Get the SoftwareUcsdDistributable based on query Parameter
$SoftwareUcsdDistributableByQueryParam = Get-IntersightSoftwareUcsdDistributable -Filter Name eq SoftwareUcsdDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .