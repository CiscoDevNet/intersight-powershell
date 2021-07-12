#Get the CapabilityServerSchemaDescriptor by Name
$CapabilityServerSchemaDescriptorByName = Get-IntersightCapabilityServerSchemaDescriptor -Name CapabilityServerSchemaDescriptorName

#Get the List of ServerProfiles
$CapabilityServerSchemaDescriptorList = Get-IntersightCapabilityServerSchemaDescriptor

#Get the list of CapabilityServerSchemaDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityServerSchemaDescriptorByOrg = Get-IntersightCapabilityServerSchemaDescriptor -Organization $org

#Get the CapabilityServerSchemaDescriptor based on query Parameter
$CapabilityServerSchemaDescriptorByQueryParam = Get-IntersightCapabilityServerSchemaDescriptor -Filter Name eq CapabilityServerSchemaDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .