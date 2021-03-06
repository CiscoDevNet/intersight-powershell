#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2021-02-05T15:05:56Z.
# Version: 1.0.9-3562
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Stores logical links per fabric.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER DbId
Return value of dbId attribute.
.PARAMETER IsPresent
Return value of isPresent attribute.
.PARAMETER LinkAddr1
Return value of linkAddr1 attribute.
.PARAMETER LinkAddr2
Return value of linkAddr2 attribute.
.PARAMETER LinkState
Return value of linkState attribute.
.PARAMETER LinkType
Return value of linkType attribute.
.PARAMETER Uptime
Return value of uptime attribute.
.OUTPUTS

NiatelemetryLogicalLink<PSCustomObject>
#>

function Initialize-IntersightNiatelemetryLogicalLink {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("niatelemetry.LogicalLink")]
        [String]
        ${ClassId} = "niatelemetry.LogicalLink",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("niatelemetry.LogicalLink")]
        [String]
        ${ObjectType} = "niatelemetry.LogicalLink",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${DbId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsPresent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LinkAddr1},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LinkAddr2},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LinkState},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LinkType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Uptime}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightNiatelemetryLogicalLink' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "DbId" = ${DbId}
            "IsPresent" = ${IsPresent}
            "LinkAddr1" = ${LinkAddr1}
            "LinkAddr2" = ${LinkAddr2}
            "LinkState" = ${LinkState}
            "LinkType" = ${LinkType}
            "Uptime" = ${Uptime}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to NiatelemetryLogicalLink<PSCustomObject>

.DESCRIPTION

Convert from JSON to NiatelemetryLogicalLink<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

NiatelemetryLogicalLink<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToNiatelemetryLogicalLink {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightNiatelemetryLogicalLink' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightNiatelemetryLogicalLink
        $AllProperties = ("ClassId", "ObjectType", "DbId", "IsPresent", "LinkAddr1", "LinkAddr2", "LinkState", "LinkType", "Uptime")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'ClassId' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ClassId' missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ObjectType' missing."
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DbId"))) { #optional property not found
            $DbId = $null
        } else {
            $DbId = $JsonParameters.PSobject.Properties["DbId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPresent"))) { #optional property not found
            $IsPresent = $null
        } else {
            $IsPresent = $JsonParameters.PSobject.Properties["IsPresent"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LinkAddr1"))) { #optional property not found
            $LinkAddr1 = $null
        } else {
            $LinkAddr1 = $JsonParameters.PSobject.Properties["LinkAddr1"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LinkAddr2"))) { #optional property not found
            $LinkAddr2 = $null
        } else {
            $LinkAddr2 = $JsonParameters.PSobject.Properties["LinkAddr2"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LinkState"))) { #optional property not found
            $LinkState = $null
        } else {
            $LinkState = $JsonParameters.PSobject.Properties["LinkState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LinkType"))) { #optional property not found
            $LinkType = $null
        } else {
            $LinkType = $JsonParameters.PSobject.Properties["LinkType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Uptime"))) { #optional property not found
            $Uptime = $null
        } else {
            $Uptime = $JsonParameters.PSobject.Properties["Uptime"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "DbId" = ${DbId}
            "IsPresent" = ${IsPresent}
            "LinkAddr1" = ${LinkAddr1}
            "LinkAddr2" = ${LinkAddr2}
            "LinkState" = ${LinkState}
            "LinkType" = ${LinkType}
            "Uptime" = ${Uptime}
        }

        return $PSO
    }

}

