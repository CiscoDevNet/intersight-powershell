#Get the SoftwareApplianceDistributable by Name
$SoftwareApplianceDistributableByName = Get-IntersightSoftwareApplianceDistributable -Name SoftwareApplianceDistributableName

#Get the List of SoftwareApplianceDistributable
$SoftwareApplianceDistributableList = Get-IntersightSoftwareApplianceDistributable

#Get the list of SoftwareApplianceDistributable under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SoftwareApplianceDistributableByOrg = Get-IntersightSoftwareApplianceDistributable -Organization $org

#Get the SoftwareApplianceDistributable based on query Parameter
$SoftwareApplianceDistributableByQueryParam = Get-IntersightSoftwareApplianceDistributable -Filter Name eq SoftwareApplianceDistributableName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .