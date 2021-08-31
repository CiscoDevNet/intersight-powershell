---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowPrimitiveDataType

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowPrimitiveDataType [-AdditionalProperties< Dictionary<string,object>>][-ClassId< WorkflowPrimitiveDataType.ClassIdEnum>][-Default< Model.WorkflowDefaultValue>][-Description< string>][-DisplayMeta< Model.WorkflowDisplayMeta>][-InputParameters< object>][-Label< string>][-Name< string>][-ObjectType< WorkflowPrimitiveDataType.ObjectTypeEnum>][-Properties< Model.WorkflowPrimitiveDataProperty>][-Required< bool>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: WorkflowPrimitiveDataType.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Default
Default value for the data type. If default value was provided and the input was required the default value will be used as the input.

Note :- Use Initialize-IntersightWorkflowDefaultValue to create the object of complex type WorkflowDefaultValue

```yaml
Type: Model.WorkflowDefaultValue
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Provide a detailed description of the data type.

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

### -DisplayMeta
Captures the meta data needed for displaying workflow data types in Intersight User Interface.

Note :- Use Initialize-IntersightWorkflowDisplayMeta to create the object of complex type WorkflowDisplayMeta

```yaml
Type: Model.WorkflowDisplayMeta
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InputParameters
JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is &amp;apos;${workflow.input.property}&amp;apos;. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is &amp;apos;${workflow.input.property.subproperty}&amp;apos;. The format to specify mapping in a custom data type definition is &amp;apos;${datatype.type.property}&amp;apos;. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like &amp;apos;cdt_property:${workflow.input.property}&amp;apos;.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Label
Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character.

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

### -Name
Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: WorkflowPrimitiveDataType.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Properties
Primitive data type properties.

Note :- Use Initialize-IntersightWorkflowPrimitiveDataProperty to create the object of complex type WorkflowPrimitiveDataProperty

```yaml
Type: Model.WorkflowPrimitiveDataProperty
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Required
Specifies whether this parameter is required. The field is applicable for task and workflow.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightWorkflowPrimitiveDataType
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightWorkflowDefaultValue](./Initialize-IntersightWorkflowDefaultValue.md)

[Initialize-IntersightWorkflowDisplayMeta](./Initialize-IntersightWorkflowDisplayMeta.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[Initialize-IntersightWorkflowPrimitiveDataProperty](./Initialize-IntersightWorkflowPrimitiveDataProperty.md)
