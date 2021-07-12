#Get the NiaapiNibMetadata by Name
$NiaapiNibMetadataByName = Get-IntersightNiaapiNibMetadata -Name NiaapiNibMetadataName

#Get the List of ServerProfiles
$NiaapiNibMetadataList = Get-IntersightNiaapiNibMetadata

#Get the list of NiaapiNibMetadata under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiNibMetadataByOrg = Get-IntersightNiaapiNibMetadata -Organization $org

#Get the NiaapiNibMetadata based on query Parameter
$NiaapiNibMetadataByQueryParam = Get-IntersightNiaapiNibMetadata -Filter Name eq NiaapiNibMetadataName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .