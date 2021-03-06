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

Definition of the list of properties defined in 'sol.Policy', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER BaudRate
Baud Rate used for Serial Over LAN communication. * `9600` - Use baud rate 9600 for communication. * `19200` - Use baud rate 19200 for communication. * `38400` - Use baud rate 38400 for communication. * `57600` - Use baud rate 57600 for communication. * `115200` - Use baud rate 115200 for communication.
.PARAMETER ComPort
Serial port through which the system routes Serial Over LAN communication. This field is available only on some Cisco UCS C-Series servers. If it is unavailable, the server uses COM port 0 by default. * `com0` - Use serial port com0 for communication. * `com1` - Use serial port com1 for communication.
.PARAMETER Enabled
State of Serial Over LAN service on the endpoint.
.PARAMETER SshPort
SSH port used to access Serial Over LAN directly. Enables bypassing Cisco IMC shell to provide direct access to Serial Over LAN.
.PARAMETER Organization
No description available.
.PARAMETER Profiles
An array of relationships to policyAbstractConfigProfile resources.
.OUTPUTS

SolPolicyAllOf<PSCustomObject>
#>

function Initialize-IntersightSolPolicyAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("sol.Policy")]
        [String]
        ${ClassId} = "sol.Policy",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("sol.Policy")]
        [String]
        ${ObjectType} = "sol.Policy",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("9600", "19200", "38400", "57600", "115200")]
        [System.Nullable[Int32]]
        ${BaudRate} = 9600,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("com0", "com1")]
        [String]
        ${ComPort} = "com0",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $true,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${SshPort} = 2400,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Organization},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Profiles}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightSolPolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if ($SshPort -and $SshPort -gt 65535) {
          throw "invalid value for 'SshPort', must be smaller than or equal to 65535."
        }

        if ($SshPort -and $SshPort -lt 1024) {
          throw "invalid value for 'SshPort', must be greater than or equal to 1024."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "BaudRate" = ${BaudRate}
            "ComPort" = ${ComPort}
            "Enabled" = ${Enabled}
            "SshPort" = ${SshPort}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to SolPolicyAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to SolPolicyAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

SolPolicyAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToSolPolicyAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightSolPolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightSolPolicyAllOf
        $AllProperties = ("ClassId", "ObjectType", "BaudRate", "ComPort", "Enabled", "SshPort", "Organization", "Profiles")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BaudRate"))) { #optional property not found
            $BaudRate = $null
        } else {
            $BaudRate = $JsonParameters.PSobject.Properties["BaudRate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComPort"))) { #optional property not found
            $ComPort = $null
        } else {
            $ComPort = $JsonParameters.PSobject.Properties["ComPort"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SshPort"))) { #optional property not found
            $SshPort = $null
        } else {
            $SshPort = $JsonParameters.PSobject.Properties["SshPort"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Organization"))) { #optional property not found
            $Organization = $null
        } else {
            $Organization = $JsonParameters.PSobject.Properties["Organization"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Profiles"))) { #optional property not found
            $Profiles = $null
        } else {
            $Profiles = $JsonParameters.PSobject.Properties["Profiles"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "BaudRate" = ${BaudRate}
            "ComPort" = ${ComPort}
            "Enabled" = ${Enabled}
            "SshPort" = ${SshPort}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }

}

