$parameters1 = Initialize-IntersightContentParameter -ClassId 'ContentParameter' -Secure 0 -AcceptSingleValue 1 -Name 'show-pure' -ItemType 'string' -Type 'string'

$parameters2 = Initialize-IntersightContentParameter -ClassId 'ContentParameter' -Secure 0 -AcceptSingleValue 1 -Name 'show-hitachi' -ItemType 'string' -Type 'string'

$catalog1 = Get-IntersightWorkflowCatalog -Moid '<Replace with Moid>'

$types1 = Initialize-IntersightContentComplextype -Parameters $paramters2 -Name 'dummy'

$workflow_error_response_handler1 = New-IntersightWorkflowErrorResponseHandler -Types $types1 -Catalog $catalog1 -Name 'workflow_error_response_handler1' -PlatformType 'UCSD' -Parameters $parameters1