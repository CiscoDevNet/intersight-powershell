#Get the SoftwareHclMeta by Name
$SoftwareHclMetaByName = Get-IntersightSoftwareHclMeta -Name SoftwareHclMetaName

#Get the List of SoftwareHclMeta
$SoftwareHclMetaList = Get-IntersightSoftwareHclMeta

#Get the list of SoftwareHclMeta under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwareHclMetaByOrg = Get-IntersightSoftwareHclMeta -Organization $org

#Get the SoftwareHclMeta based on query Parameter
$SoftwareHclMetaByQueryParam = Get-IntersightSoftwareHclMeta -Filter Name eq SoftwareHclMetaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .