#Get the ApplianceDiagSetting by Name
$ApplianceDiagSettingByName = Get-IntersightApplianceDiagSetting -Name ApplianceDiagSettingName

#Get the List of ServerProfiles
$ApplianceDiagSettingList = Get-IntersightApplianceDiagSetting

#Get the list of ApplianceDiagSetting under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceDiagSettingByOrg = Get-IntersightApplianceDiagSetting -Organization $org

#Get the ApplianceDiagSetting based on query Parameter
$ApplianceDiagSettingByQueryParam = Get-IntersightApplianceDiagSetting -Filter Name eq ApplianceDiagSettingName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .