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

Definition of the list of properties defined in 'fabric.AppliancePcRole', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER AdminSpeed
Admin configured speed for the port channel. * `Auto` - Admin configurable speed AUTO ( default ). * `1Gbps` - Admin configurable speed 1Gbps. * `10Gbps` - Admin configurable speed 10Gbps. * `25Gbps` - Admin configurable speed 25Gbps. * `40Gbps` - Admin configurable speed 40Gbps. * `100Gbps` - Admin configurable speed 100Gbps.
.PARAMETER Mode
Port mode to be set on the appliance port-channel. * `trunk` - Trunk Mode Switch Port Type. * `access` - Access Mode Switch Port Type.
.PARAMETER Priority
The 'name' of the System QoS Class. * `Best Effort` - QoS Priority for Best-effort traffic. * `FC` - QoS Priority for FC traffic. * `Platinum` - QoS Priority for Platinum traffic. * `Gold` - QoS Priority for Gold traffic. * `Silver` - QoS Priority for Silver traffic. * `Bronze` - QoS Priority for Bronze traffic.
.PARAMETER EthNetworkControlPolicy
No description available.
.PARAMETER EthNetworkGroupPolicy
No description available.
.OUTPUTS

FabricAppliancePcRoleAllOf<PSCustomObject>
#>

function Initialize-IntersightFabricAppliancePcRoleAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fabric.AppliancePcRole")]
        [String]
        ${ClassId} = "fabric.AppliancePcRole",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fabric.AppliancePcRole")]
        [String]
        ${ObjectType} = "fabric.AppliancePcRole",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Auto", "1Gbps", "10Gbps", "25Gbps", "40Gbps", "100Gbps")]
        [String]
        ${AdminSpeed} = "Auto",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("trunk", "access")]
        [String]
        ${Mode} = "trunk",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Best Effort", "FC", "Platinum", "Gold", "Silver", "Bronze")]
        [String]
        ${Priority} = "Best Effort",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${EthNetworkControlPolicy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${EthNetworkGroupPolicy}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFabricAppliancePcRoleAllOf' | Write-Debug
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
            "AdminSpeed" = ${AdminSpeed}
            "Mode" = ${Mode}
            "Priority" = ${Priority}
            "EthNetworkControlPolicy" = ${EthNetworkControlPolicy}
            "EthNetworkGroupPolicy" = ${EthNetworkGroupPolicy}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FabricAppliancePcRoleAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to FabricAppliancePcRoleAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FabricAppliancePcRoleAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFabricAppliancePcRoleAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFabricAppliancePcRoleAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFabricAppliancePcRoleAllOf
        $AllProperties = ("ClassId", "ObjectType", "AdminSpeed", "Mode", "Priority", "EthNetworkControlPolicy", "EthNetworkGroupPolicy")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminSpeed"))) { #optional property not found
            $AdminSpeed = $null
        } else {
            $AdminSpeed = $JsonParameters.PSobject.Properties["AdminSpeed"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Mode"))) { #optional property not found
            $Mode = $null
        } else {
            $Mode = $JsonParameters.PSobject.Properties["Mode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Priority"))) { #optional property not found
            $Priority = $null
        } else {
            $Priority = $JsonParameters.PSobject.Properties["Priority"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EthNetworkControlPolicy"))) { #optional property not found
            $EthNetworkControlPolicy = $null
        } else {
            $EthNetworkControlPolicy = $JsonParameters.PSobject.Properties["EthNetworkControlPolicy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EthNetworkGroupPolicy"))) { #optional property not found
            $EthNetworkGroupPolicy = $null
        } else {
            $EthNetworkGroupPolicy = $JsonParameters.PSobject.Properties["EthNetworkGroupPolicy"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "AdminSpeed" = ${AdminSpeed}
            "Mode" = ${Mode}
            "Priority" = ${Priority}
            "EthNetworkControlPolicy" = ${EthNetworkControlPolicy}
            "EthNetworkGroupPolicy" = ${EthNetworkGroupPolicy}
        }

        return $PSO
    }

}

