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

Network interface configuration data for IPv6 interfaces. Netmask, Gateway and DNS settings.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER Gateway
IP address of the default IPv6 gateway.
.PARAMETER Prefix
A prefix length which masks the  IP address and divides the IP address into network address and host address.
.PARAMETER PrimaryDns
IP Address of the primary Domain Name System (DNS) server.
.PARAMETER SecondaryDns
IP Address of the secondary Domain Name System (DNS) server.
.OUTPUTS

IppoolIpV6Config<PSCustomObject>
#>

function Initialize-IntersightIppoolIpV6Config {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("ippool.IpV6Config")]
        [String]
        ${ClassId} = "ippool.IpV6Config",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("ippool.IpV6Config")]
        [String]
        ${ObjectType} = "ippool.IpV6Config",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        [String]
        ${Gateway},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${Prefix},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        [String]
        ${PrimaryDns},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^$|^(([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:([0-9A-Fa-f]{1,4}:[0-9A-Fa-f]{0,4}|:[0-9A-Fa-f]{1,4})?|(:[0-9A-Fa-f]{1,4}){0,2})|(:[0-9A-Fa-f]{1,4}){0,3})|(:[0-9A-Fa-f]{1,4}){0,4})|:(:[0-9A-Fa-f]{1,4}){0,5})((:[0-9A-Fa-f]{1,4}){2}|:(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])(\.(25[0-5]|(2[0-4]|1[0-9]|[1-9])?[0-9])){3})|(([0-9A-Fa-f]{1,4}:){1,6}|:):[0-9A-Fa-f]{0,4}|([0-9A-Fa-f]{1,4}:){7}:)$")]
        [String]
        ${SecondaryDns}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightIppoolIpV6Config' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if ($Prefix -and $Prefix -gt 127) {
          throw "invalid value for 'Prefix', must be smaller than or equal to 127."
        }

        if ($Prefix -and $Prefix -lt 1) {
          throw "invalid value for 'Prefix', must be greater than or equal to 1."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Gateway" = ${Gateway}
            "Prefix" = ${Prefix}
            "PrimaryDns" = ${PrimaryDns}
            "SecondaryDns" = ${SecondaryDns}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to IppoolIpV6Config<PSCustomObject>

.DESCRIPTION

Convert from JSON to IppoolIpV6Config<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

IppoolIpV6Config<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToIppoolIpV6Config {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightIppoolIpV6Config' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightIppoolIpV6Config
        $AllProperties = ("ClassId", "ObjectType", "Gateway", "Prefix", "PrimaryDns", "SecondaryDns")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Gateway"))) { #optional property not found
            $Gateway = $null
        } else {
            $Gateway = $JsonParameters.PSobject.Properties["Gateway"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Prefix"))) { #optional property not found
            $Prefix = $null
        } else {
            $Prefix = $JsonParameters.PSobject.Properties["Prefix"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryDns"))) { #optional property not found
            $PrimaryDns = $null
        } else {
            $PrimaryDns = $JsonParameters.PSobject.Properties["PrimaryDns"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryDns"))) { #optional property not found
            $SecondaryDns = $null
        } else {
            $SecondaryDns = $JsonParameters.PSobject.Properties["SecondaryDns"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Gateway" = ${Gateway}
            "Prefix" = ${Prefix}
            "PrimaryDns" = ${PrimaryDns}
            "SecondaryDns" = ${SecondaryDns}
        }

        return $PSO
    }

}

