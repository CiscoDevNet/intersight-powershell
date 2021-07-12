#Get the ApplianceExternalSyslogSetting by Name
$ApplianceExternalSyslogSettingByName = Get-IntersightApplianceExternalSyslogSetting -Name ApplianceExternalSyslogSettingName

#Get the List of ServerProfiles
$ApplianceExternalSyslogSettingList = Get-IntersightApplianceExternalSyslogSetting

#Get the list of ApplianceExternalSyslogSetting under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ApplianceExternalSyslogSettingByOrg = Get-IntersightApplianceExternalSyslogSetting -Organization $org

#Get the ApplianceExternalSyslogSetting based on query Parameter
$ApplianceExternalSyslogSettingByQueryParam = Get-IntersightApplianceExternalSyslogSetting -Filter Name eq ApplianceExternalSyslogSettingName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .