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

Definition of the list of properties defined in 'equipment.IoCardBase', excluding properties defined in parent classes.

.PARAMETER ConnectionStatus
Connectivity Status of FEX/IOM to Switch - A or B or AB.
.PARAMETER HostPorts
An array of relationships to etherHostPort resources.
.PARAMETER MgmtController
No description available.
.PARAMETER NetworkPorts
An array of relationships to etherNetworkPort resources.
.OUTPUTS

EquipmentIoCardBaseAllOf<PSCustomObject>
#>

function Initialize-IntersightEquipmentIoCardBaseAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ConnectionStatus},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${HostPorts},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MgmtController},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${NetworkPorts}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightEquipmentIoCardBaseAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ConnectionStatus" = ${ConnectionStatus}
            "HostPorts" = ${HostPorts}
            "MgmtController" = ${MgmtController}
            "NetworkPorts" = ${NetworkPorts}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to EquipmentIoCardBaseAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to EquipmentIoCardBaseAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

EquipmentIoCardBaseAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToEquipmentIoCardBaseAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightEquipmentIoCardBaseAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightEquipmentIoCardBaseAllOf
        $AllProperties = ("ConnectionStatus", "Description", "ModuleId", "OperState", "PartNumber", "Pid", "Presence", "ProductName", "Sku", "Version", "Vid", "HostPorts", "MgmtController", "NetworkPorts")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectionStatus"))) { #optional property not found
            $ConnectionStatus = $null
        } else {
            $ConnectionStatus = $JsonParameters.PSobject.Properties["ConnectionStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ModuleId"))) { #optional property not found
            $ModuleId = $null
        } else {
            $ModuleId = $JsonParameters.PSobject.Properties["ModuleId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OperState"))) { #optional property not found
            $OperState = $null
        } else {
            $OperState = $JsonParameters.PSobject.Properties["OperState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PartNumber"))) { #optional property not found
            $PartNumber = $null
        } else {
            $PartNumber = $JsonParameters.PSobject.Properties["PartNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Pid"))) { #optional property not found
            $VarPid = $null
        } else {
            $VarPid = $JsonParameters.PSobject.Properties["Pid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Presence"))) { #optional property not found
            $Presence = $null
        } else {
            $Presence = $JsonParameters.PSobject.Properties["Presence"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProductName"))) { #optional property not found
            $ProductName = $null
        } else {
            $ProductName = $JsonParameters.PSobject.Properties["ProductName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sku"))) { #optional property not found
            $Sku = $null
        } else {
            $Sku = $JsonParameters.PSobject.Properties["Sku"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Version"))) { #optional property not found
            $Version = $null
        } else {
            $Version = $JsonParameters.PSobject.Properties["Version"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Vid"))) { #optional property not found
            $Vid = $null
        } else {
            $Vid = $JsonParameters.PSobject.Properties["Vid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HostPorts"))) { #optional property not found
            $HostPorts = $null
        } else {
            $HostPorts = $JsonParameters.PSobject.Properties["HostPorts"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MgmtController"))) { #optional property not found
            $MgmtController = $null
        } else {
            $MgmtController = $JsonParameters.PSobject.Properties["MgmtController"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkPorts"))) { #optional property not found
            $NetworkPorts = $null
        } else {
            $NetworkPorts = $JsonParameters.PSobject.Properties["NetworkPorts"].value
        }

        $PSO = [PSCustomObject]@{
            "ConnectionStatus" = ${ConnectionStatus}
            "Description" = ${Description}
            "ModuleId" = ${ModuleId}
            "OperState" = ${OperState}
            "PartNumber" = ${PartNumber}
            "Pid" = ${VarPid}
            "Presence" = ${Presence}
            "ProductName" = ${ProductName}
            "Sku" = ${Sku}
            "Version" = ${Version}
            "Vid" = ${Vid}
            "HostPorts" = ${HostPorts}
            "MgmtController" = ${MgmtController}
            "NetworkPorts" = ${NetworkPorts}
        }

        return $PSO
    }

}
