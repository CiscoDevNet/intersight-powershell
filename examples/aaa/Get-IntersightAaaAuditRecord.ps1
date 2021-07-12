#Get the AaaAuditRecord by Name
$AaaAuditRecordByName = Get-IntersightAaaAuditRecord -Name AaaAuditRecordName

#Get the List of ServerProfiles
$AaaAuditRecordList = Get-IntersightAaaAuditRecord

#Get the list of AaaAuditRecord under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AaaAuditRecordByOrg = Get-IntersightAaaAuditRecord -Organization $org

#Get the AaaAuditRecord based on query Parameter
$AaaAuditRecordByQueryParam = Get-IntersightAaaAuditRecord -Filter Name eq AaaAuditRecordName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .