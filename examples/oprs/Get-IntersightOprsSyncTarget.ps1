#Get the OprsSyncTarget by Name
$OprsSyncTargetByName = Get-IntersightOprsSyncTarget -Name OprsSyncTargetName

#Get the List of ServerProfiles
$OprsSyncTargetList = Get-IntersightOprsSyncTarget

#Get the list of OprsSyncTarget under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$OprsSyncTargetByOrg = Get-IntersightOprsSyncTarget -Organization $org

#Get the OprsSyncTarget based on query Parameter
$OprsSyncTargetByQueryParam = Get-IntersightOprsSyncTarget -Filter Name eq OprsSyncTargetName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .