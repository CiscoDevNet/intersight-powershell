---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightWorkflowPrimitiveDataProperty

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightWorkflowPrimitiveDataProperty [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< WorkflowPrimitiveDataProperty.ClassIdEnum>][-Constraints< Model.WorkflowConstraints>][-DataSourceSelector< System.Collections.Generic.List`1[Model.WorkflowDataSourceSelector]>][-InventorySelector< System.Collections.Generic.List`1[Model.WorkflowMoReferenceProperty]>][-ObjectType< WorkflowPrimitiveDataProperty.ObjectTypeEnum>][-Secure< bool>][-Type< WorkflowPrimitiveDataProperty.TypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: WorkflowPrimitiveDataProperty.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Constraints
Constraints that must be applied to the parameter value supplied for this data type.

Note :- Use Initialize-IntersightWorkflowConstraints to create the object of complex type WorkflowConstraints

```yaml
Type: Model.WorkflowConstraints
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DataSourceSelector


Note :- Use Initialize-IntersightWorkflowDataSourceSelector to create the object of complex type WorkflowDataSourceSelector

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowDataSourceSelector]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -InventorySelector


Note :- Use Initialize-IntersightWorkflowMoReferenceProperty to create the object of complex type WorkflowMoReferenceProperty

```yaml
Type: System.Collections.Generic.List`1[Model.WorkflowMoReferenceProperty]
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
Type: WorkflowPrimitiveDataProperty.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Secure
Intersight supports secure properties as task input/output. The values of\nthese properties are encrypted and stored in Intersight.\nThis flag marks the property to be secure when it is set to true.

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

### -Type
Specify the enum type for primitive data type.\n* `string` - Enum to specify a string data type.\n* `integer` - Enum to specify an integer32 data type.\n* `float` - Enum to specify a float64 data type.\n* `boolean` - Enum to specify a boolean data type.\n* `json` - Enum to specify a json data type.\n* `enum` - Enum to specify a enum data type which is a list of pre-defined strings.

```yaml
Type: WorkflowPrimitiveDataProperty.TypeEnum
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
PS C:\> Initialize-IntersightWorkflowPrimitiveDataProperty
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightWorkflowConstraints](./Initialize-IntersightWorkflowConstraints.md)

[Initialize-IntersightWorkflowDataSourceSelector](./Initialize-IntersightWorkflowDataSourceSelector.md)

[Initialize-IntersightWorkflowMoReferenceProperty](./Initialize-IntersightWorkflowMoReferenceProperty.md)
