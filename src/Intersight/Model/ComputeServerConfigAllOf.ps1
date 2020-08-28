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

Definition of the list of properties defined in 'compute.ServerConfig', excluding properties defined in parent classes.

.PARAMETER AssetTag
User defined asset tag of the server.
.PARAMETER UserLabel
User defined description of the server.
.OUTPUTS

ComputeServerConfigAllOf<PSCustomObject>
#>

function Initialize-IntersightComputeServerConfigAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^[ #$%\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        [String]
        ${AssetTag},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^[ !#$%&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        [String]
        ${UserLabel}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightComputeServerConfigAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$AssetTag -and $AssetTag.length -gt 32) {
            throw "invalid value for 'AssetTag', the character length must be smaller than or equal to 32."
        }

        if (!$AssetTag -and $AssetTag.length -lt 0) {
            throw "invalid value for 'AssetTag', the character length must be great than or equal to 0."
        }

        if (!$UserLabel -and $UserLabel.length -gt 64) {
            throw "invalid value for 'UserLabel', the character length must be smaller than or equal to 64."
        }

        if (!$UserLabel -and $UserLabel.length -lt 0) {
            throw "invalid value for 'UserLabel', the character length must be great than or equal to 0."
        }

        
        $PSO = [PSCustomObject]@{
            "AssetTag" = ${AssetTag}
            "UserLabel" = ${UserLabel}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to ComputeServerConfigAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to ComputeServerConfigAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

ComputeServerConfigAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToComputeServerConfigAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightComputeServerConfigAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightComputeServerConfigAllOf
        $AllProperties = ("AssetTag", "UserLabel")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssetTag"))) { #optional property not found
            $AssetTag = $null
        } else {
            $AssetTag = $JsonParameters.PSobject.Properties["AssetTag"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserLabel"))) { #optional property not found
            $UserLabel = $null
        } else {
            $UserLabel = $JsonParameters.PSobject.Properties["UserLabel"].value
        }

        $PSO = [PSCustomObject]@{
            "AssetTag" = ${AssetTag}
            "UserLabel" = ${UserLabel}
        }

        return $PSO
    }

}
