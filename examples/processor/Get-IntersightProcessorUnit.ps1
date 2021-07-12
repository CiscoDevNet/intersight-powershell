#Get the ProcessorUnit by Name
$ProcessorUnitByName = Get-IntersightProcessorUnit -Name ProcessorUnitName

#Get the List of ServerProfiles
$ProcessorUnitList = Get-IntersightProcessorUnit

#Get the list of ProcessorUnit under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ProcessorUnitByOrg = Get-IntersightProcessorUnit -Organization $org

#Get the ProcessorUnit based on query Parameter
$ProcessorUnitByQueryParam = Get-IntersightProcessorUnit -Filter Name eq ProcessorUnitName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .