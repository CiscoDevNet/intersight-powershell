---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightFeedbackFeedbackData

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightFeedbackFeedbackData [-AccountName< string>][-AdditionalProperties< Dictionary<string,object>>][-AlternativeFollowUpEmails< List<string>>][-ClassId< FeedbackFeedbackData.ClassIdEnum>][-Comment< string>][-Email< string>][-Evaluation< FeedbackFeedbackData.EvaluationEnum>][-FollowUp< bool>][-ObjectType< FeedbackFeedbackData.ObjectTypeEnum>][-TraceIds< object>][-Type< FeedbackFeedbackData.TypeEnum>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -AccountName
Account name of the feedback sender. Copied in order to be persisted in case of account removal.

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

### -AlternativeFollowUpEmails


```yaml
Type: System.Collections.Generic.List`1[string]
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
Type: FeedbackFeedbackData.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Comment
Text of the feedback as provided by the user, if it is a bug or a comment.

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

### -Email
User&amp;apos;s email address details.

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

### -Evaluation
Evalation rating as provided by the user to capture user sentiment regarding the issue.\n* `Excellent` - Option that specifies user&apos;s excelent evaluation.\n* `Poor` - Option that specifies user&apos;s poor evaluation.\n* `Fair` - Option that specifies user&apos;s fair evaluation.\n* `Good` - Option that specifies user&apos;s good evaluation.

```yaml
Type: FeedbackFeedbackData.EvaluationEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FollowUp
If a user is open for follow-up or not.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: FeedbackFeedbackData.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TraceIds
Bunch of last traceId for reproducing user last activity.

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

### -Type
Type of the feedback from user.\n* `Evaluation` - User&apos;s feedback classified as an evaluation.\n* `Bug` - User&apos;s feedback classified as a bug.

```yaml
Type: FeedbackFeedbackData.TypeEnum
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
PS C:\> Initialize-IntersightFeedbackFeedbackData
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
