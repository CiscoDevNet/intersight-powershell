#Get the ApplianceRestore by Name
$ApplianceRestoreByName = Get-IntersightApplianceRestore -Name ApplianceRestoreName

#Get the List of ServerProfiles
$ApplianceRestoreList = Get-IntersightApplianceRestore

#Get the list of ApplianceRestore under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceRestoreByOrg = Get-IntersightApplianceRestore -Organization $org

#Get the ApplianceRestore based on query Parameter
$ApplianceRestoreByQueryParam = Get-IntersightApplianceRestore -Filter Name eq ApplianceRestoreName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .