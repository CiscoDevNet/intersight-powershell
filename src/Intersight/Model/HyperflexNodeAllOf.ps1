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

Definition of the list of properties defined in 'hyperflex.Node', excluding properties defined in parent classes.

.PARAMETER Identity
No description available.
.PARAMETER Ip
No description available.
.PARAMETER Cluster
No description available.
.PARAMETER ClusterMember
No description available.
.PARAMETER PhysicalServer
No description available.
.OUTPUTS

HyperflexNodeAllOf<PSCustomObject>
#>

function Initialize-IntersightHyperflexNodeAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Identity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Ip},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Cluster},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ClusterMember},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PhysicalServer}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightHyperflexNodeAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Identity" = ${Identity}
            "Ip" = ${Ip}
            "Cluster" = ${Cluster}
            "ClusterMember" = ${ClusterMember}
            "PhysicalServer" = ${PhysicalServer}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to HyperflexNodeAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to HyperflexNodeAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

HyperflexNodeAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToHyperflexNodeAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightHyperflexNodeAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightHyperflexNodeAllOf
        $AllProperties = ("BuildNumber", "DisplayVersion", "HostName", "Hypervisor", "Identity", "Ip", "Lockdown", "ModelNumber", "Role", "SerialNumber", "Status", "Version", "Cluster", "ClusterMember", "PhysicalServer")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BuildNumber"))) { #optional property not found
            $BuildNumber = $null
        } else {
            $BuildNumber = $JsonParameters.PSobject.Properties["BuildNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayVersion"))) { #optional property not found
            $DisplayVersion = $null
        } else {
            $DisplayVersion = $JsonParameters.PSobject.Properties["DisplayVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HostName"))) { #optional property not found
            $HostName = $null
        } else {
            $HostName = $JsonParameters.PSobject.Properties["HostName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Hypervisor"))) { #optional property not found
            $Hypervisor = $null
        } else {
            $Hypervisor = $JsonParameters.PSobject.Properties["Hypervisor"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Identity"))) { #optional property not found
            $Identity = $null
        } else {
            $Identity = $JsonParameters.PSobject.Properties["Identity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Ip"))) { #optional property not found
            $Ip = $null
        } else {
            $Ip = $JsonParameters.PSobject.Properties["Ip"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Lockdown"))) { #optional property not found
            $Lockdown = $null
        } else {
            $Lockdown = $JsonParameters.PSobject.Properties["Lockdown"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ModelNumber"))) { #optional property not found
            $ModelNumber = $null
        } else {
            $ModelNumber = $JsonParameters.PSobject.Properties["ModelNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Role"))) { #optional property not found
            $Role = $null
        } else {
            $Role = $JsonParameters.PSobject.Properties["Role"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SerialNumber"))) { #optional property not found
            $SerialNumber = $null
        } else {
            $SerialNumber = $JsonParameters.PSobject.Properties["SerialNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Version"))) { #optional property not found
            $Version = $null
        } else {
            $Version = $JsonParameters.PSobject.Properties["Version"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Cluster"))) { #optional property not found
            $Cluster = $null
        } else {
            $Cluster = $JsonParameters.PSobject.Properties["Cluster"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClusterMember"))) { #optional property not found
            $ClusterMember = $null
        } else {
            $ClusterMember = $JsonParameters.PSobject.Properties["ClusterMember"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhysicalServer"))) { #optional property not found
            $PhysicalServer = $null
        } else {
            $PhysicalServer = $JsonParameters.PSobject.Properties["PhysicalServer"].value
        }

        $PSO = [PSCustomObject]@{
            "BuildNumber" = ${BuildNumber}
            "DisplayVersion" = ${DisplayVersion}
            "HostName" = ${HostName}
            "Hypervisor" = ${Hypervisor}
            "Identity" = ${Identity}
            "Ip" = ${Ip}
            "Lockdown" = ${Lockdown}
            "ModelNumber" = ${ModelNumber}
            "Role" = ${Role}
            "SerialNumber" = ${SerialNumber}
            "Status" = ${Status}
            "Version" = ${Version}
            "Cluster" = ${Cluster}
            "ClusterMember" = ${ClusterMember}
            "PhysicalServer" = ${PhysicalServer}
        }

        return $PSO
    }

}
