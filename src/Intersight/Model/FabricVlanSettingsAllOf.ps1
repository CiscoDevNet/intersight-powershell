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

Definition of the list of properties defined in 'fabric.VlanSettings', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER AllowedVlans
Allowed VLAN IDs of the virtual interface.
.PARAMETER NativeVlan
Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. Setting the ID to 0 will not associate any native VLAN to the traffic on the virtual interface.
.OUTPUTS

FabricVlanSettingsAllOf<PSCustomObject>
#>

function Initialize-IntersightFabricVlanSettingsAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fabric.VlanSettings")]
        [String]
        ${ClassId} = "fabric.VlanSettings",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fabric.VlanSettings")]
        [String]
        ${ObjectType} = "fabric.VlanSettings",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^$|^((\d+\-\d+)|(\d+))(,((\d+\-\d+)|(\d+)))*$")]
        [String]
        ${AllowedVlans},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${NativeVlan} = 0
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFabricVlanSettingsAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if ($NativeVlan -and $NativeVlan -gt 4094) {
          throw "invalid value for 'NativeVlan', must be smaller than or equal to 4094."
        }

        if ($NativeVlan -and $NativeVlan -lt 0) {
          throw "invalid value for 'NativeVlan', must be greater than or equal to 0."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "AllowedVlans" = ${AllowedVlans}
            "NativeVlan" = ${NativeVlan}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FabricVlanSettingsAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to FabricVlanSettingsAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FabricVlanSettingsAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFabricVlanSettingsAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFabricVlanSettingsAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFabricVlanSettingsAllOf
        $AllProperties = ("ClassId", "ObjectType", "AllowedVlans", "NativeVlan")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowedVlans"))) { #optional property not found
            $AllowedVlans = $null
        } else {
            $AllowedVlans = $JsonParameters.PSobject.Properties["AllowedVlans"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NativeVlan"))) { #optional property not found
            $NativeVlan = $null
        } else {
            $NativeVlan = $JsonParameters.PSobject.Properties["NativeVlan"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "AllowedVlans" = ${AllowedVlans}
            "NativeVlan" = ${NativeVlan}
        }

        return $PSO
    }

}

