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

Definition of the list of properties defined in 'vnic.RssHashSettings', excluding properties defined in parent classes.

.PARAMETER Ipv4Hash
When enabled, the IPv4 address is used for traffic distribution.
.PARAMETER Ipv6ExtHash
When enabled, the IPv6 extensions are used for traffic distribution.
.PARAMETER Ipv6Hash
When enabled, the IPv6 address is used for traffic distribution.
.PARAMETER TcpIpv4Hash
When enabled, both the IPv4 address and TCP port number are used for traffic distribution.
.PARAMETER TcpIpv6ExtHash
When enabled, both the IPv6 extensions and TCP port number are used for traffic distribution.
.PARAMETER TcpIpv6Hash
When enabled, both the IPv6 address and TCP port number are used for traffic distribution.
.PARAMETER UdpIpv4Hash
When enabled, both the IPv4 address and UDP port number are used for traffic distribution.
.PARAMETER UdpIpv6Hash
When enabled, both the IPv6 address and UDP port number are used for traffic distribution.
.OUTPUTS

VnicRssHashSettingsAllOf<PSCustomObject>
#>

function Initialize-IntersightVnicRssHashSettingsAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Ipv4Hash},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Ipv6ExtHash},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Ipv6Hash},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${TcpIpv4Hash},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${TcpIpv6ExtHash},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${TcpIpv6Hash},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${UdpIpv4Hash},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${UdpIpv6Hash}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightVnicRssHashSettingsAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Ipv4Hash" = ${Ipv4Hash}
            "Ipv6ExtHash" = ${Ipv6ExtHash}
            "Ipv6Hash" = ${Ipv6Hash}
            "TcpIpv4Hash" = ${TcpIpv4Hash}
            "TcpIpv6ExtHash" = ${TcpIpv6ExtHash}
            "TcpIpv6Hash" = ${TcpIpv6Hash}
            "UdpIpv4Hash" = ${UdpIpv4Hash}
            "UdpIpv6Hash" = ${UdpIpv6Hash}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to VnicRssHashSettingsAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to VnicRssHashSettingsAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

VnicRssHashSettingsAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToVnicRssHashSettingsAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightVnicRssHashSettingsAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightVnicRssHashSettingsAllOf
        $AllProperties = ("Ipv4Hash", "Ipv6ExtHash", "Ipv6Hash", "TcpIpv4Hash", "TcpIpv6ExtHash", "TcpIpv6Hash", "UdpIpv4Hash", "UdpIpv6Hash")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Ipv4Hash"))) { #optional property not found
            $Ipv4Hash = $null
        } else {
            $Ipv4Hash = $JsonParameters.PSobject.Properties["Ipv4Hash"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Ipv6ExtHash"))) { #optional property not found
            $Ipv6ExtHash = $null
        } else {
            $Ipv6ExtHash = $JsonParameters.PSobject.Properties["Ipv6ExtHash"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Ipv6Hash"))) { #optional property not found
            $Ipv6Hash = $null
        } else {
            $Ipv6Hash = $JsonParameters.PSobject.Properties["Ipv6Hash"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TcpIpv4Hash"))) { #optional property not found
            $TcpIpv4Hash = $null
        } else {
            $TcpIpv4Hash = $JsonParameters.PSobject.Properties["TcpIpv4Hash"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TcpIpv6ExtHash"))) { #optional property not found
            $TcpIpv6ExtHash = $null
        } else {
            $TcpIpv6ExtHash = $JsonParameters.PSobject.Properties["TcpIpv6ExtHash"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TcpIpv6Hash"))) { #optional property not found
            $TcpIpv6Hash = $null
        } else {
            $TcpIpv6Hash = $JsonParameters.PSobject.Properties["TcpIpv6Hash"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UdpIpv4Hash"))) { #optional property not found
            $UdpIpv4Hash = $null
        } else {
            $UdpIpv4Hash = $JsonParameters.PSobject.Properties["UdpIpv4Hash"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UdpIpv6Hash"))) { #optional property not found
            $UdpIpv6Hash = $null
        } else {
            $UdpIpv6Hash = $JsonParameters.PSobject.Properties["UdpIpv6Hash"].value
        }

        $PSO = [PSCustomObject]@{
            "Ipv4Hash" = ${Ipv4Hash}
            "Ipv6ExtHash" = ${Ipv6ExtHash}
            "Ipv6Hash" = ${Ipv6Hash}
            "TcpIpv4Hash" = ${TcpIpv4Hash}
            "TcpIpv6ExtHash" = ${TcpIpv6ExtHash}
            "TcpIpv6Hash" = ${TcpIpv6Hash}
            "UdpIpv4Hash" = ${UdpIpv4Hash}
            "UdpIpv6Hash" = ${UdpIpv6Hash}
        }

        return $PSO
    }

}
