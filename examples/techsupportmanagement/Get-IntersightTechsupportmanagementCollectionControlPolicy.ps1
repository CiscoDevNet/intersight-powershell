#Get the TechsupportmanagementCollectionControlPolicy by Name
$TechsupportmanagementCollectionControlPolicyByName = Get-IntersightTechsupportmanagementCollectionControlPolicy -Name TechsupportmanagementCollectionControlPolicyName

#Get the List of TechsupportmanagementCollectionControlPolicy
$TechsupportmanagementCollectionControlPolicyList = Get-IntersightTechsupportmanagementCollectionControlPolicy

#Get the list of TechsupportmanagementCollectionControlPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$TechsupportmanagementCollectionControlPolicyByOrg = Get-IntersightTechsupportmanagementCollectionControlPolicy -Organization $org

#Get the TechsupportmanagementCollectionControlPolicy based on query Parameter
$TechsupportmanagementCollectionControlPolicyByQueryParam = Get-IntersightTechsupportmanagementCollectionControlPolicy -Filter Name eq TechsupportmanagementCollectionControlPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .