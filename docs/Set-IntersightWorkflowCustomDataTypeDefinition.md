---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightWorkflowCustomDataTypeDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightWorkflowCustomDataTypeDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Catalog< WorkflowCatalogRelationship>][-CompositeType< bool>][-Description< string>][-Label< string>][[-Moid]< string>][-Name< string>][-ParameterSet< System.Collections.Generic.List`1[WorkflowParameterSet]>][-Properties< WorkflowCustomDataTypeProperties>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TypeDefinition< System.Collections.Generic.List`1[WorkflowBaseDataType]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &amp;apos;WorkflowCustomDataTypeDefinition&amp;apos; resource.

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

### -Catalog
A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: WorkflowCatalogRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CompositeType
When true this data type definition is a collection of type definitions to represent composite data like JSON.

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

### -Description
A human-friendly description of this custom data type indicating it&apos;s domain and usage.

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

### -Label
A user friendly short name to identify the custom data type definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote (&apos;), or an underscore (_) and must be at least 2 characters.

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

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name of custom data type definition. The valid name can contain lower case and upper case alphabetic characters, digits and special characters &amp;apos;-&amp;apos; and &amp;apos;_&amp;apos;.

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

### -ParameterSet


Note :- Use Initialize-IntersightWorkflowParameterSet to create the object of complex type WorkflowParameterSet

```yaml
Type: System.Collections.Generic.List`1[WorkflowParameterSet]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Properties
Type to capture all the properties for the custom data type definition.

Note :- Use Initialize-IntersightWorkflowCustomDataTypeProperties to create the object of complex type WorkflowCustomDataTypeProperties

```yaml
Type: WorkflowCustomDataTypeProperties
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

### -TypeDefinition


Note :- Use Initialize-IntersightWorkflowBaseDataType to create the object of complex type WorkflowBaseDataType

```yaml
Type: System.Collections.Generic.List`1[WorkflowBaseDataType]
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
PS C:\> Set-IntersightWorkflowCustomDataTypeDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[New-IntersightWorkflowCustomDataTypeDefinition](./New-IntersightWorkflowCustomDataTypeDefinition.md)

[Get-IntersightWorkflowCustomDataTypeDefinition](./Get-IntersightWorkflowCustomDataTypeDefinition.md)

[Remove-IntersightWorkflowCustomDataTypeDefinition](./Remove-IntersightWorkflowCustomDataTypeDefinition.md)

[Initialize-IntersightWorkflowParameterSet](./Initialize-IntersightWorkflowParameterSet.md)

[Initialize-IntersightWorkflowCustomDataTypeProperties](./Initialize-IntersightWorkflowCustomDataTypeProperties.md)

[Initialize-IntersightWorkflowBaseDataType](./Initialize-IntersightWorkflowBaseDataType.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
