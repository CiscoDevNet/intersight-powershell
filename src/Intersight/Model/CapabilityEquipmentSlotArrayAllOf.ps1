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

Definition of the list of properties defined in 'capability.EquipmentSlotArray', excluding properties defined in parent classes.

.PARAMETER FirstIndex
First Index information for a Switch/Fabric-Interconnect hardware.
.PARAMETER Height
Height information for a Switch/Fabric-Interconnect hardware.
.PARAMETER HorizontalStartOffset
Horizontal Start Offset information for a Switch/Fabric-Interconnect hardware.
.PARAMETER InlineGroupSeparation
Inline Group Separation information for a Switch/Fabric-Interconnect hardware.
.PARAMETER InlineGroupSize
Inline Group Size information for a Switch/Fabric-Interconnect hardware.
.PARAMETER InlineOffset
Inline Offset information for a Switch/Fabric-Interconnect hardware.
.PARAMETER Location
Location information for a Switch/Fabric-Interconnect hardware.
.PARAMETER NumberOfSlots
Number of Slots information for a Switch/Fabric-Interconnect hardware.
.PARAMETER Orientation
Orientation information for a Switch/Fabric-Interconnect hardware.
.PARAMETER Selector
Selector information for a Switch/Fabric-Interconnect hardware.
.PARAMETER SlotsPerLine
Slots per line information for a Switch/Fabric-Interconnect hardware.
.PARAMETER TransverseGroupSeparation
Transverse Group Separation information for a Switch/Fabric-Interconnect hardware.
.PARAMETER TransverseGroupSize
Transverse Group Size information for a Switch/Fabric-Interconnect hardware.
.PARAMETER TransverseOffset
Transverse Offset information for a Switch/Fabric-Interconnect hardware.
.PARAMETER VerticalStartOffset
Vertical Start Offset information for a Switch/Fabric-Interconnect hardware.
.PARAMETER Width
Width information for a Switch/Fabric-Interconnect hardware.
.OUTPUTS

CapabilityEquipmentSlotArrayAllOf<PSCustomObject>
#>

