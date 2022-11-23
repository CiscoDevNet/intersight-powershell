---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightAssetWorkloadOptimizerGoogleCloudPlatformBillingOptions

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightAssetWorkloadOptimizerGoogleCloudPlatformBillingOptions [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-BillingAccountId< string>][-ClassId< AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ClassIdEnum>][-CostExportDataSetName< string>][-CostExportTableName< string>][-ObjectType< AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ObjectTypeEnum>][-PricingExportDataSetName< string>][-PricingExportTableName< string>][-ProjectId< string>][-ResourceLevelCostEnabled< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -BillingAccountId
The Google Cloud Platform (GCP) Billing Account ID.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CostExportDataSetName
Name of Google BigQuery Cost Export Data Set which is the dataset for the billed cost export.

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

### -CostExportTableName
Google BigQuery Cost Export Table Name. This table will store the exported data from the Cost Export.

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
Type: AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PricingExportDataSetName
Name of the BigQuery Pricing Export Data Set which is the dataset for negotiated pricing.

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

### -PricingExportTableName
The Google BigQuery Pricing Export Table Name field is auto-populated with the table used in BigQuery, cloud_pricing_export. There is no need to modify this name, unless you use a different table for negotiated pricing. The Default name is \&quot;cloud_pricing_export\&quot;.

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

### -ProjectId
The unique ID assigned to the project containing the cost and pricing exports. If the exports are in separate projects, multiple billing targets will be necessary.

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

### -ResourceLevelCostEnabled
This flag will enable querying of detailed usage cost with resource level information included.  If not enabled, cost export data will be queried, if dataset and table name are provided.

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
PS C:\> Initialize-IntersightAssetWorkloadOptimizerGoogleCloudPlatformBillingOptions
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
