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

Definition of the list of properties defined in 'capability.SwitchNetworkLimits', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER MaxCompressedPortVlanCount
Maximum Compressed configurable VLANs on Switch/Fabric-Interconnect.
.PARAMETER MaxUncompressedPortVlanCount
Maximum configurable VLANs on Switch/Fabric-Interconnect.
.PARAMETER MaximumActiveTrafficMonitoringSessions
Maximum configured and enabled Traffic Monitoring sessions on this Switch/Fabric-Interconnect.
.PARAMETER MaximumEthernetPortChannels
Maximum configurable Ethernet port-channels on Switch/Fabric-Interconnect.
.PARAMETER MaximumEthernetUplinkPorts
Maximum configurable Ethernet Uplink ports on Switch/Fabric-Interconnect.
.PARAMETER MaximumFcPortChannelMembers
Maximum configurable Fibre Channel port-channel member ports on Switch/Fabric-Interconnect.
.PARAMETER MaximumFcPortChannels
Maximum configurable Fibre Channel port-channels on Switch/Fabric-Interconnect.
.PARAMETER MaximumIgmpGroups
Maximum configurable IGMP Groups on Switch/Fabric-Interconnect.
.PARAMETER MaximumPortChannelMembers
Maximum configurable ports per each port-channel on Switch/Fabric-Interconnect.
.PARAMETER MaximumPrimaryVlan
Maximum configurable Primary Private VLANs on Switch/Fabric-Interconnect.
.PARAMETER MaximumSecondaryVlan
Maximum configurable Secondary Private VLANs on Switch/Fabric-Interconnect.
.PARAMETER MaximumSecondaryVlanPerPrimary
Maximum configurable Secondary VLANs per each Primary VLAN on Switch/Fabric-Interconnect.
.PARAMETER MaximumVifs
Maximum allowes VIFs on Switch/Fabric-Interconnect.
.PARAMETER MaximumVlans
Maximum configurable VLANs on Switch/Fabric-Interconnect.
.PARAMETER MinimumActiveFans
Minimum required fans in 'active' state for this Switch/Fabric-Interconnect.
.OUTPUTS

CapabilitySwitchNetworkLimitsAllOf<PSCustomObject>
#>

function Initialize-IntersightCapabilitySwitchNetworkLimitsAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("capability.SwitchNetworkLimits")]
        [String]
        ${ClassId} = "capability.SwitchNetworkLimits",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("capability.SwitchNetworkLimits")]
        [String]
        ${ObjectType} = "capability.SwitchNetworkLimits",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaxCompressedPortVlanCount},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaxUncompressedPortVlanCount},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumActiveTrafficMonitoringSessions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumEthernetPortChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumEthernetUplinkPorts},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumFcPortChannelMembers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumFcPortChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumIgmpGroups},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumPortChannelMembers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumPrimaryVlan},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumSecondaryVlan},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumSecondaryVlanPerPrimary},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumVifs},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaximumVlans},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MinimumActiveFans}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightCapabilitySwitchNetworkLimitsAllOf' | Write-Debug
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
            "MaxCompressedPortVlanCount" = ${MaxCompressedPortVlanCount}
            "MaxUncompressedPortVlanCount" = ${MaxUncompressedPortVlanCount}
            "MaximumActiveTrafficMonitoringSessions" = ${MaximumActiveTrafficMonitoringSessions}
            "MaximumEthernetPortChannels" = ${MaximumEthernetPortChannels}
            "MaximumEthernetUplinkPorts" = ${MaximumEthernetUplinkPorts}
            "MaximumFcPortChannelMembers" = ${MaximumFcPortChannelMembers}
            "MaximumFcPortChannels" = ${MaximumFcPortChannels}
            "MaximumIgmpGroups" = ${MaximumIgmpGroups}
            "MaximumPortChannelMembers" = ${MaximumPortChannelMembers}
            "MaximumPrimaryVlan" = ${MaximumPrimaryVlan}
            "MaximumSecondaryVlan" = ${MaximumSecondaryVlan}
            "MaximumSecondaryVlanPerPrimary" = ${MaximumSecondaryVlanPerPrimary}
            "MaximumVifs" = ${MaximumVifs}
            "MaximumVlans" = ${MaximumVlans}
            "MinimumActiveFans" = ${MinimumActiveFans}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to CapabilitySwitchNetworkLimitsAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to CapabilitySwitchNetworkLimitsAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

CapabilitySwitchNetworkLimitsAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToCapabilitySwitchNetworkLimitsAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightCapabilitySwitchNetworkLimitsAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightCapabilitySwitchNetworkLimitsAllOf
        $AllProperties = ("ClassId", "ObjectType", "MaxCompressedPortVlanCount", "MaxUncompressedPortVlanCount", "MaximumActiveTrafficMonitoringSessions", "MaximumEthernetPortChannels", "MaximumEthernetUplinkPorts", "MaximumFcPortChannelMembers", "MaximumFcPortChannels", "MaximumIgmpGroups", "MaximumPortChannelMembers", "MaximumPrimaryVlan", "MaximumSecondaryVlan", "MaximumSecondaryVlanPerPrimary", "MaximumVifs", "MaximumVlans", "MinimumActiveFans")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaxCompressedPortVlanCount"))) { #optional property not found
            $MaxCompressedPortVlanCount = $null
        } else {
            $MaxCompressedPortVlanCount = $JsonParameters.PSobject.Properties["MaxCompressedPortVlanCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaxUncompressedPortVlanCount"))) { #optional property not found
            $MaxUncompressedPortVlanCount = $null
        } else {
            $MaxUncompressedPortVlanCount = $JsonParameters.PSobject.Properties["MaxUncompressedPortVlanCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumActiveTrafficMonitoringSessions"))) { #optional property not found
            $MaximumActiveTrafficMonitoringSessions = $null
        } else {
            $MaximumActiveTrafficMonitoringSessions = $JsonParameters.PSobject.Properties["MaximumActiveTrafficMonitoringSessions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumEthernetPortChannels"))) { #optional property not found
            $MaximumEthernetPortChannels = $null
        } else {
            $MaximumEthernetPortChannels = $JsonParameters.PSobject.Properties["MaximumEthernetPortChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumEthernetUplinkPorts"))) { #optional property not found
            $MaximumEthernetUplinkPorts = $null
        } else {
            $MaximumEthernetUplinkPorts = $JsonParameters.PSobject.Properties["MaximumEthernetUplinkPorts"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumFcPortChannelMembers"))) { #optional property not found
            $MaximumFcPortChannelMembers = $null
        } else {
            $MaximumFcPortChannelMembers = $JsonParameters.PSobject.Properties["MaximumFcPortChannelMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumFcPortChannels"))) { #optional property not found
            $MaximumFcPortChannels = $null
        } else {
            $MaximumFcPortChannels = $JsonParameters.PSobject.Properties["MaximumFcPortChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumIgmpGroups"))) { #optional property not found
            $MaximumIgmpGroups = $null
        } else {
            $MaximumIgmpGroups = $JsonParameters.PSobject.Properties["MaximumIgmpGroups"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumPortChannelMembers"))) { #optional property not found
            $MaximumPortChannelMembers = $null
        } else {
            $MaximumPortChannelMembers = $JsonParameters.PSobject.Properties["MaximumPortChannelMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumPrimaryVlan"))) { #optional property not found
            $MaximumPrimaryVlan = $null
        } else {
            $MaximumPrimaryVlan = $JsonParameters.PSobject.Properties["MaximumPrimaryVlan"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumSecondaryVlan"))) { #optional property not found
            $MaximumSecondaryVlan = $null
        } else {
            $MaximumSecondaryVlan = $JsonParameters.PSobject.Properties["MaximumSecondaryVlan"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumSecondaryVlanPerPrimary"))) { #optional property not found
            $MaximumSecondaryVlanPerPrimary = $null
        } else {
            $MaximumSecondaryVlanPerPrimary = $JsonParameters.PSobject.Properties["MaximumSecondaryVlanPerPrimary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumVifs"))) { #optional property not found
            $MaximumVifs = $null
        } else {
            $MaximumVifs = $JsonParameters.PSobject.Properties["MaximumVifs"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaximumVlans"))) { #optional property not found
            $MaximumVlans = $null
        } else {
            $MaximumVlans = $JsonParameters.PSobject.Properties["MaximumVlans"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MinimumActiveFans"))) { #optional property not found
            $MinimumActiveFans = $null
        } else {
            $MinimumActiveFans = $JsonParameters.PSobject.Properties["MinimumActiveFans"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "MaxCompressedPortVlanCount" = ${MaxCompressedPortVlanCount}
            "MaxUncompressedPortVlanCount" = ${MaxUncompressedPortVlanCount}
            "MaximumActiveTrafficMonitoringSessions" = ${MaximumActiveTrafficMonitoringSessions}
            "MaximumEthernetPortChannels" = ${MaximumEthernetPortChannels}
            "MaximumEthernetUplinkPorts" = ${MaximumEthernetUplinkPorts}
            "MaximumFcPortChannelMembers" = ${MaximumFcPortChannelMembers}
            "MaximumFcPortChannels" = ${MaximumFcPortChannels}
            "MaximumIgmpGroups" = ${MaximumIgmpGroups}
            "MaximumPortChannelMembers" = ${MaximumPortChannelMembers}
            "MaximumPrimaryVlan" = ${MaximumPrimaryVlan}
            "MaximumSecondaryVlan" = ${MaximumSecondaryVlan}
            "MaximumSecondaryVlanPerPrimary" = ${MaximumSecondaryVlanPerPrimary}
            "MaximumVifs" = ${MaximumVifs}
            "MaximumVlans" = ${MaximumVlans}
            "MinimumActiveFans" = ${MinimumActiveFans}
        }

        return $PSO
    }

}
