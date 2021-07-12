#Get the TechsupportmanagementTechSupportStatus by Name
$TechsupportmanagementTechSupportStatusByName = Get-IntersightTechsupportmanagementTechSupportStatus -Name TechsupportmanagementTechSupportStatusName

#Get the List of ServerProfiles
$TechsupportmanagementTechSupportStatusList = Get-IntersightTechsupportmanagementTechSupportStatus

#Get the list of TechsupportmanagementTechSupportStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$TechsupportmanagementTechSupportStatusByOrg = Get-IntersightTechsupportmanagementTechSupportStatus -Organization $org

#Get the TechsupportmanagementTechSupportStatus based on query Parameter
$TechsupportmanagementTechSupportStatusByQueryParam = Get-IntersightTechsupportmanagementTechSupportStatus -Filter Name eq TechsupportmanagementTechSupportStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .