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

Captures configuration specific to the HyperV target for the Workload Optimizer service.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER DiscoverHostCluster
When enabled, all HyperV hosts in the same cluster of specified HyperV host target will be discovered Each server must still be configured to allow remote management (for example, configuring WinRM using a GPO).
.PARAMETER FullDomainName
Fully qualified domain name of the HyperV target. It is used to get the name of the Hyper-V cluster node and do Active Directory authentication process through Kerberos scheme.
.OUTPUTS

AssetWorkloadOptimizerHypervOptions<PSCustomObject>
#>

function Initialize-IntersightAssetWorkloadOptimizerHypervOptions {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("asset.WorkloadOptimizerHypervOptions")]
        [String]
        ${ClassId} = "asset.WorkloadOptimizerHypervOptions",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("asset.WorkloadOptimizerHypervOptions")]
        [String]
        ${ObjectType} = "asset.WorkloadOptimizerHypervOptions",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${DiscoverHostCluster},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullDomainName}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightAssetWorkloadOptimizerHypervOptions' | Write-Debug
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
            "DiscoverHostCluster" = ${DiscoverHostCluster}
            "FullDomainName" = ${FullDomainName}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to AssetWorkloadOptimizerHypervOptions<PSCustomObject>

.DESCRIPTION

Convert from JSON to AssetWorkloadOptimizerHypervOptions<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

AssetWorkloadOptimizerHypervOptions<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToAssetWorkloadOptimizerHypervOptions {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightAssetWorkloadOptimizerHypervOptions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightAssetWorkloadOptimizerHypervOptions
        $AllProperties = ("ClassId", "ObjectType", "DiscoverHostCluster", "FullDomainName")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DiscoverHostCluster"))) { #optional property not found
            $DiscoverHostCluster = $null
        } else {
            $DiscoverHostCluster = $JsonParameters.PSobject.Properties["DiscoverHostCluster"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullDomainName"))) { #optional property not found
            $FullDomainName = $null
        } else {
            $FullDomainName = $JsonParameters.PSobject.Properties["FullDomainName"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "DiscoverHostCluster" = ${DiscoverHostCluster}
            "FullDomainName" = ${FullDomainName}
        }

        return $PSO
    }

}

