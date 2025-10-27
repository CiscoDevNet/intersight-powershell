---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCommPhysicalAddress

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCommPhysicalAddress [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Address1< string>][-Address2< string>][-City< string>][-ClassId< CommPhysicalAddress.ClassIdEnum>][-Country< CommPhysicalAddress.CountryEnum>][-ObjectType< CommPhysicalAddress.ObjectTypeEnum>][-PostalCode< string>][-StateProvince< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -Address1
The primary street address.

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

### -Address2
Additional address information, such as suite number or floor.

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

### -City
The city where the address is located.

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
Type: CommPhysicalAddress.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Country
The country code in ISO 3166-1 alpha-2 format.\n* `Unknown` - The value Unknown is used when the country code is not known or applicable.\n* `AD` - The country code for Andorra.\n* `AE` - The country code for United Arab Emirates.\n* `AF` - The country code for Afghanistan.\n* `AG` - The country code for Antigua and Barbuda.\n* `AI` - The country code for Anguilla.\n* `AL` - The country code for Albania.\n* `AM` - The country code for Armenia.\n* `AO` - The country code for Angola.\n* `AQ` - The country code for Antarctica.\n* `AR` - The country code for Argentina.\n* `AS` - The country code for American Samoa.\n* `AT` - The country code for Austria.\n* `AU` - The country code for Australia.\n* `AW` - The country code for Aruba.\n* `AX` - The country code for Åland Islands.\n* `AZ` - The country code for Azerbaijan.\n* `BA` - The country code for Bosnia and Herzegovina.\n* `BB` - The country code for Barbados.\n* `BD` - The country code for Bangladesh.\n* `BE` - The country code for Belgium.\n* `BF` - The country code for Burkina Faso.\n* `BG` - The country code for Bulgaria.\n* `BH` - The country code for Bahrain.\n* `BI` - The country code for Burundi.\n* `BJ` - The country code for Benin.\n* `BL` - The country code for Saint Barthélemy.\n* `BM` - The country code for Bermuda.\n* `BN` - The country code for Brunei Darussalam.\n* `BO` - The country code for Plurinational State of Bolivia.\n* `BQ` - The country code for Sint Eustatius and Saba Bonaire.\n* `BR` - The country code for Brazil.\n* `BS` - The country code for Bahamas.\n* `BT` - The country code for Bhutan.\n* `BV` - The country code for Bouvet Island.\n* `BW` - The country code for Botswana.\n* `BY` - The country code for Belarus.\n* `BZ` - The country code for Belize.\n* `CA` - The country code for Canada.\n* `CC` - The country code for Cocos (Keeling) Islands.\n* `CD` - The country code for Democratic Republic of the Congo.\n* `CF` - The country code for Central African Republic.\n* `CG` - The country code for Congo.\n* `CH` - The country code for Switzerland.\n* `CI` - The country code for Côte d&apos;Ivoire.\n* `CK` - The country code for Cook Islands.\n* `CL` - The country code for Chile.\n* `CM` - The country code for Cameroon.\n* `CN` - The country code for China.\n* `CO` - The country code for Colombia.\n* `CR` - The country code for Costa Rica.\n* `CU` - The country code for Cuba.\n* `CV` - The country code for Cabo Verde.\n* `CW` - The country code for Curaçao.\n* `CX` - The country code for Christmas Island.\n* `CY` - The country code for Cyprus.\n* `CZ` - The country code for Czechia.\n* `DE` - The country code for Germany.\n* `DJ` - The country code for Djibouti.\n* `DK` - The country code for Denmark.\n* `DM` - The country code for Dominica.\n* `DO` - The country code for Dominican Republic.\n* `DZ` - The country code for Algeria.\n* `EC` - The country code for Ecuador.\n* `EE` - The country code for Estonia.\n* `EG` - The country code for Egypt.\n* `EH` - The country code for Western Sahara.\n* `ER` - The country code for Eritrea.\n* `ES` - The country code for Spain.\n* `ET` - The country code for Ethiopia.\n* `FI` - The country code for Finland.\n* `FJ` - The country code for Fiji.\n* `FK` - The country code for Falkland Islands (Malvinas).\n* `FM` - The country code for Federated States of Micronesia.\n* `FO` - The country code for Faroe Islands.\n* `FR` - The country code for France.\n* `GA` - The country code for Gabon.\n* `GB` - The country code for United Kingdom of Great Britain and Northern Ireland.\n* `GD` - The country code for Grenada.\n* `GE` - The country code for Georgia.\n* `GF` - The country code for French Guiana.\n* `GG` - The country code for Guernsey.\n* `GH` - The country code for Ghana.\n* `GI` - The country code for Gibraltar.\n* `GL` - The country code for Greenland.\n* `GM` - The country code for Gambia.\n* `GN` - The country code for Guinea.\n* `GP` - The country code for Guadeloupe.\n* `GQ` - The country code for Equatorial Guinea.\n* `GR` - The country code for Greece.\n* `GS` - The country code for South Georgia and the South Sandwich Islands.\n* `GT` - The country code for Guatemala.\n* `GU` - The country code for Guam.\n* `GW` - The country code for Guinea-Bissau.\n* `GY` - The country code for Guyana.\n* `HK` - The country code for Hong Kong.\n* `HM` - The country code for Heard Island and McDonald Islands.\n* `HN` - The country code for Honduras.\n* `HR` - The country code for Croatia.\n* `HT` - The country code for Haiti.\n* `HU` - The country code for Hungary.\n* `ID` - The country code for Indonesia.\n* `IE` - The country code for Ireland.\n* `IL` - The country code for Israel.\n* `IM` - The country code for Isle of Man.\n* `IN` - The country code for India.\n* `IO` - The country code for British Indian Ocean Territory.\n* `IQ` - The country code for Iraq.\n* `IR` - The country code for Islamic Republic of Iran.\n* `IS` - The country code for Iceland.\n* `IT` - The country code for Italy.\n* `JE` - The country code for Jersey.\n* `JM` - The country code for Jamaica.\n* `JO` - The country code for Jordan.\n* `JP` - The country code for Japan.\n* `KE` - The country code for Kenya.\n* `KG` - The country code for Kyrgyzstan.\n* `KH` - The country code for Cambodia.\n* `KI` - The country code for Kiribati.\n* `KM` - The country code for Comoros.\n* `KN` - The country code for Saint Kitts and Nevis.\n* `KP` - The country code for Democratic People&apos;s Republic of Korea.\n* `KR` - The country code for Republic of Korea.\n* `KW` - The country code for Kuwait.\n* `KY` - The country code for Cayman Islands.\n* `KZ` - The country code for Kazakhstan.\n* `LA` - The country code for Lao People&apos;s Democratic Republic.\n* `LB` - The country code for Lebanon.\n* `LC` - The country code for Saint Lucia.\n* `LI` - The country code for Liechtenstein.\n* `LK` - The country code for Sri Lanka.\n* `LR` - The country code for Liberia.\n* `LS` - The country code for Lesotho.\n* `LT` - The country code for Lithuania.\n* `LU` - The country code for Luxembourg.\n* `LV` - The country code for Latvia.\n* `LY` - The country code for Libya.\n* `MA` - The country code for Morocco.\n* `MC` - The country code for Monaco.\n* `MD` - The country code for Republic of Moldova.\n* `ME` - The country code for Montenegro.\n* `MF` - The country code for Saint Martin (French part).\n* `MG` - The country code for Madagascar.\n* `MH` - The country code for Marshall Islands.\n* `MK` - The country code for North Macedonia.\n* `ML` - The country code for Mali.\n* `MM` - The country code for Myanmar.\n* `MN` - The country code for Mongolia.\n* `MO` - The country code for Macao.\n* `MP` - The country code for Northern Mariana Islands.\n* `MQ` - The country code for Martinique.\n* `MR` - The country code for Mauritania.\n* `MS` - The country code for Montserrat.\n* `MT` - The country code for Malta.\n* `MU` - The country code for Mauritius.\n* `MV` - The country code for Maldives.\n* `MW` - The country code for Malawi.\n* `MX` - The country code for Mexico.\n* `MY` - The country code for Malaysia.\n* `MZ` - The country code for Mozambique.\n* `NA` - The country code for Namibia.\n* `NC` - The country code for New Caledonia.\n* `NE` - The country code for Niger.\n* `NF` - The country code for Norfolk Island.\n* `NG` - The country code for Nigeria.\n* `NI` - The country code for Nicaragua.\n* `NL` - The country code for Kingdom of the Netherlands.\n* `NO` - The country code for Norway.\n* `NP` - The country code for Nepal.\n* `NR` - The country code for Nauru.\n* `NU` - The country code for Niue.\n* `NZ` - The country code for New Zealand.\n* `OM` - The country code for Oman.\n* `PA` - The country code for Panama.\n* `PE` - The country code for Peru.\n* `PF` - The country code for French Polynesia.\n* `PG` - The country code for Papua New Guinea.\n* `PH` - The country code for Philippines.\n* `PK` - The country code for Pakistan.\n* `PL` - The country code for Poland.\n* `PM` - The country code for Saint Pierre and Miquelon.\n* `PN` - The country code for Pitcairn.\n* `PR` - The country code for Puerto Rico.\n* `PS` - The country code for State of Palestine.\n* `PT` - The country code for Portugal.\n* `PW` - The country code for Palau.\n* `PY` - The country code for Paraguay.\n* `QA` - The country code for Qatar.\n* `RE` - The country code for Réunion.\n* `RO` - The country code for Romania.\n* `RS` - The country code for Serbia.\n* `RU` - The country code for Russian Federation.\n* `RW` - The country code for Rwanda.\n* `SA` - The country code for Saudi Arabia.\n* `SB` - The country code for Solomon Islands.\n* `SC` - The country code for Seychelles.\n* `SD` - The country code for Sudan.\n* `SE` - The country code for Sweden.\n* `SG` - The country code for Singapore.\n* `SH` - The country code for Ascension and Tristan da Cunha Saint Helena.\n* `SI` - The country code for Slovenia.\n* `SJ` - The country code for Svalbard and Jan Mayen.\n* `SK` - The country code for Slovakia.\n* `SL` - The country code for Sierra Leone.\n* `SM` - The country code for San Marino.\n* `SN` - The country code for Senegal.\n* `SO` - The country code for Somalia.\n* `SR` - The country code for Suriname.\n* `SS` - The country code for South Sudan.\n* `ST` - The country code for Sao Tome and Principe.\n* `SV` - The country code for El Salvador.\n* `SX` - The country code for Sint Maarten (Dutch part).\n* `SY` - The country code for Syrian Arab Republic.\n* `SZ` - The country code for Eswatini.\n* `TC` - The country code for Turks and Caicos Islands.\n* `TD` - The country code for Chad.\n* `TF` - The country code for French Southern Territories.\n* `TG` - The country code for Togo.\n* `TH` - The country code for Thailand.\n* `TJ` - The country code for Tajikistan.\n* `TK` - The country code for Tokelau.\n* `TL` - The country code for Timor-Leste.\n* `TM` - The country code for Turkmenistan.\n* `TN` - The country code for Tunisia.\n* `TO` - The country code for Tonga.\n* `TR` - The country code for Türkiye.\n* `TT` - The country code for Trinidad and Tobago.\n* `TV` - The country code for Tuvalu.\n* `TW` - The country code for Province of China Taiwan.\n* `TZ` - The country code for United Republic of Tanzania.\n* `UA` - The country code for Ukraine.\n* `UG` - The country code for Uganda.\n* `UM` - The country code for United States Minor Outlying Islands.\n* `US` - The country code for United States of America.\n* `UY` - The country code for Uruguay.\n* `UZ` - The country code for Uzbekistan.\n* `VA` - The country code for Holy See.\n* `VC` - The country code for Saint Vincent and the Grenadines.\n* `VE` - The country code for Bolivarian Republic of Venezuela.\n* `VG` - The country code for Virgin Islands (British).\n* `VI` - The country code for Virgin Islands (U.S.).\n* `VN` - The country code for Viet Nam.\n* `VU` - The country code for Vanuatu.\n* `WF` - The country code for Wallis and Futuna.\n* `WS` - The country code for Samoa.\n* `YE` - The country code for Yemen.\n* `YT` - The country code for Mayotte.\n* `ZA` - The country code for South Africa.\n* `ZM` - The country code for Zambia.\n* `ZW` - The country code for Zimbabwe.

```yaml
Type: CommPhysicalAddress.CountryEnum
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
Type: CommPhysicalAddress.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PostalCode
The postal or ZIP code for the address.

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

### -StateProvince
The state or province where the address is located.

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
PS C:\> Initialize-IntersightCommPhysicalAddress
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
