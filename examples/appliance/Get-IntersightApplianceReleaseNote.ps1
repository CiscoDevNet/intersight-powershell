#Get the ApplianceReleaseNote by Name
$ApplianceReleaseNoteByName = Get-IntersightApplianceReleaseNote -Name ApplianceReleaseNoteName

#Get the List of ServerProfiles
$ApplianceReleaseNoteList = Get-IntersightApplianceReleaseNote

#Get the list of ApplianceReleaseNote under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceReleaseNoteByOrg = Get-IntersightApplianceReleaseNote -Organization $org

#Get the ApplianceReleaseNote based on query Parameter
$ApplianceReleaseNoteByQueryParam = Get-IntersightApplianceReleaseNote -Filter Name eq ApplianceReleaseNoteName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .