---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightContentParameter

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightContentParameter [-AcceptSingleValue< bool>][-AdditionalProperties< Dictionary<string,object>>][-ClassId< ContentParameter.ClassIdEnum>][-ComplexType< string>][-ItemType< ContentParameter.ItemTypeEnum>][-Name< string>][-ObjectType< ContentParameter.ObjectTypeEnum>][-Path< string>][-Secure< bool>][-Type< ContentParameter.TypeEnum>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -AcceptSingleValue
The flag that allows single values in content to be extracted as a\nsingle element collection in case the parameter is of Collection type.\nThis flag is applicable for parameters of type Collection only.

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
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type.

```yaml
Type: ContentParameter.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ComplexType
The name of the complex type definition in case this is a complex\nparameter. The content.Grammar object must have a complex type, content.ComplexType,\ndefined with the specified name in types collection property.

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

### -ItemType
The type of the collection item in case this is a collection parameter.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type.

```yaml
Type: ContentParameter.ItemTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name of the parameter.

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
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type.

```yaml
Type: ContentParameter.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Path
The content specific path information that identifies the parameter\nvalue within the content. The value is usually a XPath or JSONPath or a\nregular expression in case of text content.

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

### -Secure
The flag indicates if the extracted value is secure.\nThis flag is applicable for parameters of type String only.

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
The type of the parameter. Accepted values are simple, complex,\ncollection.\n* `simple` - The parameter value to be extracted is of the type simple. All the common scalar typessuch as int, bool, string, etc are represented by the simple enum.\n* `string` - The parameter value to be extracted is of the string type.\n* `integer` - The parameter value to be extracted is of the number type.\n* `float` - The parameter value to be extracted is of the float number type.\n* `boolean` - The parameter value to be extracted is of the boolean type.\n* `json` - The parameter values to be extracted is of the generic JSON literal. JSON type is applicable only if the content to be parsed is of JSON type.\n* `complex` - The parameter value to be extracted is a complex parameter that itself isanother collection of simple/complex parameters.\n* `collection` - The parameter value to be extracted is a collection parameter whose item typeshall be either simple type or complex type.

```yaml
Type: ContentParameter.TypeEnum
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
PS C:\> Initialize-IntersightContentParameter
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
