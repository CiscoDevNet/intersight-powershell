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

Configuration of Calico CNI plugin.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER Registry
CNI Image registry location.
.PARAMETER Version
Container newtork interface plugin configuration.
.PARAMETER IpVersion
IP version that can take on values v4 or v6. * `v4` - This refers to the IPv4 address. * `v6` - This refers to the IPv6 address.
.PARAMETER Mtu
Workload interface maximum transmission unit (MTU).
.OUTPUTS

KubernetesCalicoConfig<PSCustomObject>
#>

function Initialize-IntersightKubernetesCalicoConfig {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("kubernetes.CalicoConfig")]
        [String]
        ${ClassId} = "kubernetes.CalicoConfig",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("kubernetes.CalicoConfig")]
        [String]
        ${ObjectType} = "kubernetes.CalicoConfig",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Registry},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Version},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("v4", "v6")]
        [String]
        ${IpVersion} = "v4",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${Mtu}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightKubernetesCalicoConfig' | Write-Debug
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
            "Registry" = ${Registry}
            "Version" = ${Version}
            "IpVersion" = ${IpVersion}
            "Mtu" = ${Mtu}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to KubernetesCalicoConfig<PSCustomObject>

.DESCRIPTION

Convert from JSON to KubernetesCalicoConfig<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

KubernetesCalicoConfig<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToKubernetesCalicoConfig {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightKubernetesCalicoConfig' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightKubernetesCalicoConfig
        $AllProperties = ("ClassId", "ObjectType", "Registry", "Version", "IpVersion", "Mtu")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Registry"))) { #optional property not found
            $Registry = $null
        } else {
            $Registry = $JsonParameters.PSobject.Properties["Registry"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Version"))) { #optional property not found
            $Version = $null
        } else {
            $Version = $JsonParameters.PSobject.Properties["Version"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IpVersion"))) { #optional property not found
            $IpVersion = $null
        } else {
            $IpVersion = $JsonParameters.PSobject.Properties["IpVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Mtu"))) { #optional property not found
            $Mtu = $null
        } else {
            $Mtu = $JsonParameters.PSobject.Properties["Mtu"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Registry" = ${Registry}
            "Version" = ${Version}
            "IpVersion" = ${IpVersion}
            "Mtu" = ${Mtu}
        }

        return $PSO
    }

}

