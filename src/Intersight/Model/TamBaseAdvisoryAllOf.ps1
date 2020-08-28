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

Definition of the list of properties defined in 'tam.BaseAdvisory', excluding properties defined in parent classes.

.PARAMETER Description
Brief description of the advisory details.
.PARAMETER Name
A user defined name for the Intersight Advisory.
.PARAMETER Severity
No description available.
.PARAMETER State
Current state of the advisory.
.OUTPUTS

TamBaseAdvisoryAllOf<PSCustomObject>
#>

function Initialize-IntersightTamBaseAdvisoryAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Severity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("ready", "evaluating")]
        [String]
        ${State} = "ready"
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTamBaseAdvisoryAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Description" = ${Description}
            "Name" = ${Name}
            "Severity" = ${Severity}
            "State" = ${State}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TamBaseAdvisoryAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to TamBaseAdvisoryAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TamBaseAdvisoryAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTamBaseAdvisoryAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTamBaseAdvisoryAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTamBaseAdvisoryAllOf
        $AllProperties = ("Description", "Name", "Severity", "State")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Severity"))) { #optional property not found
            $Severity = $null
        } else {
            $Severity = $JsonParameters.PSobject.Properties["Severity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "State"))) { #optional property not found
            $State = $null
        } else {
            $State = $JsonParameters.PSobject.Properties["State"].value
        }

        $PSO = [PSCustomObject]@{
            "Description" = ${Description}
            "Name" = ${Name}
            "Severity" = ${Severity}
            "State" = ${State}
        }

        return $PSO
    }

}