function Initialize-IntersightCapabilityEquipmentSlotArrayAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${FirstIndex},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${Height},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${HorizontalStartOffset},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${InlineGroupSeparation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${InlineGroupSize},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${InlineOffset},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Location},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${NumberOfSlots},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Orientation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Selector},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${SlotsPerLine},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${TransverseGroupSeparation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${TransverseGroupSize},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${TransverseOffset},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${VerticalStartOffset},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${Width}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightCapabilityEquipmentSlotArrayAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "FirstIndex" = ${FirstIndex}
            "Height" = ${Height}
            "HorizontalStartOffset" = ${HorizontalStartOffset}
            "InlineGroupSeparation" = ${InlineGroupSeparation}
            "InlineGroupSize" = ${InlineGroupSize}
            "InlineOffset" = ${InlineOffset}
            "Location" = ${Location}
            "NumberOfSlots" = ${NumberOfSlots}
            "Orientation" = ${Orientation}
            "Selector" = ${Selector}
            "SlotsPerLine" = ${SlotsPerLine}
            "TransverseGroupSeparation" = ${TransverseGroupSeparation}
            "TransverseGroupSize" = ${TransverseGroupSize}
            "TransverseOffset" = ${TransverseOffset}
            "VerticalStartOffset" = ${VerticalStartOffset}
            "Width" = ${Width}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to CapabilityEquipmentSlotArrayAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to CapabilityEquipmentSlotArrayAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

CapabilityEquipmentSlotArrayAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToCapabilityEquipmentSlotArrayAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightCapabilityEquipmentSlotArrayAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightCapabilityEquipmentSlotArrayAllOf
        $AllProperties = ("FirstIndex", "Height", "HorizontalStartOffset", "InlineGroupSeparation", "InlineGroupSize", "InlineOffset", "Location", "NumberOfSlots", "Orientation", "Selector", "SlotsPerLine", "TransverseGroupSeparation", "TransverseGroupSize", "TransverseOffset", "VerticalStartOffset", "Width")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FirstIndex"))) { #optional property not found
            $FirstIndex = $null
        } else {
            $FirstIndex = $JsonParameters.PSobject.Properties["FirstIndex"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Height"))) { #optional property not found
            $Height = $null
        } else {
            $Height = $JsonParameters.PSobject.Properties["Height"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HorizontalStartOffset"))) { #optional property not found
            $HorizontalStartOffset = $null
        } else {
            $HorizontalStartOffset = $JsonParameters.PSobject.Properties["HorizontalStartOffset"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InlineGroupSeparation"))) { #optional property not found
            $InlineGroupSeparation = $null
        } else {
            $InlineGroupSeparation = $JsonParameters.PSobject.Properties["InlineGroupSeparation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InlineGroupSize"))) { #optional property not found
            $InlineGroupSize = $null
        } else {
            $InlineGroupSize = $JsonParameters.PSobject.Properties["InlineGroupSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InlineOffset"))) { #optional property not found
            $InlineOffset = $null
        } else {
            $InlineOffset = $JsonParameters.PSobject.Properties["InlineOffset"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Location"))) { #optional property not found
            $Location = $null
        } else {
            $Location = $JsonParameters.PSobject.Properties["Location"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NumberOfSlots"))) { #optional property not found
            $NumberOfSlots = $null
        } else {
            $NumberOfSlots = $JsonParameters.PSobject.Properties["NumberOfSlots"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Orientation"))) { #optional property not found
            $Orientation = $null
        } else {
            $Orientation = $JsonParameters.PSobject.Properties["Orientation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Selector"))) { #optional property not found
            $Selector = $null
        } else {
            $Selector = $JsonParameters.PSobject.Properties["Selector"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SlotsPerLine"))) { #optional property not found
            $SlotsPerLine = $null
        } else {
            $SlotsPerLine = $JsonParameters.PSobject.Properties["SlotsPerLine"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TransverseGroupSeparation"))) { #optional property not found
            $TransverseGroupSeparation = $null
        } else {
            $TransverseGroupSeparation = $JsonParameters.PSobject.Properties["TransverseGroupSeparation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TransverseGroupSize"))) { #optional property not found
            $TransverseGroupSize = $null
        } else {
            $TransverseGroupSize = $JsonParameters.PSobject.Properties["TransverseGroupSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TransverseOffset"))) { #optional property not found
            $TransverseOffset = $null
        } else {
            $TransverseOffset = $JsonParameters.PSobject.Properties["TransverseOffset"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VerticalStartOffset"))) { #optional property not found
            $VerticalStartOffset = $null
        } else {
            $VerticalStartOffset = $JsonParameters.PSobject.Properties["VerticalStartOffset"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Width"))) { #optional property not found
            $Width = $null
        } else {
            $Width = $JsonParameters.PSobject.Properties["Width"].value
        }

        $PSO = [PSCustomObject]@{
            "FirstIndex" = ${FirstIndex}
            "Height" = ${Height}
            "HorizontalStartOffset" = ${HorizontalStartOffset}
            "InlineGroupSeparation" = ${InlineGroupSeparation}
            "InlineGroupSize" = ${InlineGroupSize}
            "InlineOffset" = ${InlineOffset}
            "Location" = ${Location}
            "NumberOfSlots" = ${NumberOfSlots}
            "Orientation" = ${Orientation}
            "Selector" = ${Selector}
            "SlotsPerLine" = ${SlotsPerLine}
            "TransverseGroupSeparation" = ${TransverseGroupSeparation}
            "TransverseGroupSize" = ${TransverseGroupSize}
            "TransverseOffset" = ${TransverseOffset}
            "VerticalStartOffset" = ${VerticalStartOffset}
            "Width" = ${Width}
        }

        return $PSO
    }

}
