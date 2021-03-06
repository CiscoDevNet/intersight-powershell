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

Definition of the list of properties defined in 'virtualization.VmwareHost', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER BootTime
The time when this host booted up.
.PARAMETER ConnectionState
Indicates if the host is connected to the vCenter. Values are connected, not connected.
.PARAMETER HwPowerState
Is the host Powered-up or Powered-down. * `Unknown` - The entity's power state is unknown. * `PoweredOn` - The entity is powered on. * `PoweredOff` - The entity is powered down. * `StandBy` - The entity is in standby mode. * `Paused` - The entity is in pause state.
.PARAMETER NetworkAdapterCount
The count of all network adapters attached to this host.
.PARAMETER ResourceConsumed
No description available.
.PARAMETER StorageAdapterCount
The count of all storage adapters attached to this host.
.PARAMETER VcenterHostId
The identity of this host within vCenter (optional).
.PARAMETER Cluster
No description available.
.PARAMETER Datacenter
No description available.
.OUTPUTS

VirtualizationVmwareHostAllOf<PSCustomObject>
#>

function Initialize-IntersightVirtualizationVmwareHostAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("virtualization.VmwareHost")]
        [String]
        ${ClassId} = "virtualization.VmwareHost",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("virtualization.VmwareHost")]
        [String]
        ${ObjectType} = "virtualization.VmwareHost",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${BootTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ConnectionState},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Unknown", "PoweredOn", "PoweredOff", "StandBy", "Paused")]
        [String]
        ${HwPowerState} = "Unknown",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${NetworkAdapterCount},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ResourceConsumed},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${StorageAdapterCount},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${VcenterHostId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Cluster},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Datacenter}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightVirtualizationVmwareHostAllOf' | Write-Debug
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
            "BootTime" = ${BootTime}
            "ConnectionState" = ${ConnectionState}
            "HwPowerState" = ${HwPowerState}
            "NetworkAdapterCount" = ${NetworkAdapterCount}
            "ResourceConsumed" = ${ResourceConsumed}
            "StorageAdapterCount" = ${StorageAdapterCount}
            "VcenterHostId" = ${VcenterHostId}
            "Cluster" = ${Cluster}
            "Datacenter" = ${Datacenter}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to VirtualizationVmwareHostAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to VirtualizationVmwareHostAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

VirtualizationVmwareHostAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToVirtualizationVmwareHostAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightVirtualizationVmwareHostAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightVirtualizationVmwareHostAllOf
        $AllProperties = ("ClassId", "ObjectType", "BootTime", "ConnectionState", "HwPowerState", "NetworkAdapterCount", "ResourceConsumed", "StorageAdapterCount", "VcenterHostId", "Cluster", "Datacenter", "Datastores")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BootTime"))) { #optional property not found
            $BootTime = $null
        } else {
            $BootTime = $JsonParameters.PSobject.Properties["BootTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectionState"))) { #optional property not found
            $ConnectionState = $null
        } else {
            $ConnectionState = $JsonParameters.PSobject.Properties["ConnectionState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HwPowerState"))) { #optional property not found
            $HwPowerState = $null
        } else {
            $HwPowerState = $JsonParameters.PSobject.Properties["HwPowerState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkAdapterCount"))) { #optional property not found
            $NetworkAdapterCount = $null
        } else {
            $NetworkAdapterCount = $JsonParameters.PSobject.Properties["NetworkAdapterCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ResourceConsumed"))) { #optional property not found
            $ResourceConsumed = $null
        } else {
            $ResourceConsumed = $JsonParameters.PSobject.Properties["ResourceConsumed"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageAdapterCount"))) { #optional property not found
            $StorageAdapterCount = $null
        } else {
            $StorageAdapterCount = $JsonParameters.PSobject.Properties["StorageAdapterCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VcenterHostId"))) { #optional property not found
            $VcenterHostId = $null
        } else {
            $VcenterHostId = $JsonParameters.PSobject.Properties["VcenterHostId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Cluster"))) { #optional property not found
            $Cluster = $null
        } else {
            $Cluster = $JsonParameters.PSobject.Properties["Cluster"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Datacenter"))) { #optional property not found
            $Datacenter = $null
        } else {
            $Datacenter = $JsonParameters.PSobject.Properties["Datacenter"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Datastores"))) { #optional property not found
            $Datastores = $null
        } else {
            $Datastores = $JsonParameters.PSobject.Properties["Datastores"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "BootTime" = ${BootTime}
            "ConnectionState" = ${ConnectionState}
            "HwPowerState" = ${HwPowerState}
            "NetworkAdapterCount" = ${NetworkAdapterCount}
            "ResourceConsumed" = ${ResourceConsumed}
            "StorageAdapterCount" = ${StorageAdapterCount}
            "VcenterHostId" = ${VcenterHostId}
            "Cluster" = ${Cluster}
            "Datacenter" = ${Datacenter}
            "Datastores" = ${Datastores}
        }

        return $PSO
    }

}

