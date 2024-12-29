---
optionsClassName: TfsWorkItemDeleteProcessorOptions
optionsClassFullName: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
configurationSamples:
- name: defaults
  order: 2
  description: 
  code: There are no defaults! Check the sample for options!
  sampleFor: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
- name: sample
  order: 1
  description: 
  code: There is no sample, but you can check the classic below for a general feel.
  sampleFor: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
- name: classic
  order: 3
  description: 
  code: >-
    {
      "$type": "TfsWorkItemDeleteProcessorOptions",
      "Enabled": false,
      "WIQLQuery": "SELECT [System.Id] FROM WorkItems WHERE [System.TeamProject] = @TeamProject AND [System.WorkItemType] NOT IN ('Test Suite', 'Test Plan','Shared Steps','Shared Parameter','Feedback Request') ORDER BY [System.ChangedDate] desc",
      "WorkItemIDs": null,
      "FilterWorkItemsThatAlreadyExistInTarget": false,
      "PauseAfterEachWorkItem": false,
      "WorkItemCreateRetryLimit": 0,
      "SourceName": null,
      "TargetName": null
    }
  sampleFor: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
description: The `WorkItemDelete` processor allows you to delete any amount of work items that meet the query. **DANGER:** This is not a recoverable action and should be use with extream caution.
className: TfsWorkItemDeleteProcessor
typeName: Processors
architecture: 
options:
- parameterName: Enabled
  type: Boolean
  description: If set to `true` then the processor will run. Set to `false` and the processor will not run.
  defaultValue: missing XML code comments
- parameterName: FilterWorkItemsThatAlreadyExistInTarget
  type: Boolean
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: PauseAfterEachWorkItem
  type: Boolean
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: SourceName
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: TargetName
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: WIQLQuery
  type: String
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: WorkItemCreateRetryLimit
  type: Int32
  description: missing XML code comments
  defaultValue: missing XML code comments
- parameterName: WorkItemIDs
  type: IList
  description: missing XML code comments
  defaultValue: missing XML code comments
status: ready
processingTarget: WorkItem
classFile: /src/MigrationTools.Clients.TfsObjectModel/Processors/TfsWorkItemDeleteProcessor.cs
optionsClassFile: /src/MigrationTools.Clients.TfsObjectModel/Processors/TfsWorkItemDeleteProcessorOptions.cs

redirectFrom:
- /Reference/Processors/TfsWorkItemDeleteProcessorOptions/
layout: reference
toc: true
permalink: /Reference/Processors/TfsWorkItemDeleteProcessor/
title: TfsWorkItemDeleteProcessor
categories:
- Processors
- 
topics:
- topic: notes
  path: /docs/Reference/Processors/TfsWorkItemDeleteProcessor-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Processors/TfsWorkItemDeleteProcessor-introduction.md
  exists: false
  markdown: ''

---