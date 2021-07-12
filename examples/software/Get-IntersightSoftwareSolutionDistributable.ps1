#Get the SoftwareSolutionDistributable by Name
$SoftwareSolutionDistributableByName = Get-IntersightSoftwareSolutionDistributable -Name SoftwareSolutionDistributableName

#Get the List of ServerProfiles
$SoftwareSolutionDistributableList = Get-IntersightSoftwareSolutionDistributable

#Get the list of SoftwareSolutionDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwareSolutionDistributableByOrg = Get-IntersightSoftwareSolutionDistributable -Organization $org

#Get the SoftwareSolutionDistributable based on query Parameter
$SoftwareSolutionDistributableByQueryParam = Get-IntersightSoftwareSolutionDistributable -Filter Name eq SoftwareSolutionDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .