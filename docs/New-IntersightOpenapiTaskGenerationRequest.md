---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightOpenapiTaskGenerationRequest

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightOpenapiTaskGenerationRequest [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-EndpointType< OpenapiTaskGenerationRequest.EndpointTypeEnum>][-HeaderParameters< System.Collections.Generic.List`1[OpenapiKeyValuePair]>][-IsValidateRequest< bool>][-Moid< string>][-Organization< OrganizationOrganizationRelationship>][-Protocol< OpenapiTaskGenerationRequest.ProtocolEnum>][-QueryParameters< System.Collections.Generic.List`1[OpenapiKeyValuePair]>][-SelectedApis< System.Collections.Generic.List`1[OpenapiApiInfo]>][-Source< OpenapiProcessFileRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TaskPrefix< string>][-TaskTags< System.Collections.Generic.List`1[OpenapiKeyValuePair]>][-Url< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;OpenapiTaskGenerationRequest&apos; resource.

## PARAMETERS

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EndpointType
Indicates if target endpoint is external or internal. An endpoint is internal if the target is an Intersight resource. For instance, configuring an intersight object using a Task.\n* `External` - Denotes that the target endpoint is an external API endpoint.\n* `Internal` - Denotes that the target endpoint is a Intersight API endpoint.

```yaml
Type: OpenapiTaskGenerationRequest.EndpointTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HeaderParameters


Note :- Use Initialize-IntersightOpenapiKeyValuePair to create the object of complex type OpenapiKeyValuePair

```yaml
Type: System.Collections.Generic.List`1[OpenapiKeyValuePair]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsValidateRequest
When this value is set to true, the task name validations happen and provides the task validation status against each of the selected API on the property selectedApis When this value is set to false, an internal workflow to generate the tasks is submitted,  conflicting task names are created with an incremented version.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Protocol
Specifies the REST API protocol being used, which can be one of HTTP or HTTPS.\n* `HTTPS` - Denotes that the API call uses the HTTPS protocol type\n* `HTTP` - Denotes that the API call uses the HTTP protocol type

```yaml
Type: OpenapiTaskGenerationRequest.ProtocolEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QueryParameters


Note :- Use Initialize-IntersightOpenapiKeyValuePair to create the object of complex type OpenapiKeyValuePair

```yaml
Type: System.Collections.Generic.List`1[OpenapiKeyValuePair]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SelectedApis


Note :- Use Initialize-IntersightOpenapiApiInfo to create the object of complex type OpenapiApiInfo

```yaml
Type: System.Collections.Generic.List`1[OpenapiApiInfo]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Source
A reference to a openapiProcessFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OpenapiProcessFileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TaskPrefix
Optional string that can be prefixed to the name of created tasks.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TaskTags


Note :- Use Initialize-IntersightOpenapiKeyValuePair to create the object of complex type OpenapiKeyValuePair

```yaml
Type: System.Collections.Generic.List`1[OpenapiKeyValuePair]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Url
Specifies the URL of the endpoint that the created task communicates with. It is defaulted to intersight.com for internal endpoints.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightOpenapiTaskGenerationRequest
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightOpenapiTaskGenerationRequest](./Get-IntersightOpenapiTaskGenerationRequest.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightOpenapiApiInfo](./Initialize-IntersightOpenapiApiInfo.md)

[Initialize-IntersightOpenapiFailedTask](./Initialize-IntersightOpenapiFailedTask.md)

[Initialize-IntersightOpenapiKeyValuePair](./Initialize-IntersightOpenapiKeyValuePair.md)

[Remove-IntersightOpenapiTaskGenerationRequest](./Remove-IntersightOpenapiTaskGenerationRequest.md)

[Set-IntersightOpenapiTaskGenerationRequest](./Set-IntersightOpenapiTaskGenerationRequest.md)
