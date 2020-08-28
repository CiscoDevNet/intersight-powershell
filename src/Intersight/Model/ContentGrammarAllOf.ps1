#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Definition of the list of properties defined in 'content.Grammar', excluding properties defined in parent classes.

.PARAMETER ErrorParameters
No description available.
.PARAMETER Parameters
No description available.
.PARAMETER Types
No description available.
.OUTPUTS

ContentGrammarAllOf<PSCustomObject>
#>

function Initialize-IntersightContentGrammarAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ErrorParameters},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Parameters},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Types}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightContentGrammarAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ErrorParameters" = ${ErrorParameters}
            "Parameters" = ${Parameters}
            "Types" = ${Types}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to ContentGrammarAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to ContentGrammarAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

ContentGrammarAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToContentGrammarAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightContentGrammarAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightContentGrammarAllOf
        $AllProperties = ("ErrorParameters", "Parameters", "Types")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorParameters"))) { #optional property not found
            $ErrorParameters = $null
        } else {
            $ErrorParameters = $JsonParameters.PSobject.Properties["ErrorParameters"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Parameters"))) { #optional property not found
            $Parameters = $null
        } else {
            $Parameters = $JsonParameters.PSobject.Properties["Parameters"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Types"))) { #optional property not found
            $Types = $null
        } else {
            $Types = $JsonParameters.PSobject.Properties["Types"].value
        }

        $PSO = [PSCustomObject]@{
            "ErrorParameters" = ${ErrorParameters}
            "Parameters" = ${Parameters}
            "Types" = ${Types}
        }

        return $PSO
    }

}
