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

No description available.

.PARAMETER Code
A value that is used to determine the nature of the error, and why it occurred.
.PARAMETER MessageId
A language-independent identifier of the specific error message.
.PARAMETER Message
A human-readable description of the error, localized with the i18n standard. The language is determined from the ""Accept-Language"" request-header. The Accept-Language request-header restricts the set of natural languages that are preferred as a response to the request. See RFC 2616 for more details. Codes: 1. **InternalServerError**   An internal error occurred. 1. **InvalidMethod**         The HTTP method (POST, PUT...) is invalid for this API path. For example, a POST request was sent but this API path only supports GET. 1. **InvalidUrl**            The HTTP request contains an invalid URL. 1. **InvalidRequest**        The HTTP request contains an invalid or malformed message body. 1. **NotSupported**          The request is not supported for the specified REST resource. 1. **NotImplemented**        This API path is experimental and not implemented yet. 1. **NotFound**              The requested REST resource does not exist. 1. **AuthenticationFailure** The request lacks valid authentication credentials. 1. **UnauthorizedOperation** The client is not authorized to perform the operation, such as when the user has insufficient privileges. 1. **ValidationConflict**    The request contains conflicting attributes, such as two mutually exclusive attribute values. 1. **ServiceUnavailable**    See RFC 7231, status 503.
.PARAMETER Cause
No description available.
.OUTPUTS

ModelError<PSCustomObject>
#>

function Initialize-IntersightModelError {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("InternalServerError", "InvalidMethod", "InvalidUrl", "InvalidRequest", "NotFound", "NotSupported", "NotImplemented", "AuthenticationFailure", "UnauthorizedOperation", "ValidationConflict", "ServiceUnavailable")]
        [String]
        ${Code},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MessageId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Message},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Cause}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightModelError' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$Code) {
            throw "invalid value for 'Code', 'Code' cannot be null."
        }

        if (!$Message) {
            throw "invalid value for 'Message', 'Message' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "code" = ${Code}
            "messageId" = ${MessageId}
            "message" = ${Message}
            "cause" = ${Cause}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to ModelError<PSCustomObject>

.DESCRIPTION

Convert from JSON to ModelError<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

ModelError<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToModelError {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightModelError' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightModelError
        $AllProperties = ("code", "messageId", "message", "cause")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'code' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "code"))) {
            throw "Error! JSON cannot be serialized due to the required property 'code' missing."
        } else {
            $Code = $JsonParameters.PSobject.Properties["code"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "message"))) {
            throw "Error! JSON cannot be serialized due to the required property 'message' missing."
        } else {
            $Message = $JsonParameters.PSobject.Properties["message"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "messageId"))) { #optional property not found
            $MessageId = $null
        } else {
            $MessageId = $JsonParameters.PSobject.Properties["messageId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "cause"))) { #optional property not found
            $Cause = $null
        } else {
            $Cause = $JsonParameters.PSobject.Properties["cause"].value
        }

        $PSO = [PSCustomObject]@{
            "code" = ${Code}
            "messageId" = ${MessageId}
            "message" = ${Message}
            "cause" = ${Cause}
        }

        return $PSO
    }

}

