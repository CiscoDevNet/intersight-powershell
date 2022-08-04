#Get the NiatelemetryNiaInventoryDcnm by Name
$NiatelemetryNiaInventoryDcnmByName = Get-IntersightNiatelemetryNiaInventoryDcnm -Name NiatelemetryNiaInventoryDcnmName

#Get the List of ServerProfiles
$NiatelemetryNiaInventoryDcnmList = Get-IntersightNiatelemetryNiaInventoryDcnm

#Get the list of NiatelemetryNiaInventoryDcnm under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryNiaInventoryDcnmByOrg = Get-IntersightNiatelemetryNiaInventoryDcnm -Organization $org

#Get the NiatelemetryNiaInventoryDcnm based on query Parameter
$NiatelemetryNiaInventoryDcnmByQueryParam = Get-IntersightNiatelemetryNiaInventoryDcnm -Filter Name eq NiatelemetryNiaInventoryDcnmName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .