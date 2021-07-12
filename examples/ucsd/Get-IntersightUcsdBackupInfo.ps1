#Get the UcsdBackupInfo by Name
$UcsdBackupInfoByName = Get-IntersightUcsdBackupInfo -Name UcsdBackupInfoName

#Get the List of ServerProfiles
$UcsdBackupInfoList = Get-IntersightUcsdBackupInfo

#Get the list of UcsdBackupInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$UcsdBackupInfoByOrg = Get-IntersightUcsdBackupInfo -Organization $org

#Get the UcsdBackupInfo based on query Parameter
$UcsdBackupInfoByQueryParam = Get-IntersightUcsdBackupInfo -Filter Name eq UcsdBackupInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .