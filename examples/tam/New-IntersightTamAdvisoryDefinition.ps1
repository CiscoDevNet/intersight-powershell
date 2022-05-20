$actions1 = Initialize-IntersightTamAction -Description 'tam action' -Name 'action1'

$api_data_sources1 = Initialize-IntersightTamApidatasource -Name 'api_data_source_1' -Type 'intersightApi'

$advisory_details1 = Initialize-IntersightTamSecurityadvisorydetails -Description 'tam security advisory' -ClassId 'TamSecurityAdvisoryDetails'

$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$tam_advisory_definition = New-IntersightTamAdvisoryDefinition -Actions $actions1 -ApiDataSources $api_data_sources1 -AdvisoryDetails $advisory_details1 -Organization $organization -Name 'tam_advisory_definition' -State 'ready' -Type 'securityAdvisory'