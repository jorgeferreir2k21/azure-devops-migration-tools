---
optionsClassName: TfsAttachmentToolOptions
optionsClassFullName: MigrationTools.Tools.TfsAttachmentToolOptions
configurationSamples:
- name: defaults
  description: 
  code: >-
    {
      "MigrationTools": {
        "CommonTools": {
          "TfsAttachmentTool": {
            "Enabled": "True",
            "ExportBasePath": "c:\\temp\\WorkItemAttachmentExport",
            "MaxAttachmentSize": "480000000",
            "RefName": "TfsAttachmentTool"
          }
        }
      }
    }
  sampleFor: MigrationTools.Tools.TfsAttachmentToolOptions
- name: sample
  description: 
  code: >-
    {
      "MigrationTools": {
        "CommonTools": {
          "TfsAttachmentTool": {
            "Enabled": "True",
            "ExportBasePath": "c:\\temp\\WorkItemAttachmentExport",
            "MaxAttachmentSize": "480000000",
            "RefName": "TfsAttachmentTool"
          }
        }
      }
    }
  sampleFor: MigrationTools.Tools.TfsAttachmentToolOptions
- name: classic
  description: 
  code: >-
    {
      "$type": "TfsAttachmentToolOptions",
      "Enabled": true,
      "ExportBasePath": "c:\\temp\\WorkItemAttachmentExport",
      "MaxAttachmentSize": 480000000
    }
  sampleFor: MigrationTools.Tools.TfsAttachmentToolOptions
description: missng XML code comments
className: TfsAttachmentTool
typeName: Tools
architecture: 
options:
- parameterName: Enabled
  type: Boolean
  description: If set to `true` then the tool will run. Set to `false` and the processor will not run.
  defaultValue: missng XML code comments
- parameterName: ExportBasePath
  type: String
  description: '`AttachmentMigration` is set to true then you need to specify a working path for attachments to be saved locally.'
  defaultValue: C:\temp\Migration\
- parameterName: MaxAttachmentSize
  type: Int32
  description: '`AttachmentMigration` is set to true then you need to specify a max file size for upload in bites. For Azure DevOps Services the default is 480,000,000 bites (60mb), for TFS its 32,000,000 bites (4mb).'
  defaultValue: 480000000
status: missng XML code comments
processingTarget: missng XML code comments
classFile: /src/MigrationTools.Clients.TfsObjectModel/Tools/TfsAttachmentTool.cs
optionsClassFile: /src/MigrationTools.Clients.TfsObjectModel/Tools/TfsAttachmentToolOptions.cs

redirectFrom:
- /Reference/Tools/TfsAttachmentToolOptions/
layout: reference
toc: true
permalink: /Reference/Tools/TfsAttachmentTool/
title: TfsAttachmentTool
categories:
- Tools
- 
topics:
- topic: notes
  path: /docs/Reference/Tools/TfsAttachmentTool-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Tools/TfsAttachmentTool-introduction.md
  exists: false
  markdown: ''

---