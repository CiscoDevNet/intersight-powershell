#Get the NiaapiNiaMetadata by Name
$NiaapiNiaMetadataByName = Get-IntersightNiaapiNiaMetadata -Name NiaapiNiaMetadataName

#Get the List of ServerProfiles
$NiaapiNiaMetadataList = Get-IntersightNiaapiNiaMetadata

#Get the list of NiaapiNiaMetadata under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiaapiNiaMetadataByOrg = Get-IntersightNiaapiNiaMetadata -Organization $org

#Get the NiaapiNiaMetadata based on query Parameter
$NiaapiNiaMetadataByQueryParam = Get-IntersightNiaapiNiaMetadata -Filter Name eq NiaapiNiaMetadataName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .