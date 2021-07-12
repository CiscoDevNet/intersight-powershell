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

Definition of the list of properties defined in 'kubernetes.EsxiVirtualMachineInfraConfig', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER Cluster
Name of the vSphere cluster on which the virtual machines are created.
.PARAMETER Datastore
Name of the datasore on which the virtual machine disks are created.
.PARAMETER Passphrase
Passphrase for the vcenter user.
.PARAMETER ResourcePool
Name of the vSphere resource pool on which the virtual machines are created.
.OUTPUTS

KubernetesEsxiVirtualMachineInfraConfigAllOf<PSCustomObject>
#>

function Initialize-IntersightKubernetesEsxiVirtualMachineInfraConfigAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("kubernetes.EsxiVirtualMachineInfraConfig")]
        [String]
        ${ClassId} = "kubernetes.EsxiVirtualMachineInfraConfig",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("kubernetes.EsxiVirtualMachineInfraConfig")]
        [String]
        ${ObjectType} = "kubernetes.EsxiVirtualMachineInfraConfig",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Cluster},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Datastore},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Passphrase},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ResourcePool}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightKubernetesEsxiVirtualMachineInfraConfigAllOf' | Write-Debug
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
            "Cluster" = ${Cluster}
            "Datastore" = ${Datastore}
            "Passphrase" = ${Passphrase}
            "ResourcePool" = ${ResourcePool}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to KubernetesEsxiVirtualMachineInfraConfigAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to KubernetesEsxiVirtualMachineInfraConfigAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

KubernetesEsxiVirtualMachineInfraConfigAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToKubernetesEsxiVirtualMachineInfraConfigAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightKubernetesEsxiVirtualMachineInfraConfigAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightKubernetesEsxiVirtualMachineInfraConfigAllOf
        $AllProperties = ("ClassId", "ObjectType", "Cluster", "Datastore", "IsPassphraseSet", "Passphrase", "ResourcePool")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Cluster"))) { #optional property not found
            $Cluster = $null
        } else {
            $Cluster = $JsonParameters.PSobject.Properties["Cluster"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Datastore"))) { #optional property not found
            $Datastore = $null
        } else {
            $Datastore = $JsonParameters.PSobject.Properties["Datastore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPassphraseSet"))) { #optional property not found
            $IsPassphraseSet = $null
        } else {
            $IsPassphraseSet = $JsonParameters.PSobject.Properties["IsPassphraseSet"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Passphrase"))) { #optional property not found
            $Passphrase = $null
        } else {
            $Passphrase = $JsonParameters.PSobject.Properties["Passphrase"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ResourcePool"))) { #optional property not found
            $ResourcePool = $null
        } else {
            $ResourcePool = $JsonParameters.PSobject.Properties["ResourcePool"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Cluster" = ${Cluster}
            "Datastore" = ${Datastore}
            "IsPassphraseSet" = ${IsPassphraseSet}
            "Passphrase" = ${Passphrase}
            "ResourcePool" = ${ResourcePool}
        }

        return $PSO
    }

}
