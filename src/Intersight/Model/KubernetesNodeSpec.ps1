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

Kubernetes Node Specification.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER PodCidr
Node Pod CIDR. In Kubernetes, the workload (Pod) is allocated to an IP address by Kubernetes. The IP address is from a Pod CIDR of the cluster. Each node will (mostly) evenly be distributed the Pod CIDR.
.PARAMETER ProviderId
Kubernetes can be running on a specific cloud provider such as Openstack, Amazon Web Services, vCenter etc. Each cloud provider will have a specific cloud provider ID. This field is to represent that ID for the corresponding Kubernetes cluster.
.OUTPUTS

KubernetesNodeSpec<PSCustomObject>
#>

function Initialize-IntersightKubernetesNodeSpec {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("kubernetes.NodeSpec")]
        [String]
        ${ClassId} = "kubernetes.NodeSpec",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("kubernetes.NodeSpec")]
        [String]
        ${ObjectType} = "kubernetes.NodeSpec",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PodCidr},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProviderId}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightKubernetesNodeSpec' | Write-Debug
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
            "PodCidr" = ${PodCidr}
            "ProviderId" = ${ProviderId}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to KubernetesNodeSpec<PSCustomObject>

.DESCRIPTION

Convert from JSON to KubernetesNodeSpec<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

KubernetesNodeSpec<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToKubernetesNodeSpec {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightKubernetesNodeSpec' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightKubernetesNodeSpec
        $AllProperties = ("ClassId", "ObjectType", "PodCidr", "ProviderId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PodCidr"))) { #optional property not found
            $PodCidr = $null
        } else {
            $PodCidr = $JsonParameters.PSobject.Properties["PodCidr"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProviderId"))) { #optional property not found
            $ProviderId = $null
        } else {
            $ProviderId = $JsonParameters.PSobject.Properties["ProviderId"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "PodCidr" = ${PodCidr}
            "ProviderId" = ${ProviderId}
        }

        return $PSO
    }

}

