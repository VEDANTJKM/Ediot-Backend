using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Models;

public partial class IteindiaContext : DbContext
{
    public IteindiaContext()
    {
    }

    public IteindiaContext(DbContextOptions<IteindiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdvanceLicenceTbl> AdvanceLicenceTbls { get; set; }

    public virtual DbSet<AdvanceLicencesOperationTbl> AdvanceLicencesOperationTbls { get; set; }

    public virtual DbSet<AnimationRecord> AnimationRecords { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<AssociatedDocument> AssociatedDocuments { get; set; }

    public virtual DbSet<AttachmentMst> AttachmentMsts { get; set; }

    public virtual DbSet<BackupLog> BackupLogs { get; set; }

    public virtual DbSet<CatagoryTbl> CatagoryTbls { get; set; }

    public virtual DbSet<ConfranceroomBookDatum> ConfranceroomBookData { get; set; }

    public virtual DbSet<CrupMst> CrupMsts { get; set; }

    public virtual DbSet<DayClose> DayCloses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DeptContinuousImprovementProject> DeptContinuousImprovementProjects { get; set; }

    public virtual DbSet<DeptForm> DeptForms { get; set; }

    public virtual DbSet<DeptInterviewQuestion> DeptInterviewQuestions { get; set; }

    public virtual DbSet<DeptKpi> DeptKpis { get; set; }

    public virtual DbSet<DeptMasterProjectList> DeptMasterProjectLists { get; set; }

    public virtual DbSet<DeptMultiname> DeptMultinames { get; set; }

    public virtual DbSet<DeptOpenActionItem> DeptOpenActionItems { get; set; }

    public virtual DbSet<DeptPeriodicActionItem> DeptPeriodicActionItems { get; set; }

    public virtual DbSet<DeptPersonalGrowth> DeptPersonalGrowths { get; set; }

    public virtual DbSet<DeptReponsibilityMatrix> DeptReponsibilityMatrices { get; set; }

    public virtual DbSet<DeptReportNeedDepartment> DeptReportNeedDepartments { get; set; }

    public virtual DbSet<DeptSoftwareSubscription> DeptSoftwareSubscriptions { get; set; }

    public virtual DbSet<DeptTask> DeptTasks { get; set; }

    public virtual DbSet<DeptTrainingTopic> DeptTrainingTopics { get; set; }

    public virtual DbSet<DeptWorkloadDistribution> DeptWorkloadDistributions { get; set; }

    public virtual DbSet<DeptWorkloadReportTbl> DeptWorkloadReportTbls { get; set; }

    public virtual DbSet<DeptWorkloadSubtaskTbl> DeptWorkloadSubtaskTbls { get; set; }

    public virtual DbSet<DispatchAvilableDetail> DispatchAvilableDetails { get; set; }

    public virtual DbSet<DispatchBoxDropDown> DispatchBoxDropDowns { get; set; }

    public virtual DbSet<DispatchCode> DispatchCodes { get; set; }

    public virtual DbSet<DispatchDatum> DispatchData { get; set; }

    public virtual DbSet<DispatchGrade> DispatchGrades { get; set; }

    public virtual DbSet<DispatchInventoryStock> DispatchInventoryStocks { get; set; }

    public virtual DbSet<DispatchInventoryStockLog> DispatchInventoryStockLogs { get; set; }

    public virtual DbSet<DispatchMaterialShape> DispatchMaterialShapes { get; set; }

    public virtual DbSet<DispatchPackingDetail> DispatchPackingDetails { get; set; }

    public virtual DbSet<DispatchPalletSuggestion> DispatchPalletSuggestions { get; set; }

    public virtual DbSet<DispatchProvidedPackingDetailsPalate> DispatchProvidedPackingDetailsPalates { get; set; }

    public virtual DbSet<DispatchProvidedPackingDetailsPalateBoxesInside> DispatchProvidedPackingDetailsPalateBoxesInsides { get; set; }

    public virtual DbSet<DispatchStaticdatum> DispatchStaticdata { get; set; }

    public virtual DbSet<DispatchType> DispatchTypes { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<EcnChangeOption> EcnChangeOptions { get; set; }

    public virtual DbSet<EcnDatabaseFlex> EcnDatabaseFlexes { get; set; }

    public virtual DbSet<EducationDetail> EducationDetails { get; set; }

    public virtual DbSet<Emailauto> Emailautos { get; set; }

    public virtual DbSet<EmpCourseDatum> EmpCourseData { get; set; }

    public virtual DbSet<EmpLimit> EmpLimits { get; set; }

    public virtual DbSet<EmpTrainingFinalDatabase> EmpTrainingFinalDatabases { get; set; }

    public virtual DbSet<EmpTrainingMaster> EmpTrainingMasters { get; set; }

    public virtual DbSet<EmpTrialDatum> EmpTrialData { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }

    public virtual DbSet<EngWorkAdminPanel> EngWorkAdminPanels { get; set; }

    public virtual DbSet<EngWorkAdminPanelHistory> EngWorkAdminPanelHistories { get; set; }

    public virtual DbSet<EngineeringCncNew> EngineeringCncNews { get; set; }

    public virtual DbSet<EngineeringProcess> EngineeringProcesses { get; set; }

    public virtual DbSet<EngineeringProcessMafiaDatum> EngineeringProcessMafiaData { get; set; }

    public virtual DbSet<EngineeringProcessNew> EngineeringProcessNews { get; set; }

    public virtual DbSet<EngworkAddNewTool> EngworkAddNewTools { get; set; }

    public virtual DbSet<EngworkMafiaHistory> EngworkMafiaHistories { get; set; }

    public virtual DbSet<EngworkMafium> EngworkMafia { get; set; }

    public virtual DbSet<EngworkMaterialSuggestion> EngworkMaterialSuggestions { get; set; }

    public virtual DbSet<EngworkMaterialSuggestionDetail> EngworkMaterialSuggestionDetails { get; set; }

    public virtual DbSet<EngworkMaterialSuggestionHistory> EngworkMaterialSuggestionHistories { get; set; }

    public virtual DbSet<EngworkMom> EngworkMoms { get; set; }

    public virtual DbSet<EngworkMomDetail> EngworkMomDetails { get; set; }

    public virtual DbSet<EngworkMomHistory> EngworkMomHistories { get; set; }

    public virtual DbSet<EngworkOpd> EngworkOpds { get; set; }

    public virtual DbSet<EngworkOpdHistory> EngworkOpdHistories { get; set; }

    public virtual DbSet<EngworkOpsequence> EngworkOpsequences { get; set; }

    public virtual DbSet<EngworkPoForecast> EngworkPoForecasts { get; set; }

    public virtual DbSet<EngworkPoForecastHistory> EngworkPoForecastHistories { get; set; }

    public virtual DbSet<EngworkProcessMaster> EngworkProcessMasters { get; set; }

    public virtual DbSet<EngworkPtd> EngworkPtds { get; set; }

    public virtual DbSet<EngworkPtdHistory> EngworkPtdHistories { get; set; }

    public virtual DbSet<EngworkSqrmcode> EngworkSqrmcodes { get; set; }

    public virtual DbSet<EngworkToolingSuggesstionAvaCheck> EngworkToolingSuggesstionAvaChecks { get; set; }

    public virtual DbSet<EngworkToolingSuggestionDetail> EngworkToolingSuggestionDetails { get; set; }

    public virtual DbSet<EngworkToolingSuggestionHistory> EngworkToolingSuggestionHistories { get; set; }

    public virtual DbSet<EpicorJobHead> EpicorJobHeads { get; set; }

    public virtual DbSet<EpicorJobOpDtl> EpicorJobOpDtls { get; set; }

    public virtual DbSet<EpicorPartLibrary> EpicorPartLibraries { get; set; }

    public virtual DbSet<EpicorPartUpdateLog> EpicorPartUpdateLogs { get; set; }

    public virtual DbSet<EpicorTransactionLog> EpicorTransactionLogs { get; set; }

    public virtual DbSet<EpoApproval> EpoApprovals { get; set; }

    public virtual DbSet<EpoCreation> EpoCreations { get; set; }

    public virtual DbSet<EpoEmployeeDetail> EpoEmployeeDetails { get; set; }

    public virtual DbSet<EpoItemReceive> EpoItemReceives { get; set; }

    public virtual DbSet<EpoMpcVote> EpoMpcVotes { get; set; }

    public virtual DbSet<EpoRefTable> EpoRefTables { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventLoggerDatum> EventLoggerData { get; set; }

    public virtual DbSet<EventLoggerSupervisorDatum> EventLoggerSupervisorData { get; set; }

    public virtual DbSet<EventManagementMsm> EventManagementMsms { get; set; }

    public virtual DbSet<EventManagementMsmDetail> EventManagementMsmDetails { get; set; }

    public virtual DbSet<EventManagementMultiname> EventManagementMultinames { get; set; }

    public virtual DbSet<EventManagementReportDetail> EventManagementReportDetails { get; set; }

    public virtual DbSet<EventManagementWithTextboxValue> EventManagementWithTextboxValues { get; set; }

    public virtual DbSet<EventNameMaster> EventNameMasters { get; set; }

    public virtual DbSet<EventSecondaryMsm> EventSecondaryMsms { get; set; }

    public virtual DbSet<ExperianceDetail> ExperianceDetails { get; set; }

    public virtual DbSet<FamilyDetail> FamilyDetails { get; set; }

    public virtual DbSet<FeedbackQueryTable> FeedbackQueryTables { get; set; }

    public virtual DbSet<FinalInspectionDatum> FinalInspectionData { get; set; }

    public virtual DbSet<FinalInspectionDocumentDatum> FinalInspectionDocumentData { get; set; }

    public virtual DbSet<FinalInspectionDocumentVarification> FinalInspectionDocumentVarifications { get; set; }

    public virtual DbSet<FinalInspectionLogTable> FinalInspectionLogTables { get; set; }

    public virtual DbSet<FinalInspectionMrbDatum> FinalInspectionMrbData { get; set; }

    public virtual DbSet<FinalInspectionMrbDecisionDatum> FinalInspectionMrbDecisionData { get; set; }

    public virtual DbSet<FinalInspectionMrbRcode> FinalInspectionMrbRcodes { get; set; }

    public virtual DbSet<FinalInspectionProcess> FinalInspectionProcesses { get; set; }

    public virtual DbSet<FinalInspectionProcessRework> FinalInspectionProcessReworks { get; set; }

    public virtual DbSet<FinalInspectionRcode> FinalInspectionRcodes { get; set; }

    public virtual DbSet<FinalInspectionRework> FinalInspectionReworks { get; set; }

    public virtual DbSet<FinalInspectionStageDatum> FinalInspectionStageData { get; set; }

    public virtual DbSet<FinalInspectionStageMaster> FinalInspectionStageMasters { get; set; }

    public virtual DbSet<FinalInspectionUserList> FinalInspectionUserLists { get; set; }

    public virtual DbSet<FormulaHistoryTbl> FormulaHistoryTbls { get; set; }

    public virtual DbSet<FormulaMasterTbl> FormulaMasterTbls { get; set; }

    public virtual DbSet<FpaColorGradeHistory> FpaColorGradeHistories { get; set; }

    public virtual DbSet<FpaForm> FpaForms { get; set; }

    public virtual DbSet<FpaFormHistory> FpaFormHistories { get; set; }

    public virtual DbSet<FpaGdntSymbol> FpaGdntSymbols { get; set; }

    public virtual DbSet<FpaView> FpaViews { get; set; }

    public virtual DbSet<FunctionMst> FunctionMsts { get; set; }

    public virtual DbSet<Gatepass> Gatepasses { get; set; }

    public virtual DbSet<GatepassApprovalList> GatepassApprovalLists { get; set; }

    public virtual DbSet<GatepassJobwork> GatepassJobworks { get; set; }

    public virtual DbSet<GatepassMaterialDetail> GatepassMaterialDetails { get; set; }

    public virtual DbSet<GatepassReturnablenew> GatepassReturnablenews { get; set; }

    public virtual DbSet<Gatepasspreviousdaydetail> Gatepasspreviousdaydetails { get; set; }

    public virtual DbSet<HibcApprentixTable> HibcApprentixTables { get; set; }

    public virtual DbSet<HibcCodeGenerator> HibcCodeGenerators { get; set; }

    public virtual DbSet<HibcPrimaryBarcodeTemp> HibcPrimaryBarcodeTemps { get; set; }

    public virtual DbSet<HibcTempStorage> HibcTempStorages { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<Hourcounting> Hourcountings { get; set; }

    public virtual DbSet<Icrdtemp> Icrdtemps { get; set; }

    public virtual DbSet<InitiatorName> InitiatorNames { get; set; }

    public virtual DbSet<IntervierwExperienceReference> IntervierwExperienceReferences { get; set; }

    public virtual DbSet<InterviewAnswerVerify> InterviewAnswerVerifies { get; set; }

    public virtual DbSet<InterviewEducationDetail> InterviewEducationDetails { get; set; }

    public virtual DbSet<InterviewFamilyBackground> InterviewFamilyBackgrounds { get; set; }

    public virtual DbSet<InterviewFormPersonalDetail> InterviewFormPersonalDetails { get; set; }

    public virtual DbSet<InterviewQuestion> InterviewQuestions { get; set; }

    public virtual DbSet<InvoiceEntryMasterTbl> InvoiceEntryMasterTbls { get; set; }

    public virtual DbSet<Isquery> Isqueries { get; set; }

    public virtual DbSet<IssueMaterial> IssueMaterials { get; set; }

    public virtual DbSet<Isuser> Isusers { get; set; }

    public virtual DbSet<ItemNameTbl> ItemNameTbls { get; set; }

    public virtual DbSet<ItemType> ItemTypes { get; set; }

    public virtual DbSet<ItemsOfEpoTemp> ItemsOfEpoTemps { get; set; }

    public virtual DbSet<Jobwork> Jobworks { get; set; }

    public virtual DbSet<Jobworkhour> Jobworkhours { get; set; }

    public virtual DbSet<LateComersOfWeekMail> LateComersOfWeekMails { get; set; }

    public virtual DbSet<LateComingImgTable> LateComingImgTables { get; set; }

    public virtual DbSet<LoginTbl> LoginTbls { get; set; }

    public virtual DbSet<Machine> Machines { get; set; }

    public virtual DbSet<MachineDetail> MachineDetails { get; set; }

    public virtual DbSet<Maintenance> Maintenances { get; set; }

    public virtual DbSet<MaterialLibrary> MaterialLibraries { get; set; }

    public virtual DbSet<MdrPartDatum> MdrPartData { get; set; }

    public virtual DbSet<Metadata> Metadata { get; set; }

    public virtual DbSet<MiscelleneousIssueTbl> MiscelleneousIssueTbls { get; set; }

    public virtual DbSet<MiscelleneousRequestTbl> MiscelleneousRequestTbls { get; set; }

    public virtual DbSet<ModuleMap> ModuleMaps { get; set; }

    public virtual DbSet<ModuleMst> ModuleMsts { get; set; }

    public virtual DbSet<MonthlyAttendanceDatum> MonthlyAttendanceData { get; set; }

    public virtual DbSet<MrsReasonCodeWithPartClass> MrsReasonCodeWithPartClasses { get; set; }

    public virtual DbSet<MrsRequesterDatum> MrsRequesterData { get; set; }

    public virtual DbSet<MrsSupervisorApproval> MrsSupervisorApprovals { get; set; }

    public virtual DbSet<MrsTempMiscelleneousRequestTbl> MrsTempMiscelleneousRequestTbls { get; set; }

    public virtual DbSet<MrsTempReturnMiscelleneousRequestTbl> MrsTempReturnMiscelleneousRequestTbls { get; set; }

    public virtual DbSet<MrsmiscelleneousIssueTbl> MrsmiscelleneousIssueTbls { get; set; }

    public virtual DbSet<MrsmiscelleneousRequestTbl> MrsmiscelleneousRequestTbls { get; set; }

    public virtual DbSet<MrsreturnMiscelleneousRequestTbl> MrsreturnMiscelleneousRequestTbls { get; set; }

    public virtual DbSet<MrsreturnReturnTransactionTbl> MrsreturnReturnTransactionTbls { get; set; }

    public virtual DbSet<Multiname> Multinames { get; set; }

    public virtual DbSet<Mytimepunchrecord> Mytimepunchrecords { get; set; }

    public virtual DbSet<NewFpaGdntSymbol> NewFpaGdntSymbols { get; set; }

    public virtual DbSet<Nonreturnablegatepass> Nonreturnablegatepasses { get; set; }

    public virtual DbSet<NotificationListDocument> NotificationListDocuments { get; set; }

    public virtual DbSet<PackslipDtl> PackslipDtls { get; set; }

    public virtual DbSet<PartLibrary> PartLibraries { get; set; }

    public virtual DbSet<PartMasterTbl> PartMasterTbls { get; set; }

    public virtual DbSet<Partnumber> Partnumbers { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<PpapDatum> PpapData { get; set; }

    public virtual DbSet<PrivilageMenudemon> PrivilageMenudemons { get; set; }

    public virtual DbSet<PrivilegeMst> PrivilegeMsts { get; set; }

    public virtual DbSet<ProdFlexBulkShaftIssue> ProdFlexBulkShaftIssues { get; set; }

    public virtual DbSet<ProdFlexBulkShaftJobList> ProdFlexBulkShaftJobLists { get; set; }

    public virtual DbSet<ProdFlexBulkShaftJobListHistory> ProdFlexBulkShaftJobListHistories { get; set; }

    public virtual DbSet<ProdFlexCutShaftJobList> ProdFlexCutShaftJobLists { get; set; }

    public virtual DbSet<ProdFlexCutShaftJobListHistory> ProdFlexCutShaftJobListHistories { get; set; }

    public virtual DbSet<ProdFlexInventory> ProdFlexInventories { get; set; }

    public virtual DbSet<ProdFlexInventoryHistory> ProdFlexInventoryHistories { get; set; }

    public virtual DbSet<ProdFlexPartList> ProdFlexPartLists { get; set; }

    public virtual DbSet<ProdFlexPartListHistory> ProdFlexPartListHistories { get; set; }

    public virtual DbSet<ProdFlexPartWiseOperation> ProdFlexPartWiseOperations { get; set; }

    public virtual DbSet<ProdcutionReportCnc> ProdcutionReportCncs { get; set; }

    public virtual DbSet<ProductDetail> ProductDetails { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<ProductionDeviationReport> ProductionDeviationReports { get; set; }

    public virtual DbSet<ProductionEcrDatum> ProductionEcrData { get; set; }

    public virtual DbSet<ProductionFinalDatum> ProductionFinalData { get; set; }

    public virtual DbSet<ProductionPlanning> ProductionPlannings { get; set; }

    public virtual DbSet<ProductionPlanningComlexityOfPart> ProductionPlanningComlexityOfParts { get; set; }

    public virtual DbSet<ProductionPlanningPriority> ProductionPlanningPriorities { get; set; }

    public virtual DbSet<ProductionPlanningYearlyQty> ProductionPlanningYearlyQties { get; set; }

    public virtual DbSet<ProductionProductionDtl> ProductionProductionDtls { get; set; }

    public virtual DbSet<ProductionQtydtl> ProductionQtydtls { get; set; }

    public virtual DbSet<ProductionReportGeneratorDetail> ProductionReportGeneratorDetails { get; set; }

    public virtual DbSet<ProductionSetupDtl> ProductionSetupDtls { get; set; }

    public virtual DbSet<ProductionSystemName> ProductionSystemNames { get; set; }

    public virtual DbSet<ProductionToolDetail> ProductionToolDetails { get; set; }

    public virtual DbSet<ProductionUniqueOp> ProductionUniqueOps { get; set; }

    public virtual DbSet<ProductionUtilization> ProductionUtilizations { get; set; }

    public virtual DbSet<ProgramOperationWiseToolLibrary> ProgramOperationWiseToolLibraries { get; set; }

    public virtual DbSet<ProgrammerEvaluationBonou> ProgrammerEvaluationBonous { get; set; }

    public virtual DbSet<ProgrammerEvaluationBonousCalculation> ProgrammerEvaluationBonousCalculations { get; set; }

    public virtual DbSet<ProgrammerEvaluationBonousCalculationHistory> ProgrammerEvaluationBonousCalculationHistories { get; set; }

    public virtual DbSet<ProgrammerEvaluationDiscipline> ProgrammerEvaluationDisciplines { get; set; }

    public virtual DbSet<ProgrammerEvaluationEmployeeList> ProgrammerEvaluationEmployeeLists { get; set; }

    public virtual DbSet<ProgrammerEvaluationLoginActivityLog> ProgrammerEvaluationLoginActivityLogs { get; set; }

    public virtual DbSet<ProgrammerEvaluationRulesTable> ProgrammerEvaluationRulesTables { get; set; }

    public virtual DbSet<ProgrammerEvaluationSettingDifficulty> ProgrammerEvaluationSettingDifficulties { get; set; }

    public virtual DbSet<ProgrammerEvaluationSettingTime> ProgrammerEvaluationSettingTimes { get; set; }

    public virtual DbSet<ProgrammerEvaluationStandrdizedBin> ProgrammerEvaluationStandrdizedBins { get; set; }

    public virtual DbSet<ProgrammerEvaluationTrainersDetail> ProgrammerEvaluationTrainersDetails { get; set; }

    public virtual DbSet<ProgrammerEvaluationTraining> ProgrammerEvaluationTrainings { get; set; }

    public virtual DbSet<ProgrammerevaluationAdduseractivitylog> ProgrammerevaluationAdduseractivitylogs { get; set; }

    public virtual DbSet<PurchaseAnalysisDataFromErp> PurchaseAnalysisDataFromErps { get; set; }

    public virtual DbSet<PurchaseAnalysisInvoiceconfirm> PurchaseAnalysisInvoiceconfirms { get; set; }

    public virtual DbSet<PurchaseAnalysisItemGroupMaster> PurchaseAnalysisItemGroupMasters { get; set; }

    public virtual DbSet<PurchaseAnalysisPartDepartment> PurchaseAnalysisPartDepartments { get; set; }

    public virtual DbSet<Purreq> Purreqs { get; set; }

    public virtual DbSet<PurreqInvoiceViewdetail> PurreqInvoiceViewdetails { get; set; }

    public virtual DbSet<QueryTbl> QueryTbls { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<ReactEmployee> ReactEmployees { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<Required> Requireds { get; set; }

    public virtual DbSet<RequisitionEntry> RequisitionEntries { get; set; }

    public virtual DbSet<ResponsibilitiesMatrixPriority> ResponsibilitiesMatrixPriorities { get; set; }

    public virtual DbSet<ResponsibilityMatrix> ResponsibilityMatrices { get; set; }

    public virtual DbSet<ResultDetail> ResultDetails { get; set; }

    public virtual DbSet<ReturnMiscelleneousRequestTbl> ReturnMiscelleneousRequestTbls { get; set; }

    public virtual DbSet<ReturnReturnTransactionTbl> ReturnReturnTransactionTbls { get; set; }

    public virtual DbSet<RoleMst> RoleMsts { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<SholderImplantDatabase> SholderImplantDatabases { get; set; }

    public virtual DbSet<SholderImplantDatabaseHistory> SholderImplantDatabaseHistories { get; set; }

    public virtual DbSet<ShopFloorEntry> ShopFloorEntries { get; set; }

    public virtual DbSet<ShoulderImplantDatabaseNew> ShoulderImplantDatabaseNews { get; set; }

    public virtual DbSet<ShoulderImplantImage> ShoulderImplantImages { get; set; }

    public virtual DbSet<ShoulderImplantImagesDesc> ShoulderImplantImagesDescs { get; set; }

    public virtual DbSet<ShoulderImplantMaster> ShoulderImplantMasters { get; set; }

    public virtual DbSet<ShoulderImplantTechnique> ShoulderImplantTechniques { get; set; }

    public virtual DbSet<Signature> Signatures { get; set; }

    public virtual DbSet<SswAppliance> SswAppliances { get; set; }

    public virtual DbSet<SswApplianceForReference> SswApplianceForReferences { get; set; }

    public virtual DbSet<SswAppliancesMain> SswAppliancesMains { get; set; }

    public virtual DbSet<SswAppliancesMainAdded> SswAppliancesMainAddeds { get; set; }

    public virtual DbSet<SswVacancy> SswVacancies { get; set; }

    public virtual DbSet<SswhiteGallery> SswhiteGalleries { get; set; }

    public virtual DbSet<StudentDatum> StudentData { get; set; }

    public virtual DbSet<SupervisorRecord> SupervisorRecords { get; set; }

    public virtual DbSet<SuppEmail> SuppEmails { get; set; }

    public virtual DbSet<SupplierDataNew> SupplierDataNews { get; set; }

    public virtual DbSet<SupplierDatum> SupplierData { get; set; }

    public virtual DbSet<SupplierMaster> SupplierMasters { get; set; }

    public virtual DbSet<SupplierNewDatum> SupplierNewData { get; set; }

    public virtual DbSet<TaskManagementTrial> TaskManagementTrials { get; set; }

    public virtual DbSet<TaskManagementTrialSecondary> TaskManagementTrialSecondaries { get; set; }

    public virtual DbSet<TblAudit> TblAudits { get; set; }

    public virtual DbSet<TblCityStatesCounty> TblCityStatesCounties { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblFile> TblFiles { get; set; }

    public virtual DbSet<Tblbin> Tblbins { get; set; }

    public virtual DbSet<Tblcontact> Tblcontacts { get; set; }

    public virtual DbSet<TbllabelDtl> TbllabelDtls { get; set; }

    public virtual DbSet<TbllabelMst> TbllabelMsts { get; set; }

    public virtual DbSet<Tbllocation> Tbllocations { get; set; }

    public virtual DbSet<TempUser> TempUsers { get; set; }

    public virtual DbSet<TempUser1> TempUser1s { get; set; }

    public virtual DbSet<Tempdatatable> Tempdatatables { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<TicketGeneratedDepartmentApplicable> TicketGeneratedDepartmentApplicables { get; set; }

    public virtual DbSet<TicketGenerationApplicationRevisionDetail> TicketGenerationApplicationRevisionDetails { get; set; }

    public virtual DbSet<TicketGenerationProcess> TicketGenerationProcesses { get; set; }

    public virtual DbSet<TicketProcessChat> TicketProcessChats { get; set; }

    public virtual DbSet<ToolCategory> ToolCategories { get; set; }

    public virtual DbSet<ToolInventorySystem> ToolInventorySystems { get; set; }

    public virtual DbSet<ToolTrialDatum> ToolTrialData { get; set; }

    public virtual DbSet<ToolTrialLogTable> ToolTrialLogTables { get; set; }

    public virtual DbSet<ToolTrialProductionDatum> ToolTrialProductionData { get; set; }

    public virtual DbSet<ToolTrialShiftDatum> ToolTrialShiftData { get; set; }

    public virtual DbSet<ToolUtilization> ToolUtilizations { get; set; }

    public virtual DbSet<ToolingUtilizationAllDetail> ToolingUtilizationAllDetails { get; set; }

    public virtual DbSet<ToolingUtilizationDetail> ToolingUtilizationDetails { get; set; }

    public virtual DbSet<TpmEpoEntryDatum> TpmEpoEntryData { get; set; }

    public virtual DbSet<TpmIssueReturnDetail> TpmIssueReturnDetails { get; set; }

    public virtual DbSet<TpmNonconReceiptIssue> TpmNonconReceiptIssues { get; set; }

    public virtual DbSet<TpmPurchaseInvoiceDetail> TpmPurchaseInvoiceDetails { get; set; }

    public virtual DbSet<TpmRequestform> TpmRequestforms { get; set; }

    public virtual DbSet<Trial> Trials { get; set; }

    public virtual DbSet<UdaiUdimaster> UdaiUdimasters { get; set; }

    public virtual DbSet<UdaiUdimasterHistoryTbl> UdaiUdimasterHistoryTbls { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<Uom> Uoms { get; set; }

    public virtual DbSet<UserDatum> UserData { get; set; }

    public virtual DbSet<UserDtl> UserDtls { get; set; }

    public virtual DbSet<UserMst> UserMsts { get; set; }

    public virtual DbSet<UserMstForShoulder> UserMstForShoulders { get; set; }

    public virtual DbSet<UserRight> UserRights { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserRolesForShoulderApp> UserRolesForShoulderApps { get; set; }

    public virtual DbSet<UserRolesWithOccupation> UserRolesWithOccupations { get; set; }

    public virtual DbSet<UserWiseSholderImplantFvrt> UserWiseSholderImplantFvrts { get; set; }

    public virtual DbSet<UserWiseShoulderImplantHistory> UserWiseShoulderImplantHistories { get; set; }

    public virtual DbSet<Userdatum1> Userdata { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<VideoTable> VideoTables { get; set; }

    public virtual DbSet<VisitorGatepassDatum> VisitorGatepassData { get; set; }

    public virtual DbSet<VmsDataFromDashboard> VmsDataFromDashboards { get; set; }

    public virtual DbSet<VmsFtoRequest> VmsFtoRequests { get; set; }

    public virtual DbSet<VmsMonthlyDatum> VmsMonthlyData { get; set; }

    public virtual DbSet<Vmsattendance> Vmsattendances { get; set; }

    public virtual DbSet<VmsattendanceShiftDetail> VmsattendanceShiftDetails { get; set; }

    public virtual DbSet<VmsattendanceShiftchangedataHistory> VmsattendanceShiftchangedataHistories { get; set; }

    public virtual DbSet<VmsattendanceShiftchangedatum> VmsattendanceShiftchangedata { get; set; }

    public virtual DbSet<VmsemployeeDetail> VmsemployeeDetails { get; set; }

    public virtual DbSet<Vmsflexdatafilter> Vmsflexdatafilters { get; set; }

    public virtual DbSet<Vmsforexport> Vmsforexports { get; set; }

    public virtual DbSet<Vmsforexportattend> Vmsforexportattends { get; set; }

    public virtual DbSet<Vmsview> Vmsviews { get; set; }

    public virtual DbSet<Weather> Weathers { get; set; }

    public virtual DbSet<WhoIsInTheBuilding> WhoIsInTheBuildings { get; set; }

    public virtual DbSet<WorkSamplingStudyAll> WorkSamplingStudyAlls { get; set; }

    public virtual DbSet<WorkSamplingStudyMachine> WorkSamplingStudyMachines { get; set; }

    public virtual DbSet<WorkingSamplingTime> WorkingSamplingTimes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:sswhite.database.windows.net,1433;Initial Catalog=ITEIndia;User ID=ssw-ad;Password=ahbarp#6008_ss;MultipleActiveResultSets=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdvanceLicenceTbl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.GroupId, e.LineId }).HasName("PK_Advance_licence_tbl_1");

            entity.ToTable("Advance_licence_tbl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.LineId).HasColumnName("line_id");
            entity.Property(e => e.ApproxIssueQtyKg)
                .HasMaxLength(50)
                .HasColumnName("approx_issue_qty_kg");
            entity.Property(e => e.Binno)
                .HasMaxLength(500)
                .HasColumnName("binno");
            entity.Property(e => e.ChipWtProducedKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("chip_wt_produced_kg");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsFinal).HasColumnName("is_final");
            entity.Property(e => e.IssuedQtyInchActual)
                .HasMaxLength(50)
                .HasColumnName("issued_qty_inch_actual");
            entity.Property(e => e.IssuedQtyKgActual)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("issued_qty_kg_actual");
            entity.Property(e => e.JobQty)
                .HasMaxLength(50)
                .HasColumnName("job_qty");
            entity.Property(e => e.OkQtyKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ok_qty_kg");
            entity.Property(e => e.OkQtyPc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ok_qty_pc");
            entity.Property(e => e.OpWeight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OP_Weight");
            entity.Property(e => e.PerOperationOkQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("per_operation_ok_qty");
            entity.Property(e => e.PerPartInch)
                .HasMaxLength(50)
                .HasColumnName("per_part_inch");
            entity.Property(e => e.PerPartQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("per_part_qty");
            entity.Property(e => e.QtyRejectedInNumber)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty_Rejected_in_number");
            entity.Property(e => e.RejectedQtyInKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Rejected_qty_in_Kg");
            entity.Property(e => e.RemarkForOkqty)
                .HasMaxLength(500)
                .HasColumnName("remark_for_okqty");
            entity.Property(e => e.RmDescription)
                .HasMaxLength(500)
                .HasColumnName("rm_description");
            entity.Property(e => e.RmFgPartNo)
                .HasMaxLength(50)
                .HasColumnName("rm_fg_part_no");
            entity.Property(e => e.RmIssueDate).HasColumnName("rm_issue_date");
            entity.Property(e => e.RmJobNo)
                .HasMaxLength(50)
                .HasColumnName("rm_job_no");
            entity.Property(e => e.RmLotNo)
                .HasMaxLength(50)
                .HasColumnName("rm_lot_no");
            entity.Property(e => e.RmOperation).HasColumnName("rm_operation");
            entity.Property(e => e.RmOperationName)
                .HasMaxLength(50)
                .HasColumnName("rm_operation_name");
            entity.Property(e => e.RmPartNo)
                .HasMaxLength(50)
                .HasColumnName("rm_part_no");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploaded_date");
            entity.Property(e => e.UploadedName)
                .HasMaxLength(50)
                .HasColumnName("uploaded_name");
            entity.Property(e => e.WasteScrap)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Waste_Scrap");
        });

        modelBuilder.Entity<AdvanceLicencesOperationTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_operation_tbl");

            entity.ToTable("Advance_Licences_operation_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FgOkQtyKg)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fg_ok_qty_kg");
            entity.Property(e => e.FgOkQtyPc)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("fg_ok_qty_pc");
            entity.Property(e => e.IssuedQtyKg)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("issued_qty_kg");
            entity.Property(e => e.OkQtyPieace)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ok_qty_pieace");
            entity.Property(e => e.QtyRejectedInNumber)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("qty_Rejected_in_number");
            entity.Property(e => e.RId).HasColumnName("r_id");
            entity.Property(e => e.RejectedQtyInKg)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Rejected_qty_in_Kg");
            entity.Property(e => e.ReturnQtyInch)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("return_qty_inch");
            entity.Property(e => e.ReturnQtyKg)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("return_qty_kg");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(50)
                .HasColumnName("return_remark");
            entity.Property(e => e.RmOperation)
                .HasMaxLength(50)
                .HasColumnName("rm_operation");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploaded_date");
            entity.Property(e => e.UploadedName)
                .HasMaxLength(50)
                .HasColumnName("uploaded_name");
            entity.Property(e => e.WasteScrap)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Waste_Scrap");
        });

        modelBuilder.Entity<AnimationRecord>(entity =>
        {
            entity.ToTable("Animation_Record");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CameraMovements).HasMaxLength(50);
            entity.Property(e => e.EntireFilmora)
                .HasMaxLength(50)
                .HasColumnName("Entire_Filmora");
            entity.Property(e => e.FilmoraText)
                .HasMaxLength(50)
                .HasColumnName("Filmora_text");
            entity.Property(e => e.FilmoraVoice)
                .HasMaxLength(50)
                .HasColumnName("Filmora_voice");
            entity.Property(e => e.FormatsForStoryboards)
                .HasMaxLength(50)
                .HasColumnName("formats_for_storyboards");
            entity.Property(e => e.MaterialTexture)
                .HasMaxLength(50)
                .HasColumnName("material_texture");
            entity.Property(e => e.ObjectImport)
                .HasMaxLength(50)
                .HasColumnName("Object_Import");
            entity.Property(e => e.ObjectMovementsKeyframes)
                .HasMaxLength(50)
                .HasColumnName("Object_Movements_Keyframes");
            entity.Property(e => e.PersonName).HasMaxLength(500);
            entity.Property(e => e.RenderParameter).HasMaxLength(50);
            entity.Property(e => e.SolidWorksBoneCreation)
                .HasMaxLength(50)
                .HasColumnName("Solid_works_Bone_creation");
            entity.Property(e => e.SolidWorksKitCreation)
                .HasMaxLength(50)
                .HasColumnName("Solid_works_kit_creation");
            entity.Property(e => e.SolidWorksModelCreation)
                .HasMaxLength(50)
                .HasColumnName("Solid_works_model_creation");
            entity.Property(e => e.StoryboardIdeas)
                .HasMaxLength(50)
                .HasColumnName("Storyboard_Ideas");
            entity.Property(e => e.StoryboardWriteup)
                .HasMaxLength(50)
                .HasColumnName("Storyboard_Writeup");
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(50)
                .HasColumnName("Submitted_by");
            entity.Property(e => e.Techniquesforlightingandrendering).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.ToTable("application");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addressline1)
                .IsUnicode(false)
                .HasColumnName("addressline1");
            entity.Property(e => e.Addressline2)
                .IsUnicode(false)
                .HasColumnName("addressline2");
            entity.Property(e => e.Adharcard)
                .IsUnicode(false)
                .HasColumnName("adharcard");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Applydate).HasColumnName("applydate");
            entity.Property(e => e.Children).HasColumnName("children");
            entity.Property(e => e.City)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Dateofbirth).HasColumnName("dateofbirth");
            entity.Property(e => e.Disability)
                .IsUnicode(false)
                .HasColumnName("disability");
            entity.Property(e => e.Disabilityyesno)
                .IsUnicode(false)
                .HasColumnName("disabilityyesno");
            entity.Property(e => e.Dist)
                .IsUnicode(false)
                .HasColumnName("dist");
            entity.Property(e => e.Drivinglicense)
                .IsUnicode(false)
                .HasColumnName("drivinglicense");
            entity.Property(e => e.EducationId).HasColumnName("education_id");
            entity.Property(e => e.Electioncard)
                .IsUnicode(false)
                .HasColumnName("electioncard");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Father)
                .IsUnicode(false)
                .HasColumnName("father");
            entity.Property(e => e.Maritalstatus)
                .IsUnicode(false)
                .HasColumnName("maritalstatus");
            entity.Property(e => e.Mobile)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Paddressline1)
                .IsUnicode(false)
                .HasColumnName("paddressline1");
            entity.Property(e => e.Paddressline2)
                .IsUnicode(false)
                .HasColumnName("paddressline2");
            entity.Property(e => e.Pancard)
                .IsUnicode(false)
                .HasColumnName("pancard");
            entity.Property(e => e.Pcity)
                .IsUnicode(false)
                .HasColumnName("pcity");
            entity.Property(e => e.Pdist)
                .IsUnicode(false)
                .HasColumnName("pdist");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Pincode)
                .IsUnicode(false)
                .HasColumnName("pincode");
            entity.Property(e => e.Pmobile)
                .IsUnicode(false)
                .HasColumnName("pmobile");
            entity.Property(e => e.Ppincode)
                .IsUnicode(false)
                .HasColumnName("ppincode");
            entity.Property(e => e.Ptaluka)
                .IsUnicode(false)
                .HasColumnName("ptaluka");
            entity.Property(e => e.Ptelephone)
                .IsUnicode(false)
                .HasColumnName("ptelephone");
            entity.Property(e => e.Refaddress)
                .IsUnicode(false)
                .HasColumnName("refaddress");
            entity.Property(e => e.Refbusiness)
                .IsUnicode(false)
                .HasColumnName("refbusiness");
            entity.Property(e => e.Refcontact)
                .IsUnicode(false)
                .HasColumnName("refcontact");
            entity.Property(e => e.Refname)
                .IsUnicode(false)
                .HasColumnName("refname");
            entity.Property(e => e.Relation)
                .IsUnicode(false)
                .HasColumnName("relation");
            entity.Property(e => e.Relativename)
                .IsUnicode(false)
                .HasColumnName("relativename");
            entity.Property(e => e.Relativeyesno)
                .IsUnicode(false)
                .HasColumnName("relativeyesno");
            entity.Property(e => e.Sex)
                .IsUnicode(false)
                .HasColumnName("sex");
            entity.Property(e => e.Sign)
                .HasColumnType("image")
                .HasColumnName("sign");
            entity.Property(e => e.Surname)
                .IsUnicode(false)
                .HasColumnName("surname");
            entity.Property(e => e.Taluka)
                .IsUnicode(false)
                .HasColumnName("taluka");
            entity.Property(e => e.Telephone)
                .IsUnicode(false)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<AssociatedDocument>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Associated_Document");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.DocumentId).HasColumnName("document_ID");
            entity.Property(e => e.DocumentIdTitle)
                .HasMaxLength(500)
                .HasColumnName("document_ID_Title");
        });

        modelBuilder.Entity<AttachmentMst>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Attachment_Mst");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Approval)
                .HasMaxLength(10)
                .HasColumnName("approval");
            entity.Property(e => e.AttachedFileName).HasColumnName("attached_file_name");
            entity.Property(e => e.AttachmentDate)
                .HasColumnType("datetime")
                .HasColumnName("attachment_date");
            entity.Property(e => e.AttachmentType)
                .HasMaxLength(500)
                .HasColumnName("attachment_Type");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.EpoNo).HasColumnName("EPO_no");
            entity.Property(e => e.FileName).HasColumnName("file_name");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<BackupLog>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid });

            entity.ToTable("backup_logs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Filename)
                .HasMaxLength(50)
                .HasColumnName("filename");
        });

        modelBuilder.Entity<CatagoryTbl>(entity =>
        {
            entity.ToTable("catagory_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("is_deleted");
        });

        modelBuilder.Entity<ConfranceroomBookDatum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.End)
                .HasColumnType("datetime")
                .HasColumnName("end");
            entity.Property(e => e.EndTime).HasMaxLength(500);
            entity.Property(e => e.EventDate).HasMaxLength(500);
            entity.Property(e => e.Frequncy).HasMaxLength(50);
            entity.Property(e => e.Iid).HasColumnName("IID");
            entity.Property(e => e.Start).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasMaxLength(500);
        });

        modelBuilder.Entity<CrupMst>(entity =>
        {
            entity.HasKey(e => new { e.TenantId, e.CrupId }).HasName("PK_ERP_CREATEUPDATE_MST");

            entity.ToTable("CRUP_MST");

            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.ActivityType).HasColumnName("Activity_Type");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDt)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DT");
            entity.Property(e => e.MenuId).HasColumnName("MENU_ID");
            entity.Property(e => e.Physicallocid)
                .HasMaxLength(100)
                .HasColumnName("PHYSICALLOCID");
            entity.Property(e => e.TableName).HasColumnName("Table_Name");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UpdatedDt)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED_DT");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<DayClose>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TenentId, e.UserId }).HasName("PK__DayClose__3214EC27B97A42A6");

            entity.ToTable("DayClose");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Amtdelivered)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("AMTDelivered");
            entity.Property(e => e.ChequeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("ChequeAMT");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeliveredTo).HasColumnName("DeliveredTO");
            entity.Property(e => e.ExpAmt)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("ExpAMT");
            entity.Property(e => e.OpAmt)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("OpAMT");
            entity.Property(e => e.RefNo).HasColumnName("RefNO");
            entity.Property(e => e.ShiftCih)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("ShiftCIH");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ShiftPurchase)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)");
            entity.Property(e => e.ShiftReturn)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)");
            entity.Property(e => e.ShiftSales)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)");
            entity.Property(e => e.SynId).HasColumnName("SynID");
            entity.Property(e => e.Syncby).HasMaxLength(50);
            entity.Property(e => e.TrmId).HasColumnName("TrmID");
            entity.Property(e => e.UndeliverdAmt)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("undeliverdAMT");
            entity.Property(e => e.Uploadby).HasMaxLength(50);
            entity.Property(e => e.VoucharAmt)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("VoucharAMT");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ColorCode).HasMaxLength(50);
            entity.Property(e => e.Departmentname).HasColumnName("departmentname");
            entity.Property(e => e.DepartmentsupervisorDeputyManager).HasColumnName("departmentsupervisor_deputy_manager");
            entity.Property(e => e.DepartmentsupervisorManager).HasColumnName("departmentsupervisor_manager");
            entity.Property(e => e.Departmentsupervisorname).HasColumnName("departmentsupervisorname");
            entity.Property(e => e.Mid).HasColumnName("mid");
            entity.Property(e => e.PersonId)
                .HasMaxLength(10)
                .HasColumnName("personID");
        });

        modelBuilder.Entity<DeptContinuousImprovementProject>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_Continuous_Improvement_Projects");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.CompletionDate).HasColumnName("Completion_Date");
            entity.Property(e => e.CurrentGap).HasColumnName("Current_Gap");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.EstimatedCompletionDate).HasColumnName("Estimated_Completion_Date");
            entity.Property(e => e.PlanToAddress).HasColumnName("Plan_to_Address");
            entity.Property(e => e.ReferenceDocument).HasColumnName("Reference_Document");
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeptForm>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("dept_forms");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.FormName)
                .HasMaxLength(100)
                .HasColumnName("Form_name");
        });

        modelBuilder.Entity<DeptInterviewQuestion>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_Interview_Questions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.ExpectedResponse).HasColumnName("Expected_Response");
            entity.Property(e => e.TypeOfQuestion)
                .HasMaxLength(500)
                .HasColumnName("Type_of_Question");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<DeptKpi>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_KPI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ActualAverageOfKpi).HasColumnName("Actual_Average_of_KPI");
            entity.Property(e => e.ActualKpiCount).HasColumnName("Actual_KPI_Count");
            entity.Property(e => e.ActualYtd).HasColumnName("Actual_YTD");
            entity.Property(e => e.Attachment).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.HasSubProcess).HasColumnName("Has_Sub_Process");
            entity.Property(e => e.Kpi).HasColumnName("KPI");
            entity.Property(e => e.KpiDate).HasColumnName("KPI_Date");
            entity.Property(e => e.KpiMonth).HasColumnName("KPI_Month");
            entity.Property(e => e.KpiYear).HasColumnName("KPI_Year");
            entity.Property(e => e.Owner).HasMaxLength(50);
            entity.Property(e => e.PlanAverageOfKpi).HasColumnName("Plan_Average_of_KPI");
            entity.Property(e => e.PlanKpiCount).HasColumnName("Plan_KPI_Count");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubProcess).HasColumnName("Sub_Process");
            entity.Property(e => e.Ytd).HasColumnName("YTD");
        });

        modelBuilder.Entity<DeptMasterProjectList>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Dept_Master_Project_List");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ActualEndDate).HasColumnName("Actual_End_Date");
            entity.Property(e => e.ActualStartDate).HasColumnName("Actual_Start_Date");
            entity.Property(e => e.AssignedBy).HasColumnName("Assigned_By");
            entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");
            entity.Property(e => e.AssignedTo).HasColumnName("Assigned_To");
            entity.Property(e => e.ExpectedEndDate).HasColumnName("Expected_End_Date");
            entity.Property(e => e.LeadPerson).HasColumnName("Lead_Person");
            entity.Property(e => e.ProjectDescription).HasColumnName("Project_Description");
            entity.Property(e => e.ProjectName).HasColumnName("Project_Name");
            entity.Property(e => e.TypeOfProject).HasColumnName("Type_Of_Project");
        });

        modelBuilder.Entity<DeptMultiname>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Dept_Multiname");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.FormName).HasColumnName("Form_Name");
            entity.Property(e => e.PersonId).HasColumnName("Person_ID");
            entity.Property(e => e.PersonName).HasColumnName("Person_Name");
            entity.Property(e => e.TaskId).HasColumnName("TASK_ID");
        });

        modelBuilder.Entity<DeptOpenActionItem>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_Open_Action_Item");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ActualEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Actual_End_Date");
            entity.Property(e => e.ActualStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Actual_Start_Date");
            entity.Property(e => e.AssignedBy).HasColumnName("Assigned_By");
            entity.Property(e => e.AssignedTo).HasColumnName("Assigned_TO");
            entity.Property(e => e.DateAssigned)
                .HasColumnType("datetime")
                .HasColumnName("Date_Assigned");
            entity.Property(e => e.EstimatedEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Estimated_End_Date");
            entity.Property(e => e.HasSubTask).HasColumnName("Has_Sub_Task");
            entity.Property(e => e.ProjectDescription).HasColumnName("Project_Description");
            entity.Property(e => e.ProjectList).HasColumnName("Project_List");
            entity.Property(e => e.ProjectStatus).HasColumnName("Project_Status");
            entity.Property(e => e.ReleventInformation).HasColumnName("Relevent_Information");
            entity.Property(e => e.SubTask).HasColumnName("Sub_Task");
        });

        modelBuilder.Entity<DeptPeriodicActionItem>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_Periodic_Action_Items");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Frequency).HasMaxLength(50);
            entity.Property(e => e.ProcessName).HasColumnName("Process_Name");
            entity.Property(e => e.ProcessReview).HasColumnName("Process_Review");
            entity.Property(e => e.ReferenceDocument).HasColumnName("Reference_Document");
            entity.Property(e => e.ResponsiblePerson).HasColumnName("Responsible_Person");
            entity.Property(e => e.ResponsiblePersonName).HasColumnName("Responsible_Person_Name");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeptPersonalGrowth>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("DEPT_Personal_Growth");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectName).HasColumnName("Project_Name");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UploadBy).HasMaxLength(50);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeptReponsibilityMatrix>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_Reponsibility_Matrix");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Person).HasMaxLength(100);
            entity.Property(e => e.Responsibility).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(100);
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate).HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<DeptReportNeedDepartment>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("dept_Report_need_department");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.TypeOfDocument).HasColumnName("Type_of_Document");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeptSoftwareSubscription>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_Software_Subscription");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.NextRenewalDate).HasColumnName("Next_Renewal_date");
            entity.Property(e => e.NoOfLicence).HasColumnName("No_of_Licence");
            entity.Property(e => e.PaymentBy).HasColumnName("Payment_By");
            entity.Property(e => e.PrimaryDepartment).HasColumnName("Primary_Department");
            entity.Property(e => e.SoftwareName).HasColumnName("Software_name");
            entity.Property(e => e.SoftwareType).HasColumnName("Software_Type");
            entity.Property(e => e.SubsccriptionTimePeriod).HasColumnName("Subsccription_Time_Period");
            entity.Property(e => e.SubscriptionStartDate).HasColumnName("Subscription_Start_Date");
            entity.Property(e => e.UploadBy).HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate).HasColumnName("Upload_Date");
            entity.Property(e => e.VendorContactDetails).HasColumnName("Vendor_Contact_Details");
        });

        modelBuilder.Entity<DeptTask>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid }).HasName("PK_Task");

            entity.ToTable("dept_Task");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.CompletedBy).HasColumnName("Completed_by");
            entity.Property(e => e.DueDate).HasColumnName("Due_Date");
            entity.Property(e => e.EndDate).HasColumnName("End_Date");
            entity.Property(e => e.ProjectName).HasColumnName("Project_Name");
            entity.Property(e => e.StartDate).HasColumnName("Start_Date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TaskDescription).HasColumnName("Task_Description");
            entity.Property(e => e.TaskFile).HasColumnName("Task_File");
            entity.Property(e => e.TaskProgress)
                .HasMaxLength(50)
                .HasColumnName("Task_Progress");
            entity.Property(e => e.TaskTags).HasColumnName("Task_Tags");
            entity.Property(e => e.TaskTitle).HasColumnName("Task_Title");
            entity.Property(e => e.UploadBy).HasColumnName("Upload_by");
        });

        modelBuilder.Entity<DeptTrainingTopic>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_Training_Topic");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Frequency).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Trainer).HasMaxLength(50);
            entity.Property(e => e.TrainingDate)
                .HasColumnType("datetime")
                .HasColumnName("Training_Date");
            entity.Property(e => e.TrainingMaterial).HasColumnName("Training_Material");
            entity.Property(e => e.TrainingTopic).HasColumnName("Training_Topic");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<DeptWorkloadDistribution>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("dept_workload_distribution");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.FrequencyOfTask)
                .HasMaxLength(50)
                .HasColumnName("Frequency_of_Task");
            entity.Property(e => e.MainTask).HasColumnName("Main_Task");
            entity.Property(e => e.Person).HasMaxLength(50);
            entity.Property(e => e.PrimaryResponsibility).HasColumnName("Primary_Responsibility");
            entity.Property(e => e.SecondaryResponsibility).HasColumnName("Secondary_Responsibility");
            entity.Property(e => e.SubTask).HasColumnName("Sub_Task");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<DeptWorkloadReportTbl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Rid });

            entity.ToTable("dept_workload_report_tbl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.ReportingDate).HasColumnType("datetime");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<DeptWorkloadSubtaskTbl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Rid });

            entity.ToTable("dept_workload_subtask_tbl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.DeadLine).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(50);
            entity.Property(e => e.ResponsibilityPersonId).HasColumnName("ResponsibilityPersonID");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(50)
                .HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<DispatchAvilableDetail>(entity =>
        {
            entity.ToTable("Dispatch_Avilable _Details");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PalletsCounts).HasColumnName("Pallets_Counts");
            entity.Property(e => e.Pid).ValueGeneratedOnAdd();
            entity.Property(e => e.SuggestedPallets).HasColumnName("Suggested_Pallets");
        });

        modelBuilder.Entity<DispatchBoxDropDown>(entity =>
        {
            entity.ToTable("Dispatch_BoxDropDown");

            entity.Property(e => e.ActiveLogs).HasColumnName("Active_logs");
            entity.Property(e => e.BoxName).HasMaxLength(50);
            entity.Property(e => e.BoxValue).HasMaxLength(50);
            entity.Property(e => e.EmptyBoxWeight).HasColumnType("decimal(10, 3)");
        });

        modelBuilder.Entity<DispatchCode>(entity =>
        {
            entity.ToTable("Dispatch_Code");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FdaClassification)
                .HasMaxLength(50)
                .HasColumnName("FDA Classification");
            entity.Property(e => e.FdaProductCode)
                .HasMaxLength(10)
                .HasColumnName("FDA Product Code");
            entity.Property(e => e.IndustryProductCode)
                .HasMaxLength(10)
                .HasColumnName("Industry & Product Code");
            entity.Property(e => e.InvoiceDescription)
                .HasMaxLength(500)
                .HasColumnName("Invoice Description");
            entity.Property(e => e.Methodology).HasMaxLength(500);
            entity.Property(e => e.NotesQuestions).HasColumnName("Notes/Questions");
            entity.Property(e => e.PartDesc).HasColumnName("Part Desc");
            entity.Property(e => e.PartNum).HasMaxLength(200);
            entity.Property(e => e.Tariff).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.UsHts)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("US HTS");
        });

        modelBuilder.Entity<DispatchDatum>(entity =>
        {
            entity.ToTable("Dispatch_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BoxHeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BoxLength).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BoxType).HasMaxLength(500);
            entity.Property(e => e.BoxWeight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BoxWidth).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.JobNo).HasMaxLength(100);
            entity.Property(e => e.Lm).HasColumnName("LM");
            entity.Property(e => e.PackingDetailsManualorSuggested).HasMaxLength(50);
            entity.Property(e => e.PartNo).HasMaxLength(100);
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.PoNo).HasMaxLength(100);
            entity.Property(e => e.TotalWeight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WPcs)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("wPcs");
        });

        modelBuilder.Entity<DispatchGrade>(entity =>
        {
            entity.ToTable("Dispatch_Grade");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Grade).HasMaxLength(10);
            entity.Property(e => e.MaterialType)
                .HasMaxLength(500)
                .HasColumnName("Material Type");
            entity.Property(e => e.PId).HasColumnName("P ID");
        });

        modelBuilder.Entity<DispatchInventoryStock>(entity =>
        {
            entity.ToTable("Dispatch_Inventory_Stock");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PalletAdditionalWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PalletType).HasMaxLength(50);
        });

        modelBuilder.Entity<DispatchInventoryStockLog>(entity =>
        {
            entity.ToTable("Dispatch_Inventory_StockLogs");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DateandTime).HasColumnType("datetime");
            entity.Property(e => e.Pid).HasColumnName("PID");
        });

        modelBuilder.Entity<DispatchMaterialShape>(entity =>
        {
            entity.ToTable("Dispatch_Material_Shape");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActiveLogs).HasColumnName("Active_logs");
            entity.Property(e => e.MaterialGrade).HasColumnName("Material_Grade");
            entity.Property(e => e.MaterialShape).HasColumnName("Material_Shape");
            entity.Property(e => e.MaterialType).HasColumnName("Material_Type");
        });

        modelBuilder.Entity<DispatchPackingDetail>(entity =>
        {
            entity.ToTable("Dispatch_PackingDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category).HasMaxLength(200);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.PackslipNo).HasMaxLength(50);
        });

        modelBuilder.Entity<DispatchPalletSuggestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dispatch__3214EC0741F6DE7B");

            entity.ToTable("Dispatch_PalletSuggestions");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PalletSize).HasMaxLength(50);
        });

        modelBuilder.Entity<DispatchProvidedPackingDetailsPalate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Dispatch_ProvidedPackingDetails");

            entity.ToTable("Dispatch_ProvidedPackingDetailsPalate");

            entity.Property(e => e.PallateType).HasMaxLength(50);
            entity.Property(e => e.Pid).HasColumnName("PId");
        });

        modelBuilder.Entity<DispatchProvidedPackingDetailsPalateBoxesInside>(entity =>
        {
            entity.ToTable("Dispatch_ProvidedPackingDetailsPalateBoxesInside");

            entity.Property(e => e.PalletId).HasColumnName("PalletID");
        });

        modelBuilder.Entity<DispatchStaticdatum>(entity =>
        {
            entity.ToTable("dispatch_Staticdata");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Cin)
                .IsUnicode(false)
                .HasColumnName("CIN");
            entity.Property(e => e.CountryOfOrigin).IsUnicode(false);
            entity.Property(e => e.FdafacilityRegn)
                .IsUnicode(false)
                .HasColumnName("FDAFacilityRegn#");
            entity.Property(e => e.Fei)
                .IsUnicode(false)
                .HasColumnName("FEI#");
            entity.Property(e => e.Gstin)
                .IsUnicode(false)
                .HasColumnName("GSTIN");
            entity.Property(e => e.Iecno)
                .IsUnicode(false)
                .HasColumnName("IECNO");
            entity.Property(e => e.PaymentTerms).IsUnicode(false);
            entity.Property(e => e.PortOfLoading).IsUnicode(false);
            entity.Property(e => e.Signature)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SnaddLine1)
                .IsUnicode(false)
                .HasColumnName("SNAddLine1");
            entity.Property(e => e.SnaddLine2)
                .IsUnicode(false)
                .HasColumnName("SNAddLine2");
            entity.Property(e => e.SnaddLine3)
                .IsUnicode(false)
                .HasColumnName("SNAddLine3");
            entity.Property(e => e.SnaddLine4)
                .IsUnicode(false)
                .HasColumnName("SNAddLine4");
            entity.Property(e => e.SnaddLine5)
                .IsUnicode(false)
                .HasColumnName("SNAddLine5");
            entity.Property(e => e.SnaddLine6)
                .IsUnicode(false)
                .HasColumnName("SNAddLine6");
            entity.Property(e => e.SnaddLine7)
                .IsUnicode(false)
                .HasColumnName("SNAddLine7");
            entity.Property(e => e.TermsOfDelivery).IsUnicode(false);
            entity.Property(e => e.VesselFlightNo)
                .IsUnicode(false)
                .HasColumnName("Vessel_FlightNo");
        });

        modelBuilder.Entity<DispatchType>(entity =>
        {
            entity.ToTable("dispatch_type");

            entity.Property(e => e.ActiveLogs).HasColumnName("Active_logs");
            entity.Property(e => e.Cin).HasColumnName("CIN");
            entity.Property(e => e.FdafacilityRegn).HasColumnName("FDAFacilityRegn");
            entity.Property(e => e.Fei).HasColumnName("FEI");
            entity.Property(e => e.Gstin).HasColumnName("GSTIN");
            entity.Property(e => e.Hscode)
                .HasMaxLength(50)
                .HasColumnName("HSCode");
            entity.Property(e => e.Iecno).HasColumnName("IECNO");
            entity.Property(e => e.Ritc).HasColumnName("RITC");
            entity.Property(e => e.SnplantAddressLine1).HasColumnName("SNPlantAddressLine1");
            entity.Property(e => e.SnplantAddressLine2).HasColumnName("SNPlantAddressLine2");
            entity.Property(e => e.SnplantAddressLine3).HasColumnName("SNPlantAddressLine3");
            entity.Property(e => e.SnplantName).HasColumnName("SNPlantName");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VesselFlightNo).HasColumnName("Vessel_FlightNo");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.DocumentType, e.DocumentId });

            entity.ToTable("Document");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .HasColumnName("document_type");
            entity.Property(e => e.DocumentId).HasColumnName("document_id");
            entity.Property(e => e.AssociatedDocumentId).HasColumnName("associated_document_ID");
            entity.Property(e => e.AssociatedDocuments)
                .HasMaxLength(500)
                .HasColumnName("associated_documents");
            entity.Property(e => e.AttachmentId).HasColumnName("attachment_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(500)
                .HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CurrentRev).HasColumnName("Current_rev");
            entity.Property(e => e.CustomerApprovalRequired)
                .HasMaxLength(50)
                .HasColumnName("Customer_approval_required");
            entity.Property(e => e.CustomerNotificationRequired)
                .HasMaxLength(50)
                .HasColumnName("Customer_Notification_Required");
            entity.Property(e => e.CustomerPartNumber).HasColumnName("Customer_part_number");
            entity.Property(e => e.Definitions).HasColumnName("definitions");
            entity.Property(e => e.DescriptionOfChange).HasColumnName("description_of_change");
            entity.Property(e => e.DocumentIdTitle)
                .HasMaxLength(500)
                .HasColumnName("document_ID_Title");
            entity.Property(e => e.DocumentName).HasColumnName("document_name");
            entity.Property(e => e.DocumentTitle).HasColumnName("document_title");
            entity.Property(e => e.DrawingNumber).HasColumnName("Drawing_Number");
            entity.Property(e => e.EcnDateNeeded)
                .HasColumnType("datetime")
                .HasColumnName("ECN_date_needed");
            entity.Property(e => e.EcnNumber).HasColumnName("ECN_Number");
            entity.Property(e => e.EcnTitle).HasColumnName("ECN_Title");
            entity.Property(e => e.EcnWillChangeNo).HasColumnName("ECN_Will_change_no");
            entity.Property(e => e.FileSubjectToApprovalProcess)
                .HasMaxLength(10)
                .HasColumnName("File_Subject_to_Approval_process");
            entity.Property(e => e.Form).HasColumnName("form");
            entity.Property(e => e.ImplementationDate)
                .HasColumnType("datetime")
                .HasColumnName("implementation_date");
            entity.Property(e => e.InstructionForEcnImplementation).HasColumnName("Instruction_for_ECN_implementation");
            entity.Property(e => e.NewRev).HasColumnName("New_rev");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PartDescriptionOrName).HasColumnName("part_description_or_name");
            entity.Property(e => e.PartNumber).HasColumnName("part_number");
            entity.Property(e => e.ProceDure).HasColumnName("proce_dure");
            entity.Property(e => e.Procedures).HasColumnName("procedures");
            entity.Property(e => e.PropertyApprovalId).HasColumnName("property_approval_id");
            entity.Property(e => e.PropertyElectricalId).HasColumnName("property_Electrical_id");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.ReasonForChange).HasColumnName("reason_for_change");
            entity.Property(e => e.Responsibilities).HasColumnName("responsibilities");
            entity.Property(e => e.Rev).HasColumnName("rev");
            entity.Property(e => e.RevChangeMode).HasColumnName("rev_change_mode");
            entity.Property(e => e.RevChangedBy)
                .HasMaxLength(50)
                .HasColumnName("rev_changed_by");
            entity.Property(e => e.RevChangedDate)
                .HasColumnType("datetime")
                .HasColumnName("rev_changed_date");
            entity.Property(e => e.RevSecParaChanged).HasColumnName("rev_sec_para_changed");
            entity.Property(e => e.RevTrainingCompletedOn)
                .HasColumnType("datetime")
                .HasColumnName("rev_training_completed_on");
            entity.Property(e => e.RevTrainingRequired)
                .HasMaxLength(50)
                .HasColumnName("rev_training_required");
            entity.Property(e => e.RevisionLog).HasColumnName("revision_log");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.UpdateBy).HasColumnName("update_by");
            entity.Property(e => e.UpdateDateDoc)
                .HasColumnType("datetime")
                .HasColumnName("update_date_doc");
            entity.Property(e => e.WorkInstruction).HasColumnName("work_instruction");
        });

        modelBuilder.Entity<EcnChangeOption>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Ecnid, e.Pid });

            entity.ToTable("ECN_CHANGE_OPTIONS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Ecnid).HasColumnName("ECNID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EcnName)
                .HasMaxLength(500)
                .HasColumnName("ECN_Name");
        });

        modelBuilder.Entity<EcnDatabaseFlex>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EcnNo });

            entity.ToTable("ECN_Database_Flex");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EcnNo)
                .HasMaxLength(100)
                .HasColumnName("ECN_No");
            entity.Property(e => e.ChangeDetails).HasColumnName("change_Details");
            entity.Property(e => e.ChangeDetailsExisting).HasColumnName("change_details_Existing");
            entity.Property(e => e.ChangeDetailsProposed).HasColumnName("change_details_proposed");
            entity.Property(e => e.ChangeReferenceDocument)
                .HasMaxLength(500)
                .HasColumnName("Change_reference_document");
            entity.Property(e => e.ChangeRequestedBy)
                .HasMaxLength(500)
                .HasColumnName("Change_Requested_by");
            entity.Property(e => e.ChangeType)
                .HasMaxLength(500)
                .HasColumnName("Change_Type");
            entity.Property(e => e.CustomerDrawingNumber)
                .HasMaxLength(500)
                .HasColumnName("Customer_Drawing_Number");
            entity.Property(e => e.CustomerDrawingRevision)
                .HasMaxLength(100)
                .HasColumnName("Customer_Drawing_revision");
            entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerPartNumber)
                .HasMaxLength(500)
                .HasColumnName("Customer_Part_Number");
            entity.Property(e => e.CustomerPartRevision)
                .HasMaxLength(100)
                .HasColumnName("Customer_Part_Revision");
            entity.Property(e => e.EcnReleaseDate)
                .HasColumnType("datetime")
                .HasColumnName("ECN_Release_Date");
            entity.Property(e => e.EcnStatus)
                .HasMaxLength(100)
                .HasColumnName("ECN_Status");
            entity.Property(e => e.EngineeringChangeCumApprovalNote)
                .HasMaxLength(500)
                .HasColumnName("Engineering_change_cum_approval_note");
            entity.Property(e => e.Feasibility).HasMaxLength(500);
            entity.Property(e => e.FlApprovalDocument).HasColumnName("FL_Approval_Document");
            entity.Property(e => e.OtherReasonName).HasColumnName("Other_reason_name");
            entity.Property(e => e.OtherStageName).HasColumnName("Other_stage_name");
            entity.Property(e => e.Process).HasColumnName("process");
            entity.Property(e => e.Productafterproduction).HasColumnName("productafterproduction");
            entity.Property(e => e.Productprototype).HasColumnName("productprototype");
            entity.Property(e => e.ReasonForChange)
                .HasMaxLength(500)
                .HasColumnName("Reason_For_Change");
            entity.Property(e => e.RemarkForApproval).HasColumnName("Remark_for_Approval");
            entity.Property(e => e.RiskAssessment)
                .HasMaxLength(500)
                .HasColumnName("Risk_Assessment");
            entity.Property(e => e.SswDrawingRevision)
                .HasMaxLength(100)
                .HasColumnName("SSW_Drawing_Revision");
            entity.Property(e => e.SswFlApproval)
                .HasMaxLength(500)
                .HasColumnName("SSW_FL_Approval");
            entity.Property(e => e.SswFlApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("SSW_FL_Approval_date");
            entity.Property(e => e.SswPartName).HasColumnName("SSW_Part_Name");
            entity.Property(e => e.SswSnApproval)
                .HasMaxLength(500)
                .HasColumnName("SSW_SN_Approval");
            entity.Property(e => e.SswSnApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("SSW_SN_Approval_date");
            entity.Property(e => e.StageOfChange)
                .HasMaxLength(500)
                .HasColumnName("Stage_of_Change");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(500)
                .HasColumnName("Upload_by");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
            entity.Property(e => e.ZipFile)
                .HasMaxLength(500)
                .HasColumnName("Zip_file");
        });

        modelBuilder.Entity<EducationDetail>(entity =>
        {
            entity.HasKey(e => e.EducationId).HasName("PK_new_table");

            entity.ToTable("education_details");

            entity.Property(e => e.EducationId).HasColumnName("education_id");
            entity.Property(e => e.Academicyear).HasColumnName("academicyear");
            entity.Property(e => e.Course)
                .IsUnicode(false)
                .HasColumnName("course");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mainsubject)
                .IsUnicode(false)
                .HasColumnName("mainsubject");
            entity.Property(e => e.Percentage)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("percentage");
            entity.Property(e => e.School)
                .IsUnicode(false)
                .HasColumnName("school");
        });

        modelBuilder.Entity<Emailauto>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid });

            entity.ToTable("emailauto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.App).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EmpCourseDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Courseid });

            entity.ToTable("Emp_Course_data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.AddedDateAfterDueDate).HasColumnName("added_date_after_due_date");
            entity.Property(e => e.AuthorName).HasColumnName("author_name");
            entity.Property(e => e.CourseName).HasColumnName("course_name");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due_Date");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("from_date");
            entity.Property(e => e.Hours).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("to_date");
        });

        modelBuilder.Entity<EmpLimit>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.EmployeeId });

            entity.ToTable("Emp_Limit");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.EmpDept).HasColumnName("Emp_dept");
            entity.Property(e => e.EmpLimitnew)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Emp_Limitnew");
            entity.Property(e => e.EmpManager).HasColumnName("Emp_Manager");
            entity.Property(e => e.EmployeeName).HasColumnName("Employee_name");
            entity.Property(e => e.MpcMember)
                .HasMaxLength(50)
                .HasColumnName("MPC_Member");
            entity.Property(e => e.MpcNumber)
                .HasMaxLength(50)
                .HasColumnName("MPC_Number");
            entity.Property(e => e.PreviousEmpLimit1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Previous_emp_Limit1");
            entity.Property(e => e.PreviousEmpLimit2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Previous_emp_Limit2");
            entity.Property(e => e.PreviousEmpLimit3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Previous_emp_limit3");
            entity.Property(e => e.PreviousEmpLimit4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Previous_emp_limit4");
            entity.Property(e => e.PreviousEmpLimit5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Previous_emp_limit5");
            entity.Property(e => e.PreviousEmpLimitNo).HasColumnName("Previous_emp_limit_no");
            entity.Property(e => e.RevisedDate1)
                .HasColumnType("datetime")
                .HasColumnName("revised_date1");
            entity.Property(e => e.RevisedDate2)
                .HasColumnType("datetime")
                .HasColumnName("revised_date2");
            entity.Property(e => e.RevisedDate3)
                .HasColumnType("datetime")
                .HasColumnName("revised_date3");
            entity.Property(e => e.RevisedDate4)
                .HasColumnType("datetime")
                .HasColumnName("revised_date4");
            entity.Property(e => e.RevisedDate5)
                .HasColumnType("datetime")
                .HasColumnName("revised_date5");
        });

        modelBuilder.Entity<EmpTrainingFinalDatabase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Emp_Tempfirst");

            entity.ToTable("Emp_Training_final_database");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasMaxLength(2)
                .HasColumnName("active");
            entity.Property(e => e.AddedDateAfterDueDate).HasColumnName("added_date_after_due_date");
            entity.Property(e => e.Attachment1JobDescription).HasColumnName("Attachment1_JobDescription");
            entity.Property(e => e.Attachment2TrainingHardcopy).HasColumnName("Attachment2_Training_Hardcopy");
            entity.Property(e => e.Author).HasColumnName("author");
            entity.Property(e => e.CourceId).HasColumnName("CourceID");
            entity.Property(e => e.CourseName).HasColumnName("Course_name");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Enteredby).HasColumnName("enteredby");
            entity.Property(e => e.EvoluationDate)
                .HasColumnType("datetime")
                .HasColumnName("Evoluation_date");
            entity.Property(e => e.EvoluationMethod)
                .HasMaxLength(500)
                .HasColumnName("Evoluation_method");
            entity.Property(e => e.EvoluationReq)
                .HasMaxLength(50)
                .HasColumnName("Evoluation_req");
            entity.Property(e => e.EvoluationRequired)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Evoluation_required");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("From_date");
            entity.Property(e => e.GeneralTraining).HasColumnName("General_training");
            entity.Property(e => e.Hours).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Instructor).HasColumnName("instructor");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.SaferyTraining).HasColumnName("Safery_training");
            entity.Property(e => e.TechnicalTraining).HasColumnName("Technical_training");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("To_date");
            entity.Property(e => e.Uploadby).HasColumnName("uploadby");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
        });

        modelBuilder.Entity<EmpTrainingMaster>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Emp_Training_Master");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.CourceName)
                .HasMaxLength(500)
                .HasColumnName("Cource_Name");
            entity.Property(e => e.Department).HasMaxLength(500);
            entity.Property(e => e.Hours).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Location).HasMaxLength(500);
            entity.Property(e => e.SubDepartment)
                .HasMaxLength(500)
                .HasColumnName("Sub_Department");
            entity.Property(e => e.SummaryOfContent).HasColumnName("Summary_of_Content");
        });

        modelBuilder.Entity<EmpTrialDatum>(entity =>
        {
            entity.ToTable("emp_trial_data");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CourseName).HasColumnName("Course_name");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Location).HasColumnName("location");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.PersonId);

            entity.Property(e => e.PersonId).ValueGeneratedNever();
            entity.Property(e => e.Cityname).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
        });

        modelBuilder.Entity<EmployeeDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Employee_Table");

            entity.ToTable("Employee_Details");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(500)
                .HasColumnName("employee_name");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .HasColumnName("mobile_no");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<EngWorkAdminPanel>(entity =>
        {
            entity.ToTable("EngWork_AdminPanel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dependency).HasMaxLength(50);
            entity.Property(e => e.FormName).HasMaxLength(50);
            entity.Property(e => e.Isactive).HasColumnName("ISActive");
            entity.Property(e => e.RuleId).HasColumnName("RuleID");
        });

        modelBuilder.Entity<EngWorkAdminPanelHistory>(entity =>
        {
            entity.ToTable("EngWork_AdminPanel_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dependency).HasMaxLength(50);
            entity.Property(e => e.FormName).HasMaxLength(50);
            entity.Property(e => e.Isactive).HasColumnName("ISActive");
            entity.Property(e => e.RuleId).HasColumnName("RuleID");
        });

        modelBuilder.Entity<EngineeringCncNew>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PoNumber, e.Pid });

            entity.ToTable("Engineering_CNC_new");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(50)
                .HasColumnName("PO_Number");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.BarPlateDiameterDimensions)
                .HasMaxLength(50)
                .HasColumnName("Bar_Plate_Diameter_Dimensions");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CompDateMafiaStatusCheck)
                .HasColumnType("datetime")
                .HasColumnName("COMP_Date_Mafia_Status_Check");
            entity.Property(e => e.CorrectionDate)
                .HasColumnType("datetime")
                .HasColumnName("Correction_Date");
            entity.Property(e => e.DrawingAvailableDate)
                .HasColumnType("datetime")
                .HasColumnName("Drawing_Available_Date");
            entity.Property(e => e.DrawingVerifyDate)
                .HasColumnType("datetime")
                .HasColumnName("Drawing_Verify_Date");
            entity.Property(e => e.KpiDrawingVerify)
                .HasMaxLength(50)
                .HasColumnName("KPI_Drawing_Verify");
            entity.Property(e => e.LineNumber).HasColumnName("Line_Number");
            entity.Property(e => e.MadeBy)
                .HasMaxLength(500)
                .HasColumnName("Made_By");
            entity.Property(e => e.MafiaMade)
                .HasMaxLength(10)
                .HasColumnName("Mafia_Made");
            entity.Property(e => e.MafiaMadeDate)
                .HasColumnType("datetime")
                .HasColumnName("Mafia_Made_Date");
            entity.Property(e => e.MafiaReleased)
                .HasMaxLength(10)
                .HasColumnName("Mafia_Released");
            entity.Property(e => e.MafiaRemark).HasColumnName("Mafia_Remark");
            entity.Property(e => e.MafiaUpdateBy)
                .HasMaxLength(500)
                .HasColumnName("mafia_update_by");
            entity.Property(e => e.MaterialPartName)
                .HasMaxLength(100)
                .HasColumnName("Material_Part_Name");
            entity.Property(e => e.MaterialRelatedRemark).HasColumnName("Material_Related_Remark");
            entity.Property(e => e.MaterialSuggestionEmailDate)
                .HasColumnType("datetime")
                .HasColumnName("Material_Suggestion_Email_Date");
            entity.Property(e => e.MaterialSuggestionKpi)
                .HasMaxLength(50)
                .HasColumnName("Material_Suggestion_KPI");
            entity.Property(e => e.MomCompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("Mom_Complete_Date");
            entity.Property(e => e.MomCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("mom_Creation_Date");
            entity.Property(e => e.MomKpi)
                .HasMaxLength(50)
                .HasColumnName("MOM_KPI");
            entity.Property(e => e.NjAvaNota)
                .HasMaxLength(10)
                .HasColumnName("NJ_AVA_NOTA");
            entity.Property(e => e.Op10)
                .HasMaxLength(500)
                .HasColumnName("op10");
            entity.Property(e => e.Op100)
                .HasMaxLength(500)
                .HasColumnName("op100");
            entity.Property(e => e.Op110)
                .HasMaxLength(500)
                .HasColumnName("op110");
            entity.Property(e => e.Op120)
                .HasMaxLength(500)
                .HasColumnName("op120");
            entity.Property(e => e.Op130)
                .HasMaxLength(500)
                .HasColumnName("op130");
            entity.Property(e => e.Op140)
                .HasMaxLength(500)
                .HasColumnName("op140");
            entity.Property(e => e.Op150)
                .HasMaxLength(500)
                .HasColumnName("op150");
            entity.Property(e => e.Op160)
                .HasMaxLength(500)
                .HasColumnName("op160");
            entity.Property(e => e.Op170)
                .HasMaxLength(500)
                .HasColumnName("op170");
            entity.Property(e => e.Op180)
                .HasMaxLength(500)
                .HasColumnName("op180");
            entity.Property(e => e.Op190)
                .HasMaxLength(500)
                .HasColumnName("op190");
            entity.Property(e => e.Op20)
                .HasMaxLength(500)
                .HasColumnName("op20");
            entity.Property(e => e.Op200)
                .HasMaxLength(500)
                .HasColumnName("op200");
            entity.Property(e => e.Op210)
                .HasMaxLength(500)
                .HasColumnName("op210");
            entity.Property(e => e.Op220)
                .HasMaxLength(500)
                .HasColumnName("op220");
            entity.Property(e => e.Op30)
                .HasMaxLength(500)
                .HasColumnName("op30");
            entity.Property(e => e.Op40)
                .HasMaxLength(500)
                .HasColumnName("op40");
            entity.Property(e => e.Op50)
                .HasMaxLength(500)
                .HasColumnName("op50");
            entity.Property(e => e.Op60)
                .HasMaxLength(500)
                .HasColumnName("op60");
            entity.Property(e => e.Op70)
                .HasMaxLength(500)
                .HasColumnName("op70");
            entity.Property(e => e.Op80)
                .HasMaxLength(500)
                .HasColumnName("op80");
            entity.Property(e => e.Op90)
                .HasMaxLength(500)
                .HasColumnName("op90");
            entity.Property(e => e.OpSeqSheetCompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("OP_Seq_Sheet_complete_Date");
            entity.Property(e => e.PartEntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Part_Entry_Date");
            entity.Property(e => e.PartFinalEntry).HasColumnName("part_final_entry");
            entity.Property(e => e.PartMaximumDiaHeight)
                .HasMaxLength(100)
                .HasColumnName("Part_maximum_DIA_HEIGHT");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(25)
                .HasColumnName("Part_Number");
            entity.Property(e => e.Partdate)
                .HasColumnType("datetime")
                .HasColumnName("partdate");
            entity.Property(e => e.PirMafiaStatus)
                .HasMaxLength(50)
                .HasColumnName("PIR_MAFIA_Status");
            entity.Property(e => e.PoDate)
                .HasColumnType("datetime")
                .HasColumnName("PO_Date");
            entity.Property(e => e.PoDrawingRelatedRemarks).HasColumnName("PO_DRAWING_Related_Remarks");
            entity.Property(e => e.PoEntryDate)
                .HasColumnType("datetime")
                .HasColumnName("po_entry_date");
            entity.Property(e => e.PoQty).HasColumnName("PO_Qty");
            entity.Property(e => e.PoReceivedDateEntry)
                .HasColumnType("datetime")
                .HasColumnName("PO_Received_Date_Entry");
            entity.Property(e => e.PreviouslyAvaOrNew)
                .HasMaxLength(50)
                .HasColumnName("Previously_Ava_Or_New");
            entity.Property(e => e.ProcessDetail).HasColumnName("Process_Detail");
            entity.Property(e => e.ProcessRemark).HasColumnName("Process_Remark");
            entity.Property(e => e.PtdDate)
                .HasColumnType("datetime")
                .HasColumnName("PTD_Date");
            entity.Property(e => e.PtdFormRequired)
                .HasMaxLength(10)
                .HasColumnName("PTD_Form_Required");
            entity.Property(e => e.PtdFormStatus)
                .HasMaxLength(50)
                .HasColumnName("PTD_Form_Status");
            entity.Property(e => e.QuantityParent)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Quantity_Parent");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("datetime")
                .HasColumnName("Released_Date");
            entity.Property(e => e.RevisionNumber).HasColumnName("Revision_Number");
            entity.Property(e => e.SnAvaNota)
                .HasMaxLength(10)
                .HasColumnName("SN_AVA_NOTA");
            entity.Property(e => e.SnMadeOutSource)
                .HasMaxLength(50)
                .HasColumnName("SN_Made_out_Source");
            entity.Property(e => e.SpecialToolDetail).HasColumnName("Special_Tool_Detail");
            entity.Property(e => e.SqrmCode)
                .HasMaxLength(50)
                .HasColumnName("SQRM_Code");
            entity.Property(e => e.StageDrawingAvailableDate)
                .HasColumnType("datetime")
                .HasColumnName("Stage_Drawing_Available_Date");
            entity.Property(e => e.StageDrawingRequired)
                .HasMaxLength(10)
                .HasColumnName("Stage_Drawing_Required");
            entity.Property(e => e.SubPart).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(10);
            entity.Property(e => e.ToolCategory)
                .HasMaxLength(50)
                .HasColumnName("Tool_Category");
            entity.Property(e => e.ToolType)
                .HasMaxLength(50)
                .HasColumnName("Tool_type");
            entity.Property(e => e.ToolTypeNew).HasColumnName("Tool_Type_New");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.WrongDrawingInPartLibrary)
                .HasMaxLength(50)
                .HasColumnName("Wrong_Drawing_In_Part_Library");
        });

        modelBuilder.Entity<EngineeringProcess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Engineering_Process_1");

            entity.ToTable("Engineering_Process");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CalculatedDrgAva)
                .HasMaxLength(500)
                .HasColumnName("Calculated_drgAva");
            entity.Property(e => e.CalculatedMomAvaDate)
                .HasMaxLength(500)
                .HasColumnName("Calculated_momAvaDate");
            entity.Property(e => e.CalculatedMomStatus)
                .HasMaxLength(500)
                .HasColumnName("Calculated_momStatus");
            entity.Property(e => e.CalculatedMtl)
                .HasMaxLength(500)
                .HasColumnName("Calculated_mtl");
            entity.Property(e => e.CalculatedOpSeqAva)
                .HasMaxLength(500)
                .HasColumnName("Calculated_opSeqAva");
            entity.Property(e => e.CalculatedOpdAva)
                .HasMaxLength(500)
                .HasColumnName("Calculated_opdAva");
            entity.Property(e => e.PartPartNum)
                .HasMaxLength(500)
                .HasColumnName("Part_PartNum");
            entity.Property(e => e.PartProdCode)
                .HasMaxLength(50)
                .HasColumnName("Part_ProdCode");
            entity.Property(e => e.PartRevAltMethod)
                .HasMaxLength(500)
                .HasColumnName("PartRev_AltMethod");
            entity.Property(e => e.PartRevEffectiveDate)
                .HasMaxLength(500)
                .HasColumnName("PartRev_EffectiveDate");
            entity.Property(e => e.PartRevRevisionNum)
                .HasMaxLength(500)
                .HasColumnName("PartRev_RevisionNum");
            entity.Property(e => e.PartUdCharacter03)
                .HasMaxLength(500)
                .HasColumnName("Part_UD_Character03");
        });

        modelBuilder.Entity<EngineeringProcessMafiaDatum>(entity =>
        {
            entity.ToTable("Engineering_Process_Mafia_data");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MafiaCreated).HasColumnName("mafia_created");
            entity.Property(e => e.MafiaReleased).HasColumnName("mafia_released");
            entity.Property(e => e.MafiaStamp)
                .HasColumnType("datetime")
                .HasColumnName("mafia_stamp");
            entity.Property(e => e.MafiaVerified).HasColumnName("mafia_verified");
            entity.Property(e => e.Partnum).HasMaxLength(500);
            entity.Property(e => e.Rev).HasMaxLength(50);
        });

        modelBuilder.Entity<EngineeringProcessNew>(entity =>
        {
            entity.ToTable("Engineering_Process_New");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DrawingAvailableDate)
                .HasColumnType("datetime")
                .HasColumnName("Drawing_Available_Date");
            entity.Property(e => e.DrgAva).HasColumnName("drgAva");
            entity.Property(e => e.EffectiveDate).HasMaxLength(500);
            entity.Property(e => e.MachiningOperationalDate)
                .HasColumnType("datetime")
                .HasColumnName("Machining_Operational_Date");
            entity.Property(e => e.MafiaCreated).HasColumnName("Mafia_created");
            entity.Property(e => e.MafiaReleased).HasColumnName("mafia_released");
            entity.Property(e => e.MafiaStamp)
                .HasColumnType("datetime")
                .HasColumnName("Mafia_stamp");
            entity.Property(e => e.MafiaVerified).HasColumnName("mafia_verified");
            entity.Property(e => e.MomAvaDate)
                .HasMaxLength(500)
                .HasColumnName("momAvaDate");
            entity.Property(e => e.MomStatus).HasColumnName("momStatus");
            entity.Property(e => e.Mtl).HasColumnName("mtl");
            entity.Property(e => e.OpSeqAva).HasColumnName("opSeqAva");
            entity.Property(e => e.OpdAva).HasColumnName("opdAva");
            entity.Property(e => e.OpdDate)
                .HasMaxLength(50)
                .HasColumnName("OPD_date");
            entity.Property(e => e.ProdCode).HasColumnName("Prod_code");
            entity.Property(e => e.UdCharacter03).HasColumnName("UD_Character03");
        });

        modelBuilder.Entity<EngworkAddNewTool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Engwork_AddNewTool_1");

            entity.ToTable("Engwork_AddNewTool");

            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.PartDescription).HasMaxLength(50);
            entity.Property(e => e.PerCornerQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PerPartQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
            entity.Property(e => e.ToolName).HasMaxLength(50);
            entity.Property(e => e.ToolType).HasMaxLength(50);
            entity.Property(e => e.TotalCorner).HasMaxLength(50);
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<EngworkMafiaHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_MAFIA_History");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.FlAvailable).HasColumnName("FL_Available");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.MafiaCorrectionDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_CorrectionDate");
            entity.Property(e => e.MafiaMade).HasColumnName("MAFIA_Made");
            entity.Property(e => e.MafiaMadeDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_MadeDate");
            entity.Property(e => e.MafiaReleased).HasColumnName("MAFIA_Released");
            entity.Property(e => e.MafiaReleasedDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_ReleasedDate");
            entity.Property(e => e.MafiaRemark)
                .HasMaxLength(50)
                .HasColumnName("MAFIA_Remark");
            entity.Property(e => e.MafiaStatusCheckDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_StatusCheckDate");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SnAvailable).HasColumnName("SN_Available");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkMafium>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_MAFIA");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.FlAvailable).HasColumnName("FL_Available");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.MafiaCorrectionDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_CorrectionDate");
            entity.Property(e => e.MafiaMade).HasColumnName("MAFIA_Made");
            entity.Property(e => e.MafiaMadeDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_MadeDate");
            entity.Property(e => e.MafiaReleased).HasColumnName("MAFIA_Released");
            entity.Property(e => e.MafiaReleasedDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_ReleasedDate");
            entity.Property(e => e.MafiaRemark)
                .HasMaxLength(50)
                .HasColumnName("MAFIA_Remark");
            entity.Property(e => e.MafiaStatusCheckDate)
                .HasColumnType("datetime")
                .HasColumnName("MAFIA_StatusCheckDate");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SnAvailable).HasColumnName("SN_Available");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkMaterialSuggestion>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_MaterialSuggestion");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.Calculator).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.MaterialDescription).HasMaxLength(50);
            entity.Property(e => e.MaterialEmailDate).HasColumnType("datetime");
            entity.Property(e => e.MaterialGrade).HasMaxLength(50);
            entity.Property(e => e.MaterialPartName).HasMaxLength(50);
            entity.Property(e => e.PartDimension).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.QtyPerParent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
            entity.Property(e => e.Uom)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<EngworkMaterialSuggestionDetail>(entity =>
        {
            entity.ToTable("Engwork_MaterialSuggestion_Details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.MaterialAvaQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MaterialDescription).HasMaxLength(50);
            entity.Property(e => e.MaterialPartName).HasMaxLength(50);
            entity.Property(e => e.QtyperParent).HasMaxLength(50);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<EngworkMaterialSuggestionHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_MaterialSuggestion_History");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.Calculator).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.MaterialDescription).HasMaxLength(50);
            entity.Property(e => e.MaterialEmailDate).HasColumnType("datetime");
            entity.Property(e => e.MaterialGrade).HasMaxLength(50);
            entity.Property(e => e.MaterialPartName).HasMaxLength(50);
            entity.Property(e => e.PartDimension).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.QtyPerParent).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
            entity.Property(e => e.Uom)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<EngworkMom>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_MOM");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.MomcompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("MOMCompleteDate");
            entity.Property(e => e.OpseqSheetCompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("OPSeqSheetCompleteDate");
            entity.Property(e => e.OpsequenceFileAttachment).HasColumnName("OPSequenceFileAttachment");
            entity.Property(e => e.ProcessRemark).HasMaxLength(50);
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkMomDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid }).HasName("PK_Engwork_MOM_Details_1");

            entity.ToTable("Engwork_MOM_Details");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.OprationNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EngworkMomHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_MOM_History");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.MomcompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("MOMCompleteDate");
            entity.Property(e => e.OpseqSheetCompleteDate)
                .HasColumnType("datetime")
                .HasColumnName("OPSeqSheetCompleteDate");
            entity.Property(e => e.OpsequenceFileAttachment).HasColumnName("OPSequenceFileAttachment");
            entity.Property(e => e.ProcessRemark).HasMaxLength(50);
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkOpd>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_OPD");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DxfavilableDate)
                .HasColumnType("datetime")
                .HasColumnName("DXFAvilableDate");
            entity.Property(e => e.Dxfremark)
                .HasMaxLength(50)
                .HasColumnName("DXFRemark");
            entity.Property(e => e.Dxfrequired).HasColumnName("DXFRequired");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.OpdcorrectionDate)
                .HasColumnType("datetime")
                .HasColumnName("OPDCorrectionDate");
            entity.Property(e => e.OpdrequestFrom).HasColumnName("OPDRequestFrom");
            entity.Property(e => e.OpdrequirementDescription)
                .HasMaxLength(50)
                .HasColumnName("OPDRequirementDescription");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.StageDrawingAvilableDate).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkOpdHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_OPD_History");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DxfavilableDate)
                .HasColumnType("datetime")
                .HasColumnName("DXFAvilableDate");
            entity.Property(e => e.Dxfremark)
                .HasMaxLength(50)
                .HasColumnName("DXFRemark");
            entity.Property(e => e.Dxfrequired).HasColumnName("DXFRequired");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.IsSubmitedBy).HasColumnName("Is_SubmitedBy");
            entity.Property(e => e.OpdcorrectionDate)
                .HasColumnType("datetime")
                .HasColumnName("OPDCorrectionDate");
            entity.Property(e => e.OpdrequestFrom).HasColumnName("OPDRequestFrom");
            entity.Property(e => e.OpdrequirementDescription)
                .HasMaxLength(50)
                .HasColumnName("OPDRequirementDescription");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.StageDrawingAvilableDate).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkOpsequence>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid });

            entity.ToTable("Engwork_OPSequence");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.Opsequence)
                .HasMaxLength(50)
                .HasColumnName("OPSequence");
            entity.Property(e => e.Process).HasMaxLength(50);
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkPoForecast>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Engwork_PoForecast");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.DrawingAvailableDate).HasColumnType("datetime");
            entity.Property(e => e.DrawingRemarks).HasMaxLength(50);
            entity.Property(e => e.DrawingVerifyDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.MaterialRelatedRemark).HasMaxLength(50);
            entity.Property(e => e.MaterialRemaks).HasMaxLength(50);
            entity.Property(e => e.PartNumber).HasMaxLength(50);
            entity.Property(e => e.PoDate).HasColumnType("datetime");
            entity.Property(e => e.PoDgRelatedRemarks).HasMaxLength(50);
            entity.Property(e => e.PoNumber).HasMaxLength(50);
            entity.Property(e => e.PoQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReferencePart).HasMaxLength(50);
            entity.Property(e => e.RevisionType).HasMaxLength(50);
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SnMadeOutSource)
                .HasMaxLength(50)
                .HasColumnName("SN_MadeOutSource");
            entity.Property(e => e.Sqrmcode)
                .HasMaxLength(50)
                .HasColumnName("SQRMCode");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubPart).HasMaxLength(50);
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EngworkPoForecastHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id1, e.Mid });

            entity.ToTable("Engwork_PoForecast_History");

            entity.Property(e => e.Id1).ValueGeneratedOnAdd();
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.DrawingAvailableDate).HasColumnType("datetime");
            entity.Property(e => e.DrawingRemarks).HasMaxLength(50);
            entity.Property(e => e.DrawingVerifyDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsDeleted1).HasColumnName("Is_deleted1");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSaved1).HasColumnName("Is_Saved1");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.IsSubmited1).HasColumnName("Is_Submited1");
            entity.Property(e => e.MafiaStatus).HasMaxLength(50);
            entity.Property(e => e.MaterialRelatedRemark).HasMaxLength(50);
            entity.Property(e => e.MaterialRemaks).HasMaxLength(50);
            entity.Property(e => e.Opsequence)
                .HasMaxLength(50)
                .HasColumnName("OPSequence");
            entity.Property(e => e.PartNumber).HasMaxLength(50);
            entity.Property(e => e.PoDate).HasColumnType("datetime");
            entity.Property(e => e.PoDgRelatedRemarks).HasMaxLength(50);
            entity.Property(e => e.PoNumber).HasMaxLength(50);
            entity.Property(e => e.PoQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Process).HasMaxLength(50);
            entity.Property(e => e.ReferencePart).HasMaxLength(50);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SaveTimestamp1).HasColumnType("datetime");
            entity.Property(e => e.SnMadeOutSource)
                .HasMaxLength(50)
                .HasColumnName("SN_MadeOutSource");
            entity.Property(e => e.Sqrmcode)
                .HasMaxLength(50)
                .HasColumnName("SQRMCode");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubPart).HasMaxLength(50);
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp1).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EngworkProcessMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_process_master_tbl");

            entity.ToTable("Engwork_ProcessMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abbrevetion).HasColumnName("abbrevetion");
            entity.Property(e => e.Process).HasColumnName("process");
        });

        modelBuilder.Entity<EngworkPtd>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_PTD");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.Ptddate)
                .HasColumnType("datetime")
                .HasColumnName("PTDDate");
            entity.Property(e => e.Ptdform)
                .HasMaxLength(50)
                .HasColumnName("PTDForm");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkPtdHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid });

            entity.ToTable("Engwork_PTD_History");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.PtdRequierd)
                .HasMaxLength(50)
                .HasColumnName("ptd_requierd");
            entity.Property(e => e.Ptddate)
                .HasColumnType("datetime")
                .HasColumnName("PTDDate");
            entity.Property(e => e.Ptdform)
                .HasMaxLength(50)
                .HasColumnName("PTDForm");
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<EngworkSqrmcode>(entity =>
        {
            entity.ToTable("Engwork_SQRMCode");

            entity.Property(e => e.Sqrm)
                .HasMaxLength(50)
                .HasColumnName("SQRM");
        });

        modelBuilder.Entity<EngworkToolingSuggesstionAvaCheck>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid });

            entity.ToTable("Engwork_ToolingSuggesstion_AvaCheck");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.OverrideToolingAvaCheckMark)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SpecialToolRequired)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
            entity.Property(e => e.ToolAvailableinStore)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ToolingOnHandQty)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ToolingPartName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ToolingRemark)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<EngworkToolingSuggestionDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid }).HasName("PK_Engwork_ToolingSuggestion_Details_1");

            entity.ToTable("Engwork_ToolingSuggestion_Details");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.OverrideToolingAvailable).HasColumnName("Override_Tooling_Available");
            entity.Property(e => e.ToolAvaInstore).HasColumnName("Tool_Ava_Instore");
            entity.Property(e => e.ToolOnHandQty)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("Tool_OnHand_Qty");
            entity.Property(e => e.ToolPartName).HasMaxLength(50);
            entity.Property(e => e.ToolRequirementQty)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("Tool_Requirement_Qty");
            entity.Property(e => e.ToolType).HasMaxLength(50);
        });

        modelBuilder.Entity<EngworkToolingSuggestionHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid, e.Mid }).HasName("PK_Engwork_ToolingSuggesstion_AvaCheck_History");

            entity.ToTable("Engwork_ToolingSuggestion_History");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Mid).HasColumnName("MId");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.IsSavedBy).HasColumnName("Is_SavedBy");
            entity.Property(e => e.IsSubmited).HasColumnName("Is_Submited");
            entity.Property(e => e.OverrideToolingAvaCheckMark)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SaveTimestamp).HasColumnType("datetime");
            entity.Property(e => e.SpecialToolRequired)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SubmitTimestamp).HasColumnType("datetime");
            entity.Property(e => e.ToolAvailableinStore)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ToolingOnHandQty)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ToolingPartName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ToolingRemark)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<EpicorJobHead>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Epicor_Job_Head");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("Closed_date");
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.CompletedDate)
                .HasColumnType("datetime")
                .HasColumnName("Completed_date");
            entity.Property(e => e.CreateDate).HasColumnName("Create_date");
            entity.Property(e => e.DrawNum).HasMaxLength(500);
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due_Date");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.JobQty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PartNum).HasMaxLength(500);
            entity.Property(e => e.ProdCode).HasMaxLength(50);
            entity.Property(e => e.Rev).HasMaxLength(50);
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_Date");
            entity.Property(e => e.TotalDays)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Total_Days");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
        });

        modelBuilder.Entity<EpicorJobOpDtl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Epicor_JobOpDtl_1");

            entity.ToTable("Epicor_JobOpDtl");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActBurCost).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ActLabCost).HasColumnType("decimal(16, 3)");
            entity.Property(e => e.ActProdHours).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ActProdRwkHours).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ActSetupHours).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ActSetupRwkHours).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CapabilityId)
                .HasMaxLength(20)
                .HasColumnName("CapabilityID");
            entity.Property(e => e.Company).HasMaxLength(8);
            entity.Property(e => e.ConcurrentCapacity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.DailyProdRate).HasColumnType("decimal(17, 6)");
            entity.Property(e => e.EstProdHours).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.EstSetHours).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.EstSetHoursPerMch).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.JobNum).HasMaxLength(14);
            entity.Property(e => e.OpDtlDesc).HasMaxLength(30);
            entity.Property(e => e.ProdBurRate).HasColumnType("decimal(17, 6)");
            entity.Property(e => e.ProdCrewSize).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ProdLabRate).HasColumnType("decimal(16, 6)");
            entity.Property(e => e.ProdStandard).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.QtyPerCycle).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.ResourceGrpId)
                .HasMaxLength(8)
                .HasColumnName("ResourceGrpID");
            entity.Property(e => e.ResourceId)
                .HasMaxLength(12)
                .HasColumnName("ResourceID");
            entity.Property(e => e.ReworkBurCost).HasColumnType("decimal(16, 3)");
            entity.Property(e => e.ReworkLabCost).HasColumnType("decimal(16, 3)");
            entity.Property(e => e.SetUpCrewSize).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SetupBurRate).HasColumnType("decimal(17, 6)");
            entity.Property(e => e.SetupLabRate).HasColumnType("decimal(16, 6)");
            entity.Property(e => e.SetupOrProd).HasMaxLength(2);
            entity.Property(e => e.StdBasis).HasMaxLength(2);
            entity.Property(e => e.StdFormat).HasMaxLength(2);
            entity.Property(e => e.SysRevId)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SysRevID");
            entity.Property(e => e.SysRowId)
                .HasMaxLength(50)
                .HasColumnName("SysRowID");
        });

        modelBuilder.Entity<EpicorPartLibrary>(entity =>
        {
            entity.ToTable("Epicor_Part_Library");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BinNo).HasMaxLength(50);
            entity.Property(e => e.ClassId)
                .HasMaxLength(50)
                .HasColumnName("ClassID");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .HasColumnName("company");
            entity.Property(e => e.CycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cycle_time");
            entity.Property(e => e.OnHandQtyFl)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OnHandQty_FL");
            entity.Property(e => e.OnHandQtySn)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OnHandQty_SN");
            entity.Property(e => e.PartDescription).HasMaxLength(1000);
            entity.Property(e => e.PartNum).HasMaxLength(200);
            entity.Property(e => e.SearchWord).HasMaxLength(100);
            entity.Property(e => e.SystemName)
                .HasMaxLength(50)
                .HasColumnName("System_Name");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UOM");
            entity.Property(e => e.Warehouse).HasMaxLength(50);
        });

        modelBuilder.Entity<EpicorPartUpdateLog>(entity =>
        {
            entity.ToTable("Epicor_Part_Update_Log");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LastRecordId).HasColumnName("Last_Record_Id");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<EpicorTransactionLog>(entity =>
        {
            entity.ToTable("Epicor_Transaction_Log");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.BinNum).HasMaxLength(50);
            entity.Property(e => e.ClassId)
                .HasMaxLength(50)
                .HasColumnName("ClassID");
            entity.Property(e => e.Company).HasMaxLength(10);
            entity.Property(e => e.EntryPerson).HasMaxLength(100);
            entity.Property(e => e.InvoiceNum).HasMaxLength(50);
            entity.Property(e => e.LotNum).HasMaxLength(30);
            entity.Property(e => e.PackSlip).HasMaxLength(20);
            entity.Property(e => e.PartNum).HasMaxLength(200);
            entity.Property(e => e.TransNum).HasMaxLength(100);
            entity.Property(e => e.TransQty).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TransType).HasMaxLength(50);
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("UOM");
            entity.Property(e => e.WareHouse).HasMaxLength(100);
        });

        modelBuilder.Entity<EpoApproval>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Epo });

            entity.ToTable("EPO_Approval");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Epo).HasColumnName("epo");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .HasColumnName("active");
            entity.Property(e => e.EmployeeApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Employee_approval_Date");
            entity.Property(e => e.EmployeeLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Employee_Limit");
            entity.Property(e => e.HigherAuthority).HasColumnName("Higher_authority");
            entity.Property(e => e.ManagerApproval)
                .HasMaxLength(10)
                .HasColumnName("Manager_approval");
            entity.Property(e => e.ManagerApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Manager_approval_date");
            entity.Property(e => e.ManagerLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Manager_Limit");
            entity.Property(e => e.Mpc).HasColumnName("MPC");
            entity.Property(e => e.MpcApproval)
                .HasMaxLength(10)
                .HasColumnName("MPC_approval");
            entity.Property(e => e.MpcApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC_Approval_date");
            entity.Property(e => e.MpcHigherApproval)
                .HasMaxLength(10)
                .HasColumnName("MPC_Higher_approval");
            entity.Property(e => e.MpcHigherApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC_Higher_approval_date");
            entity.Property(e => e.MpcLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MPC_Limit");
            entity.Property(e => e.SelfApproval)
                .HasMaxLength(10)
                .HasColumnName("Self_approval");
        });

        modelBuilder.Entity<EpoCreation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Eid, e.Pid, e.Gid, e.Lid, e.Epoid });

            entity.ToTable("EPO_Creation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Gid).HasColumnName("GID");
            entity.Property(e => e.Lid).HasColumnName("LID");
            entity.Property(e => e.Epoid)
                .HasMaxLength(50)
                .HasColumnName("EPOID");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .HasColumnName("account_no");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.AttachedByEmployee).HasColumnName("attached_by_employee");
            entity.Property(e => e.AttachmentDate)
                .HasColumnType("datetime")
                .HasColumnName("attachment_date");
            entity.Property(e => e.AttachmentFileName).HasColumnName("attachment_file_name");
            entity.Property(e => e.Cgst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cgst");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.CostOfUnitPriceAndQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cost_of_unit_price_and_qty");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(500)
                .HasColumnName("created_by");
            entity.Property(e => e.CurrencyType)
                .HasMaxLength(50)
                .HasColumnName("currency_type");
            entity.Property(e => e.DateOfPaymentCheckRequestOrCashAdvance)
                .HasColumnType("datetime")
                .HasColumnName("date_of_payment_check_request_or_cash_advance");
            entity.Property(e => e.DaysOfPaymentPayWhenBilled)
                .HasMaxLength(100)
                .HasColumnName("days_of_payment_pay_when_billed");
            entity.Property(e => e.Department)
                .HasMaxLength(500)
                .HasColumnName("department");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");
            entity.Property(e => e.EmployeeName).HasColumnName("employee_name");
            entity.Property(e => e.EmployeeVendor)
                .HasMaxLength(50)
                .HasColumnName("employee_vendor");
            entity.Property(e => e.EpoPurchaseStatus)
                .HasMaxLength(500)
                .HasColumnName("epo_purchase_status");
            entity.Property(e => e.EpoType)
                .HasMaxLength(100)
                .HasColumnName("epo_type");
            entity.Property(e => e.ExtendedCost)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("extended_cost");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("grand_total");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("gst");
            entity.Property(e => e.GstNo)
                .HasMaxLength(100)
                .HasColumnName("gst_no");
            entity.Property(e => e.GujaratOrOutside)
                .HasMaxLength(50)
                .HasColumnName("gujarat_or_outside");
            entity.Property(e => e.Igst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("igst");
            entity.Property(e => e.InternalNotes).HasColumnName("internal_notes");
            entity.Property(e => e.ManagerApproval)
                .HasMaxLength(50)
                .HasColumnName("Manager_approval");
            entity.Property(e => e.ManagerApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Manager_approval_date");
            entity.Property(e => e.MpcApproval)
                .HasMaxLength(50)
                .HasColumnName("MPC_approval");
            entity.Property(e => e.MpcApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC_Approval_date");
            entity.Property(e => e.MpcHigherApproval)
                .HasMaxLength(50)
                .HasColumnName("MPC_Higher_approval");
            entity.Property(e => e.MpcHigherApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC_Higher_approval_date");
            entity.Property(e => e.PaymentGivenBy)
                .HasMaxLength(500)
                .HasColumnName("payment_given_by");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(500)
                .HasColumnName("payment_type");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.ProductDescription).HasColumnName("product_description");
            entity.Property(e => e.ProductGroup).HasColumnName("product_group");
            entity.Property(e => e.PurchaseNotes).HasColumnName("purchase_notes");
            entity.Property(e => e.PurchaseType)
                .HasMaxLength(500)
                .HasColumnName("purchase_type");
            entity.Property(e => e.Purposeofpurchase).HasColumnName("purposeofpurchase");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.QtyStatus)
                .HasMaxLength(500)
                .HasColumnName("qty_status");
            entity.Property(e => e.ReceiptMethod)
                .HasMaxLength(500)
                .HasColumnName("receipt_method");
            entity.Property(e => e.RevisedDate)
                .HasColumnType("datetime")
                .HasColumnName("revised_date");
            entity.Property(e => e.SelfApproval)
                .HasMaxLength(50)
                .HasColumnName("Self_approval");
            entity.Property(e => e.SelfDate)
                .HasColumnType("datetime")
                .HasColumnName("Self_Date");
            entity.Property(e => e.Sgst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sgst");
            entity.Property(e => e.ShippingCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("shipping_charges");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Street1).HasColumnName("street1");
            entity.Property(e => e.Street2).HasColumnName("street2");
            entity.Property(e => e.Street3).HasColumnName("street3");
            entity.Property(e => e.SubTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sub_total");
            entity.Property(e => e.Tax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tax");
            entity.Property(e => e.TaxDiscountGst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tax_discount_gst");
            entity.Property(e => e.TaxWithDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tax_with_discount");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unit_price");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.UomOther)
                .HasMaxLength(50)
                .HasColumnName("uom_other");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vendor).HasColumnName("vendor");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("vendorID");
            entity.Property(e => e.WithinGujarat)
                .HasMaxLength(10)
                .HasColumnName("within_gujarat");
            entity.Property(e => e.WithoutAttachment)
                .HasMaxLength(10)
                .HasColumnName("Without_Attachment");
            entity.Property(e => e.Zip)
                .HasMaxLength(100)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<EpoEmployeeDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid });

            entity.ToTable("EPO_Employee_details");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_ID");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(500)
                .HasColumnName("employee_name");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .HasColumnName("mobile_no");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<EpoItemReceive>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EpoNo, e.LineNo, e.Pid });

            entity.ToTable("EPO_ITEM_Receive");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EpoNo).HasColumnName("EPO_NO");
            entity.Property(e => e.LineNo).HasColumnName("line_no");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ChallanNo).HasColumnName("challan_no");
            entity.Property(e => e.InvoiceNo).HasColumnName("invoice_no");
            entity.Property(e => e.OrderQty).HasColumnName("Order_qty");
            entity.Property(e => e.ReceivedBy).HasColumnName("received_by");
            entity.Property(e => e.ReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("received_date");
            entity.Property(e => e.ReceivedQty).HasColumnName("received_qty");
            entity.Property(e => e.RemainingQty).HasColumnName("remaining_qty");
            entity.Property(e => e.TransactionQty).HasColumnName("transaction_qty");
        });

        modelBuilder.Entity<EpoMpcVote>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Epo });

            entity.ToTable("EPO_MPC_VOTE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Epo).HasColumnName("EPO");
            entity.Property(e => e.Countvote).HasColumnName("countvote");
            entity.Property(e => e.HigherAuthorityVote)
                .HasMaxLength(50)
                .HasColumnName("Higher_authority_vote");
            entity.Property(e => e.HigherAuthorityVoteDate)
                .HasColumnType("datetime")
                .HasColumnName("Higher_authority_vote_date");
            entity.Property(e => e.Mpc1Vote)
                .HasMaxLength(10)
                .HasColumnName("MPC1_vote");
            entity.Property(e => e.Mpc1VoteDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC1_vote_date");
            entity.Property(e => e.Mpc2Vote)
                .HasMaxLength(10)
                .HasColumnName("MPC2_vote");
            entity.Property(e => e.Mpc2VoteDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC2_vote_date");
            entity.Property(e => e.Mpc3Vote)
                .HasMaxLength(10)
                .HasColumnName("MPC3_vote");
            entity.Property(e => e.Mpc3VoteDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC3_vote_date");
            entity.Property(e => e.Mpc4Vote)
                .HasMaxLength(10)
                .HasColumnName("MPC4_vote");
            entity.Property(e => e.Mpc4VoteDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC4_vote_date");
            entity.Property(e => e.Mpc5Vote)
                .HasMaxLength(10)
                .HasColumnName("MPC5_vote");
            entity.Property(e => e.Mpc5VoteDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC5_vote_date");
            entity.Property(e => e.Mpc6Vote)
                .HasMaxLength(10)
                .HasColumnName("MPC6_vote");
            entity.Property(e => e.Mpc6VoteDate)
                .HasColumnType("datetime")
                .HasColumnName("MPC6_vote_date");
            entity.Property(e => e.NeedHigherAuthority)
                .HasMaxLength(50)
                .HasColumnName("need_Higher_Authority");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<EpoRefTable>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.RefId });

            entity.ToTable("EPO_Ref_Table");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.RefId).HasColumnName("Ref_ID");
            entity.Property(e => e.RefSubType)
                .HasMaxLength(100)
                .HasColumnName("Ref_sub_type");
            entity.Property(e => e.RefType)
                .HasMaxLength(100)
                .HasColumnName("Ref_Type");
            entity.Property(e => e.Refname).HasColumnName("refname");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_Event");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("EventID");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.Endd).HasColumnType("datetime");
            entity.Property(e => e.Start).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(100);
            entity.Property(e => e.ThemeColor).HasMaxLength(10);
        });

        modelBuilder.Entity<EventLoggerDatum>(entity =>
        {
            entity.ToTable("Event_Logger_Data");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CounterTotalizerReading)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Counter_Totalizer_Reading");
            entity.Property(e => e.CuttingTimeHrs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cutting_Time_Hrs");
            entity.Property(e => e.CycletimeMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cycletime_min");
            entity.Property(e => e.Dept).HasMaxLength(50);
            entity.Property(e => e.EndOfProductEnterTimeWithAmPm)
                .HasMaxLength(50)
                .HasColumnName("End_of_Product_enter_time_with_AM_PM");
            entity.Property(e => e.EntryType)
                .HasMaxLength(50)
                .HasColumnName("Entry_type");
            entity.Property(e => e.EventDate).HasColumnName("Event_Date");
            entity.Property(e => e.FootageCounterReading)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Footage_Counter_Reading");
            entity.Property(e => e.HourMeterReading)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Hour_Meter_Reading");
            entity.Property(e => e.IfDownAllDayReason).HasColumnName("If_down_all_day_reason");
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.MachineNo).HasMaxLength(50);
            entity.Property(e => e.MachineType)
                .HasMaxLength(50)
                .HasColumnName("Machine_type");
            entity.Property(e => e.OpNo).HasMaxLength(50);
            entity.Property(e => e.Operator).HasMaxLength(50);
            entity.Property(e => e.OtherRemark).HasColumnName("other_remark");
            entity.Property(e => e.PartNumAtTimeOfReading)
                .HasMaxLength(500)
                .HasColumnName("PartNum_at_time_of_reading");
            entity.Property(e => e.PowerOnHours)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Power_On_Hours");
            entity.Property(e => e.PreviousPowerOnHours)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Previous_Power_On_Hours");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.RuntimeHrs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Runtime_Hrs");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.SupervisorId)
                .HasMaxLength(50)
                .HasColumnName("Supervisor_ID");
            entity.Property(e => e.Uploadby)
                .HasMaxLength(50)
                .HasColumnName("uploadby");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
        });

        modelBuilder.Entity<EventLoggerSupervisorDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Event_Logger_Supervisor_data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Dept).HasMaxLength(50);
            entity.Property(e => e.EventDate).HasColumnName("event_Date");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineType)
                .HasMaxLength(50)
                .HasColumnName("Machine_Type");
            entity.Property(e => e.OperatorId).HasMaxLength(50);
            entity.Property(e => e.OperatorType).HasMaxLength(50);
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .HasColumnName("shift");
            entity.Property(e => e.SupervisorId)
                .HasMaxLength(50)
                .HasColumnName("SupervisorID");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
            entity.Property(e => e.Uploadby)
                .HasMaxLength(50)
                .HasColumnName("uploadby");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
        });

        modelBuilder.Entity<EventManagementMsm>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EventId });

            entity.ToTable("Event_Management_MSM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EventId)
                .HasMaxLength(200)
                .HasColumnName("event_ID");
            entity.Property(e => e.ApproxFeetOnReel).HasColumnName("Approx_feet_on_reel");
            entity.Property(e => e.ApproximateFeet).HasColumnName("Approximate_Feet");
            entity.Property(e => e.BrakeTensionTightenOrLoosen).HasColumnName("Brake_tension_Tighten_or_loosen");
            entity.Property(e => e.CapstanRpm).HasColumnName("Capstan_RPM");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DeflLol).HasColumnName("Defl_LOL");
            entity.Property(e => e.DeflTol).HasColumnName("Defl_Tol");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EventName).HasColumnName("Event_Name");
            entity.Property(e => e.FeetPerOrder).HasColumnName("feet_per_order");
            entity.Property(e => e.FootageCounterReading).HasColumnName("footage_counter_reading");
            entity.Property(e => e.Fpm).HasColumnName("FPM");
            entity.Property(e => e.Head1Rpm).HasColumnName("Head_1_RPM");
            entity.Property(e => e.Head2Rpm).HasColumnName("Head_2_RPM");
            entity.Property(e => e.Head3Rpm).HasColumnName("Head_3_RPM");
            entity.Property(e => e.Head4Rpm).HasColumnName("Head_4_RPM");
            entity.Property(e => e.Head5Rpm).HasColumnName("Head_5_RPM");
            entity.Property(e => e.HeadNumber).HasColumnName("Head_number");
            entity.Property(e => e.HeatTemp).HasColumnName("Heat_temp");
            entity.Property(e => e.HourMeterReading).HasColumnName("hour_meter_reading");
            entity.Property(e => e.LayerFrom).HasColumnName("Layer_from");
            entity.Property(e => e.LayerTo).HasColumnName("Layer_to");
            entity.Property(e => e.Msm).HasColumnName("MSM");
            entity.Property(e => e.NewRpm).HasColumnName("New_RPM");
            entity.Property(e => e.OrderNo).HasColumnName("order_no");
            entity.Property(e => e.PulleyTeeth).HasColumnName("Pulley_Teeth");
            entity.Property(e => e.ReelGrossWeightKg).HasColumnName("Reel_Gross_weight_KG");
            entity.Property(e => e.ReelTareWeightKg).HasColumnName("Reel_Tare_weight_KG");
            entity.Property(e => e.RemarkReasonDetails).HasColumnName("Remark_Reason_details");
            entity.Property(e => e.ShaftNameOrNewShaftName).HasColumnName("shaft_name_or_new_shaft_name");
            entity.Property(e => e.ShaftOd).HasColumnName("shaft_OD");
            entity.Property(e => e.Shift).HasColumnName("shift");
            entity.Property(e => e.SpoolFromWindingHead).HasColumnName("Spool_from_Winding_head");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Ttr).HasColumnName("TTR");
            entity.Property(e => e.UtlLol).HasColumnName("UTL_LOL");
            entity.Property(e => e.UtsTol).HasColumnName("UTS_TOL");
        });

        modelBuilder.Entity<EventManagementMsmDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EventId });

            entity.ToTable("Event_Management_MSM_Details");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EventId)
                .HasMaxLength(200)
                .HasColumnName("Event_ID");
            entity.Property(e => e.ApproxFeetOnReel)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Approx_feet_on_reel");
            entity.Property(e => e.ApproximateFeet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Approximate_Feet");
            entity.Property(e => e.BrakeTensionTightenOrLoosen).HasColumnName("Brake_tension_Tighten_or_loosen");
            entity.Property(e => e.CapstanRpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Capstan_RPM");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DeflLol)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Defl_LOL");
            entity.Property(e => e.DeflTol)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Defl_Tol");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("Event_name");
            entity.Property(e => e.FeetPerOrder)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("feet_per_order");
            entity.Property(e => e.FootageCounterReading)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("footage_counter_reading");
            entity.Property(e => e.Fpm).HasColumnName("FPM");
            entity.Property(e => e.Head1Rpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Head_1_RPM");
            entity.Property(e => e.Head2Rpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Head_2_RPM");
            entity.Property(e => e.Head3Rpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Head_3_RPM");
            entity.Property(e => e.Head4Rpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Head_4_RPM");
            entity.Property(e => e.Head5Rpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Head_5_RPM");
            entity.Property(e => e.HeadNumber)
                .HasMaxLength(50)
                .HasColumnName("Head_number");
            entity.Property(e => e.HeatTemp)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Heat_temp");
            entity.Property(e => e.HourMeterReading)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("hour_meter_reading");
            entity.Property(e => e.LayerFrom).HasColumnName("Layer_from");
            entity.Property(e => e.LayerTo).HasColumnName("Layer_to");
            entity.Property(e => e.Msm).HasColumnName("MSM");
            entity.Property(e => e.NewRpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("New_RPM");
            entity.Property(e => e.OrderNo).HasColumnName("order_no");
            entity.Property(e => e.PulleyTeeth).HasColumnName("Pulley_Teeth");
            entity.Property(e => e.ReelGrossWeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Reel_Gross_weight_KG");
            entity.Property(e => e.ReelTareWeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Reel_Tare_weight_KG");
            entity.Property(e => e.RemarkReasonDetails).HasColumnName("Remark_Reason_details");
            entity.Property(e => e.ShaftNameOrNewShaftName).HasColumnName("shaft_name_or_new_shaft_name");
            entity.Property(e => e.ShaftOd)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("shaft_od");
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .HasColumnName("shift");
            entity.Property(e => e.SpoolFromWindingHead).HasColumnName("Spool_from_Winding_head");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Ttr).HasColumnName("TTR");
            entity.Property(e => e.UploadBy).HasColumnName("Upload_by");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
            entity.Property(e => e.UtlLol)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("UTL_LOL");
            entity.Property(e => e.UtsTol)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("UTS_TOL");
        });

        modelBuilder.Entity<EventManagementMultiname>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EventId });

            entity.ToTable("Event_Management_Multiname");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventId)
                .HasMaxLength(400)
                .HasColumnName("EventID");
            entity.Property(e => e.EmployeeId).HasMaxLength(50);
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
        });

        modelBuilder.Entity<EventManagementReportDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Event_Management_Report_Details");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.EndTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("End_Time");
            entity.Property(e => e.EventId)
                .HasMaxLength(50)
                .HasColumnName("EventID");
            entity.Property(e => e.EventReportType)
                .HasMaxLength(100)
                .HasColumnName("Event_Report_Type");
            entity.Property(e => e.Eventdate)
                .HasColumnType("datetime")
                .HasColumnName("eventdate");
            entity.Property(e => e.Fpm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("FPM");
            entity.Property(e => e.HeatCoilNumberOfTurn)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Heat_Coil_Number_Of_Turn");
            entity.Property(e => e.HourMeterReading)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Hour_Meter_Reading");
            entity.Property(e => e.InputPower)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Input_Power");
            entity.Property(e => e.JobNoReelNo)
                .HasMaxLength(100)
                .HasColumnName("JobNo_ReelNo");
            entity.Property(e => e.MachineNo).HasMaxLength(50);
            entity.Property(e => e.Operator).HasMaxLength(500);
            entity.Property(e => e.ProductionFeet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Production_Feet");
            entity.Property(e => e.Shaft).HasMaxLength(50);
            entity.Property(e => e.ShaftDia)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Shaft_Dia");
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .HasColumnName("shift");
            entity.Property(e => e.StartTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Start_Time");
            entity.Property(e => e.Temprature).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<EventManagementWithTextboxValue>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EventGeneratedId });

            entity.ToTable("event_management_with_textbox_values");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EventGeneratedId)
                .HasMaxLength(100)
                .HasColumnName("Event_Generated_Id");
            entity.Property(e => e.EventId).HasColumnName("Event_id");
            entity.Property(e => e.EventLabel).HasColumnName("Event_Label");
            entity.Property(e => e.EventName).HasColumnName("Event_Name");
        });

        modelBuilder.Entity<EventNameMaster>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid });

            entity.ToTable("Event_Name_Master");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EventId)
                .HasMaxLength(50)
                .HasColumnName("event_ID");
            entity.Property(e => e.EventName).HasColumnName("Event_Name");
            entity.Property(e => e.RefName).HasColumnName("Ref_Name");
        });

        modelBuilder.Entity<EventSecondaryMsm>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EventId });

            entity.ToTable("Event_Secondary_MSM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EventId)
                .HasMaxLength(100)
                .HasColumnName("Event_ID");
            entity.Property(e => e.EventDate)
                .HasColumnType("datetime")
                .HasColumnName("Event_date");
            entity.Property(e => e.EventName).HasColumnName("Event_Name");
            entity.Property(e => e.EventTextboxid).HasColumnName("Event_Textboxid");
            entity.Property(e => e.EventTransferFor).HasColumnName("Event_Transfer_for");
        });

        modelBuilder.Entity<ExperianceDetail>(entity =>
        {
            entity.HasKey(e => e.ExperianceId);

            entity.ToTable("experiance_details");

            entity.Property(e => e.ExperianceId).HasColumnName("experiance_id");
            entity.Property(e => e.Addressofcompany)
                .IsUnicode(false)
                .HasColumnName("addressofcompany");
            entity.Property(e => e.Date1).HasColumnName("date1");
            entity.Property(e => e.Date2).HasColumnName("date2");
            entity.Property(e => e.Designation)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Monthlysalary)
                .IsUnicode(false)
                .HasColumnName("monthlysalary");
            entity.Property(e => e.Nameofcompany)
                .IsUnicode(false)
                .HasColumnName("nameofcompany");
        });

        modelBuilder.Entity<FamilyDetail>(entity =>
        {
            entity.HasKey(e => e.FamilyId);

            entity.ToTable("family_details");

            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nameoforganization)
                .IsUnicode(false)
                .HasColumnName("nameoforganization");
            entity.Property(e => e.Presentoccupation)
                .IsUnicode(false)
                .HasColumnName("presentoccupation");
            entity.Property(e => e.Relation)
                .IsUnicode(false)
                .HasColumnName("relation");
        });

        modelBuilder.Entity<FeedbackQueryTable>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Feedback_Query_Table");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .HasColumnName("active");
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("PersonID");
            entity.Property(e => e.QueryApplicationName).HasColumnName("Query_Application_Name");
            entity.Property(e => e.QueryComplitionDate)
                .HasColumnType("datetime")
                .HasColumnName("query_complition_date");
            entity.Property(e => e.QueryGenerateDate)
                .HasColumnType("datetime")
                .HasColumnName("Query_generate_date");
            entity.Property(e => e.QueryReason).HasColumnName("Query_Reason");
            entity.Property(e => e.QueryTitle).HasColumnName("Query_Title");
            entity.Property(e => e.RemarkOnCompletion).HasColumnName("remark_on_completion");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
        });

        modelBuilder.Entity<FinalInspectionDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.InspectionId }).HasName("PK_Final_");

            entity.ToTable("Final_Inspection_Data");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(200)
                .HasColumnName("Inspection_ID");
            entity.Property(e => e.AcceptQty).HasColumnName("Accept_Qty");
            entity.Property(e => e.ActRev).HasMaxLength(50);
            entity.Property(e => e.CloseRequstDate).HasColumnType("datetime");
            entity.Property(e => e.Closerequest).HasColumnName("closerequest");
            entity.Property(e => e.Completeandwaiting).HasColumnName("completeandwaiting");
            entity.Property(e => e.Completedandwaiting).HasColumnName("completedandwaiting");
            entity.Property(e => e.CurrentDate).HasColumnType("datetime");
            entity.Property(e => e.CuurntCard).HasMaxLength(50);
            entity.Property(e => e.DeviationQty).HasColumnName("Deviation_Qty");
            entity.Property(e => e.Deviationpersentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Deviationwaitingtime).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.EpiRev).HasMaxLength(50);
            entity.Property(e => e.InDaviationTime).HasColumnType("datetime");
            entity.Property(e => e.InReworkDate).HasColumnType("datetime");
            entity.Property(e => e.InSortingDate).HasColumnType("datetime");
            entity.Property(e => e.Indeviation).HasColumnName("indeviation");
            entity.Property(e => e.Inrework).HasColumnName("inrework");
            entity.Property(e => e.InspectionQty).HasColumnName("Inspection_Qty");
            entity.Property(e => e.InspectionType)
                .HasMaxLength(500)
                .HasColumnName("Inspection_Type");
            entity.Property(e => e.InspectiontimeManpowerspendtime).HasMaxLength(500);
            entity.Property(e => e.InspectiontimeQualitydivisionspendtimebypart).HasMaxLength(500);
            entity.Property(e => e.InwardDate)
                .HasColumnType("datetime")
                .HasColumnName("Inward_Date");
            entity.Property(e => e.InwardTime)
                .HasMaxLength(50)
                .HasColumnName("Inward_Time");
            entity.Property(e => e.IsSubmiteed).HasColumnName("Is_Submiteed");
            entity.Property(e => e.JobNum).HasMaxLength(200);
            entity.Property(e => e.Lotreject)
                .HasMaxLength(100)
                .HasColumnName("lotreject");
            entity.Property(e => e.Mes)
                .HasMaxLength(50)
                .HasColumnName("MES");
            entity.Property(e => e.Movedfromquality).HasColumnName("movedfromquality");
            entity.Property(e => e.MrbCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Mrb_Create_date");
            entity.Property(e => e.Mrbdate)
                .HasColumnType("datetime")
                .HasColumnName("MRBDate");
            entity.Property(e => e.Mrbtakentime)
                .HasMaxLength(500)
                .HasColumnName("MRBTakentime");
            entity.Property(e => e.PartNum).HasMaxLength(200);
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Readyforpacking).HasColumnName("readyforpacking");
            entity.Property(e => e.RejectQty).HasColumnName("Reject_Qty");
            entity.Property(e => e.Rejectpersentage)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("rejectpersentage");
            entity.Property(e => e.ReworkQty).HasColumnName("Rework_Qty");
            entity.Property(e => e.Reworkpersentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Reworktime).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.SampleQty)
                .HasMaxLength(50)
                .HasColumnName("Sample_Qty");
            entity.Property(e => e.SortingQty).HasColumnName("Sorting_Qty");
            entity.Property(e => e.Sortingtime).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Split).HasColumnName("split");
            entity.Property(e => e.Stage).HasMaxLength(500);
            entity.Property(e => e.Threadcompleted).HasColumnName("threadcompleted");
            entity.Property(e => e.TotalTimeinquality).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalinspectiontimeManpowerspendtime).HasMaxLength(500);
            entity.Property(e => e.Totalinspectiontimequalitydivisionspendtimebypart).HasMaxLength(500);
            entity.Property(e => e.Unitprice).HasColumnName("unitprice");
            entity.Property(e => e.Visualcompleted).HasColumnName("visualcompleted");
            entity.Property(e => e.Waitingforfinal).HasColumnName("waitingforfinal");
            entity.Property(e => e.Waitingforhumidity).HasColumnName("waitingforhumidity");
            entity.Property(e => e.Waitingformrb).HasColumnName("waitingformrb");
            entity.Property(e => e.Waitingforrework).HasColumnName("waitingforrework");
            entity.Property(e => e.Waitingforsorting).HasColumnName("waitingforsorting");
            entity.Property(e => e.Waitingforthread).HasColumnName("waitingforthread");
            entity.Property(e => e.Waitingforvisual).HasColumnName("waitingforvisual");
        });

        modelBuilder.Entity<FinalInspectionDocumentDatum>(entity =>
        {
            entity.ToTable("Final_Inspection_Document_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Mid).HasColumnName("MID");
        });

        modelBuilder.Entity<FinalInspectionDocumentVarification>(entity =>
        {
            entity.ToTable("Final_Inspection_Document_Varification");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.Iid).HasColumnName("IID");
        });

        modelBuilder.Entity<FinalInspectionLogTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Final_LogTable");

            entity.ToTable("Final_Inspection_LogTable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(500);
            entity.Property(e => e.PageName).HasMaxLength(500);
        });

        modelBuilder.Entity<FinalInspectionMrbDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Final_In__3214EC2791ADF9A0");

            entity.ToTable("Final_Inspection_Mrb_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JobNo).HasMaxLength(100);
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.PartNo).HasMaxLength(100);
            entity.Property(e => e.Stage).IsUnicode(false);
        });

        modelBuilder.Entity<FinalInspectionMrbDecisionDatum>(entity =>
        {
            entity.ToTable("Final_Inspection_MRB_DecisionData");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Iid).HasColumnName("IID");
            entity.Property(e => e.Mrbdecision)
                .HasMaxLength(50)
                .HasColumnName("MRBDecision");
            entity.Property(e => e.OkQty).HasMaxLength(50);
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.RejectQty).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(50);
        });

        modelBuilder.Entity<FinalInspectionMrbRcode>(entity =>
        {
            entity.ToTable("Final_Inspection_Mrb_Rcode");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Desicion).HasMaxLength(100);
            entity.Property(e => e.DesicionSubQty)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Mrbsubqty).HasColumnName("mrbsubqty");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Rcode).HasMaxLength(100);
        });

        modelBuilder.Entity<FinalInspectionProcess>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.InspectionId }).HasName("PK_Final_Inspection_Process_1");

            entity.ToTable("Final_Inspection_Process");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(50)
                .HasColumnName("Inspection_ID");
            entity.Property(e => e.CkMrb).HasColumnName("CkMRB");
            entity.Property(e => e.DoneBy)
                .HasMaxLength(50)
                .HasColumnName("done_by");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("endtime");
            entity.Property(e => e.InspectionDate)
                .HasColumnType("datetime")
                .HasColumnName("Inspection_date");
            entity.Property(e => e.InspectionQty).HasColumnName("Inspection_Qty");
            entity.Property(e => e.InspectionType)
                .HasMaxLength(50)
                .HasColumnName("Inspection_Type");
            entity.Property(e => e.JobNum).HasMaxLength(200);
            entity.Property(e => e.PartNum).HasMaxLength(200);
            entity.Property(e => e.Process).HasMaxLength(50);
            entity.Property(e => e.Qualitystage).HasMaxLength(500);
            entity.Property(e => e.ReworkId).HasColumnName("Rework_Id");
            entity.Property(e => e.Sampleqty)
                .HasMaxLength(500)
                .HasColumnName("sampleqty");
            entity.Property(e => e.Stage).IsUnicode(false);
            entity.Property(e => e.Starttime)
                .HasMaxLength(50)
                .HasColumnName("starttime");
        });

        modelBuilder.Entity<FinalInspectionProcessRework>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.InspectionId });

            entity.ToTable("Final_Inspection_Process_Rework");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(50)
                .HasColumnName("Inspection_ID");
            entity.Property(e => e.DecisionOfMrb)
                .HasMaxLength(500)
                .HasColumnName("decision_of_MRB");
            entity.Property(e => e.DecisionType).HasMaxLength(50);
            entity.Property(e => e.DoneBy)
                .HasMaxLength(50)
                .HasColumnName("done_by");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("endtime");
            entity.Property(e => e.InspectionDate)
                .HasColumnType("datetime")
                .HasColumnName("Inspection_date");
            entity.Property(e => e.InspectionType)
                .HasMaxLength(50)
                .HasColumnName("Inspection_Type");
            entity.Property(e => e.JobNum).HasMaxLength(200);
            entity.Property(e => e.MrbComment)
                .HasMaxLength(500)
                .HasColumnName("MRB_Comment");
            entity.Property(e => e.MrbDate)
                .HasColumnType("datetime")
                .HasColumnName("MRB_Date");
            entity.Property(e => e.PartNum).HasMaxLength(200);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("received_date");
            entity.Property(e => e.RejectQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("reject_qty");
            entity.Property(e => e.Reworkstatuschange).HasColumnName("reworkstatuschange");
            entity.Property(e => e.SentDate)
                .HasColumnType("datetime")
                .HasColumnName("sent_date");
        });

        modelBuilder.Entity<FinalInspectionRcode>(entity =>
        {
            entity.ToTable("Final_Inspection_RCode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Rcode)
                .HasMaxLength(50)
                .HasColumnName("RCode");
        });

        modelBuilder.Entity<FinalInspectionRework>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.InsId, e.ReworkId });

            entity.ToTable("Final_Inspection_Rework");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsId)
                .HasMaxLength(200)
                .HasColumnName("InsID");
            entity.Property(e => e.ReworkId)
                .HasMaxLength(200)
                .HasColumnName("reworkID");
            entity.Property(e => e.JobNum).HasMaxLength(500);
            entity.Property(e => e.PartNum).HasMaxLength(500);
            entity.Property(e => e.ReworkCompleteQty).HasColumnName("Rework_complete_Qty");
            entity.Property(e => e.ReworkQty).HasColumnName("Rework_Qty");
        });

        modelBuilder.Entity<FinalInspectionStageDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.InspectionId }).HasName("PK_Final_stage_data");

            entity.ToTable("Final_Inspection_Stage_Data");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(200)
                .HasColumnName("Inspection_ID");
            entity.Property(e => e.CurrentDateTime).HasMaxLength(50);
            entity.Property(e => e.InspectionType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JobNum).HasMaxLength(200);
            entity.Property(e => e.PartNum).HasMaxLength(200);
            entity.Property(e => e.Qty).HasMaxLength(500);
            entity.Property(e => e.Stage).HasMaxLength(500);
            entity.Property(e => e.Stageno).HasColumnName("stageno");
        });

        modelBuilder.Entity<FinalInspectionStageMaster>(entity =>
        {
            entity.ToTable("Final_Inspection_Stage_Master");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.StagePartStatus).HasColumnName("stage_part_status");
        });

        modelBuilder.Entity<FinalInspectionUserList>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.UserId });

            entity.ToTable("Final_Inspection_UserList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<FormulaHistoryTbl>(entity =>
        {
            entity.ToTable("formula_history_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveBy).HasColumnName("active_by");
            entity.Property(e => e.ActiveTime).HasColumnName("active_time");
            entity.Property(e => e.DeactiveBy).HasColumnName("deactive_by");
            entity.Property(e => e.DeactiveTime).HasColumnName("deactive_time");
            entity.Property(e => e.FormulaId).HasColumnName("formula_id");
        });

        modelBuilder.Entity<FormulaMasterTbl>(entity =>
        {
            entity.ToTable("formula_master_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.FormatedFormula).HasColumnName("formated_formula");
            entity.Property(e => e.Formula).HasColumnName("formula");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
        });

        modelBuilder.Entity<FpaColorGradeHistory>(entity =>
        {
            entity.ToTable("FPA_Color _Grade_History");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ColorCode1)
                .HasMaxLength(50)
                .HasColumnName("color_code_1");
            entity.Property(e => e.ColorCode2)
                .HasMaxLength(50)
                .HasColumnName("color_code_2");
            entity.Property(e => e.ColourNameMaterialGrade1)
                .HasMaxLength(50)
                .HasColumnName("Colour_name_Material_Grade_1");
            entity.Property(e => e.ColourNameMaterialGrade2)
                .HasMaxLength(50)
                .HasColumnName("Colour_name_Material_Grade_2");
            entity.Property(e => e.ColourPartno)
                .HasMaxLength(50)
                .HasColumnName("colour_partno");
        });

        modelBuilder.Entity<FpaForm>(entity =>
        {
            entity.ToTable("FPA_Form");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DrawingRevision).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.InformationVerifiedByQi)
                .HasMaxLength(50)
                .HasColumnName("InformationVerifiedByQI");
            entity.Property(e => e.InspectorName).HasMaxLength(50);
            entity.Property(e => e.IsDelete).HasColumnName("IS_Delete");
            entity.Property(e => e.IsSaved).HasColumnName("is_saved");
            entity.Property(e => e.IssuedMaterialColorCode)
                .HasMaxLength(50)
                .HasColumnName("Issued_material_color_code");
            entity.Property(e => e.IssuedMaterialDescription).HasMaxLength(50);
            entity.Property(e => e.IssuedMaterialPartLot).HasMaxLength(50);
            entity.Property(e => e.IsueMaterialPartno)
                .HasMaxLength(50)
                .HasColumnName("isue_material_partno");
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.LineId).HasColumnName("line_id");
            entity.Property(e => e.MachineNo).HasMaxLength(50);
            entity.Property(e => e.MaterialColorCode).HasMaxLength(50);
            entity.Property(e => e.MaterialDrawingRequired).HasMaxLength(50);
            entity.Property(e => e.Mm).HasColumnName("mm");
            entity.Property(e => e.Operation).HasMaxLength(50);
            entity.Property(e => e.PartNo).HasMaxLength(50);
            entity.Property(e => e.PartSqrncode)
                .HasMaxLength(50)
                .HasColumnName("PartSQRNCode");
            entity.Property(e => e.Partweight)
                .HasMaxLength(50)
                .HasColumnName("partweight");
            entity.Property(e => e.ProgSign)
                .HasMaxLength(50)
                .HasColumnName("prog_sign");
            entity.Property(e => e.ProgrammerName).HasMaxLength(50);
            entity.Property(e => e.QiStampSign)
                .HasMaxLength(50)
                .HasColumnName("qi_stamp_sign");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.SupervisorName).HasMaxLength(50);
            entity.Property(e => e.SupervisorSign)
                .HasMaxLength(50)
                .HasColumnName("Supervisor_sign");
        });

        modelBuilder.Entity<FpaFormHistory>(entity =>
        {
            entity.ToTable("FPA_Form_history");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.DimensionTotal).HasColumnName("Dimension_Total");
            entity.Property(e => e.Dimentionby).HasMaxLength(50);
            entity.Property(e => e.FpaFormId).HasColumnName("FPA_Form_ID");
            entity.Property(e => e.InstrumentId).HasColumnName("Instrument_ID");
            entity.Property(e => e.IsDelete).HasColumnName("is_delete");
            entity.Property(e => e.Jobno).HasColumnName("jobno");
            entity.Property(e => e.LineFpaId).HasColumnName("line_fpa_id");
            entity.Property(e => e.ResultsByInspector).HasColumnName("Results_by_inspector");
            entity.Property(e => e.ResultsByProgrammer).HasColumnName("Results_by_programmer");
        });

        modelBuilder.Entity<FpaGdntSymbol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_fpa_gdnt");

            entity.ToTable("FPA_GDNT_SYMBOL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.GdntSymbolAndName)
                .HasMaxLength(50)
                .HasColumnName("gdnt_symbol_and_name");
            entity.Property(e => e.GdntSymbolName)
                .HasMaxLength(50)
                .HasColumnName("gdnt_symbol_name");
            entity.Property(e => e.GdnySymbol)
                .HasMaxLength(50)
                .HasColumnName("gdny_symbol");
        });

        modelBuilder.Entity<FpaView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FPA_VIEW");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.DimensionTotal).HasColumnName("Dimension_Total");
            entity.Property(e => e.DrawingRevision).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InformationVerifiedByQi)
                .HasMaxLength(50)
                .HasColumnName("InformationVerifiedByQI");
            entity.Property(e => e.InspectorName).HasMaxLength(50);
            entity.Property(e => e.InstrumentId).HasColumnName("Instrument_ID");
            entity.Property(e => e.IsDelete).HasColumnName("IS_Delete");
            entity.Property(e => e.IsSaved).HasColumnName("is_saved");
            entity.Property(e => e.IssuedMaterialColorCode)
                .HasMaxLength(50)
                .HasColumnName("Issued_material_color_code");
            entity.Property(e => e.IssuedMaterialDescription).HasMaxLength(50);
            entity.Property(e => e.IssuedMaterialPartLot).HasMaxLength(50);
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.LineId).HasColumnName("line_id");
            entity.Property(e => e.MachineNo).HasMaxLength(50);
            entity.Property(e => e.MaterialColorCode).HasMaxLength(50);
            entity.Property(e => e.MaterialDrawingRequired).HasMaxLength(50);
            entity.Property(e => e.Mm).HasColumnName("mm");
            entity.Property(e => e.Operation).HasMaxLength(50);
            entity.Property(e => e.PartNo).HasMaxLength(50);
            entity.Property(e => e.PartSqrncode)
                .HasMaxLength(50)
                .HasColumnName("PartSQRNCode");
            entity.Property(e => e.ProgSign)
                .HasMaxLength(50)
                .HasColumnName("prog_sign");
            entity.Property(e => e.ProgrammerName).HasMaxLength(50);
            entity.Property(e => e.QiStampSign)
                .HasMaxLength(50)
                .HasColumnName("qi_stamp_sign");
            entity.Property(e => e.ResultsByInspector).HasColumnName("Results_by_inspector");
            entity.Property(e => e.ResultsByProgrammer).HasColumnName("Results_by_programmer");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.SupervisorName).HasMaxLength(50);
            entity.Property(e => e.SupervisorSign)
                .HasMaxLength(50)
                .HasColumnName("Supervisor_sign");
        });

        modelBuilder.Entity<FunctionMst>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.MenuId }).HasName("PK_ACM_FUNCTION_MST_1");

            entity.ToTable("FUNCTION_MST");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.MenuId).HasColumnName("MENU_ID");
            entity.Property(e => e.ActiveFlag).HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.Activemenu).HasColumnName("ACTIVEMENU");
            entity.Property(e => e.Activetilldate).HasColumnName("ACTIVETILLDATE");
            entity.Property(e => e.Addflage).HasColumnName("ADDFLAGE");
            entity.Property(e => e.Amiglobale).HasColumnName("AMIGLOBALE");
            entity.Property(e => e.Commanline)
                .HasMaxLength(50)
                .HasColumnName("COMMANLINE");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.Delflage).HasColumnName("DELFLAGE");
            entity.Property(e => e.DocParent)
                .HasMaxLength(50)
                .HasColumnName("DOC_PARENT");
            entity.Property(e => e.Editflage).HasColumnName("EDITFLAGE");
            entity.Property(e => e.Footerinvisibledata).HasColumnName("FOOTERINVISIBLEDATA");
            entity.Property(e => e.Footervisibledata).HasColumnName("FOOTERVISIBLEDATA");
            entity.Property(e => e.Headerinvisibledata).HasColumnName("HEADERINVISIBLEDATA");
            entity.Property(e => e.Headervisibledata).HasColumnName("HEADERVISIBLEDATA");
            entity.Property(e => e.Iconpath)
                .HasMaxLength(500)
                .HasColumnName("ICONPATH");
            entity.Property(e => e.Lableflag).HasColumnName("LABLEFLAG");
            entity.Property(e => e.Link)
                .HasMaxLength(500)
                .HasColumnName("LINK");
            entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");
            entity.Property(e => e.MenuLocation)
                .HasMaxLength(50)
                .HasColumnName("MENU_LOCATION");
            entity.Property(e => e.MenuName1)
                .HasMaxLength(100)
                .HasColumnName("MENU_NAME1");
            entity.Property(e => e.MenuName2)
                .HasMaxLength(100)
                .HasColumnName("MENU_NAME2");
            entity.Property(e => e.MenuName3)
                .HasMaxLength(500)
                .HasColumnName("MENU_NAME3");
            entity.Property(e => e.MenuOrder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MENU_ORDER");
            entity.Property(e => e.MenuType)
                .HasMaxLength(100)
                .HasColumnName("MENU_TYPE");
            entity.Property(e => e.Menudate).HasColumnName("MENUDATE");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(150)
                .HasColumnName("METADESCRIPTION");
            entity.Property(e => e.Metakeyword)
                .HasMaxLength(50)
                .HasColumnName("METAKEYWORD");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(50)
                .HasColumnName("METATITLE");
            entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");
            entity.Property(e => e.Mybusid)
                .HasComment("This is come from MYBUS Table")
                .HasColumnName("MYBUSID");
            entity.Property(e => e.Mypersonal).HasColumnName("MYPERSONAL");
            entity.Property(e => e.Printflage).HasColumnName("PRINTFLAGE");
            entity.Property(e => e.Refid)
                .HasComment("This is come from REF Table where retype or sub == domain")
                .HasColumnName("REFID");
            entity.Property(e => e.Smalltext)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMALLTEXT");
            entity.Property(e => e.Sp1)
                .HasDefaultValue(0)
                .HasColumnName("SP1");
            entity.Property(e => e.Sp1name)
                .HasMaxLength(150)
                .HasColumnName("SP1Name");
            entity.Property(e => e.Sp2)
                .HasDefaultValue(0)
                .HasColumnName("SP2");
            entity.Property(e => e.Sp2name)
                .HasMaxLength(150)
                .HasColumnName("SP2Name");
            entity.Property(e => e.Sp3)
                .HasDefaultValue(0)
                .HasColumnName("SP3");
            entity.Property(e => e.Sp3name)
                .HasMaxLength(150)
                .HasColumnName("SP3Name");
            entity.Property(e => e.Sp4)
                .HasDefaultValue(0)
                .HasColumnName("SP4");
            entity.Property(e => e.Sp4name)
                .HasMaxLength(150)
                .HasColumnName("SP4Name");
            entity.Property(e => e.Sp5)
                .HasDefaultValue(0)
                .HasColumnName("SP5");
            entity.Property(e => e.Sp5name)
                .HasMaxLength(150)
                .HasColumnName("SP5Name");
            entity.Property(e => e.Urloption).HasMaxLength(100);
            entity.Property(e => e.Urlrewrite)
                .HasMaxLength(500)
                .HasColumnName("URLREWRITE");
        });

        modelBuilder.Entity<Gatepass>(entity =>
        {
            entity.HasKey(e => new { e.Gpno, e.Id, e.Gid });

            entity.ToTable("gatepass");

            entity.Property(e => e.Gpno)
                .HasMaxLength(50)
                .HasColumnName("GPNo");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.ApproxRecevingPartQty).HasColumnName("Approx_Receving_Part_Qty");
            entity.Property(e => e.Approxsswpartqty)
                .HasMaxLength(500)
                .HasColumnName("approxsswpartqty");
            entity.Property(e => e.Authorisedperson)
                .HasMaxLength(50)
                .HasColumnName("authorisedperson");
            entity.Property(e => e.Authorizedperson).HasColumnName("authorizedperson");
            entity.Property(e => e.Cancelleddate)
                .HasColumnType("datetime")
                .HasColumnName("cancelleddate");
            entity.Property(e => e.Copytype)
                .HasMaxLength(50)
                .HasColumnName("copytype");
            entity.Property(e => e.Copytypeconfirm).HasColumnName("copytypeconfirm");
            entity.Property(e => e.Deliverydate)
                .HasColumnType("datetime")
                .HasColumnName("deliverydate");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Descriptionofgoods).HasColumnName("descriptionofgoods");
            entity.Property(e => e.ForceCloseReason).HasColumnName("force_close_reason");
            entity.Property(e => e.Gatedate)
                .HasColumnType("datetime")
                .HasColumnName("gatedate");
            entity.Property(e => e.Gatepasstye)
                .HasMaxLength(50)
                .HasColumnName("gatepasstye");
            entity.Property(e => e.Historyallow)
                .HasMaxLength(50)
                .HasColumnName("historyallow");
            entity.Property(e => e.Hsn).HasColumnName("HSN");
            entity.Property(e => e.Jobnum)
                .HasMaxLength(50)
                .HasColumnName("jobnum");
            entity.Property(e => e.MaterialGrade)
                .HasMaxLength(500)
                .HasColumnName("material_grade");
            entity.Property(e => e.MaterialShape)
                .HasMaxLength(500)
                .HasColumnName("material_shape");
            entity.Property(e => e.PackagingType).HasColumnName("Packaging_Type");
            entity.Property(e => e.PackingQty).HasColumnName("Packing_Qty");
            entity.Property(e => e.PartialEntry)
                .HasMaxLength(50)
                .HasColumnName("Partial_Entry");
            entity.Property(e => e.PendingQty).HasColumnName("pending_qty");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("price");
            entity.Property(e => e.ProcessesTypes).HasColumnName("Processes_Types");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Reasonfordeletegatepass).HasColumnName("reasonfordeletegatepass");
            entity.Property(e => e.ReceivedQty).HasColumnName("receivedQty");
            entity.Property(e => e.Receivedpartweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("receivedpartweight");
            entity.Property(e => e.Receivedsswpartqty).HasColumnName("receivedsswpartqty");
            entity.Property(e => e.Receiverperson)
                .HasMaxLength(500)
                .HasColumnName("receiverperson");
            entity.Property(e => e.Receiverremark).HasColumnName("receiverremark");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Returneddate)
                .HasColumnType("datetime")
                .HasColumnName("returneddate");
            entity.Property(e => e.Returnst).HasColumnName("returnst");
            entity.Property(e => e.Sswpart)
                .HasMaxLength(500)
                .HasColumnName("sswpart");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Supplieraddress).HasColumnName("supplieraddress");
            entity.Property(e => e.Supplieremail)
                .HasMaxLength(50)
                .HasColumnName("supplieremail");
            entity.Property(e => e.Suppliergst)
                .HasMaxLength(100)
                .HasColumnName("suppliergst");
            entity.Property(e => e.Suppliername).HasColumnName("suppliername");
            entity.Property(e => e.Supplierphone)
                .HasMaxLength(50)
                .HasColumnName("supplierphone");
            entity.Property(e => e.Totalmaterialcost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalmaterialcost");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Weight)
                .HasMaxLength(50)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<GatepassApprovalList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Departmentss");

            entity.ToTable("Gatepass_Approval_List");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ColorCode).HasMaxLength(50);
            entity.Property(e => e.Departmentname).HasColumnName("departmentname");
            entity.Property(e => e.DepartmentsupervisorDeputyManager).HasColumnName("departmentsupervisor_deputy_manager");
            entity.Property(e => e.DepartmentsupervisorManager).HasColumnName("departmentsupervisor_manager");
            entity.Property(e => e.Departmentsupervisorname).HasColumnName("departmentsupervisorname");
            entity.Property(e => e.Mid).HasColumnName("mid");
            entity.Property(e => e.PersonId)
                .HasMaxLength(10)
                .HasColumnName("personID");
        });

        modelBuilder.Entity<GatepassJobwork>(entity =>
        {
            entity.HasKey(e => new { e.Gpno, e.Id, e.Gid, e.Pid });

            entity.ToTable("gatepass_jobwork");

            entity.Property(e => e.Gpno)
                .HasMaxLength(50)
                .HasColumnName("GPNo");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.ApproxRecevingPartQty).HasColumnName("Approx_Receving_Part_Qty");
            entity.Property(e => e.Approxsswpartqty)
                .HasMaxLength(500)
                .HasColumnName("approxsswpartqty");
            entity.Property(e => e.Authorizedperson)
                .HasMaxLength(50)
                .HasColumnName("authorizedperson");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Gatedate)
                .HasColumnType("datetime")
                .HasColumnName("gatedate");
            entity.Property(e => e.Gatepasstype)
                .HasMaxLength(50)
                .HasColumnName("gatepasstype");
            entity.Property(e => e.Hsn).HasColumnName("HSN");
            entity.Property(e => e.Jobnum)
                .HasMaxLength(50)
                .HasColumnName("jobnum");
            entity.Property(e => e.MaterialGrade)
                .HasMaxLength(500)
                .HasColumnName("material_grade");
            entity.Property(e => e.MaterialName).HasColumnName("material_name");
            entity.Property(e => e.MaterialShape)
                .HasMaxLength(500)
                .HasColumnName("material_shape");
            entity.Property(e => e.PackagingType).HasColumnName("Packaging_Type");
            entity.Property(e => e.PartialCreated).HasColumnName("Partial_created");
            entity.Property(e => e.ProcessesTypes).HasColumnName("Processes_Types");
            entity.Property(e => e.RawMaterialQty).HasColumnName("Raw_material_qty");
            entity.Property(e => e.Sswpart)
                .HasMaxLength(500)
                .HasColumnName("sswpart");
            entity.Property(e => e.Supplieraddress).HasColumnName("supplieraddress");
            entity.Property(e => e.Supplieremail).HasColumnName("supplieremail");
            entity.Property(e => e.Suppliergst).HasColumnName("suppliergst");
            entity.Property(e => e.Suppliername).HasColumnName("suppliername");
            entity.Property(e => e.Supplierphone)
                .HasMaxLength(50)
                .HasColumnName("supplierphone");
            entity.Property(e => e.Totalmaterialcost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalmaterialcost");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Weight)
                .HasMaxLength(50)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<GatepassMaterialDetail>(entity =>
        {
            entity.ToTable("gatepass_material_details");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MaterialGrade)
                .HasMaxLength(500)
                .HasColumnName("material_grade");
            entity.Property(e => e.MaterialName)
                .HasMaxLength(500)
                .HasColumnName("material_name");
            entity.Property(e => e.MaterialShape)
                .HasMaxLength(500)
                .HasColumnName("material_shape");
        });

        modelBuilder.Entity<GatepassReturnablenew>(entity =>
        {
            entity.HasKey(e => new { e.Gpno, e.Id, e.Gid, e.Pid });

            entity.ToTable("gatepass_returnablenew");

            entity.Property(e => e.Gpno)
                .HasMaxLength(50)
                .HasColumnName("GPNo");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Gatedate)
                .HasColumnType("datetime")
                .HasColumnName("gatedate");
            entity.Property(e => e.ItemName).HasColumnName("item_name");
            entity.Property(e => e.ItemQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("item_qty");
            entity.Property(e => e.MailSend).HasColumnName("mail_Send");
            entity.Property(e => e.ReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("received_date");
            entity.Property(e => e.ReceivedPerson).HasColumnName("received_person");
            entity.Property(e => e.ReceivedQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("received_qty");
            entity.Property(e => e.RemainingQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("remaining_qty");
            entity.Property(e => e.TransactionQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("transaction_qty");
        });

        modelBuilder.Entity<Gatepasspreviousdaydetail>(entity =>
        {
            entity.HasKey(e => new { e.Pid, e.Gpno });

            entity.ToTable("gatepasspreviousdaydetail");

            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Gpno)
                .HasMaxLength(50)
                .HasColumnName("gpno");
            entity.Property(e => e.Authorizedperson)
                .HasMaxLength(500)
                .HasColumnName("authorizedperson");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(500)
                .HasColumnName("supplierName");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<HibcApprentixTable>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("HIBC_Apprentix_Table");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ApprentixName)
                .HasMaxLength(50)
                .HasColumnName("Apprentix_Name");
            entity.Property(e => e.ApprentixValue).HasColumnName("Apprentix_VAlue");
        });

        modelBuilder.Entity<HibcCodeGenerator>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.UdiId });

            entity.ToTable("HIBC_Code_Generator");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.UdiId).HasColumnName("UDI_ID");
            entity.Property(e => e.BarcodeImagename)
                .HasMaxLength(500)
                .HasColumnName("barcode_imagename");
            entity.Property(e => e.BrandName).HasColumnName("Brand_Name");
            entity.Property(e => e.ConcentrateBarcode1)
                .HasMaxLength(500)
                .HasColumnName("Concentrate_Barcode1");
            entity.Property(e => e.ConcentrateBarcode2)
                .HasMaxLength(500)
                .HasColumnName("Concentrate_Barcode2");
            entity.Property(e => e.ConcentrateCheckCharacter1)
                .HasMaxLength(10)
                .HasColumnName("Concentrate_Check_Character1");
            entity.Property(e => e.ConcentrateCheckCharacter2)
                .HasMaxLength(10)
                .HasColumnName("Concentrate_Check_Character_2");
            entity.Property(e => e.ConcentratedCheckCharacter)
                .HasMaxLength(10)
                .HasColumnName("Concentrated_Check_Character");
            entity.Property(e => e.DataMatrixImagename)
                .HasMaxLength(500)
                .HasColumnName("data_matrix_imagename");
            entity.Property(e => e.DeviceDescription).HasColumnName("Device_Description");
            entity.Property(e => e.ExpirationDate).HasColumnName("Expiration_Date");
            entity.Property(e => e.ExpirationDateFormate)
                .HasMaxLength(50)
                .HasColumnName("Expiration_Date_Formate");
            entity.Property(e => e.ExpirationDateHour)
                .HasMaxLength(10)
                .HasColumnName("Expiration_Date_hour");
            entity.Property(e => e.IncQty).HasColumnName("Inc_Qty");
            entity.Property(e => e.LabelerCode)
                .HasMaxLength(50)
                .HasColumnName("Labeler_Code");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .HasColumnName("Lot_Number");
            entity.Property(e => e.ManufacturingDate).HasColumnName("Manufacturing_Date");
            entity.Property(e => e.PrimaryBarcodeData)
                .HasMaxLength(500)
                .HasColumnName("Primary_Barcode_Data");
            entity.Property(e => e.PrimaryCheckCharacter)
                .HasMaxLength(50)
                .HasColumnName("Primary_Check_Character");
            entity.Property(e => e.ProductCatalogueNumber)
                .HasMaxLength(50)
                .HasColumnName("Product_Catalogue_Number");
            entity.Property(e => e.QrcodeImagenameNew)
                .HasMaxLength(500)
                .HasColumnName("qrcode_imagename_new");
            entity.Property(e => e.SecondaryBarcodeData)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Secondary_Barcode_Data");
            entity.Property(e => e.SecondaryBarcodeData1)
                .HasMaxLength(500)
                .HasColumnName("Secondary_Barcode_Data1");
            entity.Property(e => e.SecondaryBarcodeData2)
                .HasMaxLength(500)
                .HasColumnName("Secondary_Barcode_Data2");
            entity.Property(e => e.SecondaryCheckCharacter)
                .HasMaxLength(50)
                .HasColumnName("Secondary_Check_Character");
            entity.Property(e => e.TextUnderPrimaryBarCode)
                .HasMaxLength(500)
                .HasColumnName("Text_Under_Primary_Bar_Code");
            entity.Property(e => e.TextUnderSecondaryBarCode)
                .HasMaxLength(500)
                .HasColumnName("Text_Under_Secondary_Bar_Code");
            entity.Property(e => e.Uom).HasColumnName("UOM");
            entity.Property(e => e.UpnUdiDeviceId)
                .HasMaxLength(500)
                .HasColumnName("UPN_UDI_Device_ID");
            entity.Property(e => e.UpnUdiDeviceIdentifier)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UPN_UDI_Device_Identifier");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.VersionOrModel).HasColumnName("Version_or_Model");
        });

        modelBuilder.Entity<HibcPrimaryBarcodeTemp>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.UdiId });

            entity.ToTable("HIBC_Primary_Barcode_Temp");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.UdiId).HasColumnName("UDI_ID");
            entity.Property(e => e.CharacetrValue)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Characetr_value");
            entity.Property(e => e.CharacterName)
                .HasMaxLength(50)
                .HasColumnName("Character_Name");
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(50)
                .HasColumnName("primary_secondary");
            entity.Property(e => e.Reminder).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<HibcTempStorage>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.Licid });

            entity.ToTable("HIBC_Temp_Storage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Licid)
                .HasMaxLength(50)
                .HasColumnName("LICID");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_Date");
            entity.Property(e => e.Lic)
                .HasMaxLength(500)
                .HasColumnName("LIC");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(500)
                .HasColumnName("Lot_number");
            entity.Property(e => e.ManufacturingDate)
                .HasColumnType("datetime")
                .HasColumnName("Manufacturing_Date");
            entity.Property(e => e.ProductName)
                .HasMaxLength(500)
                .HasColumnName("Product_Name");
            entity.Property(e => e.Qty).HasMaxLength(50);
            entity.Property(e => e.Uom).HasColumnName("UOM");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.ToTable("holiday");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .HasColumnName("active");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .HasColumnName("day");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Hourcounting>(entity =>
        {
            entity.HasKey(e => e.Gpno);

            entity.ToTable("hourcounting");

            entity.Property(e => e.Gpno)
                .HasMaxLength(50)
                .HasColumnName("gpno");
            entity.Property(e => e.Hourcount)
                .HasMaxLength(50)
                .HasColumnName("hourcount");
            entity.Property(e => e.Suppliername).HasColumnName("suppliername");
        });

        modelBuilder.Entity<Icrdtemp>(entity =>
        {
            entity.ToTable("icrdtemp");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Add1).HasMaxLength(500);
            entity.Property(e => e.Add2).HasMaxLength(500);
            entity.Property(e => e.BackRequired).HasColumnName("back_required");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .HasColumnName("bloodgroup");
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasMaxLength(50)
                .HasColumnName("DOJ");
            entity.Property(e => e.Image)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("image");
            entity.Property(e => e.ImageNew)
                .HasMaxLength(500)
                .HasColumnName("image_new");
            entity.Property(e => e.NameNew)
                .HasMaxLength(500)
                .HasColumnName("name_new");
            entity.Property(e => e.Signature)
                .HasMaxLength(50)
                .HasColumnName("signature");
        });

        modelBuilder.Entity<InitiatorName>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Rid });

            entity.ToTable("InitiatorName");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.InitiatorName1).HasColumnName("initiator_name");
        });

        modelBuilder.Entity<IntervierwExperienceReference>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Intervierw_Experience_Reference");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .HasColumnName("contact_no");
            entity.Property(e => e.Designation)
                .HasMaxLength(500)
                .HasColumnName("designation");
            entity.Property(e => e.FromDate).HasColumnName("from_date");
            entity.Property(e => e.MainSubject)
                .HasMaxLength(200)
                .HasColumnName("Main_Subject");
            entity.Property(e => e.MonthlySalary)
                .HasMaxLength(500)
                .HasColumnName("monthly_salary");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.PersonalId).HasColumnName("Personal_Id");
            entity.Property(e => e.ToDate).HasColumnName("to_date");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<InterviewAnswerVerify>(entity =>
        {
            entity.HasKey(e => new { e.Iid, e.Mid });

            entity.ToTable("Interview_Answer_verify");

            entity.Property(e => e.Iid).HasColumnName("IID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ActualAnswer)
                .HasMaxLength(50)
                .HasColumnName("actual_answer");
            entity.Property(e => e.AnswerTicked)
                .HasMaxLength(50)
                .HasColumnName("answer_ticked");
            entity.Property(e => e.PersonalId).HasColumnName("Personal_ID");
            entity.Property(e => e.Type).HasMaxLength(500);
        });

        modelBuilder.Entity<InterviewEducationDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Interview_Education_details");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.AcademicYear).HasColumnName("Academic_Year");
            entity.Property(e => e.CourseName)
                .HasMaxLength(500)
                .HasColumnName("Course_name");
            entity.Property(e => e.MainSubject)
                .HasMaxLength(500)
                .HasColumnName("Main_subject");
            entity.Property(e => e.Percentage)
                .HasMaxLength(50)
                .HasColumnName("percentage");
            entity.Property(e => e.PersonalId).HasColumnName("personal_Id");
            entity.Property(e => e.SchoolCollegeName)
                .HasMaxLength(500)
                .HasColumnName("school_College_name");
        });

        modelBuilder.Entity<InterviewFamilyBackground>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Interview_family_background");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.NameOfOrganization)
                .HasMaxLength(500)
                .HasColumnName("name_of_organization");
            entity.Property(e => e.PersonalId).HasColumnName("Personal_Id");
            entity.Property(e => e.PresentLastOccupation)
                .HasMaxLength(500)
                .HasColumnName("present_last_occupation");
            entity.Property(e => e.Relation).HasMaxLength(50);
            entity.Property(e => e.RelationName)
                .HasMaxLength(500)
                .HasColumnName("Relation_name");
        });

        modelBuilder.Entity<InterviewFormPersonalDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Interview_form_personal_details");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Age)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("age");
            entity.Property(e => e.BasicQuestionScore).HasColumnName("Basic_Question_Score");
            entity.Property(e => e.CurrentAddcity)
                .HasMaxLength(50)
                .HasColumnName("current_addcity");
            entity.Property(e => e.CurrentAdddist)
                .HasMaxLength(50)
                .HasColumnName("current_adddist");
            entity.Property(e => e.CurrentAddline1)
                .HasMaxLength(500)
                .HasColumnName("current_addline1");
            entity.Property(e => e.CurrentAddline2)
                .HasMaxLength(500)
                .HasColumnName("current_addline2");
            entity.Property(e => e.CurrentAddmobile)
                .HasMaxLength(50)
                .HasColumnName("current_addmobile");
            entity.Property(e => e.CurrentAddtaluka)
                .HasMaxLength(50)
                .HasColumnName("current_addtaluka");
            entity.Property(e => e.Disability).HasColumnName("disability");
            entity.Property(e => e.DisabilityName)
                .HasMaxLength(500)
                .HasColumnName("disability_name");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.FatherHusbandName)
                .HasMaxLength(200)
                .HasColumnName("Father_Husband_name");
            entity.Property(e => e.GrammarScore).HasColumnName("Grammar_Score");
            entity.Property(e => e.IdentityProof)
                .HasMaxLength(50)
                .HasColumnName("Identity_proof");
            entity.Property(e => e.IdentityProofName)
                .HasMaxLength(500)
                .HasColumnName("Identity_proof_name");
            entity.Property(e => e.InterviewPdf)
                .HasMaxLength(500)
                .HasColumnName("Interview_pdf");
            entity.Property(e => e.LogicalScore).HasColumnName("Logical_Score");
            entity.Property(e => e.MaritualStatus)
                .HasMaxLength(50)
                .HasColumnName("maritual_status");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NoOfChildren).HasColumnName("no_of_children");
            entity.Property(e => e.PerAddcity)
                .HasMaxLength(50)
                .HasColumnName("per_addcity");
            entity.Property(e => e.PerAdddist)
                .HasMaxLength(50)
                .HasColumnName("per_adddist");
            entity.Property(e => e.PerAddemail)
                .HasMaxLength(100)
                .HasColumnName("per_addemail");
            entity.Property(e => e.PerAddline1)
                .HasMaxLength(500)
                .HasColumnName("per_addline1");
            entity.Property(e => e.PerAddline2)
                .HasMaxLength(500)
                .HasColumnName("per_addline2");
            entity.Property(e => e.PerAddmobile)
                .HasMaxLength(50)
                .HasColumnName("per_addmobile");
            entity.Property(e => e.PerAddtaluka)
                .HasMaxLength(50)
                .HasColumnName("per_addtaluka");
            entity.Property(e => e.PersonImg)
                .HasMaxLength(500)
                .HasColumnName("Person_Img");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.RelativeName)
                .HasMaxLength(500)
                .HasColumnName("relative_name");
            entity.Property(e => e.RelativeRelation)
                .HasMaxLength(500)
                .HasColumnName("relative_relation");
            entity.Property(e => e.RelativesAtSswhite).HasColumnName("relatives_at_sswhite");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .HasColumnName("sex");
            entity.Property(e => e.Surname).HasMaxLength(200);
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
        });

        modelBuilder.Entity<InterviewQuestion>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Interview_Questions");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Answer)
                .HasMaxLength(500)
                .HasColumnName("answer");
            entity.Property(e => e.Haslogicimage).HasColumnName("haslogicimage");
            entity.Property(e => e.LogicQuestionImage)
                .HasMaxLength(500)
                .HasColumnName("logic_question_Image");
            entity.Property(e => e.OptionBasic1)
                .HasMaxLength(500)
                .HasColumnName("Option_Basic_1");
            entity.Property(e => e.OptionBasic2)
                .HasMaxLength(500)
                .HasColumnName("Option_Basic_2");
            entity.Property(e => e.OptionBasic3)
                .HasMaxLength(500)
                .HasColumnName("Option_Basic_3");
            entity.Property(e => e.OptionBasic4)
                .HasMaxLength(500)
                .HasColumnName("Option_Basic_4");
            entity.Property(e => e.OptionLogic1)
                .HasMaxLength(500)
                .HasColumnName("Option_logic_1");
            entity.Property(e => e.OptionLogic2)
                .HasMaxLength(500)
                .HasColumnName("Option_logic_2");
            entity.Property(e => e.OptionLogic3)
                .HasMaxLength(500)
                .HasColumnName("Option_logic_3");
            entity.Property(e => e.OptionLogic4)
                .HasMaxLength(500)
                .HasColumnName("Option_logic_4");
            entity.Property(e => e.QuestionForBasicEnglish).HasColumnName("Question_for_basic_English");
            entity.Property(e => e.QuestionForBasicGrammer).HasColumnName("Question_for_basic_grammer");
            entity.Property(e => e.QuestionForLogic).HasColumnName("Question_For_logic");
            entity.Property(e => e.QuestionType)
                .HasMaxLength(500)
                .HasColumnName("Question_Type");
        });

        modelBuilder.Entity<InvoiceEntryMasterTbl>(entity =>
        {
            entity.ToTable("Invoice_entry_master_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcceptedQty).HasColumnName("accepted_qty");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AverageRating).HasColumnName("average_rating");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Cd).HasColumnName("cd");
            entity.Property(e => e.ChallanNo).HasColumnName("challan_no");
            entity.Property(e => e.ConsumableNonConsumable).HasColumnName("consumable_non_consumable");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.DelayInDays).HasColumnName("delay_in_days");
            entity.Property(e => e.DeliveryRating).HasColumnName("delivery_rating");
            entity.Property(e => e.Department).HasColumnName("department");
            entity.Property(e => e.FormulaId).HasColumnName("formula_id");
            entity.Property(e => e.FrieghtCharges).HasColumnName("frieght_charges");
            entity.Property(e => e.GstAmount).HasColumnName("gst_amount");
            entity.Property(e => e.GstPersentage).HasColumnName("gst_persentage");
            entity.Property(e => e.Hsn).HasColumnName("hsn");
            entity.Property(e => e.InsertTime)
                .HasColumnType("datetime")
                .HasColumnName("insert_time");
            entity.Property(e => e.InvoiceDate).HasColumnName("invoice_date");
            entity.Property(e => e.InvoiceNo).HasColumnName("invoice_no");
            entity.Property(e => e.InwardDate).HasColumnName("inward_date");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.ItemGroup).HasColumnName("item_group");
            entity.Property(e => e.ItemName).HasColumnName("item_name");
            entity.Property(e => e.LineNo).HasColumnName("line_no");
            entity.Property(e => e.Ltb).HasColumnName("ltb");
            entity.Property(e => e.OverAllRating)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("over_all_rating");
            entity.Property(e => e.PackagingCharges).HasColumnName("packaging_charges");
            entity.Property(e => e.PoLine).HasColumnName("po_line");
            entity.Property(e => e.PoNo).HasColumnName("po_no");
            entity.Property(e => e.PoQty).HasColumnName("po_qty");
            entity.Property(e => e.PromiseDate).HasColumnName("promise_date");
            entity.Property(e => e.QualityRating).HasColumnName("quality_rating");
            entity.Property(e => e.ReceivedQty).HasColumnName("received_qty");
            entity.Property(e => e.RejAtSuppliersEnd).HasColumnName("rej_at_suppliers_end");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.RequestForDelete)
                .HasDefaultValue(false)
                .HasColumnName("requestForDelete");
            entity.Property(e => e.RequistionNo).HasColumnName("requistion_no");
            entity.Property(e => e.ResonFordlt).HasColumnName("resonFordlt");
            entity.Property(e => e.SlipNo).HasColumnName("slip_no");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
            entity.Property(e => e.TransportationCharges).HasColumnName("transportation_charges");
            entity.Property(e => e.UDAcceptedQty).HasColumnName("u_d_accepted_qty");
            entity.Property(e => e.UnitPrice).HasColumnName("unit_price");
            entity.Property(e => e.Uom).HasColumnName("uom");
        });

        modelBuilder.Entity<Isquery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ISQuery__3214EC275FABBD3F");

            entity.ToTable("ISQuery");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompeletedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Qtitle).HasColumnName("QTitle");
        });

        modelBuilder.Entity<IssueMaterial>(entity =>
        {
            entity.HasKey(e => new { e.Reqno, e.Id, e.IssueId, e.Receiptno, e.Mid });

            entity.ToTable("Issue_Material");

            entity.Property(e => e.Reqno)
                .HasMaxLength(50)
                .HasColumnName("reqno");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IssueId).HasColumnName("issue_id");
            entity.Property(e => e.Receiptno).HasColumnName("receiptno");
            entity.Property(e => e.Mid).HasColumnName("mid");
            entity.Property(e => e.ItemName).HasColumnName("item_name");
            entity.Property(e => e.Onhandqty).HasColumnName("onhandqty");
            entity.Property(e => e.Receivedqty).HasColumnName("receivedqty");
            entity.Property(e => e.Totalqty).HasColumnName("totalqty");
        });

        modelBuilder.Entity<Isuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ISUser__3214EC2778A4EF6B");

            entity.ToTable("ISUser");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PreviousQuantity).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<ItemNameTbl>(entity =>
        {
            entity.ToTable("item_name_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.ItemName).HasColumnName("item_name");
        });

        modelBuilder.Entity<ItemType>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("item_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mid).HasColumnName("mid");
            entity.Property(e => e.ItemName).HasColumnName("item_name");
        });

        modelBuilder.Entity<ItemsOfEpoTemp>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.LineNo, e.Pid });

            entity.ToTable("Items_of_EPO_temp");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LineNo).HasColumnName("line_no");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(500)
                .HasColumnName("account_no");
            entity.Property(e => e.Cgst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cgst");
            entity.Property(e => e.CgstValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cgst_value");
            entity.Property(e => e.CurrencyType)
                .HasMaxLength(50)
                .HasColumnName("Currency_Type");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.Dis)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("dis");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.EpoNo).HasColumnName("EPO_no");
            entity.Property(e => e.ExtendedCost)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("extended_cost");
            entity.Property(e => e.Gst)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("gst");
            entity.Property(e => e.Gujarat)
                .HasMaxLength(50)
                .HasColumnName("gujarat");
            entity.Property(e => e.Igst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("igst");
            entity.Property(e => e.IgstValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("igst_value");
            entity.Property(e => e.ProductDescription).HasColumnName("product_description");
            entity.Property(e => e.ProductGroup)
                .HasMaxLength(500)
                .HasColumnName("product_group");
            entity.Property(e => e.Purchase)
                .HasMaxLength(500)
                .HasColumnName("purchase");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.QtyUnitpriceTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty_unitprice_tax");
            entity.Property(e => e.ReceivedQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("received_qty");
            entity.Property(e => e.Sgst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sgst");
            entity.Property(e => e.SgstValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sgst_value");
            entity.Property(e => e.Tax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tax");
            entity.Property(e => e.TaxValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tax_value");
            entity.Property(e => e.TotalcostDis)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalcost_dis");
            entity.Property(e => e.Unitprice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unitprice");
            entity.Property(e => e.UnitypriceQty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unityprice_qty");
            entity.Property(e => e.Uom)
                .HasMaxLength(500)
                .HasColumnName("uom");
        });

        modelBuilder.Entity<Jobwork>(entity =>
        {
            entity.HasKey(e => new { e.Gatepassno, e.Id, e.Pid });

            entity.ToTable("jobwork");

            entity.Property(e => e.Gatepassno)
                .HasMaxLength(50)
                .HasColumnName("gatepassno");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Approxsswpartqty)
                .HasMaxLength(500)
                .HasColumnName("approxsswpartqty");
            entity.Property(e => e.Authorisedperson)
                .HasMaxLength(50)
                .HasColumnName("authorisedperson");
            entity.Property(e => e.Cancelleddate).HasColumnName("cancelleddate");
            entity.Property(e => e.Deliverydate).HasColumnName("deliverydate");
            entity.Property(e => e.Descriptionofgoods).HasColumnName("descriptionofgoods");
            entity.Property(e => e.Gdate).HasColumnName("gdate");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.Reasonfordelete)
                .HasMaxLength(500)
                .HasColumnName("reasonfordelete");
            entity.Property(e => e.Receivedpartweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("receivedpartweight");
            entity.Property(e => e.Receivedsswpartqty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("receivedsswpartqty");
            entity.Property(e => e.Receiverperson)
                .HasMaxLength(500)
                .HasColumnName("receiverperson");
            entity.Property(e => e.Receiverremark).HasColumnName("receiverremark");
            entity.Property(e => e.Returneddate).HasColumnName("returneddate");
            entity.Property(e => e.Sswpart)
                .HasMaxLength(500)
                .HasColumnName("sswpart");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Supplieraddress).HasColumnName("supplieraddress");
            entity.Property(e => e.Suppliername)
                .HasMaxLength(500)
                .HasColumnName("suppliername");
            entity.Property(e => e.Totalmaterialcost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalmaterialcost");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<Jobworkhour>(entity =>
        {
            entity.HasKey(e => e.Gpno);

            entity.ToTable("jobworkhour");

            entity.Property(e => e.Gpno)
                .HasMaxLength(50)
                .HasColumnName("GPNO");
            entity.Property(e => e.Countinghour)
                .HasMaxLength(50)
                .HasColumnName("countinghour");
            entity.Property(e => e.Suppliername).HasColumnName("suppliername");
        });

        modelBuilder.Entity<LateComersOfWeekMail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Late_comers_of_week_mail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DayOfWeek)
                .HasMaxLength(50)
                .HasColumnName("day_of_week");
            entity.Property(e => e.MinutesLate)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("minutes_late");
            entity.Property(e => e.PersonId).HasColumnName("Person_ID");
            entity.Property(e => e.PersonName).HasColumnName("Person_Name");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<LateComingImgTable>(entity =>
        {
            entity.ToTable("late_coming_img_table");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(500)
                .HasColumnName("img_path");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .HasColumnName("month");
        });

        modelBuilder.Entity<LoginTbl>(entity =>
        {
            entity.ToTable("login_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Department).HasColumnName("department");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Profile).HasColumnName("profile");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<Machine>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.Id });

            entity.ToTable("machine");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Machinename).HasColumnName("machinename");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<MachineDetail>(entity =>
        {
            entity.ToTable("Machine_Details");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Dept).HasMaxLength(50);
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineType)
                .HasMaxLength(50)
                .HasColumnName("Machine_Type");
            entity.Property(e => e.MachiningType)
                .HasMaxLength(50)
                .HasColumnName("Machining_type");
            entity.Property(e => e.Resource)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Resource1)
                .HasMaxLength(50)
                .HasColumnName("Resource_1");
        });

        modelBuilder.Entity<Maintenance>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.Id });

            entity.ToTable("maintenance");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .HasColumnName("active");
            entity.Property(e => e.Maintenancename).HasMaxLength(500);
        });

        modelBuilder.Entity<MaterialLibrary>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.RefId, e.Mid });

            entity.ToTable("Material_Library");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.Mid).HasColumnName("MID");
        });

        modelBuilder.Entity<MdrPartDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.MdrNo });

            entity.ToTable("MDR_Part_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.MdrNo)
                .HasMaxLength(100)
                .HasColumnName("MDR_No");
            entity.Property(e => e.Allow).HasColumnName("allow");
            entity.Property(e => e.AssemblyPart).HasColumnName("Assembly_part");
            entity.Property(e => e.ManufacturingProduction)
                .HasMaxLength(100)
                .HasColumnName("Manufacturing_Production");
            entity.Property(e => e.ProductName).HasColumnName("Product_Name");
            entity.Property(e => e.RefPart).HasColumnName("Ref_Part");
            entity.Property(e => e.SubRefPart).HasColumnName("Sub_Ref_Part");
            entity.Property(e => e.SubRefPartDesc).HasColumnName("Sub_Ref_Part_desc");
            entity.Property(e => e.SubSystem).HasColumnName("Sub_System");
            entity.Property(e => e.SystemName).HasColumnName("System_Name");
        });

        modelBuilder.Entity<Metadata>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.RequisitionNo, e.Type }).HasName("PK_METADATAN");

            entity.ToTable("METADATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RequisitionNo)
                .HasMaxLength(50)
                .HasColumnName("requisition_no");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasColumnName("type");
            entity.Property(e => e.AdjustmentTimeTakenToAttenMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("adjustment_time_taken_to_atten_min");
            entity.Property(e => e.AdjustmentTimeTakenToAttendHr)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("adjustment_time_taken_to_attend_HR");
            entity.Property(e => e.AdjustmentTimeTakenToRepairHr)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("adjustment_time_taken_to_repair_HR");
            entity.Property(e => e.AdjustmentTimeTakenToRepairMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("adjustment_time_taken_to_repair_min");
            entity.Property(e => e.Approval).HasMaxLength(10);
            entity.Property(e => e.BreakdownDate).HasColumnName("breakdown_date");
            entity.Property(e => e.BreakdownDetailChange)
                .HasMaxLength(50)
                .HasColumnName("breakdown_detail_change");
            entity.Property(e => e.BreakdownDetailChangeReason).HasColumnName("Breakdown_detail_change_reason");
            entity.Property(e => e.BreakdownMonth)
                .HasMaxLength(50)
                .HasColumnName("breakdown_month");
            entity.Property(e => e.BreakdownProblem).HasColumnName("breakdown_problem");
            entity.Property(e => e.BreakdownReason).HasColumnName("breakdown_reason");
            entity.Property(e => e.BreakdownTime).HasColumnName("breakdown_time");
            entity.Property(e => e.BreakdownTime2)
                .HasMaxLength(50)
                .HasColumnName("breakdown_time2");
            entity.Property(e => e.Closed).HasMaxLength(10);
            entity.Property(e => e.CommentForAdjustRepair).HasColumnName("Comment_for_Adjust_repair");
            entity.Property(e => e.CommentForTimeAdjustment).HasColumnName("comment_for_time_adjustment");
            entity.Property(e => e.CommentOnTotalTimeConsumedInBreakdown).HasColumnName("comment_on_total_time_consumed_in_breakdown");
            entity.Property(e => e.CommentOnWaitingToBreakdown).HasColumnName("comment_on_waiting_to_breakdown");
            entity.Property(e => e.Cost)
                .HasMaxLength(50)
                .HasColumnName("cost");
            entity.Property(e => e.Cost1)
                .HasMaxLength(50)
                .HasColumnName("cost1");
            entity.Property(e => e.Cost2)
                .HasMaxLength(50)
                .HasColumnName("cost2");
            entity.Property(e => e.EmailAddress).HasColumnName("email_address");
            entity.Property(e => e.FloorShutdownWeeklyoffHoliday)
                .HasMaxLength(50)
                .HasColumnName("floor_shutdown_weeklyoff_holiday");
            entity.Property(e => e.MachineDowntimeCost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("machine_downtime_cost");
            entity.Property(e => e.MachineSystemProcessUnit).HasColumnName("machine_system_process_unit");
            entity.Property(e => e.MachineSystemProcessUnitNumber)
                .HasMaxLength(50)
                .HasColumnName("Machine_System_Process_Unit_Number");
            entity.Property(e => e.OldBreakdownDate)
                .HasColumnType("datetime")
                .HasColumnName("old_breakdown_date");
            entity.Property(e => e.OldBreakdownTime)
                .HasMaxLength(50)
                .HasColumnName("old_breakdown_time");
            entity.Property(e => e.PartName).HasColumnName("part_name");
            entity.Property(e => e.PartName1).HasColumnName("part_name1");
            entity.Property(e => e.PartName2).HasColumnName("part_name2");
            entity.Property(e => e.Pending).HasMaxLength(10);
            entity.Property(e => e.ProblemSolved)
                .HasMaxLength(50)
                .HasColumnName("Problem_solved");
            entity.Property(e => e.ProblemType).HasColumnName("problem_type");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Quantity1).HasColumnName("quantity1");
            entity.Property(e => e.Quantity2).HasColumnName("quantity2");
            entity.Property(e => e.Rctime)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("rctime");
            entity.Property(e => e.Rctimem)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("rctimem");
            entity.Property(e => e.Reasonfornotapprove).HasColumnName("reasonfornotapprove");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.RepairActionTaken).HasColumnName("repair_action_taken");
            entity.Property(e => e.RepairCompletionDate).HasColumnName("repair_completion_date");
            entity.Property(e => e.RepairCompletionTime)
                .HasMaxLength(50)
                .HasColumnName("repair_completion_time");
            entity.Property(e => e.RepairDetailChangeReason).HasColumnName("repair_detail_change_reason");
            entity.Property(e => e.RepairstartDate).HasColumnName("repairstart_date");
            entity.Property(e => e.RepairstartTime)
                .HasMaxLength(50)
                .HasColumnName("repairstart_time");
            entity.Property(e => e.RequestedName).HasColumnName("requested_name");
            entity.Property(e => e.Rstime)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("rstime");
            entity.Property(e => e.Rstimem)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("rstimem");
            entity.Property(e => e.Rtotal)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("rtotal");
            entity.Property(e => e.Rtotalm)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("rtotalm");
            entity.Property(e => e.Shift).HasColumnName("shift");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TimeTakenToAttenHr)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("time_taken_to_atten_HR");
            entity.Property(e => e.TimeTakenToAttendMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("time_taken_to_attend_min");
            entity.Property(e => e.TimeTakenToRepairHr)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("time_taken_to_repair_HR");
            entity.Property(e => e.TimeTakenToRepairMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("time_taken_to_repair_min");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.TotalAdjustHr)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_adjust_HR");
            entity.Property(e => e.TotalAdjustMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_adjust_min");
            entity.Property(e => e.TotalCost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_cost");
            entity.Property(e => e.TotalRepairHr)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_repair_HR");
            entity.Property(e => e.TotalRepairMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_repair_min");
            entity.Property(e => e.TotalSparePartCost)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_spare_part_cost");
            entity.Property(e => e.TotalTimeHr)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_time_HR");
            entity.Property(e => e.TotalTimeMin)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("total_time_min");
            entity.Property(e => e.TypeOfMaintanance).HasColumnName("type_of_maintanance");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .HasColumnName("usertype");
            entity.Property(e => e.YourName).HasColumnName("your_name");
        });

        modelBuilder.Entity<MiscelleneousIssueTbl>(entity =>
        {
            entity.ToTable("MiscelleneousIssueTbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsFinal).HasColumnName("is_final");
            entity.Property(e => e.IssueBy)
                .HasMaxLength(50)
                .HasColumnName("issue_By");
            entity.Property(e => e.IssueId).HasColumnName("issue_id");
            entity.Property(e => e.IssueLotno)
                .HasMaxLength(50)
                .HasColumnName("issue_lotno");
            entity.Property(e => e.IssueReason)
                .HasMaxLength(50)
                .HasColumnName("issue_reason");
            entity.Property(e => e.IssueRefference)
                .HasMaxLength(50)
                .HasColumnName("issue_refference");
            entity.Property(e => e.IssueRemark).HasColumnName("issue_remark");
            entity.Property(e => e.IssueTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("issue_timestamp");
            entity.Property(e => e.TransQty).HasColumnName("trans_qty");
        });

        modelBuilder.Entity<MiscelleneousRequestTbl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.GroupId, e.LineId }).HasName("PK_MiscelleneousRequestTbl_1");

            entity.ToTable("MiscelleneousRequestTbl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("Group_id");
            entity.Property(e => e.LineId).HasColumnName("Line_id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");
            entity.Property(e => e.InitiatorId)
                .HasMaxLength(50)
                .HasColumnName("initiator_id");
            entity.Property(e => e.InitiatorName)
                .HasMaxLength(50)
                .HasColumnName("initiator_name");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsFinal).HasColumnName("is_final");
            entity.Property(e => e.IssueQty).HasColumnName("issue_qty");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.ReqDate).HasColumnName("req_date");
            entity.Property(e => e.ReqQty).HasColumnName("req_qty");
            entity.Property(e => e.RequestNo)
                .HasMaxLength(50)
                .HasColumnName("Request_no");
            entity.Property(e => e.RequestedPartDesc).HasColumnName("requested_part_desc");
            entity.Property(e => e.RequestedPartNo)
                .HasMaxLength(50)
                .HasColumnName("requested_part_no");
            entity.Property(e => e.ReturnQty).HasColumnName("return_qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.VoidResoan)
                .HasMaxLength(50)
                .HasColumnName("void_resoan");
            entity.Property(e => e.WhereUsePartNo).HasColumnName("where_use_part_no");
        });

        modelBuilder.Entity<ModuleMap>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.LocationId, e.ModuleId, e.ModuleMapId }).HasName("PK_ACM_MODULE_MAP");

            entity.ToTable("MODULE_MAP");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");
            entity.Property(e => e.ModuleMapId).HasColumnName("MODULE_MAP_ID");
            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.AddFlag)
                .HasMaxLength(1)
                .HasColumnName("ADD_FLAG");
            entity.Property(e => e.AllFlag)
                .HasMaxLength(1)
                .HasColumnName("ALL_FLAG");
            entity.Property(e => e.AppVer).HasMaxLength(50);
            entity.Property(e => e.AppVerDate).HasColumnType("datetime");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.Dbver)
                .HasMaxLength(50)
                .HasColumnName("DBVer");
            entity.Property(e => e.DbverDate)
                .HasColumnType("datetime")
                .HasColumnName("DBVerDate");
            entity.Property(e => e.DeleteFlag)
                .HasMaxLength(1)
                .HasColumnName("DELETE_FLAG");
            entity.Property(e => e.ModifyFlag)
                .HasMaxLength(1)
                .HasColumnName("MODIFY_FLAG");
            entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");
            entity.Property(e => e.Sp1)
                .HasDefaultValue(0)
                .HasColumnName("SP1");
            entity.Property(e => e.Sp1name)
                .HasMaxLength(150)
                .HasColumnName("SP1Name");
            entity.Property(e => e.Sp2)
                .HasDefaultValue(0)
                .HasColumnName("SP2");
            entity.Property(e => e.Sp2name)
                .HasMaxLength(150)
                .HasColumnName("SP2Name");
            entity.Property(e => e.Sp3)
                .HasDefaultValue(0)
                .HasColumnName("SP3");
            entity.Property(e => e.Sp3name)
                .HasMaxLength(150)
                .HasColumnName("SP3Name");
            entity.Property(e => e.Sp4)
                .HasDefaultValue(0)
                .HasColumnName("SP4");
            entity.Property(e => e.Sp4name)
                .HasMaxLength(150)
                .HasColumnName("SP4Name");
            entity.Property(e => e.Sp5)
                .HasDefaultValue(0)
                .HasColumnName("SP5");
            entity.Property(e => e.Sp5name)
                .HasMaxLength(150)
                .HasColumnName("SP5Name");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ViewFlag)
                .HasMaxLength(1)
                .HasColumnName("VIEW_FLAG");
        });

        modelBuilder.Entity<ModuleMst>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.ModuleId }).HasName("PK_ACM_MODULE_MST_1");

            entity.ToTable("MODULE_MST");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.ModuleId).HasColumnName("Module_Id");
            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.Activemodule).HasColumnName("ACTIVEMODULE");
            entity.Property(e => e.AppDownLoadUrl).HasColumnName("AppDownLoadURL");
            entity.Property(e => e.AppVer).HasMaxLength(50);
            entity.Property(e => e.AppVerDate).HasColumnType("datetime");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.Dbver)
                .HasMaxLength(50)
                .HasColumnName("DBVer");
            entity.Property(e => e.DbverDate)
                .HasColumnType("datetime")
                .HasColumnName("DBVerDate");
            entity.Property(e => e.ModuleDesc)
                .HasMaxLength(500)
                .HasColumnName("Module_Desc");
            entity.Property(e => e.ModuleLocation)
                .HasMaxLength(20)
                .HasComment("UP ,Left , Down,Top Ayo ")
                .HasColumnName("Module_Location");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(250)
                .HasColumnName("Module_Name");
            entity.Property(e => e.ModuleNameO)
                .HasMaxLength(250)
                .HasColumnName("Module_NameO");
            entity.Property(e => e.ModuleNameT)
                .HasMaxLength(250)
                .HasColumnName("Module_NameT");
            entity.Property(e => e.ModuleOrder).HasColumnName("Module_Order");
            entity.Property(e => e.Moduledate).HasColumnName("MODULEDATE");
            entity.Property(e => e.Mysysname)
                .HasMaxLength(50)
                .HasColumnName("MYSYSNAME");
            entity.Property(e => e.ParentModuleId).HasColumnName("Parent_Module_id");
            entity.Property(e => e.Spass)
                .HasMaxLength(50)
                .HasColumnName("SPass");
            entity.Property(e => e.Suser).HasMaxLength(50);
        });

        modelBuilder.Entity<MonthlyAttendanceDatum>(entity =>
        {
            entity.HasKey(e => e.PersonId);

            entity.ToTable("monthly_attendance_data");

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("personID");
            entity.Property(e => e.Day1)
                .HasMaxLength(50)
                .HasColumnName("day1");
            entity.Property(e => e.Day10)
                .HasMaxLength(50)
                .HasColumnName("day10");
            entity.Property(e => e.Day11)
                .HasMaxLength(50)
                .HasColumnName("day11");
            entity.Property(e => e.Day12)
                .HasMaxLength(50)
                .HasColumnName("day12");
            entity.Property(e => e.Day13)
                .HasMaxLength(50)
                .HasColumnName("day13");
            entity.Property(e => e.Day14)
                .HasMaxLength(50)
                .HasColumnName("day14");
            entity.Property(e => e.Day15)
                .HasMaxLength(50)
                .HasColumnName("day15");
            entity.Property(e => e.Day16)
                .HasMaxLength(50)
                .HasColumnName("day16");
            entity.Property(e => e.Day17)
                .HasMaxLength(50)
                .HasColumnName("day17");
            entity.Property(e => e.Day18)
                .HasMaxLength(50)
                .HasColumnName("day18");
            entity.Property(e => e.Day19)
                .HasMaxLength(50)
                .HasColumnName("day19");
            entity.Property(e => e.Day2)
                .HasMaxLength(50)
                .HasColumnName("day2");
            entity.Property(e => e.Day20)
                .HasMaxLength(50)
                .HasColumnName("day20");
            entity.Property(e => e.Day21)
                .HasMaxLength(50)
                .HasColumnName("day21");
            entity.Property(e => e.Day22)
                .HasMaxLength(50)
                .HasColumnName("day22");
            entity.Property(e => e.Day23)
                .HasMaxLength(50)
                .HasColumnName("day23");
            entity.Property(e => e.Day24)
                .HasMaxLength(50)
                .HasColumnName("day24");
            entity.Property(e => e.Day25)
                .HasMaxLength(50)
                .HasColumnName("day25");
            entity.Property(e => e.Day26)
                .HasMaxLength(50)
                .HasColumnName("day26");
            entity.Property(e => e.Day27)
                .HasMaxLength(50)
                .HasColumnName("day27");
            entity.Property(e => e.Day28)
                .HasMaxLength(50)
                .HasColumnName("day28");
            entity.Property(e => e.Day29)
                .HasMaxLength(50)
                .HasColumnName("day29");
            entity.Property(e => e.Day3)
                .HasMaxLength(50)
                .HasColumnName("day3");
            entity.Property(e => e.Day30)
                .HasMaxLength(50)
                .HasColumnName("day30");
            entity.Property(e => e.Day31)
                .HasMaxLength(50)
                .HasColumnName("day31");
            entity.Property(e => e.Day4)
                .HasMaxLength(50)
                .HasColumnName("day4");
            entity.Property(e => e.Day5)
                .HasMaxLength(50)
                .HasColumnName("day5");
            entity.Property(e => e.Day6)
                .HasMaxLength(50)
                .HasColumnName("day6");
            entity.Property(e => e.Day7)
                .HasMaxLength(50)
                .HasColumnName("day7");
            entity.Property(e => e.Day8)
                .HasMaxLength(50)
                .HasColumnName("day8");
            entity.Property(e => e.Day9)
                .HasMaxLength(50)
                .HasColumnName("day9");
            entity.Property(e => e.PersonName).HasMaxLength(500);
            entity.Property(e => e.Total)
                .HasMaxLength(50)
                .HasColumnName("total");
        });

        modelBuilder.Entity<MrsReasonCodeWithPartClass>(entity =>
        {
            entity.ToTable("MRS_ReasonCode_with_PartClass");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClassDescription).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.ReasonCodeDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<MrsRequesterDatum>(entity =>
        {
            entity.HasKey(e => e.SrNo);

            entity.ToTable("MRS_Requester_data");

            entity.Property(e => e.SrNo)
                .ValueGeneratedNever()
                .HasColumnName("sr_no");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.SubDepartment)
                .HasMaxLength(50)
                .HasColumnName("sub-department");
        });

        modelBuilder.Entity<MrsSupervisorApproval>(entity =>
        {
            entity.ToTable("MRS_Supervisor_Approval");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HigherAuth).HasMaxLength(50);
        });

        modelBuilder.Entity<MrsTempMiscelleneousRequestTbl>(entity =>
        {
            entity.ToTable("MRS_Temp_MiscelleneousRequestTbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.InitiatorId)
                .HasMaxLength(50)
                .HasColumnName("initiator_id");
            entity.Property(e => e.InitiatorName)
                .HasMaxLength(50)
                .HasColumnName("initiator_name");
            entity.Property(e => e.IssueQty).HasColumnName("issue_qty");
            entity.Property(e => e.LineId).HasColumnName("line_id");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.ReqDate).HasColumnName("req_date");
            entity.Property(e => e.ReqQty).HasColumnName("req_qty");
            entity.Property(e => e.RequestedPartDesc).HasColumnName("requested_part_desc");
            entity.Property(e => e.RequestedPartNo)
                .HasMaxLength(50)
                .HasColumnName("requested_part_no");
            entity.Property(e => e.ReturnQty).HasColumnName("return_qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.SubDepartmentName)
                .HasMaxLength(50)
                .HasColumnName("sub_department_name");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.WhereUsePartNo).HasColumnName("where_use_part_no");
        });

        modelBuilder.Entity<MrsTempReturnMiscelleneousRequestTbl>(entity =>
        {
            entity.ToTable("MRS_Temp__ReturnMiscelleneousRequestTbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.InitiatorId)
                .HasMaxLength(50)
                .HasColumnName("initiator_id");
            entity.Property(e => e.InitiatorName)
                .HasMaxLength(50)
                .HasColumnName("initiator_name");
            entity.Property(e => e.LineId).HasColumnName("line_id");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.ReturnPartDesc).HasColumnName("return_part_desc");
            entity.Property(e => e.ReturnPartNo)
                .HasMaxLength(50)
                .HasColumnName("return_part_no");
            entity.Property(e => e.ReturnQty).HasColumnName("return_qty");
            entity.Property(e => e.ReturnReqDate).HasColumnName("return_req_date");
            entity.Property(e => e.ReturnReqQty).HasColumnName("return_req_qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.SubDepartment)
                .HasMaxLength(50)
                .HasColumnName("sub_department");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.WhereUsePartNo).HasColumnName("where_use_part_no");
        });

        modelBuilder.Entity<MrsmiscelleneousIssueTbl>(entity =>
        {
            entity.ToTable("MRSMiscelleneousIssueTbls");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BalanceQty).HasColumnName("balance_qty");
            entity.Property(e => e.IssueBy)
                .HasMaxLength(50)
                .HasColumnName("issue_By");
            entity.Property(e => e.IssueId).HasColumnName("issue_id");
            entity.Property(e => e.IssueLotno)
                .HasMaxLength(50)
                .HasColumnName("issue_lotno");
            entity.Property(e => e.IssueQtyCurrentTime).HasColumnName("issue_qty_currentTime");
            entity.Property(e => e.IssueReason)
                .HasMaxLength(50)
                .HasColumnName("issue_reason");
            entity.Property(e => e.IssueRefference)
                .HasMaxLength(50)
                .HasColumnName("issue_refference");
            entity.Property(e => e.IssueRemark).HasColumnName("issue_remark");
            entity.Property(e => e.IssueTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("issue_timestamp");
            entity.Property(e => e.IssueTo)
                .HasMaxLength(50)
                .HasColumnName("issue_to");
            entity.Property(e => e.TransQty).HasColumnName("trans_qty");
        });

        modelBuilder.Entity<MrsmiscelleneousRequestTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MRSMiscelleneousRequestTbl_1");

            entity.ToTable("MRSMiscelleneousRequestTbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfirmationBy).HasColumnName("confirmation_by");
            entity.Property(e => e.DenyConfirmationReason).HasColumnName("deny_confirmation_reason");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");
            entity.Property(e => e.InitiatorId)
                .HasMaxLength(50)
                .HasColumnName("initiator_id");
            entity.Property(e => e.InitiatorName)
                .HasMaxLength(50)
                .HasColumnName("initiator_name");
            entity.Property(e => e.IssueQty).HasColumnName("issue_qty");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.ReqDate).HasColumnName("req_date");
            entity.Property(e => e.ReqQty).HasColumnName("req_qty");
            entity.Property(e => e.RequestNo)
                .HasMaxLength(50)
                .HasColumnName("Request_no");
            entity.Property(e => e.RequestedPartDesc).HasColumnName("requested_part_desc");
            entity.Property(e => e.RequestedPartNo)
                .HasMaxLength(50)
                .HasColumnName("requested_part_no");
            entity.Property(e => e.ReturnQty).HasColumnName("return_qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.SubDepartmentName)
                .HasMaxLength(50)
                .HasColumnName("sub_department_name");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.VoidReason)
                .HasMaxLength(50)
                .HasColumnName("void_reason");
            entity.Property(e => e.WhereUsePartNo).HasColumnName("where_use_part_no");
        });

        modelBuilder.Entity<MrsreturnMiscelleneousRequestTbl>(entity =>
        {
            entity.ToTable("MRSReturnMiscelleneousRequestTbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfirmationBy).HasColumnName("confirmation_by");
            entity.Property(e => e.DenyConfirmationReason).HasColumnName("deny_confirmation_reason");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");
            entity.Property(e => e.InitiatorId)
                .HasMaxLength(50)
                .HasColumnName("initiator_id");
            entity.Property(e => e.InitiatorName)
                .HasMaxLength(50)
                .HasColumnName("initiator_name");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.RequestNo)
                .HasMaxLength(50)
                .HasColumnName("Request_no");
            entity.Property(e => e.ReturnPartDesc).HasColumnName("return_part_desc");
            entity.Property(e => e.ReturnPartNo)
                .HasMaxLength(50)
                .HasColumnName("return_part_no");
            entity.Property(e => e.ReturnQty).HasColumnName("return_qty");
            entity.Property(e => e.ReturnReqDate).HasColumnName("return_req_date");
            entity.Property(e => e.ReturnReqQty).HasColumnName("return_req_qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.SubDepartmentName)
                .HasMaxLength(50)
                .HasColumnName("sub_department_name");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.VoidReason)
                .HasMaxLength(50)
                .HasColumnName("void_reason");
            entity.Property(e => e.WhereUsePartNo).HasColumnName("where_use_part_no");
        });

        modelBuilder.Entity<MrsreturnReturnTransactionTbl>(entity =>
        {
            entity.ToTable("MRSReturnReturnTransactionTbls");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BalanceQty).HasColumnName("balance_qty");
            entity.Property(e => e.ReturnBy)
                .HasMaxLength(50)
                .HasColumnName("return_By");
            entity.Property(e => e.ReturnId).HasColumnName("Return_id");
            entity.Property(e => e.ReturnLotno)
                .HasMaxLength(50)
                .HasColumnName("return_lotno");
            entity.Property(e => e.ReturnPurpose).HasColumnName("return_purpose");
            entity.Property(e => e.ReturnQtyCurrentTime).HasColumnName("return_qty_currentTime");
            entity.Property(e => e.ReturnReason)
                .HasMaxLength(50)
                .HasColumnName("return_reason");
            entity.Property(e => e.ReturnRefference)
                .HasMaxLength(50)
                .HasColumnName("return_refference");
            entity.Property(e => e.ReturnRemark).HasColumnName("return_remark");
            entity.Property(e => e.ReturnTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("return_timestamp");
            entity.Property(e => e.ReturnTransQty).HasColumnName("return_trans_qty");
            entity.Property(e => e.ReturnedQty).HasColumnName("returned_qty");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<Multiname>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Reqno });

            entity.ToTable("multinames");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Reqno)
                .HasMaxLength(100)
                .HasColumnName("reqno");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Mytimepunchrecord>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid });

            entity.ToTable("mytimepunchrecords");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .HasColumnName("active");
            entity.Property(e => e.Approval)
                .HasMaxLength(500)
                .HasColumnName("approval");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.NewAdded)
                .HasMaxLength(50)
                .HasColumnName("new_added");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Personname)
                .HasMaxLength(500)
                .HasColumnName("personname");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .HasColumnName("status");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<NewFpaGdntSymbol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_fpa_gdntnew");

            entity.ToTable("newFPA_GDNT_SYMBOL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.GdntSymbolAndName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gdnt_symbol_and_name");
            entity.Property(e => e.GdntSymbolName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gdnt_symbol_name");
            entity.Property(e => e.GdnySymbol)
                .HasMaxLength(50)
                .HasColumnName("gdny_symbol");
        });

        modelBuilder.Entity<Nonreturnablegatepass>(entity =>
        {
            entity.HasKey(e => new { e.Gatepassno, e.Id, e.Gid });

            entity.ToTable("nonreturnablegatepass");

            entity.Property(e => e.Gatepassno)
                .HasMaxLength(50)
                .HasColumnName("gatepassno");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Authorisedperson)
                .HasMaxLength(100)
                .HasColumnName("authorisedperson");
            entity.Property(e => e.Cancelleddate).HasColumnName("cancelleddate");
            entity.Property(e => e.Deliverydate).HasColumnName("deliverydate");
            entity.Property(e => e.Descriptionofgoods).HasColumnName("descriptionofgoods");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.Reasonfordelete).HasColumnName("reasonfordelete");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Supplieraddress)
                .HasMaxLength(500)
                .HasColumnName("supplieraddress");
        });

        modelBuilder.Entity<NotificationListDocument>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("NotificationList_Document");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Approval)
                .HasMaxLength(50)
                .HasColumnName("approval");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.DocumentAuthor)
                .HasMaxLength(500)
                .HasColumnName("document_author");
            entity.Property(e => e.DocumentManager)
                .HasMaxLength(500)
                .HasColumnName("document_manager");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("Emp_ID");
            entity.Property(e => e.EmpName).HasColumnName("Emp_Name");
            entity.Property(e => e.ListType)
                .HasMaxLength(500)
                .HasColumnName("list_type");
            entity.Property(e => e.NotificationDate)
                .HasColumnType("datetime")
                .HasColumnName("notification_date");
        });

        modelBuilder.Entity<PackslipDtl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.LabelType)
                .HasMaxLength(50)
                .HasColumnName("label_type");
            entity.Property(e => e.Lotnum)
                .HasMaxLength(50)
                .HasColumnName("lotnum");
            entity.Property(e => e.Masterqty).HasColumnName("masterqty");
            entity.Property(e => e.Packnum)
                .HasMaxLength(50)
                .HasColumnName("packnum");
            entity.Property(e => e.Totalboxqty)
                .HasMaxLength(50)
                .HasColumnName("totalboxqty");
        });

        modelBuilder.Entity<PartLibrary>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Rid, e.TypeOfDoc });

            entity.ToTable("Part_Library");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.TypeOfDoc)
                .HasMaxLength(150)
                .HasColumnName("type_of_doc");
            entity.Property(e => e.ApprovalComment).HasColumnName("Approval_comment");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_date");
            entity.Property(e => e.Approved).HasMaxLength(10);
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.Attachment).HasColumnName("attachment");
            entity.Property(e => e.Attachment2).HasColumnName("attachment2");
            entity.Property(e => e.Attachment3).HasColumnName("attachment3");
            entity.Property(e => e.Attachment4).HasColumnName("attachment4");
            entity.Property(e => e.Attchment2).HasColumnName("attchment2");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_by");
            entity.Property(e => e.CurrentHistory)
                .HasMaxLength(100)
                .HasColumnName("Current_History");
            entity.Property(e => e.DraRevNo)
                .HasMaxLength(500)
                .HasColumnName("Dra_rev_no");
            entity.Property(e => e.DrawingRevisionDate)
                .HasColumnType("datetime")
                .HasColumnName("Drawing_Revision_Date");
            entity.Property(e => e.DrawingRevisionNo).HasColumnName("Drawing_Revision_no");
            entity.Property(e => e.MachineName).HasColumnName("Machine_name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(500)
                .HasColumnName("Machine_No");
            entity.Property(e => e.OpNo).HasColumnName("op_no");
            entity.Property(e => e.PartName).HasColumnName("part_name");
            entity.Property(e => e.PartStartName)
                .HasMaxLength(200)
                .HasColumnName("part_start_name");
            entity.Property(e => e.PartSubSubType).HasColumnName("part_sub_sub_type");
            entity.Property(e => e.PartSubType).HasColumnName("part_sub_type");
            entity.Property(e => e.PartType).HasColumnName("part_type");
            entity.Property(e => e.PoNo).HasColumnName("PO_No");
            entity.Property(e => e.TypeOfOp).HasColumnName("type_of_op");
            entity.Property(e => e.UploadedRevisionNo).HasColumnName("uploaded_Revision_no");
        });

        modelBuilder.Entity<PartMasterTbl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PartNum });

            entity.ToTable("PartMasterTbl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PartNum).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsLotRequired).HasColumnName("is_lotRequired");
            entity.Property(e => e.Uom).HasMaxLength(50);
        });

        modelBuilder.Entity<Partnumber>(entity =>
        {
            entity.ToTable("partnumber");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Partno)
                .HasMaxLength(500)
                .HasColumnName("partno");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
        });

        modelBuilder.Entity<PpapDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.PpapNo });

            entity.ToTable("PPAP_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.PpapNo)
                .HasMaxLength(100)
                .HasColumnName("PPAP_No");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_date");
            entity.Property(e => e.CustDrawingNo)
                .HasMaxLength(100)
                .HasColumnName("cust_drawing_no");
            entity.Property(e => e.CustPartName).HasColumnName("cust_part_name");
            entity.Property(e => e.CustPartNo)
                .HasMaxLength(500)
                .HasColumnName("cust_part_no");
            entity.Property(e => e.CustomerPpapStatus)
                .HasMaxLength(50)
                .HasColumnName("customer_ppap_status");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.EndCustomer).HasColumnName("End_Customer");
            entity.Property(e => e.NotApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("not_approve_date");
            entity.Property(e => e.OtherReason).HasColumnName("Other_Reason");
            entity.Property(e => e.PpapAttachment).HasColumnName("PPAP_Attachment");
            entity.Property(e => e.PpapUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("PPAP_Update_Date");
            entity.Property(e => e.PpapUpdateHistory)
                .HasMaxLength(10)
                .HasColumnName("PPAP_Update_History");
            entity.Property(e => e.PpapUploadDate)
                .HasColumnType("datetime")
                .HasColumnName("ppap_upload_date");
            entity.Property(e => e.ReQualificationDate)
                .HasColumnType("datetime")
                .HasColumnName("Re_qualification_date");
            entity.Property(e => e.ReQualificationRequired).HasColumnName("Re_Qualification_Required");
            entity.Property(e => e.ReQualificationYear)
                .HasMaxLength(50)
                .HasColumnName("Re_qualification_Year");
            entity.Property(e => e.ReasonForNotApprove).HasColumnName("reason_for_not_approve");
            entity.Property(e => e.ReasonForSubmission).HasColumnName("reason_for_submission");
            entity.Property(e => e.RejectedDate)
                .HasColumnType("datetime")
                .HasColumnName("rejected_date");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.ReviceId).HasColumnName("revice_ID");
            entity.Property(e => e.ReviseDate)
                .HasColumnType("datetime")
                .HasColumnName("revise_date");
            entity.Property(e => e.SswDrawingNo)
                .HasMaxLength(100)
                .HasColumnName("ssw_drawing_no");
            entity.Property(e => e.SswPartName).HasColumnName("ssw_part_name");
            entity.Property(e => e.SswPartNo)
                .HasMaxLength(500)
                .HasColumnName("ssw_part_no");
            entity.Property(e => e.SubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("submission_date");
            entity.Property(e => e.SubmissionLevel).HasColumnName("submission_level");
        });

        modelBuilder.Entity<PrivilageMenudemon>(entity =>
        {
            entity.HasKey(e => new { e.PrivilegeMenuId, e.TenentId, e.PrivilegeId, e.Privilagefor, e.LocationId, e.MenuId }).HasName("PK_PRIVILAGE_MENUDemon_1");

            entity.ToTable("PRIVILAGE_MENUDemon");

            entity.Property(e => e.PrivilegeMenuId).HasColumnName("PRIVILEGE_MENU_ID");
            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");
            entity.Property(e => e.Privilagefor).HasColumnName("PRIVILAGEFOR");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.MenuId).HasColumnName("MENU_ID");
            entity.Property(e => e.Action).HasMaxLength(1);
            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.ActiveMenu).HasMaxLength(1);
            entity.Property(e => e.ActiveModule).HasMaxLength(1);
            entity.Property(e => e.Activetilldate).HasColumnName("ACTIVETILLDATE");
            entity.Property(e => e.AddFlag)
                .HasMaxLength(1)
                .HasColumnName("ADD_FLAG");
            entity.Property(e => e.AllFlag)
                .HasMaxLength(1)
                .HasColumnName("ALL_FLAG");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.DeleteFlag)
                .HasMaxLength(1)
                .HasColumnName("DELETE_FLAG");
            entity.Property(e => e.IsEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IS_ENABLE");
            entity.Property(e => e.IsVisible)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IS_VISIBLE");
            entity.Property(e => e.LabelFlag)
                .HasMaxLength(1)
                .HasColumnName("LABEL_FLAG");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");
            entity.Property(e => e.MenuLocation)
                .HasMaxLength(50)
                .HasColumnName("MENU_LOCATION");
            entity.Property(e => e.ModifyFlag)
                .HasMaxLength(1)
                .HasColumnName("MODIFY_FLAG");
            entity.Property(e => e.Sp1)
                .HasMaxLength(1)
                .HasColumnName("SP1");
            entity.Property(e => e.Sp1name)
                .HasMaxLength(150)
                .HasColumnName("SP1Name");
            entity.Property(e => e.Sp2)
                .HasMaxLength(1)
                .HasColumnName("SP2");
            entity.Property(e => e.Sp2name)
                .HasMaxLength(150)
                .HasColumnName("SP2Name");
            entity.Property(e => e.Sp3)
                .HasMaxLength(1)
                .HasColumnName("SP3");
            entity.Property(e => e.Sp3name)
                .HasMaxLength(150)
                .HasColumnName("SP3Name");
            entity.Property(e => e.Sp4)
                .HasMaxLength(1)
                .HasColumnName("SP4");
            entity.Property(e => e.Sp4name)
                .HasMaxLength(150)
                .HasColumnName("SP4Name");
            entity.Property(e => e.Sp5)
                .HasMaxLength(1)
                .HasColumnName("SP5");
            entity.Property(e => e.Sp5name)
                .HasMaxLength(150)
                .HasColumnName("SP5Name");
            entity.Property(e => e.ViewFlag)
                .HasMaxLength(1)
                .HasColumnName("VIEW_FLAG");
        });

        modelBuilder.Entity<PrivilegeMst>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.PrivilegeId }).HasName("PK_ACM_PRIVILEGE_MST_1");

            entity.ToTable("PRIVILEGE_MST");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");
            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");
            entity.Property(e => e.PrivilegeDesc).HasColumnName("PRIVILEGE_DESC");
            entity.Property(e => e.PrivilegeName)
                .HasMaxLength(50)
                .HasColumnName("PRIVILEGE_NAME");
            entity.Property(e => e.PrivilegeName1)
                .HasMaxLength(50)
                .HasColumnName("PRIVILEGE_NAME1");
            entity.Property(e => e.PrivilegeName2)
                .HasMaxLength(50)
                .HasColumnName("PRIVILEGE_NAME2");
        });

        modelBuilder.Entity<ProdFlexBulkShaftIssue>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.InventoryId });

            entity.ToTable("Prod_Flex_Bulk_Shaft_Issue");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.InventoryId)
                .HasMaxLength(200)
                .HasColumnName("Inventory_ID");
            entity.Property(e => e.IssueDate).HasColumnName("Issue_Date");
            entity.Property(e => e.IssueFeet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Issue_Feet");
            entity.Property(e => e.IssueMachineName)
                .HasMaxLength(300)
                .HasColumnName("Issue_Machine_Name");
            entity.Property(e => e.IssueMachineNo)
                .HasMaxLength(50)
                .HasColumnName("Issue_Machine_No");
            entity.Property(e => e.IssueTime)
                .HasMaxLength(50)
                .HasColumnName("Issue_time");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(200)
                .HasColumnName("Job_Number");
            entity.Property(e => e.ShaftPartNumber)
                .HasMaxLength(200)
                .HasColumnName("Shaft_Part_Number");
            entity.Property(e => e.Shift).HasMaxLength(100);
        });

        modelBuilder.Entity<ProdFlexBulkShaftJobList>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Prod_Flex_Bulk_Shaft_Job_List");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(100)
                .HasColumnName("Job_Number");
            entity.Property(e => e.JobQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Job_Qty");
            entity.Property(e => e.PartId).HasColumnName("Part_ID");
            entity.Property(e => e.PartNumber).HasColumnName("Part_Number");
            entity.Property(e => e.PartType)
                .HasMaxLength(100)
                .HasColumnName("part_type");
            entity.Property(e => e.RevisionNumber)
                .HasMaxLength(100)
                .HasColumnName("Revision_Number");
            entity.Property(e => e.UploadBy).HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
        });

        modelBuilder.Entity<ProdFlexBulkShaftJobListHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("Prod_Flex_Bulk_Shaft_Job_List_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("change_date");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(100)
                .HasColumnName("Job_Number");
            entity.Property(e => e.JobQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Job_Qty");
            entity.Property(e => e.PartId).HasColumnName("Part_ID");
            entity.Property(e => e.PartNumber).HasColumnName("Part_Number");
            entity.Property(e => e.PartType)
                .HasMaxLength(100)
                .HasColumnName("Part_Type");
            entity.Property(e => e.RevisionNumber)
                .HasMaxLength(100)
                .HasColumnName("Revision_Number");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<ProdFlexCutShaftJobList>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Prod_Flex_Cut_Shaft_Job_List");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(100)
                .HasColumnName("Job_Number");
            entity.Property(e => e.JobQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Job_Qty");
            entity.Property(e => e.PartId).HasColumnName("Part_ID");
            entity.Property(e => e.PartNumber).HasColumnName("Part_Number");
            entity.Property(e => e.PartType)
                .HasMaxLength(100)
                .HasColumnName("part_type");
            entity.Property(e => e.RevisionNumber)
                .HasMaxLength(100)
                .HasColumnName("Revision_Number");
            entity.Property(e => e.UploadBy).HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
        });

        modelBuilder.Entity<ProdFlexCutShaftJobListHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("Prod_Flex_Cut_Shaft_Job_List_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("change_date");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(100)
                .HasColumnName("Job_Number");
            entity.Property(e => e.JobQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Job_Qty");
            entity.Property(e => e.PartId).HasColumnName("Part_ID");
            entity.Property(e => e.PartNumber).HasColumnName("Part_Number");
            entity.Property(e => e.PartType)
                .HasMaxLength(100)
                .HasColumnName("part_type");
            entity.Property(e => e.RevisionNumber)
                .HasMaxLength(100)
                .HasColumnName("Revision_Number");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
        });

        modelBuilder.Entity<ProdFlexInventory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.InventoryId });

            entity.ToTable("Prod_Flex_Inventory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.InventoryId)
                .HasMaxLength(200)
                .HasColumnName("Inventory_ID");
            entity.Property(e => e.AfcMsmJobNo)
                .HasMaxLength(200)
                .HasColumnName("AFC_MSM_Job_No");
            entity.Property(e => e.AfcMsmMachineName)
                .HasMaxLength(100)
                .HasColumnName("AFC_MSM_Machine_Name");
            entity.Property(e => e.AfcMsmMachineNo)
                .HasMaxLength(50)
                .HasColumnName("AFC_MSM_Machine_No");
            entity.Property(e => e.AfcOperator)
                .HasMaxLength(200)
                .HasColumnName("AFC_Operator");
            entity.Property(e => e.CurrentStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("current_stock");
            entity.Property(e => e.Feet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("feet");
            entity.Property(e => e.InventoryDate).HasColumnName("inventory_date");
            entity.Property(e => e.InventoryTime)
                .HasMaxLength(50)
                .HasColumnName("inventory_time");
            entity.Property(e => e.IssueDate).HasColumnName("Issue_date");
            entity.Property(e => e.IssueFeet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Issue_Feet");
            entity.Property(e => e.IssueMachineName)
                .HasMaxLength(100)
                .HasColumnName("Issue_Machine_Name");
            entity.Property(e => e.IssueMachineNo)
                .HasMaxLength(100)
                .HasColumnName("Issue_Machine_No");
            entity.Property(e => e.IssueMaterial).HasColumnName("Issue_Material");
            entity.Property(e => e.IssueTime)
                .HasMaxLength(50)
                .HasColumnName("Issue_time");
            entity.Property(e => e.IssueWeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Issue_Weight_Kg");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(100)
                .HasColumnName("Job_number");
            entity.Property(e => e.JobToInventory).HasColumnName("Job_to_Inventory");
            entity.Property(e => e.JobToMesProduction).HasColumnName("Job_to_MES_Production");
            entity.Property(e => e.JobToMesQuality).HasColumnName("Job_to_MES_Quality");
            entity.Property(e => e.MachineName)
                .HasMaxLength(500)
                .HasColumnName("Machine_name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(100)
                .HasColumnName("Machine_no");
            entity.Property(e => e.PartName)
                .HasMaxLength(200)
                .HasColumnName("Part_name");
            entity.Property(e => e.PartNameForIssue)
                .HasMaxLength(500)
                .HasColumnName("Part_Name_For_issue");
            entity.Property(e => e.ReelIssueDate).HasColumnName("Reel_Issue_Date");
            entity.Property(e => e.ReelIssueShift)
                .HasMaxLength(50)
                .HasColumnName("Reel_Issue_Shift");
            entity.Property(e => e.ReelIssueTime)
                .HasMaxLength(50)
                .HasColumnName("Reel_Issue_Time");
            entity.Property(e => e.ReelReturnShift).HasColumnName("Reel_Return_Shift");
            entity.Property(e => e.ReelStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("reel_stock");
            entity.Property(e => e.ResponsibleMsmOperator).HasColumnName("Responsible_MSM_Operator");
            entity.Property(e => e.ReturnDate).HasColumnName("Return_Date");
            entity.Property(e => e.ReturnFeet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Return_feet");
            entity.Property(e => e.ReturnMaterial).HasColumnName("Return_Material");
            entity.Property(e => e.ReturnTime)
                .HasMaxLength(50)
                .HasColumnName("Return_Time");
            entity.Property(e => e.ReturnWeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Return_weight_kg");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.WeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight_kg");
        });

        modelBuilder.Entity<ProdFlexInventoryHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Prod_Flex_Inventory_History");

            entity.Property(e => e.AfcMsmJobNo)
                .HasMaxLength(200)
                .HasColumnName("AFC_MSM_Job_No");
            entity.Property(e => e.AfcMsmMachineName)
                .HasMaxLength(100)
                .HasColumnName("AFC_MSM_Machine_Name");
            entity.Property(e => e.AfcMsmMachineNo)
                .HasMaxLength(50)
                .HasColumnName("AFC_MSM_Machine_No");
            entity.Property(e => e.AfcOperator)
                .HasMaxLength(200)
                .HasColumnName("AFC_Operator");
            entity.Property(e => e.CurrentStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("current_Stock");
            entity.Property(e => e.Feet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("feet");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("Inventory_Date");
            entity.Property(e => e.InventoryId)
                .HasMaxLength(200)
                .HasColumnName("Inventory_ID");
            entity.Property(e => e.InventoryTime)
                .HasMaxLength(50)
                .HasColumnName("inventory_time");
            entity.Property(e => e.IssueDate).HasColumnName("Issue_date");
            entity.Property(e => e.IssueFeet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Issue_Feet");
            entity.Property(e => e.IssueMachineName)
                .HasMaxLength(100)
                .HasColumnName("Issue_Machine_Name");
            entity.Property(e => e.IssueMachineNo)
                .HasMaxLength(100)
                .HasColumnName("Issue_Machine_No");
            entity.Property(e => e.IssueMaterial).HasColumnName("Issue_Material");
            entity.Property(e => e.IssueTime)
                .HasMaxLength(50)
                .HasColumnName("Issue_time");
            entity.Property(e => e.IssueWeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Issue_Weight_Kg");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(100)
                .HasColumnName("Job_number");
            entity.Property(e => e.JobToInventory).HasColumnName("Job_to_Inventory");
            entity.Property(e => e.JobToMesProduction).HasColumnName("job_to_MES_Production");
            entity.Property(e => e.JobToMesQuality).HasColumnName("Job_to_MES_Quality");
            entity.Property(e => e.MachineName)
                .HasMaxLength(500)
                .HasColumnName("Machine_name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(100)
                .HasColumnName("Machine_no");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.PartName)
                .HasMaxLength(200)
                .HasColumnName("Part_name");
            entity.Property(e => e.PartNameForIssue)
                .HasMaxLength(500)
                .HasColumnName("Part_Name_For_issue");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ReelIssueDate).HasColumnName("Reel_Issue_Date");
            entity.Property(e => e.ReelIssueShift)
                .HasMaxLength(50)
                .HasColumnName("Reel_Issue_Shift");
            entity.Property(e => e.ReelIssueTime)
                .HasMaxLength(50)
                .HasColumnName("Reel_Issue_Time");
            entity.Property(e => e.ReelReturnShift).HasColumnName("Reel_Return_Shift");
            entity.Property(e => e.ReelStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("reel_stock");
            entity.Property(e => e.ResponsibleMsmOperator).HasColumnName("Responsible_MSM_Operator");
            entity.Property(e => e.ReturnDate).HasColumnName("Return_Date");
            entity.Property(e => e.ReturnFeet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Return_feet");
            entity.Property(e => e.ReturnMaterial).HasColumnName("Return_Material");
            entity.Property(e => e.ReturnTime)
                .HasMaxLength(50)
                .HasColumnName("Return_Time");
            entity.Property(e => e.ReturnWeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Return_weight_kg");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.WeightKg)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight_kg");
        });

        modelBuilder.Entity<ProdFlexPartList>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Prod_Flex_Part_List");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Approved).HasMaxLength(50);
            entity.Property(e => e.PartNumber)
                .HasMaxLength(500)
                .HasColumnName("Part_number");
            entity.Property(e => e.PartType)
                .HasMaxLength(30)
                .HasColumnName("Part_Type");
            entity.Property(e => e.RevisionNumber)
                .HasMaxLength(100)
                .HasColumnName("Revision_Number");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ProdFlexPartListHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("Prod_Flex_Part_List_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Approved).HasMaxLength(50);
            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("change_date");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(500)
                .HasColumnName("Part_number");
            entity.Property(e => e.PartType)
                .HasMaxLength(30)
                .HasColumnName("Part_Type");
            entity.Property(e => e.RevisionNumber)
                .HasMaxLength(100)
                .HasColumnName("Revision_Number");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ProdFlexPartWiseOperation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Prod_Flex_Part_Wise_Operation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.AfcOp).HasColumnName("AFC_Op");
            entity.Property(e => e.AssemblyOp).HasColumnName("Assembly_Op");
            entity.Property(e => e.DeburringOp).HasColumnName("Deburring_Op");
            entity.Property(e => e.FinalInspectionOp).HasColumnName("Final_Inspection_Op");
            entity.Property(e => e.FlockingOp).HasColumnName("Flocking_Op");
            entity.Property(e => e.GaugingOp).HasColumnName("Gauging_Op");
            entity.Property(e => e.HeatingOp).HasColumnName("Heating_Op");
            entity.Property(e => e.OverflockGaugingOp).HasColumnName("Overflock_Gauging_Op");
            entity.Property(e => e.PackingOp).HasColumnName("Packing_Op");
            entity.Property(e => e.PartNumber).HasColumnName("Part_Number");
            entity.Property(e => e.QcInspectionOp).HasColumnName("QC_Inspection_Op");
            entity.Property(e => e.RevNo).HasColumnName("rev_no");
            entity.Property(e => e.RollTestOp).HasColumnName("Roll_Test_Op");
            entity.Property(e => e.SiliconOp).HasColumnName("Silicon_Op");
            entity.Property(e => e.TappingOp).HasColumnName("Tapping_Op");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
            entity.Property(e => e.VisualInspenctionOp).HasColumnName("Visual_Inspenction_Op");
        });

        modelBuilder.Entity<ProdcutionReportCnc>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.ProductionId });

            entity.ToTable("Prodcution_Report_CNC");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ProductionId)
                .HasMaxLength(100)
                .HasColumnName("Production_ID");
            entity.Property(e => e.ActualCycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Actual_Cycle_Time");
            entity.Property(e => e.ActualSetupTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Actual_Setup_Time");
            entity.Property(e => e.DeviationRequired).HasColumnName("Deviation_Required");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(100)
                .HasColumnName("Job_number");
            entity.Property(e => e.LoadingTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Loading_Time");
            entity.Property(e => e.LotQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Lot_Qty");
            entity.Property(e => e.MachineName).HasColumnName("Machine_Name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(500)
                .HasColumnName("Machine_No");
            entity.Property(e => e.NonConfQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Non_Conf_Qty");
            entity.Property(e => e.NonProductiveCheckPerson).HasColumnName("Non_productive_check_person");
            entity.Property(e => e.NonProductiveTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Non_Productive_time");
            entity.Property(e => e.OkQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OK_Qty");
            entity.Property(e => e.OpDone)
                .HasMaxLength(50)
                .HasColumnName("OP_Done");
            entity.Property(e => e.OpNo)
                .HasMaxLength(100)
                .HasColumnName("Op_No");
            entity.Property(e => e.Opd).HasColumnName("OPD");
            entity.Property(e => e.OperationSequence).HasColumnName("Operation_Sequence");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(500)
                .HasColumnName("Part_number");
            entity.Property(e => e.PlanTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Plan_time");
            entity.Property(e => e.ProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Production_date");
            entity.Property(e => e.Programmer)
                .HasMaxLength(500)
                .HasColumnName("programmer");
            entity.Property(e => e.ReasonForRejection).HasColumnName("Reason_for_rejection");
            entity.Property(e => e.RejectQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Reject_Qty");
            entity.Property(e => e.RequestForEcr).HasColumnName("Request_for_ECR");
            entity.Property(e => e.RevNo)
                .HasMaxLength(100)
                .HasColumnName("Rev_No");
            entity.Property(e => e.SetupBinFixuring).HasColumnName("setup_bin_fixuring");
            entity.Property(e => e.Shift).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .HasColumnName("status");
            entity.Property(e => e.StdCycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Std_Cycle_Time");
            entity.Property(e => e.StdSetupTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Std_Setup_Time");
            entity.Property(e => e.TotalProductionTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total_production_time");
            entity.Property(e => e.TotalQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total_Qty");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<ProductDetail>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.Pid, e.Id });

            entity.ToTable("Product_detail");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DescriptionProduct).HasColumnName("Description_Product");
            entity.Property(e => e.ProductHeader).HasColumnName("Product_header");
            entity.Property(e => e.ProductInfoInner).HasColumnName("product_info_inner");
            entity.Property(e => e.ProductInfoMain).HasColumnName("product_info_main");
            entity.Property(e => e.ProductName)
                .HasMaxLength(500)
                .HasColumnName("product_name");
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.Id, e.Pid });

            entity.ToTable("product_image");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ProductImage1)
                .HasMaxLength(500)
                .HasColumnName("Product_image");
            entity.Property(e => e.ProductName)
                .HasMaxLength(500)
                .HasColumnName("Product_name");
        });

        modelBuilder.Entity<ProductionDeviationReport>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.DeviationId });

            entity.ToTable("Production_Deviation_Report");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.DeviationId)
                .HasMaxLength(100)
                .HasColumnName("Deviation_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(500)
                .HasColumnName("Approved_by");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("Approved_date");
            entity.Property(e => e.DescriptionOfNonconformance).HasColumnName("Description_of_Nonconformance");
            entity.Property(e => e.DeviationBy)
                .HasMaxLength(50)
                .HasColumnName("Deviation_by");
            entity.Property(e => e.DeviationDate)
                .HasColumnType("datetime")
                .HasColumnName("Deviation_Date");
            entity.Property(e => e.JobNo)
                .HasMaxLength(100)
                .HasColumnName("Job_No");
            entity.Property(e => e.OpNo)
                .HasMaxLength(50)
                .HasColumnName("Op_No");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(500)
                .HasColumnName("Part_Number");
            entity.Property(e => e.PoForecast)
                .HasMaxLength(100)
                .HasColumnName("PO_Forecast");
            entity.Property(e => e.ProductionId)
                .HasMaxLength(100)
                .HasColumnName("Production_ID");
            entity.Property(e => e.QtyForDeviation)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qty_for_Deviation");
            entity.Property(e => e.Quntity).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.RevNo)
                .HasMaxLength(50)
                .HasColumnName("Rev_No");
            entity.Property(e => e.RootCause).HasColumnName("Root_Cause");
            entity.Property(e => e.Status).HasMaxLength(500);
        });

        modelBuilder.Entity<ProductionEcrDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EcrId });

            entity.ToTable("Production_ECR_Data");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EcrId)
                .HasMaxLength(200)
                .HasColumnName("ECR_ID");
            entity.Property(e => e.EcnId)
                .HasMaxLength(50)
                .HasColumnName("ECN_ID");
            entity.Property(e => e.EcrDate)
                .HasColumnType("datetime")
                .HasColumnName("ecr_date");
            entity.Property(e => e.Functional).HasColumnName("functional");
            entity.Property(e => e.JobNo)
                .HasMaxLength(100)
                .HasColumnName("Job_No");
            entity.Property(e => e.OpNo)
                .HasMaxLength(50)
                .HasColumnName("Op_No");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(500)
                .HasColumnName("Part_Number");
            entity.Property(e => e.ProductionId)
                .HasMaxLength(100)
                .HasColumnName("Production_ID");
            entity.Property(e => e.RevNo)
                .HasMaxLength(50)
                .HasColumnName("Rev_No");
        });

        modelBuilder.Entity<ProductionFinalDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SetupId });

            entity.ToTable("Production_Final_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SetupId)
                .HasMaxLength(50)
                .HasColumnName("Setup_ID");
            entity.Property(e => e.CycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cycle_Time");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.LoadingTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Loading_Time");
            entity.Property(e => e.Machine).HasMaxLength(50);
            entity.Property(e => e.NonConQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NonCon_Qty");
            entity.Property(e => e.OkQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OK_Qty");
            entity.Property(e => e.Op).HasMaxLength(50);
            entity.Property(e => e.OtherTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Other_Time");
            entity.Property(e => e.PartNum).HasMaxLength(50);
            entity.Property(e => e.Person).HasMaxLength(50);
            entity.Property(e => e.RejectQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Reject_Qty");
            entity.Property(e => e.Rev).HasMaxLength(50);
            entity.Property(e => e.SetupContinue)
                .HasColumnType("datetime")
                .HasColumnName("Setup_Continue");
            entity.Property(e => e.SetupEnd)
                .HasColumnType("datetime")
                .HasColumnName("Setup_End");
            entity.Property(e => e.SetupStart)
                .HasColumnType("datetime")
                .HasColumnName("Setup_Start");
            entity.Property(e => e.SetupTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Setup_Time");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.Uploaddate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductionPlanning>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Production_Planning");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.AssignedQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Assigned_Qty");
            entity.Property(e => e.ChangeJob).HasColumnName("Change_Job");
            entity.Property(e => e.ChangeJobApproval).HasColumnName("Change_job_Approval");
            entity.Property(e => e.ChangeJobnum)
                .HasMaxLength(50)
                .HasColumnName("Change_Jobnum");
            entity.Property(e => e.ChangeMachineName)
                .HasMaxLength(50)
                .HasColumnName("Change_machine_name");
            entity.Property(e => e.ChangeOp)
                .HasMaxLength(50)
                .HasColumnName("Change_op");
            entity.Property(e => e.ChangeRemark).HasColumnName("Change_Remark");
            entity.Property(e => e.CompletedDay).HasColumnName("Completed_Day");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(100)
                .HasColumnName("created_user");
            entity.Property(e => e.CycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cycle_Time");
            entity.Property(e => e.ForceClose).HasColumnName("Force_Close");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.JobQty).HasColumnName("Job_Qty");
            entity.Property(e => e.Machine).HasMaxLength(50);
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("Machine_name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .HasColumnName("Machine_no");
            entity.Property(e => e.OkQty).HasColumnName("Ok_Qty");
            entity.Property(e => e.Op)
                .HasMaxLength(50)
                .HasColumnName("OP");
            entity.Property(e => e.OpName)
                .HasMaxLength(100)
                .HasColumnName("OP_Name");
            entity.Property(e => e.OtherDatetime)
                .HasColumnType("datetime")
                .HasColumnName("Other_Datetime");
            entity.Property(e => e.PartNum).HasMaxLength(50);
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.PlanningEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Planning_end_date");
            entity.Property(e => e.PlanningEndTime).HasColumnName("Planning_end_time");
            entity.Property(e => e.PlanningStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Planning_start_date");
            entity.Property(e => e.PlanningStartTime).HasColumnName("Planning_start_time");
            entity.Property(e => e.ProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Production_Date");
            entity.Property(e => e.ProductionEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Production_End_Date");
            entity.Property(e => e.ProductionStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Production_Start_Date");
            entity.Property(e => e.ProductionStartDateResetting)
                .HasColumnType("datetime")
                .HasColumnName("Production_Start_date_resetting");
            entity.Property(e => e.ProductionTime).HasColumnName("Production_Time");
            entity.Property(e => e.PromiseShipDate)
                .HasColumnType("datetime")
                .HasColumnName("Promise_Ship_Date");
            entity.Property(e => e.RemainingQty).HasColumnName("Remaining_Qty");
            entity.Property(e => e.ResettingDate)
                .HasColumnType("datetime")
                .HasColumnName("Resetting_date");
            entity.Property(e => e.Revision)
                .HasMaxLength(50)
                .HasColumnName("revision");
            entity.Property(e => e.SetupDate)
                .HasColumnType("datetime")
                .HasColumnName("Setup_Date");
            entity.Property(e => e.SetupDatetime).HasColumnName("Setup_datetime");
            entity.Property(e => e.SetupTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Setup_time");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.SystemName)
                .HasMaxLength(50)
                .HasColumnName("System_Name");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
        });

        modelBuilder.Entity<ProductionPlanningComlexityOfPart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Production_Planning_Comlexity_of_Part");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ChangeBy)
                .HasMaxLength(50)
                .HasColumnName("Change_By");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("Change_Date");
            entity.Property(e => e.ChangeRemark).HasColumnName("Change_Remark");
            entity.Property(e => e.PartNum).HasMaxLength(50);
            entity.Property(e => e.SystemName).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductionPlanningPriority>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Production_Planning_Priority");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ChangeBy)
                .HasMaxLength(50)
                .HasColumnName("Change_By");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("Change_Date");
            entity.Property(e => e.ChangeRemark).HasColumnName("Change_Remark");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.PartNum).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductionPlanningYearlyQty>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Production_Planning_YearlyQty");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ChangeBy)
                .HasMaxLength(50)
                .HasColumnName("Change_By");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("Change_Date");
            entity.Property(e => e.ChangeRemark).HasColumnName("Change_Remark");
            entity.Property(e => e.PartNum).HasMaxLength(50);
            entity.Property(e => e.SystemName).HasMaxLength(50);
            entity.Property(e => e.YearlyQty).HasColumnName("Yearly_Qty");
        });

        modelBuilder.Entity<ProductionProductionDtl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.SetupId });

            entity.ToTable("Production_Production_dtls");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.SetupId).HasColumnName("Setup_ID");
            entity.Property(e => e.ActualProductionDate).HasColumnName("Actual_Production_Date");
            entity.Property(e => e.ActualProductionTime)
                .HasMaxLength(50)
                .HasColumnName("Actual_Production_Time");
            entity.Property(e => e.BackEntry).HasColumnName("Back_Entry");
            entity.Property(e => e.CycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cycle_time");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.LoadingTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Loading_Time");
            entity.Property(e => e.LotQty)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Lot_qty");
            entity.Property(e => e.Machine).HasMaxLength(50);
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .HasColumnName("Machine_No");
            entity.Property(e => e.NonConQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NonCon_Qty");
            entity.Property(e => e.OkQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OK_Qty");
            entity.Property(e => e.Op).HasColumnName("OP");
            entity.Property(e => e.OtherTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Other_Time");
            entity.Property(e => e.PartNum).HasMaxLength(100);
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("PersonID");
            entity.Property(e => e.PlanningDate).HasColumnName("Planning_Date");
            entity.Property(e => e.ProductionEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Production_end_date");
            entity.Property(e => e.ProductionStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Production_start_date");
            entity.Property(e => e.ProductionTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Production_time");
            entity.Property(e => e.RejectQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Reject_Qty");
            entity.Property(e => e.RemainingQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Remaining_Qty");
            entity.Property(e => e.RevNo).HasMaxLength(50);
            entity.Property(e => e.Setup).HasMaxLength(50);
            entity.Property(e => e.SetupDate).HasColumnName("Setup_Date");
            entity.Property(e => e.SetupTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Setup_time");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.ShiftEntry).HasColumnName("Shift_entry");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("Start_time");
            entity.Property(e => e.StartTimeForShift)
                .HasColumnType("datetime")
                .HasColumnName("start_time_for_shift");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("starttime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total_Qty");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductionQtydtl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("Production_Qtydtls");

            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ActualDate)
                .HasColumnType("datetime")
                .HasColumnName("actual_date");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.Machine).HasMaxLength(50);
            entity.Property(e => e.MultipleEntriesDropdown).HasColumnName("multipleEntriesDropdown");
            entity.Property(e => e.Operator).HasMaxLength(50);
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("qty");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.Setup)
                .HasMaxLength(50)
                .HasColumnName("setup");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.TypeOfQty)
                .HasMaxLength(50)
                .HasColumnName("Type_of_Qty");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
        });

        modelBuilder.Entity<ProductionReportGeneratorDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PersonId });

            entity.ToTable("Production_Report_Generator_Detail");

            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.PersonName).HasMaxLength(500);
            entity.Property(e => e.PersonType)
                .HasMaxLength(500)
                .HasColumnName("Person_Type");
            entity.Property(e => e.ToolTrialUserType).HasColumnName("Tool_Trial_UserTYpe");
            entity.Property(e => e.UserName).HasColumnName("User_Name");
        });

        modelBuilder.Entity<ProductionSetupDtl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.SetupId });

            entity.ToTable("Production_Setup_Dtls");

            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.SetupId).HasColumnName("Setup_ID");
            entity.Property(e => e.ActualUpload).HasColumnName("Actual_Upload");
            entity.Property(e => e.CycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cycle_Time");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.ForceClose).HasColumnName("Force_close");
            entity.Property(e => e.ForceQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Force_qty");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.LoadingTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Loading_Time");
            entity.Property(e => e.LotQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("lot_Qty");
            entity.Property(e => e.Machine).HasMaxLength(50);
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .HasColumnName("Machine_no");
            entity.Property(e => e.NonConQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NonCon_Qty");
            entity.Property(e => e.OkQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OK_QTY");
            entity.Property(e => e.Op).HasColumnName("OP");
            entity.Property(e => e.OtherTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Other_Time");
            entity.Property(e => e.PartNum).HasMaxLength(100);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.PlanningDate).HasColumnName("Planning_Date");
            entity.Property(e => e.ProductionDate).HasColumnName("Production_Date");
            entity.Property(e => e.RejectQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Reject_Qty");
            entity.Property(e => e.RemainingQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Remaining_Qty");
            entity.Property(e => e.RemarkForJob).HasColumnName("Remark_For_Job");
            entity.Property(e => e.RemarkForMachine).HasColumnName("Remark_For_Machine");
            entity.Property(e => e.RevNo).HasMaxLength(50);
            entity.Property(e => e.Setup).HasMaxLength(50);
            entity.Property(e => e.SetupTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("setup_Time");
            entity.Property(e => e.SetupTimeTotal)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Setup_time_total");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.TimeForTotalQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Time_For_Total_Qty");
            entity.Property(e => e.TotalQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total_Qty");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Updatedate).HasColumnType("datetime");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
        });

        modelBuilder.Entity<ProductionSystemName>(entity =>
        {
            entity.ToTable("Production_System_Name");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CycleTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cycle_Time");
            entity.Property(e => e.FlStock).HasColumnName("FL_Stock");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.PartNum).HasMaxLength(100);
            entity.Property(e => e.PartType)
                .HasMaxLength(100)
                .HasColumnName("Part_Type");
            entity.Property(e => e.SnStock).HasColumnName("SN_Stock");
            entity.Property(e => e.SystemNum).HasMaxLength(100);
            entity.Property(e => e.YearlyQty).HasColumnName("Yearly_Qty");
        });

        modelBuilder.Entity<ProductionToolDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.ToolId });

            entity.ToTable("Production_Tool_Details");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ToolId)
                .HasMaxLength(100)
                .HasColumnName("ToolID");
            entity.Property(e => e.InsertOrCorner).HasMaxLength(50);
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.NewOrUsed).HasMaxLength(50);
            entity.Property(e => e.Operator).HasMaxLength(50);
            entity.Property(e => e.PartNum).HasMaxLength(50);
            entity.Property(e => e.ProductionId)
                .HasMaxLength(100)
                .HasColumnName("Production_Id");
            entity.Property(e => e.RevNo).HasMaxLength(50);
            entity.Property(e => e.RuffOrFinish).HasMaxLength(50);
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.Toolname).HasMaxLength(300);
        });

        modelBuilder.Entity<ProductionUniqueOp>(entity =>
        {
            entity.ToTable("Production_Unique_Op");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.OpColorCode)
                .HasMaxLength(50)
                .HasColumnName("Op_Color_code");
            entity.Property(e => e.OpName)
                .HasMaxLength(50)
                .HasColumnName("Op_Name");
        });

        modelBuilder.Entity<ProductionUtilization>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.SetupId });

            entity.ToTable("Production_Utilization");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.SetupId)
                .HasMaxLength(50)
                .HasColumnName("Setup_ID");
            entity.Property(e => e.JobNum).HasMaxLength(50);
            entity.Property(e => e.MachineName)
                .HasMaxLength(200)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineUtilization)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Machine_utilization");
            entity.Property(e => e.MachiningQuality)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("machining_quality");
            entity.Property(e => e.NonProductiveTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("non_productive_time");
            entity.Property(e => e.PartNum).HasMaxLength(100);
            entity.Property(e => e.ProductiveTime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Productive_time");
            entity.Property(e => e.Shift).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UploadDate).HasColumnName("Upload_date");
        });

        modelBuilder.Entity<ProgramOperationWiseToolLibrary>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Program_Operation_wise_Tool_Library");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .HasColumnName("Job_No");
            entity.Property(e => e.MachineName)
                .HasMaxLength(500)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(500)
                .HasColumnName("Machine_No");
            entity.Property(e => e.OpNo)
                .HasMaxLength(50)
                .HasColumnName("Op_No");
            entity.Property(e => e.PartName).HasColumnName("Part_Name");
            entity.Property(e => e.ProgramId).HasColumnName("Program_ID");
            entity.Property(e => e.RevNo)
                .HasMaxLength(50)
                .HasColumnName("Rev_no");
            entity.Property(e => e.ToolName).HasColumnName("Tool_Name");
            entity.Property(e => e.ToolType)
                .HasMaxLength(500)
                .HasColumnName("Tool_Type");
            entity.Property(e => e.TypeOfOperation)
                .HasMaxLength(500)
                .HasColumnName("Type_of_Operation");
        });

        modelBuilder.Entity<ProgrammerEvaluationBonou>(entity =>
        {
            entity.ToTable("ProgrammerEvaluation_Bonous");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BonousMonth).HasColumnType("datetime");
            entity.Property(e => e.CalDiciplineBonous).HasColumnName("Cal_DiciplineBonous");
            entity.Property(e => e.CalDiciplineRating).HasColumnName("Cal_DiciplineRating");
            entity.Property(e => e.CalResettingtimeBonous).HasColumnName("Cal_ResettingtimeBonous");
            entity.Property(e => e.CalResettingtimeRating).HasColumnName("Cal_ResettingtimeRating");
            entity.Property(e => e.CalSettingtimeBonous).HasColumnName("Cal_SettingtimeBonous");
            entity.Property(e => e.CalSettingtimeRating).HasColumnName("Cal_SettingtimeRating");
            entity.Property(e => e.CalSetupbinBonous).HasColumnName("Cal_SetupbinBonous");
            entity.Property(e => e.CalSetupbinRating).HasColumnName("Cal_SetupbinRating");
            entity.Property(e => e.CalTrainninggivenBonous).HasColumnName("Cal_TrainninggivenBonous");
            entity.Property(e => e.CalTrainninggivenRating).HasColumnName("Cal_TrainninggivenRating");
            entity.Property(e => e.CalTrainningtakenBonous).HasColumnName("Cal_TrainningtakenBonous");
            entity.Property(e => e.CalTrainningtakenRating).HasColumnName("Cal_TrainningtakenRating");
            entity.Property(e => e.ProgrammerId).HasColumnName("programmer_id");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ProgrammerEvaluationBonousCalculation>(entity =>
        {
            entity.ToTable("ProgrammerEvaluation_BonousCalculation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bonous)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("bonous");
            entity.Property(e => e.Lower).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Upper).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ProgrammerEvaluationBonousCalculationHistory>(entity =>
        {
            entity.ToTable("ProgrammerEvaluation_BonousCalculationHistory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bonous)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("bonous");
            entity.Property(e => e.Lower).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Upper).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ProgrammerEvaluationDiscipline>(entity =>
        {
            entity.ToTable("ProgrammerEvaluation_Discipline");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProgrammerId).HasColumnName("programmer_id");
        });

        modelBuilder.Entity<ProgrammerEvaluationEmployeeList>(entity =>
        {
            entity.ToTable("ProgrammerEvaluation_EmployeeList");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.ApprovedBy).HasMaxLength(100);
            entity.Property(e => e.DeleteTimespan).HasColumnType("datetime");
            entity.Property(e => e.EmployeeName).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Isapproved).HasColumnName("ISApproved");
            entity.Property(e => e.JoiningDate)
                .HasColumnType("datetime")
                .HasColumnName("Joining Date");
            entity.Property(e => e.LoginIpaddress).HasColumnName("LoginIPAddress");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserType).HasMaxLength(100);
        });

        modelBuilder.Entity<ProgrammerEvaluationLoginActivityLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProgrammerEvaluation_Activity_Logs");

            entity.ToTable("ProgrammerEvaluation_Login_Activity_Logs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActiveUser).HasColumnName("Active_User");
            entity.Property(e => e.DeleteUser).HasColumnName("Delete_User");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasColumnName("IP_Address");
            entity.Property(e => e.LoginId).HasColumnName("Login_Id");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TimeSpan)
                .HasColumnType("datetime")
                .HasColumnName("Time_Span");
        });

        modelBuilder.Entity<ProgrammerEvaluationRulesTable>(entity =>
        {
            entity.HasKey(e => e.Ruleid);

            entity.ToTable("ProgrammerEvaluation_RulesTable");

            entity.Property(e => e.SettingRuleId).HasColumnName("SettingRuleID");
            entity.Property(e => e.SetupRuleId).HasColumnName("SetupRuleID");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<ProgrammerEvaluationSettingDifficulty>(entity =>
        {
            entity.HasKey(e => e.Part);

            entity.ToTable("ProgrammerEvaluation_SettingDifficulty");

            entity.Property(e => e.Part).HasMaxLength(50);
            entity.Property(e => e.Difficulty).HasMaxLength(50);
        });

        modelBuilder.Entity<ProgrammerEvaluationSettingTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Programm__3214EC07E2CE9018");

            entity.ToTable("ProgrammerEvaluation_SettingTime");

            entity.Property(e => e.Difficulty).HasMaxLength(50);
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.Machine).HasMaxLength(255);
            entity.Property(e => e.OpProcess).HasMaxLength(50);
            entity.Property(e => e.PartNumber).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RevNo).HasMaxLength(50);
            entity.Property(e => e.SettingType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupervisiorRemark).HasMaxLength(50);
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ProgrammerEvaluationStandrdizedBin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StandrdizedBin");

            entity.ToTable("ProgrammerEvaluation_StandrdizedBin");

            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.Machine).HasMaxLength(255);
            entity.Property(e => e.OpProcess).HasMaxLength(50);
            entity.Property(e => e.PartNumber).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RevNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SupervisiorRemark).HasMaxLength(50);
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ProgrammerEvaluationTrainersDetail>(entity =>
        {
            entity.ToTable("ProgrammerEvaluation_TrainersDetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TrainnerId).HasColumnName("trainner_id");
            entity.Property(e => e.TtId).HasColumnName("TT_id");
        });

        modelBuilder.Entity<ProgrammerEvaluationTraining>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProgrammerEvaluation_TrainingTakenData");

            entity.ToTable("ProgrammerEvaluation_Training");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Files).HasColumnName("files");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.TrainerName).HasMaxLength(100);
            entity.Property(e => e.TrainningType).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ProgrammerevaluationAdduseractivitylog>(entity =>
        {
            entity.ToTable("Programmerevaluation_Adduseractivitylog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeName).HasColumnName("Employee_Name");
        });

        modelBuilder.Entity<PurchaseAnalysisDataFromErp>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Ponum, e.PackSlip, e.Poline });

            entity.ToTable("Purchase_Analysis_DataFromERP");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Ponum).HasColumnName("PONum");
            entity.Property(e => e.PackSlip).HasMaxLength(50);
            entity.Property(e => e.Poline).HasColumnName("POLine");
            entity.Property(e => e.ClassId)
                .HasMaxLength(50)
                .HasColumnName("ClassID");
            entity.Property(e => e.CommentText)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocUnitCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ExtCost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Ium)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IUM");
            entity.Property(e => e.OrderQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OurQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.TaxCatId).HasMaxLength(50);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalDedTax).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
            entity.Property(e => e.VendorName).IsUnicode(false);
        });

        modelBuilder.Entity<PurchaseAnalysisInvoiceconfirm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_purchase_analysis_invoiceconfirm_1");

            entity.ToTable("purchase_analysis_invoiceconfirm");

            entity.Property(e => e.AcceptedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Addedby).HasColumnName("addedby");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Averagerating).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.Cd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CD");
            entity.Property(e => e.ChallanNo).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasMaxLength(50);
            entity.Property(e => e.DeliveryRating).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.EntryType).HasMaxLength(500);
            entity.Property(e => e.Epono).HasColumnName("EPONo");
            entity.Property(e => e.FreightCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Gstamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GSTAmount");
            entity.Property(e => e.Gstpercentage)
                .HasMaxLength(50)
                .HasColumnName("GSTPercentage");
            entity.Property(e => e.Hsn)
                .HasMaxLength(50)
                .HasColumnName("HSN");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.InwardDate).HasColumnType("datetime");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.OverallRating)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PackingOrCuttingCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pono).HasColumnName("PONo");
            entity.Property(e => e.Poqty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("POQty");
            entity.Property(e => e.PromiseDate).HasColumnType("datetime");
            entity.Property(e => e.Qr)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("QR");
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RejSuppEnd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RequisitionNo).HasMaxLength(50);
            entity.Property(e => e.SupName).HasMaxLength(100);
            entity.Property(e => e.Timestap)
                .HasComputedColumnSql("(getdate())", false)
                .HasColumnType("datetime")
                .HasColumnName("timestap");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransportationCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TypeCode).HasMaxLength(50);
            entity.Property(e => e.Uaqty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UAQty");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Uom)
                .HasMaxLength(20)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<PurchaseAnalysisItemGroupMaster>(entity =>
        {
            entity.ToTable("purchase_analysis_item_group_master");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("is_deleted");
            entity.Property(e => e.ItemGroup).HasColumnName("item_group");
        });

        modelBuilder.Entity<PurchaseAnalysisPartDepartment>(entity =>
        {
            entity.ToTable("Purchase_Analysis_Part_Department");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(50);
        });

        modelBuilder.Entity<Purreq>(entity =>
        {
            entity.HasKey(e => new { e.ReqNo, e.Id, e.Pid });

            entity.ToTable("purreq");

            entity.Property(e => e.ReqNo)
                .HasMaxLength(50)
                .HasColumnName("req_no");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Approval)
                .HasMaxLength(10)
                .HasColumnName("approval");
            entity.Property(e => e.Askforquotation).HasColumnName("askforquotation");
            entity.Property(e => e.AskforquotationDate)
                .HasColumnType("datetime")
                .HasColumnName("askforquotation_date");
            entity.Property(e => e.Attachment).HasColumnName("attachment");
            entity.Property(e => e.BillReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("bill_received_date");
            entity.Property(e => e.Billno)
                .HasMaxLength(50)
                .HasColumnName("billno");
            entity.Property(e => e.ChallanNo)
                .HasMaxLength(100)
                .HasColumnName("challan_no");
            entity.Property(e => e.ChallanNo2)
                .HasMaxLength(100)
                .HasColumnName("challan_no2");
            entity.Property(e => e.ChallanNo3)
                .HasMaxLength(100)
                .HasColumnName("challan_no3");
            entity.Property(e => e.ChallanNo4)
                .HasMaxLength(100)
                .HasColumnName("challan_no4");
            entity.Property(e => e.ChallanNo5)
                .HasMaxLength(100)
                .HasColumnName("challan_no5");
            entity.Property(e => e.CheckPoint)
                .HasMaxLength(50)
                .HasColumnName("check_point");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Department).HasColumnName("department");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.Epo)
                .HasMaxLength(500)
                .HasColumnName("epo");
            entity.Property(e => e.Epo2)
                .HasMaxLength(100)
                .HasColumnName("epo2");
            entity.Property(e => e.Epo3)
                .HasMaxLength(100)
                .HasColumnName("epo3");
            entity.Property(e => e.Epo4)
                .HasMaxLength(100)
                .HasColumnName("epo4");
            entity.Property(e => e.Epo5)
                .HasMaxLength(100)
                .HasColumnName("epo5");
            entity.Property(e => e.EpoAttachment).HasColumnName("EPO_Attachment");
            entity.Property(e => e.EpoDate)
                .HasColumnType("datetime")
                .HasColumnName("epo_date");
            entity.Property(e => e.EpoLineno).HasColumnName("epo_lineno");
            entity.Property(e => e.EpoStatus)
                .HasMaxLength(500)
                .HasColumnName("epo_status");
            entity.Property(e => e.Extracharge)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("extracharge");
            entity.Property(e => e.FilterAllow)
                .HasMaxLength(2)
                .HasColumnName("filter_allow");
            entity.Property(e => e.IntransitDate)
                .HasColumnType("datetime")
                .HasColumnName("intransit_date");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(100)
                .HasColumnName("invoice_no");
            entity.Property(e => e.InvoiceNo2)
                .HasMaxLength(100)
                .HasColumnName("invoice_no2");
            entity.Property(e => e.InvoiceNo3)
                .HasMaxLength(100)
                .HasColumnName("invoice_no3");
            entity.Property(e => e.InvoiceNo4)
                .HasMaxLength(100)
                .HasColumnName("invoice_no4");
            entity.Property(e => e.InvoiceNo5)
                .HasMaxLength(100)
                .HasColumnName("invoice_no5");
            entity.Property(e => e.IssueItemQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("issue_item_qty");
            entity.Property(e => e.IssueStatus)
                .HasMaxLength(100)
                .HasColumnName("issue_status");
            entity.Property(e => e.ItemIssueDateAgainstReqNo)
                .HasColumnType("datetime")
                .HasColumnName("item_issue_date_against_req_no");
            entity.Property(e => e.ItemIssueToPerson).HasColumnName("item_issue_to_person");
            entity.Property(e => e.Itemname).HasColumnName("itemname");
            entity.Property(e => e.Itemqty).HasColumnName("itemqty");
            entity.Property(e => e.ItemqtyNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("itemqty_new");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(500)
                .HasColumnName("itemtype");
            entity.Property(e => e.Nameofinitiator).HasColumnName("nameofinitiator");
            entity.Property(e => e.Payslipnumber)
                .HasMaxLength(500)
                .HasColumnName("payslipnumber");
            entity.Property(e => e.PendingQty).HasColumnName("pending_qty");
            entity.Property(e => e.PerfomaWaiting).HasColumnName("perfoma_waiting");
            entity.Property(e => e.PerformaWaitingDate)
                .HasColumnType("datetime")
                .HasColumnName("performa_waiting_date");
            entity.Property(e => e.PeruomPrice)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("peruom_price");
            entity.Property(e => e.PurchaserRemark).HasColumnName("purchaser_remark");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Qtymanage).HasColumnName("qtymanage");
            entity.Property(e => e.QueryInReq).HasColumnName("Query_in_Req");
            entity.Property(e => e.QueryResolve).HasColumnName("Query_Resolve");
            entity.Property(e => e.QueryResolveDate)
                .HasColumnType("datetime")
                .HasColumnName("Query_resolve_date");
            entity.Property(e => e.QueryResolveRemark).HasColumnName("Query_Resolve_remark");
            entity.Property(e => e.QuotationType)
                .HasMaxLength(50)
                .HasColumnName("quotation_type");
            entity.Property(e => e.Reasonforedit).HasColumnName("reasonforedit");
            entity.Property(e => e.ReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("received_date");
            entity.Property(e => e.ReceivedQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("received_qty");
            entity.Property(e => e.RemarkInQuery).HasColumnName("Remark_in_Query");
            entity.Property(e => e.RemarkOnItem).HasColumnName("remark_on_item");
            entity.Property(e => e.RemarkOnReceivedItem).HasColumnName("remark_on_received_item");
            entity.Property(e => e.Remarkonitem).HasColumnName("remarkonitem");
            entity.Property(e => e.ReqDate)
                .HasColumnType("datetime")
                .HasColumnName("req_date");
            entity.Property(e => e.ReqInQueryDate)
                .HasColumnType("datetime")
                .HasColumnName("Req_in_query_date");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .HasColumnName("status");
            entity.Property(e => e.SuggestedSupplier).HasColumnName("suggested_supplier");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(500)
                .HasColumnName("supplier_name");
            entity.Property(e => e.Totalkg).HasColumnName("totalkg");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.VoidDate)
                .HasColumnType("datetime")
                .HasColumnName("Void_Date");
            entity.Property(e => e.VoidRemark).HasColumnName("void_remark");
        });

        modelBuilder.Entity<PurreqInvoiceViewdetail>(entity =>
        {
            entity.HasKey(e => new { e.Reqno, e.Id, e.LineNo, e.Pid, e.Payslipno });

            entity.ToTable("purreq_invoice_viewdetail");

            entity.Property(e => e.Reqno)
                .HasMaxLength(100)
                .HasColumnName("reqno");
            entity.Property(e => e.LineNo).HasColumnName("line_no");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Payslipno)
                .HasMaxLength(100)
                .HasColumnName("payslipno");
            entity.Property(e => e.ChallanNo)
                .HasMaxLength(100)
                .HasColumnName("challan_no");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(100)
                .HasColumnName("invoice_no");
            entity.Property(e => e.IssueBy).HasColumnName("Issue_by");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("Issue_date");
            entity.Property(e => e.IssueIteQty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("issue_ite_qty");
            entity.Property(e => e.IssueStatus)
                .HasMaxLength(100)
                .HasColumnName("Issue_status");
            entity.Property(e => e.Itemname).HasColumnName("itemname");
            entity.Property(e => e.Itemqty).HasColumnName("itemqty");
            entity.Property(e => e.ItemqtyNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("itemqty_new");
            entity.Property(e => e.Payslipnonew).HasColumnName("payslipnonew");
            entity.Property(e => e.ReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("received_date");
            entity.Property(e => e.ReceivedQty).HasColumnName("received_qty");
            entity.Property(e => e.ReceivedQtyNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("received_qty_new");
            entity.Property(e => e.RemainingQty).HasColumnName("remaining_qty");
            entity.Property(e => e.RemainingQtyNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("remaining_qty_new");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.SuppName).HasColumnName("supp_name");
            entity.Property(e => e.TransactionQty).HasColumnName("Transaction_qty");
            entity.Property(e => e.TransactionQtyNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("transaction_qty_new");
        });

        modelBuilder.Entity<QueryTbl>(entity =>
        {
            entity.ToTable("Query_tbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Query).HasMaxLength(50);
            entity.Property(e => e.QueryStatus).HasMaxLength(50);
            entity.Property(e => e.QueryTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("questions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ans)
                .IsUnicode(false)
                .HasColumnName("ans");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.OptionA).IsUnicode(false);
            entity.Property(e => e.OptionB).IsUnicode(false);
            entity.Property(e => e.OptionC).IsUnicode(false);
            entity.Property(e => e.OptionD).IsUnicode(false);
            entity.Property(e => e.QNo)
                .IsUnicode(false)
                .HasColumnName("qNo");
            entity.Property(e => e.Qset)
                .IsUnicode(false)
                .HasColumnName("qset");
            entity.Property(e => e.Question1)
                .IsUnicode(false)
                .HasColumnName("question");
            entity.Property(e => e.Quiz)
                .IsUnicode(false)
                .HasColumnName("quiz");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<ReactEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("React_Employee");

            entity.Property(e => e.DateOfJoining).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(500);
            entity.Property(e => e.EmployeeId).ValueGeneratedOnAdd();
            entity.Property(e => e.EmployeeName).HasMaxLength(500);
            entity.Property(e => e.PhotoFileName).HasMaxLength(500);
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Record");

            entity.Property(e => e.Age).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(250);
            entity.Property(e => e.CityName)
                .HasMaxLength(250)
                .HasColumnName("City-Name");
            entity.Property(e => e.Country).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PersonId).HasColumnName("Person_ID");
        });

        modelBuilder.Entity<Required>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("required");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
        });

        modelBuilder.Entity<RequisitionEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Requisit__3214EC27FF140FF5");

            entity.ToTable("RequisitionEntry");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FStatus).HasColumnName("F_Status");
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.RequisitionNo).HasMaxLength(255);
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Sconfirmation)
                .HasMaxLength(255)
                .HasColumnName("SConfirmation");
            entity.Property(e => e.ToolName).HasMaxLength(255);
            entity.Property(e => e.ToolType).HasMaxLength(255);
        });

        modelBuilder.Entity<ResponsibilitiesMatrixPriority>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Responsibilities_Matrix_Priority");

            entity.Property(e => e.ResponsibilityType)
                .HasMaxLength(50)
                .HasColumnName("Responsibility_type");
            entity.Property(e => e.Role).HasMaxLength(500);
        });

        modelBuilder.Entity<ResponsibilityMatrix>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Responsibility_Matrix");

            entity.Property(e => e.JrSoftwareDeveloper).HasColumnName("Jr_Software_developer");
            entity.Property(e => e.ResponsibilityType)
                .HasMaxLength(500)
                .HasColumnName("Responsibility_Type");
            entity.Property(e => e.SoftwareDeveloper).HasColumnName("Software_developer");
            entity.Property(e => e.SrSoftwareDeveloper).HasColumnName("Sr_Software_developer");
            entity.Property(e => e.TraineeDeveloper).HasColumnName("Trainee_developer");
        });

        modelBuilder.Entity<ResultDetail>(entity =>
        {
            entity.HasKey(e => e.ResultId);

            entity.ToTable("result_details");

            entity.Property(e => e.ResultId).HasColumnName("result_id");
            entity.Property(e => e.CboQuestionSets)
                .IsUnicode(false)
                .HasColumnName("cboQuestionSets");
            entity.Property(e => e.Correctans)
                .IsUnicode(false)
                .HasColumnName("correctans");
            entity.Property(e => e.Givenans)
                .IsUnicode(false)
                .HasColumnName("givenans");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.QNo).HasColumnName("qNo");
            entity.Property(e => e.Qlquestion)
                .IsUnicode(false)
                .HasColumnName("qlquestion");
            entity.Property(e => e.Result)
                .IsUnicode(false)
                .HasColumnName("result");
        });

        modelBuilder.Entity<ReturnMiscelleneousRequestTbl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.GroupId, e.LineId }).HasName("PK_ReturnMiscelleneousRequestTbl_1");

            entity.ToTable("ReturnMiscelleneousRequestTbl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("Group_id");
            entity.Property(e => e.LineId).HasColumnName("Line_id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("department_name");
            entity.Property(e => e.InitiatorId)
                .HasMaxLength(50)
                .HasColumnName("initiator_id");
            entity.Property(e => e.InitiatorName)
                .HasMaxLength(50)
                .HasColumnName("initiator_name");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsFinal).HasColumnName("is_final");
            entity.Property(e => e.IsReturn).HasColumnName("is_return");
            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .HasColumnName("purpose");
            entity.Property(e => e.RequestNo)
                .HasMaxLength(50)
                .HasColumnName("Request_no");
            entity.Property(e => e.ReturnPartDesc).HasColumnName("return_part_desc");
            entity.Property(e => e.ReturnPartNo)
                .HasMaxLength(50)
                .HasColumnName("return_part_no");
            entity.Property(e => e.ReturnQty).HasColumnName("return_qty");
            entity.Property(e => e.ReturnReqDate).HasColumnName("return_req_date");
            entity.Property(e => e.ReturnReqQty).HasColumnName("return_req_qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("uom");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.VoidResoan)
                .HasMaxLength(50)
                .HasColumnName("void_resoan");
            entity.Property(e => e.WhereUsePartNo).HasColumnName("where_use_part_no");
        });

        modelBuilder.Entity<ReturnReturnTransactionTbl>(entity =>
        {
            entity.ToTable("ReturnReturnTransactionTbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsFinal).HasColumnName("is_final");
            entity.Property(e => e.ReturnBy)
                .HasMaxLength(50)
                .HasColumnName("return_By");
            entity.Property(e => e.ReturnId).HasColumnName("Return_id");
            entity.Property(e => e.ReturnLotno)
                .HasMaxLength(50)
                .HasColumnName("return_lotno");
            entity.Property(e => e.ReturnPurpose).HasColumnName("return_purpose");
            entity.Property(e => e.ReturnReason)
                .HasMaxLength(50)
                .HasColumnName("return_reason");
            entity.Property(e => e.ReturnRefference)
                .HasMaxLength(50)
                .HasColumnName("return_refference");
            entity.Property(e => e.ReturnRemark).HasColumnName("return_remark");
            entity.Property(e => e.ReturnTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("return_timestamp");
            entity.Property(e => e.ReturnTransQty).HasColumnName("return_trans_qty");
            entity.Property(e => e.ReturnedQty).HasColumnName("returned_qty");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.VoidResoan)
                .HasMaxLength(50)
                .HasColumnName("void_resoan");
        });

        modelBuilder.Entity<RoleMst>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.RoleId }).HasName("PK_ACM_ROLE_MST_1");

            entity.ToTable("ROLE_MST");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.ActiveFromDt)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_FROM_DT");
            entity.Property(e => e.ActiveToDt)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_TO_DT");
            entity.Property(e => e.Activerole).HasColumnName("ACTIVEROLE");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.ErpTenantId).HasColumnName("ERP_TENANT_ID");
            entity.Property(e => e.RoleDesc)
                .HasMaxLength(250)
                .HasColumnName("ROLE_DESC");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("ROLE_NAME");
            entity.Property(e => e.RoleName1)
                .HasMaxLength(50)
                .HasColumnName("ROLE_NAME1");
            entity.Property(e => e.RoleName2)
                .HasMaxLength(50)
                .HasColumnName("ROLE_NAME2");
            entity.Property(e => e.Rolldate).HasColumnName("ROLLDATE");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid });

            entity.ToTable("shift");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Shift1)
                .HasMaxLength(50)
                .HasColumnName("shift");
        });

        modelBuilder.Entity<SholderImplantDatabase>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.SholderId });

            entity.ToTable("Sholder_Implant_Database");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.SholderId)
                .HasMaxLength(100)
                .HasColumnName("Sholder_ID");
            entity.Property(e => e.AnatomyReverse)
                .HasMaxLength(100)
                .HasColumnName("Anatomy_Reverse");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasColumnName("Approved_By");
            entity.Property(e => e.ApprovedByAdmin).HasColumnName("Approved_by_Admin");
            entity.Property(e => e.DeniedBy).HasColumnName("Denied_by");
            entity.Property(e => e.DeniedDate)
                .HasColumnType("datetime")
                .HasColumnName("Denied_date");
            entity.Property(e => e.DeniedReason).HasColumnName("Denied_Reason");
            entity.Property(e => e.GlenoidGlenosphere).HasColumnName("Glenoid_Glenosphere");
            entity.Property(e => e.HumeralHeads).HasColumnName("Humeral_Heads");
            entity.Property(e => e.ImplantImg)
                .HasMaxLength(500)
                .HasColumnName("implant_img");
            entity.Property(e => e.ImplantName)
                .HasMaxLength(500)
                .HasColumnName("Implant_name");
            entity.Property(e => e.InnerLip).HasColumnName("Inner_Lip");
            entity.Property(e => e.Manufacturer).HasMaxLength(500);
            entity.Property(e => e.ProximalNotchedLip).HasColumnName("Proximal_Notched_Lip");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StemAngle).HasColumnName("stem_angle");
            entity.Property(e => e.StemExtractionTechniqueASteps).HasColumnName("Stem_Extraction_Technique_A_Steps");
            entity.Property(e => e.StemExtractionTechniqueATools).HasColumnName("Stem_Extraction_Technique_A_Tools");
            entity.Property(e => e.StemExtractionTechniqueBSteps).HasColumnName("Stem_Extraction_Technique_B_Steps");
            entity.Property(e => e.StemExtractionTechniqueBTools).HasColumnName("Stem_Extraction_Technique_B_Tools");
            entity.Property(e => e.StemExtractionTechniqueCSteps).HasColumnName("Stem_Extraction_Technique_C_Steps");
            entity.Property(e => e.StemExtractionTechniqueCTools).HasColumnName("Stem_Extraction_Technique_C_Tools");
            entity.Property(e => e.StemExtractionTechniqueDSteps).HasColumnName("Stem_Extraction_Technique_D_Steps");
            entity.Property(e => e.StemExtractionTechniqueDTools).HasColumnName("Stem_Extraction_Technique_D_Tools");
            entity.Property(e => e.StemTrunnionAngle)
                .HasMaxLength(500)
                .HasColumnName("Stem_Trunnion_Angle");
            entity.Property(e => e.StepsExtractionTechniqueESteps).HasColumnName("Steps_Extraction_Technique_E_Steps");
            entity.Property(e => e.StepsExtractionTechniqueETools).HasColumnName("Steps_Extraction_Technique_E_Tools");
            entity.Property(e => e.TrinnionNew)
                .HasMaxLength(50)
                .HasColumnName("Trinnion_new");
            entity.Property(e => e.UnthreadedProximalHole).HasColumnName("Unthreaded_Proximal_Hole");
            entity.Property(e => e.UploadBy).HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<SholderImplantDatabaseHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.ShoulderId, e.HistoryId });

            entity.ToTable("Sholder_Implant_Database_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ShoulderId)
                .HasMaxLength(100)
                .HasColumnName("Shoulder_ID");
            entity.Property(e => e.HistoryId).HasColumnName("History_ID");
            entity.Property(e => e.AnatomyReverse)
                .HasMaxLength(100)
                .HasColumnName("Anatomy_Reverse");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasColumnName("Approved_By");
            entity.Property(e => e.ApprovedByAdmin).HasColumnName("Approved_by_Admin");
            entity.Property(e => e.DeniedBy).HasColumnName("Denied_by");
            entity.Property(e => e.DeniedDate)
                .HasColumnType("datetime")
                .HasColumnName("Denied_date");
            entity.Property(e => e.DeniedReason).HasColumnName("Denied_Reason");
            entity.Property(e => e.GlenoidGlenosphere).HasColumnName("Glenoid_Glenosphere");
            entity.Property(e => e.HuneralHeads).HasColumnName("Huneral_Heads");
            entity.Property(e => e.ImplantImg).HasColumnName("Implant_img");
            entity.Property(e => e.ImplantName)
                .HasMaxLength(500)
                .HasColumnName("Implant_Name");
            entity.Property(e => e.InnerLip).HasColumnName("Inner_Lip");
            entity.Property(e => e.Manufacturer).HasMaxLength(500);
            entity.Property(e => e.ProximalNotchedLip).HasColumnName("Proximal_Notched_Lip");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StemAngle).HasColumnName("stem_angle");
            entity.Property(e => e.StemExtractionTechniqueASteps).HasColumnName("Stem_Extraction_Technique_A_Steps");
            entity.Property(e => e.StemExtractionTechniqueATools).HasColumnName("Stem_Extraction_Technique_A_Tools");
            entity.Property(e => e.StemExtractionTechniqueBSteps).HasColumnName("Stem_Extraction_Technique_B_Steps");
            entity.Property(e => e.StemExtractionTechniqueBTools).HasColumnName("Stem_Extraction_Technique_B_Tools");
            entity.Property(e => e.StemExtractionTechniqueCSteps).HasColumnName("Stem_Extraction_Technique_C_Steps");
            entity.Property(e => e.StemExtractionTechniqueCTools).HasColumnName("Stem_Extraction_Technique_C_Tools");
            entity.Property(e => e.StemExtractionTechniqueDSteps).HasColumnName("Stem_Extraction_Technique_D_Steps");
            entity.Property(e => e.StemExtractionTechniqueDTools).HasColumnName("Stem_Extraction_Technique_D_Tools");
            entity.Property(e => e.StemExtractionTechniqueETools).HasColumnName("Stem_Extraction_Technique_E_Tools");
            entity.Property(e => e.StemTrunnionAngle)
                .HasMaxLength(500)
                .HasColumnName("Stem_Trunnion_angle");
            entity.Property(e => e.StemmExtractionTechniqueESteps).HasColumnName("Stemm_Extraction_Technique_E_Steps");
            entity.Property(e => e.Trunnion).HasMaxLength(50);
            entity.Property(e => e.UnthreadedProximalHole).HasColumnName("Unthreaded_Proximal_Hole");
            entity.Property(e => e.UploadBy).HasColumnName("Upload_By");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<ShopFloorEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ShopFloo__3214EC27F4659AE0");

            entity.ToTable("ShopFloorEntry");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Available).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.JobNumber).HasMaxLength(255);
            entity.Property(e => e.MachineNumber).HasMaxLength(255);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PartNumber).HasMaxLength(255);
            entity.Property(e => e.RequisitionNo).HasMaxLength(255);
            entity.Property(e => e.Rev).HasMaxLength(255);
            entity.Property(e => e.Rid).HasColumnName("RID");
            entity.Property(e => e.Status).HasColumnName("_Status");
            entity.Property(e => e.ToolName).HasMaxLength(255);
            entity.Property(e => e.ToolType).HasMaxLength(255);
        });

        modelBuilder.Entity<ShoulderImplantDatabaseNew>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.ShoulderId });

            entity.ToTable("Shoulder_Implant_Database_New");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ShoulderId)
                .HasMaxLength(100)
                .HasColumnName("Shoulder_ID");
            entity.Property(e => e.AnatomicReverse)
                .HasMaxLength(500)
                .HasColumnName("Anatomic_Reverse");
            entity.Property(e => e.GlenoidGlenosphere).HasColumnName("Glenoid_Glenosphere");
            entity.Property(e => e.HuneralHeads).HasColumnName("Huneral_Heads");
            entity.Property(e => e.ImplantName).HasColumnName("Implant_Name");
            entity.Property(e => e.InnerLip).HasColumnName("Inner_Lip");
            entity.Property(e => e.ProximalFalsetchedLip).HasColumnName("Proximal_Falsetched_Lip");
            entity.Property(e => e.StemExtractionTechniqueASteps).HasColumnName("Stem_Extraction_Technique_A_Steps");
            entity.Property(e => e.StemExtractionTechniqueATools).HasColumnName("Stem_Extraction_Technique_A_Tools");
            entity.Property(e => e.StemExtractionTechniqueBSteps).HasColumnName("Stem_Extraction_Technique_B_Steps");
            entity.Property(e => e.StemExtractionTechniqueBTools).HasColumnName("Stem_Extraction_Technique_B_Tools");
            entity.Property(e => e.StemExtractionTechniqueCSteps).HasColumnName("Stem_Extraction_Technique_C_Steps");
            entity.Property(e => e.StemExtractionTechniqueCTools).HasColumnName("Stem_Extraction_Technique_C_Tools");
            entity.Property(e => e.StemExtractionTechniqueDSteps).HasColumnName("Stem_Extraction_Technique_D_Steps");
            entity.Property(e => e.StemExtractionTechniqueDTools).HasColumnName("Stem_Extraction_Technique_D_Tools");
            entity.Property(e => e.StemExtractionTechniqueESteps).HasColumnName("Stem_Extraction_Technique_E_Steps");
            entity.Property(e => e.StemExtractionTechniqueETools).HasColumnName("Stem_Extraction_Technique_E_Tools");
            entity.Property(e => e.StemTrunnionAngle)
                .HasMaxLength(500)
                .HasColumnName("Stem_Trunnion_Angle");
            entity.Property(e => e.Trunnion).HasMaxLength(500);
            entity.Property(e => e.UnthreadedProximalHole).HasColumnName("Unthreaded_proximal_hole");
        });

        modelBuilder.Entity<ShoulderImplantImage>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Shoulder_implant_Images");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.PartDescription).HasColumnName("Part_description");
            entity.Property(e => e.PartImage).HasColumnName("part_image");
            entity.Property(e => e.PartName)
                .HasMaxLength(500)
                .HasColumnName("Part_name");
        });

        modelBuilder.Entity<ShoulderImplantImagesDesc>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("Shoulder_Implant_Images_desc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ImplantId)
                .HasMaxLength(100)
                .HasColumnName("Implant_ID");
            entity.Property(e => e.ImplantImage).HasColumnName("Implant_Image");
            entity.Property(e => e.ImplantName).HasColumnName("Implant_Name");
        });

        modelBuilder.Entity<ShoulderImplantMaster>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.Refid });

            entity.ToTable("Shoulder_Implant_Master");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ManufacturerName).HasColumnName("Manufacturer_Name");
            entity.Property(e => e.RefType).HasColumnName("Ref_Type");
            entity.Property(e => e.RerSubType).HasColumnName("Rer_Sub_Type");
        });

        modelBuilder.Entity<ShoulderImplantTechnique>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Shoulder_Implant_Technique");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
        });

        modelBuilder.Entity<Signature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Signatur__3214EC07B6C9D00C");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.InitialId).HasColumnName("Initial_ID");
            entity.Property(e => e.Initials).HasMaxLength(10);
            entity.Property(e => e.SignatureId).HasMaxLength(50);
            entity.Property(e => e.SignatureText).HasMaxLength(500);
        });

        modelBuilder.Entity<SswAppliance>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("SSW_Appliances");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Refname1).HasColumnName("refname1");
            entity.Property(e => e.Subrefname).HasColumnName("subrefname");
        });

        modelBuilder.Entity<SswApplianceForReference>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.TypeOfAppliance });

            entity.ToTable("ssw_appliance_for_reference");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.TypeOfAppliance)
                .HasMaxLength(100)
                .HasColumnName("Type_of_Appliance");
            entity.Property(e => e.ApplianceId).HasColumnName("Appliance_ID");
            entity.Property(e => e.ApplianceName).HasColumnName("Appliance_name");
            entity.Property(e => e.ApplianceNumber)
                .HasMaxLength(100)
                .HasColumnName("Appliance_Number");
            entity.Property(e => e.ApplianceSourceId).HasColumnName("Appliance_source_ID");
            entity.Property(e => e.ApplianceType).HasColumnName("Appliance_Type");
            entity.Property(e => e.CalibrationDate)
                .HasColumnType("datetime")
                .HasColumnName("calibration_date");
            entity.Property(e => e.CalibrationReport).HasColumnName("calibration_report");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.HandoverDate)
                .HasColumnType("datetime")
                .HasColumnName("handover_date");
            entity.Property(e => e.HandoverTo).HasColumnName("handover_to");
            entity.Property(e => e.InstallmentDate)
                .HasColumnType("datetime")
                .HasColumnName("installment_date");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .HasColumnName("IP");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.ItemImage).HasColumnName("Item_Image");
            entity.Property(e => e.KeyboardMouse)
                .HasMaxLength(100)
                .HasColumnName("keyboard_Mouse");
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.MacAddress)
                .HasMaxLength(500)
                .HasColumnName("MAC_Address");
            entity.Property(e => e.MountStand)
                .HasMaxLength(100)
                .HasColumnName("mount_stand");
            entity.Property(e => e.NextCalibrationDate)
                .HasColumnType("datetime")
                .HasColumnName("next_calibration_date");
            entity.Property(e => e.OtherDetail).HasColumnName("other_detail");
            entity.Property(e => e.PcConfiguration).HasColumnName("PC_Configuration");
            entity.Property(e => e.PurchaseDate)
                .HasColumnType("datetime")
                .HasColumnName("purchase_date");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
            entity.Property(e => e.WindowVersion)
                .HasMaxLength(200)
                .HasColumnName("Window_Version");
        });

        modelBuilder.Entity<SswAppliancesMain>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.Sid, e.TypeOfAppliance }).HasName("PK_SSW_Appliances_Main_1");

            entity.ToTable("SSW_Appliances_Main");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.TypeOfAppliance)
                .HasMaxLength(100)
                .HasColumnName("Type_of_appliance");
            entity.Property(e => e.Active).HasMaxLength(2);
            entity.Property(e => e.ApplianceName).HasColumnName("Appliance_Name");
            entity.Property(e => e.ApplianceNumber)
                .HasMaxLength(100)
                .HasColumnName("Appliance_Number");
            entity.Property(e => e.ApplianceSubType).HasColumnName("Appliance_Sub_Type");
            entity.Property(e => e.ApplianceType).HasColumnName("Appliance_Type");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .HasColumnName("IP");
            entity.Property(e => e.ItemImage)
                .HasMaxLength(200)
                .HasColumnName("Item_image");
            entity.Property(e => e.KeyboardMouse)
                .HasMaxLength(100)
                .HasColumnName("Keyboard_Mouse");
            entity.Property(e => e.Location).HasMaxLength(500);
            entity.Property(e => e.MacAddress)
                .HasMaxLength(500)
                .HasColumnName("MAC_Address");
            entity.Property(e => e.MountStand)
                .HasMaxLength(100)
                .HasColumnName("mount_stand");
            entity.Property(e => e.OtherDetail).HasColumnName("other_detail");
            entity.Property(e => e.PcConfiguration).HasColumnName("PC_Configuration");
            entity.Property(e => e.WindowVersion)
                .HasMaxLength(200)
                .HasColumnName("Window_Version");
        });

        modelBuilder.Entity<SswAppliancesMainAdded>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.TypeOfAppliance }).HasName("PK_SSW_Appliances_Main");

            entity.ToTable("SSW_Appliances_Main_added");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.TypeOfAppliance)
                .HasMaxLength(100)
                .HasColumnName("Type_of_appliance");
            entity.Property(e => e.Active).HasMaxLength(2);
            entity.Property(e => e.ApplianceName).HasColumnName("Appliance_Name");
            entity.Property(e => e.ApplianceNumber)
                .HasMaxLength(100)
                .HasColumnName("Appliance_Number");
            entity.Property(e => e.ApplianceSubType).HasColumnName("Appliance_sub_type");
            entity.Property(e => e.ApplianceType).HasColumnName("Appliance_type");
            entity.Property(e => e.DesktopPhone)
                .HasMaxLength(50)
                .HasColumnName("Desktop_Phone");
            entity.Property(e => e.Hall).HasMaxLength(50);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .HasColumnName("IP");
            entity.Property(e => e.KeyboardMouse)
                .HasMaxLength(100)
                .HasColumnName("Keyboard_Mouse");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(500)
                .HasColumnName("MAC_Address");
            entity.Property(e => e.MonitorDetail).HasColumnName("monitor_detail");
            entity.Property(e => e.MountStand)
                .HasMaxLength(100)
                .HasColumnName("mount_stand");
            entity.Property(e => e.PcConfiguration).HasColumnName("PC_configuration");
            entity.Property(e => e.WindowVersion)
                .HasMaxLength(200)
                .HasColumnName("Window_version");
        });

        modelBuilder.Entity<SswVacancy>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid });

            entity.ToTable("SSW_Vacancy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ApplicantEmail).HasColumnName("Applicant_email");
            entity.Property(e => e.ApplicantMobile).HasColumnName("Applicant_Mobile");
            entity.Property(e => e.ApplicantName).HasColumnName("Applicant_name");
            entity.Property(e => e.ApplicantPosition).HasColumnName("Applicant_Position");
        });

        modelBuilder.Entity<SswhiteGallery>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.ImageId, e.Id });

            entity.ToTable("sswhite_gallery");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ATitle)
                .HasMaxLength(50)
                .HasColumnName("aTitle");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .HasColumnName("image");
            entity.Property(e => e.ImageName)
                .HasMaxLength(500)
                .HasColumnName("image_name");
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<StudentDatum>(entity =>
        {
            entity.ToTable("Student_Data");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Rollno)
                .HasMaxLength(100)
                .HasColumnName("rollno");
            entity.Property(e => e.Standard)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("standard");
            entity.Property(e => e.StudentName)
                .HasMaxLength(500)
                .HasColumnName("student_name");
            entity.Property(e => e.TeacherName)
                .HasMaxLength(500)
                .HasColumnName("Teacher_Name");
        });

        modelBuilder.Entity<SupervisorRecord>(entity =>
        {
            entity.ToTable("Supervisor_Record");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.HigherAuth).HasMaxLength(50);
            entity.Property(e => e.IdName)
                .HasMaxLength(50)
                .HasColumnName("id_name");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<SuppEmail>(entity =>
        {
            entity.ToTable("supp_email");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.SuppEmail1).HasColumnName("Supp_email");
            entity.Property(e => e.SuppName).HasColumnName("supp_name");
        });

        modelBuilder.Entity<SupplierDataNew>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Sid });

            entity.ToTable("Supplier_Data_new");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Sid)
                .HasMaxLength(50)
                .HasColumnName("SID");
            entity.Property(e => e.SuppAdd).HasColumnName("Supp_Add");
            entity.Property(e => e.SuppEmail)
                .HasMaxLength(500)
                .HasColumnName("Supp_email");
            entity.Property(e => e.SuppGst)
                .HasMaxLength(500)
                .HasColumnName("Supp_gst");
            entity.Property(e => e.SuppMob)
                .HasMaxLength(50)
                .HasColumnName("Supp_mob");
            entity.Property(e => e.SuppName).HasColumnName("Supp_Name");
        });

        modelBuilder.Entity<SupplierDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.SuppId });

            entity.ToTable("Supplier_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.SuppId)
                .HasMaxLength(100)
                .HasColumnName("Supp_ID");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.EmailId).HasColumnName("email_Id");
            entity.Property(e => e.GstNo).HasColumnName("GST_No");
            entity.Property(e => e.PanNo).HasColumnName("Pan_no");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.SuppAdd1).HasColumnName("Supp_Add1");
            entity.Property(e => e.SuppAdd2).HasColumnName("Supp_Add2");
            entity.Property(e => e.SuppAdd3).HasColumnName("Supp_Add3");
            entity.Property(e => e.SuppName).HasColumnName("Supp_Name");
        });

        modelBuilder.Entity<SupplierMaster>(entity =>
        {
            entity.ToTable("Supplier_master");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddOne).HasColumnName("add_one");
            entity.Property(e => e.AddThree).HasColumnName("add_three");
            entity.Property(e => e.AddTwo).HasColumnName("add_two");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AutoSuppId).HasColumnName("auto_supp_id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.EmailId).HasColumnName("email_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.GstId).HasColumnName("gst_id");
            entity.Property(e => e.InsertTime).HasColumnName("insert_time");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.ItemSupplied).HasColumnName("item_supplied");
            entity.Property(e => e.ManualSuppId).HasColumnName("manual_supp_id");
            entity.Property(e => e.PanNo).HasColumnName("pan_no");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.SuppName).HasColumnName("supp_name");
            entity.Property(e => e.TaxId).HasColumnName("tax_id");
        });

        modelBuilder.Entity<SupplierNewDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.SupplierId });

            entity.ToTable("Supplier_New_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(100)
                .HasColumnName("Supplier_ID");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.EmailId)
                .HasMaxLength(500)
                .HasColumnName("email_id");
            entity.Property(e => e.Gstin).HasColumnName("GSTIN");
            entity.Property(e => e.Phone)
                .HasMaxLength(500)
                .HasColumnName("phone");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.RegisterType).HasColumnName("Register_Type");
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.SuppAdd1).HasColumnName("Supp_add1");
            entity.Property(e => e.SuppAdd2).HasColumnName("Supp_add2");
            entity.Property(e => e.SuppAdd3).HasColumnName("Supp_add3");
            entity.Property(e => e.SuppName).HasColumnName("Supp_name");
        });

        modelBuilder.Entity<TaskManagementTrial>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.TaskId });

            entity.ToTable("Task_Management_Trial");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.TaskId)
                .HasMaxLength(100)
                .HasColumnName("taskID");
            entity.Property(e => e.TaskAssigned)
                .HasMaxLength(500)
                .HasColumnName("Task_Assigned");
            entity.Property(e => e.TaskDate)
                .HasColumnType("datetime")
                .HasColumnName("Task_Date");
            entity.Property(e => e.TaskHour)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Task_hour");
            entity.Property(e => e.TaskName).HasColumnName("Task_Name");
            entity.Property(e => e.TaskRemark).HasColumnName("Task_Remark");
        });

        modelBuilder.Entity<TaskManagementTrialSecondary>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.TaskId, e.AssignId });

            entity.ToTable("Task_Management_Trial_Secondary");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.TaskId)
                .HasMaxLength(100)
                .HasColumnName("Task_ID");
            entity.Property(e => e.AssignId)
                .HasMaxLength(100)
                .HasColumnName("Assign_ID");
            entity.Property(e => e.TaskAssigned)
                .HasMaxLength(500)
                .HasColumnName("Task_Assigned");
            entity.Property(e => e.TaskDate)
                .HasColumnType("datetime")
                .HasColumnName("Task_Date");
            entity.Property(e => e.TaskEndDate).HasColumnName("task_end_date");
            entity.Property(e => e.TaskEndTime)
                .HasMaxLength(50)
                .HasColumnName("task_end_time");
            entity.Property(e => e.TaskHour)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Task_Hour");
            entity.Property(e => e.TaskName).HasColumnName("Task_Name");
            entity.Property(e => e.TaskStartDate).HasColumnName("task_start_date");
            entity.Property(e => e.TaskStartTime)
                .HasMaxLength(50)
                .HasColumnName("task_start_time");
            entity.Property(e => e.TaskStatus)
                .HasMaxLength(50)
                .HasColumnName("task_status");
        });

        modelBuilder.Entity<TblAudit>(entity =>
        {
            entity.HasKey(e => new { e.TenantId, e.CrupId, e.MySerial, e.AuditNo }).HasName("PK_Audit");

            entity.ToTable("tblAudit");

            entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.AuditNo).ValueGeneratedOnAdd();
            entity.Property(e => e.AuditType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUserName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TableName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateUserName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCityStatesCounty>(entity =>
        {
            entity.HasKey(e => new { e.CityId, e.StateId, e.Countryid });

            entity.ToTable("tblCityStatesCounty");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");
            entity.Property(e => e.Active1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACTIVE1");
            entity.Property(e => e.Active2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACTIVE2");
            entity.Property(e => e.AssignedRoute).HasMaxLength(50);
            entity.Property(e => e.CityArabic).HasMaxLength(250);
            entity.Property(e => e.CityEnglish).HasMaxLength(250);
            entity.Property(e => e.CityOther).HasMaxLength(250);
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.LandLine).HasMaxLength(20);
            entity.Property(e => e.Shortcode)
                .HasMaxLength(50)
                .HasColumnName("SHORTCODE");
            entity.Property(e => e.SynId).HasColumnName("SynID");
            entity.Property(e => e.SyncDate).HasColumnType("datetime");
            entity.Property(e => e.Syncby).HasMaxLength(50);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.Uploadby).HasMaxLength(50);
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .HasColumnName("ZONE");
        });

        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.Countryid });

            entity.ToTable("tblCOUNTRY");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Capital)
                .HasMaxLength(50)
                .HasColumnName("CAPITAL");
            entity.Property(e => e.Couname1)
                .HasMaxLength(50)
                .HasColumnName("COUNAME1");
            entity.Property(e => e.Couname2)
                .HasMaxLength(50)
                .HasColumnName("COUNAME2");
            entity.Property(e => e.Couname3)
                .HasMaxLength(50)
                .HasColumnName("COUNAME3");
            entity.Property(e => e.CountryTsubType)
                .HasMaxLength(50)
                .HasColumnName("CountryTSubType");
            entity.Property(e => e.CountryType).HasMaxLength(30);
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.Currencyname1)
                .HasMaxLength(50)
                .HasColumnName("CURRENCYNAME1");
            entity.Property(e => e.Currencyname2)
                .HasMaxLength(50)
                .HasColumnName("CURRENCYNAME2");
            entity.Property(e => e.Currencyname3)
                .HasMaxLength(50)
                .HasColumnName("CURRENCYNAME3");
            entity.Property(e => e.Currencyshortname1)
                .HasMaxLength(50)
                .HasColumnName("CURRENCYSHORTNAME1");
            entity.Property(e => e.Currencyshortname2)
                .HasMaxLength(50)
                .HasColumnName("CURRENCYSHORTNAME2");
            entity.Property(e => e.Currencyshortname3)
                .HasMaxLength(50)
                .HasColumnName("CURRENCYSHORTNAME3");
            entity.Property(e => e.Currentconvrate)
                .HasColumnType("numeric(8, 5)")
                .HasColumnName("CURRENTCONVRATE");
            entity.Property(e => e.IanacountryCodeTld)
                .HasMaxLength(50)
                .HasColumnName("IANACountryCodeTLD");
            entity.Property(e => e.Iso316612letterCode)
                .HasMaxLength(50)
                .HasColumnName("ISO3166_1_2LetterCode");
            entity.Property(e => e.Iso316613letterCode)
                .HasMaxLength(10)
                .HasColumnName("ISO3166_1_3LetterCode");
            entity.Property(e => e.Iso31661number)
                .HasMaxLength(50)
                .HasColumnName("ISO3166_1Number");
            entity.Property(e => e.Iso4217curCode)
                .HasMaxLength(30)
                .HasColumnName("ISO4217CurCode");
            entity.Property(e => e.Iso4217curName)
                .HasMaxLength(50)
                .HasColumnName("ISO4217CurName");
            entity.Property(e => e.ItuttelephoneCode)
                .HasMaxLength(10)
                .HasColumnName("ITUTTelephoneCode");
            entity.Property(e => e.Nationality1)
                .HasMaxLength(50)
                .HasColumnName("NATIONALITY1");
            entity.Property(e => e.Nationality2)
                .HasMaxLength(50)
                .HasColumnName("NATIONALITY2");
            entity.Property(e => e.Nationality3)
                .HasMaxLength(50)
                .HasColumnName("NATIONALITY3");
            entity.Property(e => e.Region1)
                .HasMaxLength(50)
                .HasColumnName("REGION1");
            entity.Property(e => e.Sovereignty).HasMaxLength(50);
            entity.Property(e => e.SynId).HasColumnName("SynID");
            entity.Property(e => e.SyncDate).HasColumnType("datetime");
            entity.Property(e => e.Syncby).HasColumnType("text");
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.Uploadby).HasColumnType("text");
        });

        modelBuilder.Entity<TblFile>(entity =>
        {
            entity.ToTable("tblFiles");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FileName).HasMaxLength(50);
            entity.Property(e => e.FilePath).HasMaxLength(500);
        });

        modelBuilder.Entity<Tblbin>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.BinId })
                .HasName("PK_TBLGROUP2")
                .IsClustered(false);

            entity.ToTable("TBLBIN");

            entity.Property(e => e.TenentId)
                .HasDefaultValue(1)
                .HasColumnName("TenentID");
            entity.Property(e => e.BinId).HasColumnName("BIN_ID");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Bindesc1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BINDesc1");
            entity.Property(e => e.Bindesc2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BINDesc2");
            entity.Property(e => e.Binremarks)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BINRemarks");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.MyComLocId).HasColumnName("MyComLocID");
        });

        modelBuilder.Entity<Tblcontact>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.ContactMyId });

            entity.ToTable("TBLCONTACT");

            entity.Property(e => e.TenentId)
                .HasDefaultValue(1)
                .HasColumnName("TenentID");
            entity.Property(e => e.ContactMyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ContactMyID");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Addr1).HasColumnName("ADDR1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(100)
                .HasColumnName("ADDR2");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .HasColumnName("BARCODE");
            entity.Property(e => e.Busphone1)
                .HasMaxLength(24)
                .HasColumnName("BUSPHONE1");
            entity.Property(e => e.Buyer).HasColumnName("BUYER");
            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Cattype)
                .HasMaxLength(3)
                .HasColumnName("CATTYPE");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .HasColumnName("CITY");
            entity.Property(e => e.CivilId)
                .HasMaxLength(30)
                .HasColumnName("CivilID");
            entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
            entity.Property(e => e.Contactid)
                .HasDefaultValue(1)
                .HasColumnName("CONTACTID");
            entity.Property(e => e.Countryid)
                .HasDefaultValue(126)
                .HasColumnName("COUNTRYID");
            entity.Property(e => e.Cpasswrd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CPASSWRD");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.Cuserid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSERID");
            entity.Property(e => e.Deserial)
                .HasMaxLength(25)
                .HasColumnName("DESERIAL");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .HasColumnName("device_id");
            entity.Property(e => e.Email1)
                .HasMaxLength(30)
                .HasColumnName("EMAIL1");
            entity.Property(e => e.Email2)
                .HasMaxLength(50)
                .HasColumnName("EMAIL2");
            entity.Property(e => e.Emailsubdate)
                .HasColumnType("datetime")
                .HasColumnName("EMAILSUBDATE");
            entity.Property(e => e.Emaisub).HasColumnName("EMAISUB");
            entity.Property(e => e.Entrytime)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYTIME");
            entity.Property(e => e.FaxId)
                .HasMaxLength(50)
                .HasColumnName("FaxID");
            entity.Property(e => e.FbTokenId)
                .HasMaxLength(50)
                .HasColumnName("fb_token_id");
            entity.Property(e => e.Freelancer).HasColumnName("FREELANCER");
            entity.Property(e => e.GoogleTokenId)
                .HasMaxLength(50)
                .HasColumnName("google_token_id");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.Img).HasColumnName("IMG");
            entity.Property(e => e.Inhawally).HasColumnName("INHAWALLY");
            entity.Property(e => e.InstuctorUsername)
                .HasMaxLength(50)
                .HasColumnName("Instuctor_Username");
            entity.Property(e => e.Issmb).HasColumnName("ISSMB");
            entity.Property(e => e.Itmanager)
                .HasMaxLength(150)
                .HasColumnName("ITMANAGER");
            entity.Property(e => e.Mobphone)
                .HasMaxLength(30)
                .HasColumnName("MOBPHONE");
            entity.Property(e => e.Mycatsubid).HasColumnName("MYCATSUBID");
            entity.Property(e => e.Myconlocid).HasColumnName("MYCONLOCID");
            entity.Property(e => e.Myprodid)
                .HasMaxLength(20)
                .HasColumnName("MYPRODID");
            entity.Property(e => e.Paci)
                .HasMaxLength(50)
                .HasColumnName("PACI");
            entity.Property(e => e.PersName1).HasMaxLength(100);
            entity.Property(e => e.PersName2).HasMaxLength(100);
            entity.Property(e => e.PersName3).HasMaxLength(100);
            entity.Property(e => e.Persname)
                .HasMaxLength(50)
                .HasColumnName("PERSNAME");
            entity.Property(e => e.Persnameo)
                .HasMaxLength(50)
                .HasColumnName("PERSNAMEO");
            entity.Property(e => e.Persnameo2)
                .HasMaxLength(50)
                .HasColumnName("PERSNAMEO2");
            entity.Property(e => e.Physicallocid)
                .HasMaxLength(10)
                .HasDefaultValue("KWT")
                .HasColumnName("PHYSICALLOCID");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(40)
                .HasColumnName("POSTALCODE");
            entity.Property(e => e.Primlanguge)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PRIMLANGUGE");
            entity.Property(e => e.Productdealin)
                .HasMaxLength(255)
                .HasColumnName("PRODUCTDEALIN");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Saledeprod).HasColumnName("SALEDEPROD");
            entity.Property(e => e.Saler).HasColumnName("SALER");
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .HasColumnName("STATE");
            entity.Property(e => e.Subcatid).HasColumnName("SUBCATID");
            entity.Property(e => e.Subcattype)
                .HasMaxLength(3)
                .HasColumnName("SUBCATTYPE");
            entity.Property(e => e.Switch1).HasDefaultValue(0);
            entity.Property(e => e.Switch2).HasDefaultValue(0);
            entity.Property(e => e.Switch3).HasDefaultValue(0);
            entity.Property(e => e.Switch4).HasDefaultValue(0);
            entity.Property(e => e.Switch5)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.SynId).HasColumnName("SynID");
            entity.Property(e => e.SyncDate).HasColumnType("datetime");
            entity.Property(e => e.Syncby).HasMaxLength(50);
            entity.Property(e => e.Updttime)
                .HasColumnType("datetime")
                .HasColumnName("UPDTTIME");
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.Uploadby).HasMaxLength(50);
            entity.Property(e => e.Userid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID");
            entity.Property(e => e.Webpage)
                .HasMaxLength(150)
                .HasColumnName("WEBPAGE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(10)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<TbllabelDtl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TBLLabelDTLn");

            entity.ToTable("TBLLabelDTL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.FieldName).HasMaxLength(50);
            entity.Property(e => e.LabelId)
                .HasMaxLength(50)
                .HasColumnName("LabelID");
            entity.Property(e => e.LabelMstId)
                .HasMaxLength(50)
                .HasColumnName("LabelMstID");
            entity.Property(e => e.LabelName).HasMaxLength(100);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Langdisp)
                .HasMaxLength(5)
                .HasColumnName("LANGDISP");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
        });

        modelBuilder.Entity<TbllabelMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TBLLabelMSTn");

            entity.ToTable("TBLLabelMST");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.MySysName).HasMaxLength(3);
            entity.Property(e => e.PageName).HasMaxLength(50);
            entity.Property(e => e.PageTitle).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Updated).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Tbllocation>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.Locationid });

            entity.ToTable("TBLLOCATION");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");
            entity.Property(e => e.Account)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.Dept)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("DEPT");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Entrytime)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYTIME");
            entity.Property(e => e.Locname)
                .HasMaxLength(50)
                .HasColumnName("LOCNAME");
            entity.Property(e => e.Locname1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCNAME1");
            entity.Property(e => e.Locname2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCNAME2");
            entity.Property(e => e.Locname3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCNAME3");
            entity.Property(e => e.Locnamech)
                .HasMaxLength(50)
                .HasColumnName("LOCNAMECH");
            entity.Property(e => e.Locnameo)
                .HasMaxLength(50)
                .HasColumnName("LOCNAMEO");
            entity.Property(e => e.Maxdiscount).HasColumnName("MAXDISCOUNT");
            entity.Property(e => e.Physicallocid)
                .HasMaxLength(10)
                .HasColumnName("PHYSICALLOCID");
            entity.Property(e => e.Sectioncode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SECTIONCODE");
            entity.Property(e => e.SynId).HasColumnName("SynID");
            entity.Property(e => e.SyncDate).HasColumnType("datetime");
            entity.Property(e => e.Syncby).HasMaxLength(50);
            entity.Property(e => e.Updttime)
                .HasColumnType("datetime")
                .HasColumnName("UPDTTIME");
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.Uploadby).HasMaxLength(50);
            entity.Property(e => e.Userid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID");
        });

        modelBuilder.Entity<TempUser>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.Privilageid, e.Privilagesource, e.Menuid, e.LocationId }).HasName("PK_ACM_tempUser");

            entity.ToTable("tempUser");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.Privilageid).HasColumnName("PRIVILAGEID");
            entity.Property(e => e.Privilagesource)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("PRIVILAGESOURCE");
            entity.Property(e => e.Menuid).HasColumnName("MENUID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Activemenu).HasColumnName("ACTIVEMENU");
            entity.Property(e => e.Activemodule).HasColumnName("ACTIVEMODULE");
            entity.Property(e => e.Activeprivilage).HasColumnName("ACTIVEPRIVILAGE");
            entity.Property(e => e.Activerole).HasColumnName("ACTIVEROLE");
            entity.Property(e => e.Activetilldate).HasColumnName("ACTIVETILLDATE");
            entity.Property(e => e.AddFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ADD_FLAG");
            entity.Property(e => e.AllFlag)
                .HasMaxLength(50)
                .HasColumnName("ALL_FLAG");
            entity.Property(e => e.Amiglobale).HasColumnName("AMIGLOBALE");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.DeleteFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DELETE_FLAG");
            entity.Property(e => e.DocParent)
                .HasMaxLength(50)
                .HasColumnName("DOC_PARENT");
            entity.Property(e => e.Footerinvisibledata).HasColumnName("FOOTERINVISIBLEDATA");
            entity.Property(e => e.Footervisibledata).HasColumnName("FOOTERVISIBLEDATA");
            entity.Property(e => e.Headerinvisibledata).HasColumnName("HEADERINVISIBLEDATA");
            entity.Property(e => e.Headervisibledata).HasColumnName("HEADERVISIBLEDATA");
            entity.Property(e => e.Iconpath)
                .HasMaxLength(500)
                .HasColumnName("ICONPATH");
            entity.Property(e => e.Link)
                .HasMaxLength(500)
                .HasColumnName("LINK");
            entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");
            entity.Property(e => e.MenuLocation)
                .HasMaxLength(50)
                .HasColumnName("MENU_LOCATION");
            entity.Property(e => e.MenuName1)
                .HasMaxLength(100)
                .HasColumnName("MENU_NAME1");
            entity.Property(e => e.MenuName2)
                .HasMaxLength(100)
                .HasColumnName("MENU_NAME2");
            entity.Property(e => e.MenuName3)
                .HasMaxLength(500)
                .HasColumnName("MENU_NAME3");
            entity.Property(e => e.MenuOrder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MENU_ORDER");
            entity.Property(e => e.MenuType)
                .HasMaxLength(100)
                .HasColumnName("MENU_TYPE");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(150)
                .HasColumnName("METADESCRIPTION");
            entity.Property(e => e.Metakeyword)
                .HasMaxLength(50)
                .HasColumnName("METAKEYWORD");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(50)
                .HasColumnName("METATITLE");
            entity.Property(e => e.ModifyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MODIFY_FLAG");
            entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");
            entity.Property(e => e.Mybusid)
                .HasComment("This is come from MYBUS Table")
                .HasColumnName("MYBUSID");
            entity.Property(e => e.Mypersonal).HasColumnName("MYPERSONAL");
            entity.Property(e => e.Printflage).HasColumnName("PRINTFLAGE");
            entity.Property(e => e.PrivilageMenuid).HasColumnName("PRIVILAGE_MENUID");
            entity.Property(e => e.Refid)
                .HasComment("This is come from REF Table where retype or sub == domain")
                .HasColumnName("REFID");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.Smalltext)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMALLTEXT");
            entity.Property(e => e.Sp1)
                .HasDefaultValue(0)
                .HasColumnName("SP1");
            entity.Property(e => e.Sp1name)
                .HasMaxLength(150)
                .HasColumnName("SP1Name");
            entity.Property(e => e.Sp2)
                .HasDefaultValue(0)
                .HasColumnName("SP2");
            entity.Property(e => e.Sp2name)
                .HasMaxLength(150)
                .HasColumnName("SP2Name");
            entity.Property(e => e.Sp3)
                .HasDefaultValue(0)
                .HasColumnName("SP3");
            entity.Property(e => e.Sp3name)
                .HasMaxLength(150)
                .HasColumnName("SP3Name");
            entity.Property(e => e.Sp4)
                .HasDefaultValue(0)
                .HasColumnName("SP4");
            entity.Property(e => e.Sp4name)
                .HasMaxLength(150)
                .HasColumnName("SP4Name");
            entity.Property(e => e.Sp5)
                .HasDefaultValue(0)
                .HasColumnName("SP5");
            entity.Property(e => e.Sp5name)
                .HasMaxLength(150)
                .HasColumnName("SP5Name");
            entity.Property(e => e.UraddFlag).HasColumnName("URADD_FLAG");
            entity.Property(e => e.UrallFlag).HasColumnName("URALL_FLAG");
            entity.Property(e => e.UrdeleteFlag).HasColumnName("URDELETE_FLAG");
            entity.Property(e => e.Urlrewrite)
                .HasMaxLength(500)
                .HasColumnName("URLREWRITE");
            entity.Property(e => e.UrmodifyFlag).HasColumnName("URMODIFY_FLAG");
            entity.Property(e => e.UrviewFlag).HasColumnName("URVIEW_FLAG");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ViewFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VIEW_FLAG");
        });

        modelBuilder.Entity<TempUser1>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.Privilageid, e.Menuid, e.LocationId, e.UserId, e.RoleId }).HasName("PK_tempUser1_1");

            entity.ToTable("tempUser1");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.Privilageid).HasColumnName("PRIVILAGEID");
            entity.Property(e => e.Menuid).HasColumnName("MENUID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.Activemenu).HasColumnName("ACTIVEMENU");
            entity.Property(e => e.Activemodule).HasColumnName("ACTIVEMODULE");
            entity.Property(e => e.Activeprivilage).HasColumnName("ACTIVEPRIVILAGE");
            entity.Property(e => e.Activerole).HasColumnName("ACTIVEROLE");
            entity.Property(e => e.Activetenent).HasColumnName("ACTIVETENENT");
            entity.Property(e => e.Activetilldate).HasColumnName("ACTIVETILLDATE");
            entity.Property(e => e.Activeuser).HasColumnName("ACTIVEUSER");
            entity.Property(e => e.AddFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ADD_FLAG");
            entity.Property(e => e.AllFlag)
                .HasMaxLength(50)
                .HasColumnName("ALL_FLAG");
            entity.Property(e => e.Amiglobale).HasColumnName("AMIGLOBALE");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.DeleteFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DELETE_FLAG");
            entity.Property(e => e.DocParent)
                .HasMaxLength(50)
                .HasColumnName("DOC_PARENT");
            entity.Property(e => e.Footerinvisibledata).HasColumnName("FOOTERINVISIBLEDATA");
            entity.Property(e => e.Footervisibledata).HasColumnName("FOOTERVISIBLEDATA");
            entity.Property(e => e.Headerinvisibledata).HasColumnName("HEADERINVISIBLEDATA");
            entity.Property(e => e.Headervisibledata).HasColumnName("HEADERVISIBLEDATA");
            entity.Property(e => e.Iconpath)
                .HasMaxLength(500)
                .HasColumnName("ICONPATH");
            entity.Property(e => e.Link)
                .HasMaxLength(500)
                .HasColumnName("LINK");
            entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");
            entity.Property(e => e.MenuLocation)
                .HasMaxLength(50)
                .HasColumnName("MENU_LOCATION");
            entity.Property(e => e.MenuName1)
                .HasMaxLength(100)
                .HasColumnName("MENU_NAME1");
            entity.Property(e => e.MenuName2)
                .HasMaxLength(100)
                .HasColumnName("MENU_NAME2");
            entity.Property(e => e.MenuName3)
                .HasMaxLength(500)
                .HasColumnName("MENU_NAME3");
            entity.Property(e => e.MenuOrder)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MENU_ORDER");
            entity.Property(e => e.MenuType)
                .HasMaxLength(100)
                .HasColumnName("MENU_TYPE");
            entity.Property(e => e.Menudate).HasColumnName("MENUDATE");
            entity.Property(e => e.Metadescription)
                .HasMaxLength(150)
                .HasColumnName("METADESCRIPTION");
            entity.Property(e => e.Metakeyword)
                .HasMaxLength(50)
                .HasColumnName("METAKEYWORD");
            entity.Property(e => e.Metatitle)
                .HasMaxLength(50)
                .HasColumnName("METATITLE");
            entity.Property(e => e.ModifyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MODIFY_FLAG");
            entity.Property(e => e.ModuleId).HasColumnName("MODULE_ID");
            entity.Property(e => e.Moduledate).HasColumnName("MODULEDATE");
            entity.Property(e => e.Mybusid).HasColumnName("MYBUSID");
            entity.Property(e => e.Mypersonal).HasColumnName("MYPERSONAL");
            entity.Property(e => e.Printflage).HasColumnName("PRINTFLAGE");
            entity.Property(e => e.PrivilageMenuid).HasColumnName("PRIVILAGE_MENUID");
            entity.Property(e => e.Privilagedate).HasColumnName("PRIVILAGEDATE");
            entity.Property(e => e.Privilagesource)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("PRIVILAGESOURCE");
            entity.Property(e => e.Refid).HasColumnName("REFID");
            entity.Property(e => e.Rolldate).HasColumnName("ROLLDATE");
            entity.Property(e => e.Smalltext)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMALLTEXT");
            entity.Property(e => e.Sp1)
                .HasDefaultValue(0)
                .HasColumnName("SP1");
            entity.Property(e => e.Sp1name)
                .HasMaxLength(150)
                .HasColumnName("SP1Name");
            entity.Property(e => e.Sp2)
                .HasDefaultValue(0)
                .HasColumnName("SP2");
            entity.Property(e => e.Sp2name)
                .HasMaxLength(150)
                .HasColumnName("SP2Name");
            entity.Property(e => e.Sp3)
                .HasDefaultValue(0)
                .HasColumnName("SP3");
            entity.Property(e => e.Sp3name)
                .HasMaxLength(150)
                .HasColumnName("SP3Name");
            entity.Property(e => e.Sp4)
                .HasDefaultValue(0)
                .HasColumnName("SP4");
            entity.Property(e => e.Sp4name)
                .HasMaxLength(150)
                .HasColumnName("SP4Name");
            entity.Property(e => e.Sp5)
                .HasDefaultValue(0)
                .HasColumnName("SP5");
            entity.Property(e => e.Sp5name)
                .HasMaxLength(150)
                .HasColumnName("SP5Name");
            entity.Property(e => e.Tenentdate).HasColumnName("TENENTDATE");
            entity.Property(e => e.UraddFlag).HasColumnName("URADD_FLAG");
            entity.Property(e => e.UrallFlag).HasColumnName("URALL_FLAG");
            entity.Property(e => e.UrdeleteFlag).HasColumnName("URDELETE_FLAG");
            entity.Property(e => e.Urlrewrite)
                .HasMaxLength(500)
                .HasColumnName("URLREWRITE");
            entity.Property(e => e.UrmodifyFlag).HasColumnName("URMODIFY_FLAG");
            entity.Property(e => e.UrviewFlag).HasColumnName("URVIEW_FLAG");
            entity.Property(e => e.Userdate).HasColumnName("USERDATE");
            entity.Property(e => e.ViewFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VIEW_FLAG");
        });

        modelBuilder.Entity<Tempdatatable>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.Type, e.Id });

            entity.ToTable("Tempdatatable");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Count).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Percentage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("percentage");
            entity.Property(e => e.TotalCount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.ToTable("test");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .HasColumnName("data");
        });

        modelBuilder.Entity<TicketGeneratedDepartmentApplicable>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.TicketId });

            entity.ToTable("Ticket_generated_department_applicable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.TicketId)
                .HasMaxLength(50)
                .HasColumnName("TicketID");
            entity.Property(e => e.ApplicableDepartment)
                .HasMaxLength(500)
                .HasColumnName("applicable_department");
        });

        modelBuilder.Entity<TicketGenerationApplicationRevisionDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.TicketNo });

            entity.ToTable("Ticket_generation_application_revision_detail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.TicketNo)
                .HasMaxLength(50)
                .HasColumnName("Ticket_no");
            entity.Property(e => e.DenyDate)
                .HasColumnType("datetime")
                .HasColumnName("Deny_date");
            entity.Property(e => e.Department)
                .HasMaxLength(500)
                .HasColumnName("department");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("datetime")
                .HasColumnName("Release_date");
            entity.Property(e => e.ReleaseNotes).HasColumnName("Release_notes");
            entity.Property(e => e.RevisionType)
                .HasMaxLength(50)
                .HasColumnName("Revision_type");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VersionNo)
                .HasMaxLength(50)
                .HasColumnName("version_no");
            entity.Property(e => e.VersionNoTwo).HasColumnName("version_no_two");
            entity.Property(e => e.VesrionNoGen).HasColumnName("vesrion_no_gen");
        });

        modelBuilder.Entity<TicketGenerationProcess>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.TicketId });

            entity.ToTable("Ticket_generation_Process");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.TicketId)
                .HasMaxLength(100)
                .HasColumnName("Ticket_ID");
            entity.Property(e => e.ApplicaitonScope).HasColumnName("Applicaiton_scope");
            entity.Property(e => e.ApplicationLiability)
                .HasMaxLength(100)
                .HasColumnName("Application_Liability");
            entity.Property(e => e.ApplicationName).HasColumnName("Application_name");
            entity.Property(e => e.ApplicationPurpose).HasColumnName("Application_purpose");
            entity.Property(e => e.ApplicationType)
                .HasMaxLength(50)
                .HasColumnName("Application_Type");
            entity.Property(e => e.Approval).HasColumnName("approval");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalRemark).HasColumnName("Approval_remark");
            entity.Property(e => e.Attachment).HasColumnName("attachment");
            entity.Property(e => e.CancelDate)
                .HasColumnType("datetime")
                .HasColumnName("cancel_date");
            entity.Property(e => e.CompletionDate)
                .HasColumnType("datetime")
                .HasColumnName("completion_date");
            entity.Property(e => e.DatabaseImportance)
                .HasMaxLength(100)
                .HasColumnName("Database_importance");
            entity.Property(e => e.DeadlineDate)
                .HasColumnType("datetime")
                .HasColumnName("deadline_date");
            entity.Property(e => e.EmailId).HasColumnName("Email_ID");
            entity.Property(e => e.FinalDate)
                .HasColumnType("datetime")
                .HasColumnName("Final_date");
            entity.Property(e => e.FromDepartment)
                .HasMaxLength(100)
                .HasColumnName("from_department");
            entity.Property(e => e.HowItWorks).HasColumnName("How_It_Works");
            entity.Property(e => e.ItCloseDate)
                .HasColumnType("datetime")
                .HasColumnName("IT_Close_date");
            entity.Property(e => e.ItCloseRemark).HasColumnName("IT_Close_remark");
            entity.Property(e => e.MockDueDate)
                .HasColumnType("datetime")
                .HasColumnName("Mock_due_date");
            entity.Property(e => e.NeedApplication).HasColumnName("Need_Application");
            entity.Property(e => e.RemarkCancel).HasColumnName("remark_cancel");
            entity.Property(e => e.RemarkCompletion).HasColumnName("remark_completion");
            entity.Property(e => e.ResponsibleDepartment)
                .HasMaxLength(100)
                .HasColumnName("Responsible_Department");
            entity.Property(e => e.ResposibleUser).HasColumnName("Resposible_user");
            entity.Property(e => e.RetentionData)
                .HasMaxLength(50)
                .HasColumnName("retention_data");
            entity.Property(e => e.ServerRequirement)
                .HasMaxLength(50)
                .HasColumnName("Server_Requirement");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.TicketGeneratorName).HasColumnName("Ticket_Generator_Name");
            entity.Property(e => e.ToDepartment)
                .HasMaxLength(100)
                .HasColumnName("to_department");
            entity.Property(e => e.TypeOfTicket)
                .HasMaxLength(100)
                .HasColumnName("type_of_ticket");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
            entity.Property(e => e.UserCloseDate)
                .HasColumnType("datetime")
                .HasColumnName("User_Close_date");
            entity.Property(e => e.UserCloseRemark).HasColumnName("User_Close_remark");
            entity.Property(e => e.UserId).HasColumnName("user_ID");
            entity.Property(e => e.WhatAreYouUsingNow).HasColumnName("What_are_you_using_now");
            entity.Property(e => e.WhichDepartmentMonitoring)
                .HasMaxLength(50)
                .HasColumnName("Which_department_monitoring");
        });

        modelBuilder.Entity<TicketProcessChat>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.Ticketno });

            entity.ToTable("Ticket_process_chat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Ticketno).HasMaxLength(200);
            entity.Property(e => e.ChatDate)
                .HasColumnType("datetime")
                .HasColumnName("chat_date");
            entity.Property(e => e.TicketChat).HasColumnName("Ticket_chat");
            entity.Property(e => e.TicketRemark).HasColumnName("Ticket_remark");
            entity.Property(e => e.TicketUser).HasColumnName("Ticket_user");
        });

        modelBuilder.Entity<ToolCategory>(entity =>
        {
            entity.ToTable("Tool_Category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.QtyInShopfloorMonday).HasColumnName("Qty_in_Shopfloor_Monday");
            entity.Property(e => e.ToolCategory1)
                .HasMaxLength(500)
                .HasColumnName("Tool_Category");
            entity.Property(e => e.ToolType)
                .HasMaxLength(500)
                .HasColumnName("Tool_Type");
            entity.Property(e => e.ToolTypeDescription).HasColumnName("Tool_Type_description");
            entity.Property(e => e.ToolTypeName).HasColumnName("Tool_Type_Name");
            entity.Property(e => e.ToolTypeSearchWord).HasColumnName("Tool_type_search_word");
            entity.Property(e => e.Using).HasMaxLength(50);
        });

        modelBuilder.Entity<ToolInventorySystem>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.ToolId });

            entity.ToTable("Tool_Inventory_System");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ToolId).HasColumnName("Tool_ID");
            entity.Property(e => e.Active)
                .HasMaxLength(50)
                .HasColumnName("active");
            entity.Property(e => e.ItemQtyInBox).HasColumnName("item_qty_in_box");
            entity.Property(e => e.MinQty).HasColumnName("min_qty");
            entity.Property(e => e.PartDscription).HasColumnName("Part_Dscription");
            entity.Property(e => e.PartName).HasColumnName("Part_name");
            entity.Property(e => e.ProductClass)
                .HasMaxLength(500)
                .HasColumnName("Product_Class");
            entity.Property(e => e.ProductGroup)
                .HasMaxLength(500)
                .HasColumnName("Product_group");
            entity.Property(e => e.QtyAsPerPhysicalStock).HasColumnName("Qty_as_per_physical_stock");
            entity.Property(e => e.ToolType)
                .HasMaxLength(500)
                .HasColumnName("Tool_Type");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<ToolTrialDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ToolTrialData");

            entity.ToTable("Tool_TrialData");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commentfromuser).HasColumnName("commentfromuser");
            entity.Property(e => e.CurrentDate).HasColumnType("datetime");
            entity.Property(e => e.HourlyMachineCost).HasMaxLength(500);
            entity.Property(e => e.InsertCostPerPiece).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MctimeToolCost).HasColumnName("MCTimeToolCost");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.Supplier)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.ToolcostPcs).HasColumnName("Toolcost/pcs");
        });

        modelBuilder.Entity<ToolTrialLogTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ToolTrial_LogTable");

            entity.ToTable("Tool_Trial_LogTable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentDateTime).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(500);
            entity.Property(e => e.PageName).HasMaxLength(500);
        });

        modelBuilder.Entity<ToolTrialProductionDatum>(entity =>
        {
            entity.ToTable("Tool_Trial_Production_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Currentdate).HasColumnType("datetime");
            entity.Property(e => e.CuttingSpeedOrrpm).HasColumnName("CuttingSpeedORRPM");
            entity.Property(e => e.Savesubmit).HasColumnName("savesubmit");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.WorkPieceCuttingDiameter).HasColumnName("WorkPiece_CuttingDiameter");
        });

        modelBuilder.Entity<ToolTrialShiftDatum>(entity =>
        {
            entity.ToTable("Tool_Trial_Shift_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Currentdate).HasColumnType("datetime");
            entity.Property(e => e.Cycletime)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CYCLETIME");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Tid).HasColumnName("TID");
        });

        modelBuilder.Entity<ToolUtilization>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Tool_Utilization");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.IssueQty).HasColumnName("Issue_Qty");
            entity.Property(e => e.Jobno).HasMaxLength(50);
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("Machine_name");
            entity.Property(e => e.MachineType)
                .HasMaxLength(50)
                .HasColumnName("Machine_Type");
            entity.Property(e => e.OrderQty).HasColumnName("Order_Qty");
            entity.Property(e => e.PartNo)
                .HasMaxLength(50)
                .HasColumnName("Part_No");
            entity.Property(e => e.ReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("received_date");
            entity.Property(e => e.ReceivedQty).HasColumnName("Received_Qty");
            entity.Property(e => e.ReqStatus)
                .HasMaxLength(50)
                .HasColumnName("Req_Status");
            entity.Property(e => e.Rev).HasMaxLength(50);
            entity.Property(e => e.ShopFloorOnhandQty).HasColumnName("Shop_floor_Onhand_Qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StoreOnHandQty).HasColumnName("Store_on_Hand_qty");
            entity.Property(e => e.ToolCategory)
                .HasMaxLength(50)
                .HasColumnName("Tool_Category");
            entity.Property(e => e.ToolName)
                .HasMaxLength(500)
                .HasColumnName("Tool_Name");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionQty).HasColumnName("transaction_qty");
            entity.Property(e => e.TransactionTransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("transaction\r\ntransaction_date");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
            entity.Property(e => e.Uploadedby)
                .HasMaxLength(50)
                .HasColumnName("uploadedby");
        });

        modelBuilder.Entity<ToolingUtilizationAllDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Tooling_Utilization_all_details");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .HasColumnName("Job_no");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineType)
                .HasMaxLength(50)
                .HasColumnName("Machine_Type");
            entity.Property(e => e.OparatorReceiveQty)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Oparator_receive_qty");
            entity.Property(e => e.OperatorReceiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Operator_receive_date");
            entity.Property(e => e.OperatorReceiveQty).HasColumnName("Operator_receive_qty");
            entity.Property(e => e.OrderQty).HasColumnName("Order_Qty");
            entity.Property(e => e.PartNo)
                .HasMaxLength(50)
                .HasColumnName("part_no");
            entity.Property(e => e.PendingQty).HasColumnName("Pending_Qty");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.RemarkShopfloor)
                .HasMaxLength(1000)
                .HasColumnName("Remark_Shopfloor");
            entity.Property(e => e.RemarkStore)
                .HasMaxLength(1000)
                .HasColumnName("Remark_Store");
            entity.Property(e => e.ReturnToScrapQtyShopFloor).HasColumnName("Return_To_Scrap_qty_ShopFloor");
            entity.Property(e => e.ReturnToScrapQtyStore).HasColumnName("Return_To_Scrap_qty_Store");
            entity.Property(e => e.ReturnToStockQtyShopFloor).HasColumnName("Return_To_Stock_qty_ShopFloor");
            entity.Property(e => e.ReturnToStockQtyStore).HasColumnName("Return_To_Stock_qty_Store");
            entity.Property(e => e.Rev).HasMaxLength(50);
            entity.Property(e => e.ShopFloorQty).HasColumnName("Shop_floor_qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.ToolName)
                .HasMaxLength(500)
                .HasColumnName("Tool_Name");
            entity.Property(e => e.ToolType)
                .HasMaxLength(50)
                .HasColumnName("Tool_Type");
            entity.Property(e => e.TransactionBy)
                .HasMaxLength(50)
                .HasColumnName("transaction_by");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");
            entity.Property(e => e.TransactionQty).HasColumnName("transaction_qty");
        });

        modelBuilder.Entity<ToolingUtilizationDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("Tooling_Utilization_details");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .HasColumnName("job_no");
            entity.Property(e => e.MachineType)
                .HasMaxLength(50)
                .HasColumnName("Machine_Type");
            entity.Property(e => e.OrderQty).HasColumnName("Order_Qty");
            entity.Property(e => e.PartNo)
                .HasMaxLength(50)
                .HasColumnName("part_no");
            entity.Property(e => e.QtyMove).HasColumnName("Qty_Move");
            entity.Property(e => e.Rev)
                .HasMaxLength(50)
                .HasColumnName("rev");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.ToolName)
                .HasMaxLength(500)
                .HasColumnName("Tool_Name");
            entity.Property(e => e.ToolType)
                .HasMaxLength(50)
                .HasColumnName("Tool_Type");
            entity.Property(e => e.TransactionBy)
                .HasMaxLength(50)
                .HasColumnName("transaction_by");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("Transaction_date");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .HasColumnName("Transaction_Type");
            entity.Property(e => e.UnusedQty).HasColumnName("unused_qty");
            entity.Property(e => e.UsedQty).HasColumnName("used_qty");
        });

        modelBuilder.Entity<TpmEpoEntryDatum>(entity =>
        {
            entity.HasKey(e => e.InitiatorId);

            entity.ToTable("TPM_EpoEntryData");

            entity.Property(e => e.InitiatorId).HasColumnName("Initiator_ID");
            entity.Property(e => e.EpoApproveStatus).HasColumnName("EPO_Approve_Status");
            entity.Property(e => e.TpmEpoEntryDataStatus).HasColumnName("TPM_EpoEntryData_Status");
            entity.Property(e => e.TpmRequestformStatus).HasColumnName("TPM_Requestform_Status");
        });

        modelBuilder.Entity<TpmIssueReturnDetail>(entity =>
        {
            entity.HasKey(e => e.InitiatorId);

            entity.ToTable("TPM_IssueReturnDetails");

            entity.Property(e => e.InitiatorId).HasColumnName("Initiator_ID");
            entity.Property(e => e.BalancedQty).HasColumnName("Balanced_Qty");
            entity.Property(e => e.InitiatorName).HasColumnName("Initiator_Name");
            entity.Property(e => e.IssueDate).HasColumnName("Issue_Date");
            entity.Property(e => e.IssueQty).HasColumnName("Issue_Qty");
            entity.Property(e => e.IssueTo).HasColumnName("Issue_To");
            entity.Property(e => e.ItemDescription).HasColumnName("Item_Description");
            entity.Property(e => e.ItemIssued).HasColumnName("Item_Issued");
            entity.Property(e => e.ItemName).HasColumnName("Item_Name");
            entity.Property(e => e.ItemReturned).HasColumnName("Item_Returned");
            entity.Property(e => e.OrderQty).HasColumnName("Order_Qty");
            entity.Property(e => e.PartUsage).HasColumnName("Part_Usage");
            entity.Property(e => e.RemainingQty).HasColumnName("Remaining_Qty");
            entity.Property(e => e.RequestDate).HasColumnName("Request_Date");
            entity.Property(e => e.ReturnDate).HasColumnName("Return_Date");
            entity.Property(e => e.ReturnFrom).HasColumnName("Return_From");
            entity.Property(e => e.ReturnQty).HasColumnName("Return_Qty");
            entity.Property(e => e.Uom).HasColumnName("UOM");
        });

        modelBuilder.Entity<TpmNonconReceiptIssue>(entity =>
        {
            entity.HasKey(e => e.ReceiptNo);

            entity.ToTable("TPM_Noncon_ReceiptIssue");

            entity.Property(e => e.ReceiptNo).HasColumnName("Receipt_No");
            entity.Property(e => e.ChallanNo).HasColumnName("Challan_No");
            entity.Property(e => e.InitiatiorId).HasColumnName("Initiatior_ID");
            entity.Property(e => e.InvoiceNo).HasColumnName("Invoice_No");
            entity.Property(e => e.IssueDate).HasColumnName("Issue_Date");
            entity.Property(e => e.IssueQty).HasColumnName("issue_Qty");
            entity.Property(e => e.IssueStatus).HasColumnName("issue_Status");
            entity.Property(e => e.IssueTo).HasColumnName("Issue_To");
            entity.Property(e => e.ReceiveDate).HasColumnName("Receive_Date");
            entity.Property(e => e.RemainingQty).HasColumnName("Remaining_Qty");
            entity.Property(e => e.RequestedQty).HasColumnName("Requested_Qty");
            entity.Property(e => e.TransactionQty).HasColumnName("Transaction_Qty");
        });

        modelBuilder.Entity<TpmPurchaseInvoiceDetail>(entity =>
        {
            entity.ToTable("Tpm_Purchase_Invoice_Details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DocUnitCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ium).HasColumnName("IUM");
            entity.Property(e => e.OrderQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OurQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Poline).HasColumnName("POLine");
            entity.Property(e => e.Ponum).HasColumnName("PONum");
            entity.Property(e => e.TaxCatId).HasColumnName("TaxCatID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDedTax).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TpmRequestform>(entity =>
        {
            entity.HasKey(e => e.InitiatorId);

            entity.ToTable("TPM_Requestform");

            entity.Property(e => e.InitiatorId).HasColumnName("Initiator_ID");
            entity.Property(e => e.CurrentDateTime).HasColumnName("Current_DateTime");
            entity.Property(e => e.DueDate).HasColumnName("Due_Date");
            entity.Property(e => e.InitiatorName).HasColumnName("Initiator_Name");
            entity.Property(e => e.IsSaved).HasColumnName("Is_Saved");
            entity.Property(e => e.ItemDescription).HasColumnName("Item_Description");
            entity.Property(e => e.ItemName).HasColumnName("Item_Name");
            entity.Property(e => e.ItemType).HasColumnName("Item_Type");
            entity.Property(e => e.PartUsage).HasColumnName("Part_Usage");
            entity.Property(e => e.ReqType).HasColumnName("Req_Type");
            entity.Property(e => e.RequestedQty).HasColumnName("Requested_Qty");
            entity.Property(e => e.ReviewDate).HasColumnName("Review_Date");
            entity.Property(e => e.SupplierName).HasColumnName("Supplier_name");
            entity.Property(e => e.Uom).HasColumnName("UOM");
        });

        modelBuilder.Entity<Trial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("trial");

            entity.Property(e => e.Education).HasMaxLength(500);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Percentage)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("percentage");
        });

        modelBuilder.Entity<UdaiUdimaster>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.GroupId, e.LineId });

            entity.ToTable("UDAI_UDIMaster");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.LineId).HasColumnName("LineID");
            entity.Property(e => e.CloseTimestamp).HasColumnType("datetime");
            entity.Property(e => e.DenyReson).HasMaxLength(50);
            entity.Property(e => e.EngProcessTimestamp).HasColumnType("datetime");
            entity.Property(e => e.IsErpDown).HasColumnName("isErpDown");
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.PartNo).HasMaxLength(50);
            entity.Property(e => e.PlanningTimestamp).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuggestedJobNo).HasMaxLength(50);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.UdiRemark).HasMaxLength(50);
            entity.Property(e => e.UdidrawingRequired).HasColumnName("UDIDrawingRequired");
            entity.Property(e => e.UdigeneratedBy).HasColumnName("UDIGeneratedBy");
            entity.Property(e => e.UdigenerationTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("UDIGenerationTimestamp");
            entity.Property(e => e.Udistring)
                .HasMaxLength(50)
                .HasColumnName("UDIString");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<UdaiUdimasterHistoryTbl>(entity =>
        {
            entity.ToTable("UDAI_UDIMaster_History_tbl");

            entity.Property(e => e.CloseTimestamp).HasColumnType("datetime");
            entity.Property(e => e.DenyReson).HasMaxLength(50);
            entity.Property(e => e.EditId).HasColumnName("EditID");
            entity.Property(e => e.EngProcessTimestamp).HasColumnType("datetime");
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.PartNo).HasMaxLength(50);
            entity.Property(e => e.PlanningTimestamp).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuggestedJobNo).HasMaxLength(50);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.UdiRemark).HasMaxLength(50);
            entity.Property(e => e.UdidrawingRequired).HasColumnName("UDIDrawingRequired");
            entity.Property(e => e.UdigeneratedBy).HasColumnName("UDIGeneratedBy");
            entity.Property(e => e.UdigenerationTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("UDIGenerationTimestamp");
            entity.Property(e => e.Udiid).HasColumnName("UDIId");
            entity.Property(e => e.Udistring)
                .HasMaxLength(50)
                .HasColumnName("UDIString");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.Id });

            entity.ToTable("unit");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .HasColumnName("active");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Unitname).HasColumnName("unitname");
        });

        modelBuilder.Entity<Uom>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("UOM");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mid).HasColumnName("mid");
            entity.Property(e => e.UomName)
                .HasMaxLength(50)
                .HasColumnName("uom_name");
        });

        modelBuilder.Entity<UserDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_employe_tbl");

            entity.ToTable("user_data");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attachment).HasColumnName("attachment");
            entity.Property(e => e.Department).HasColumnName("department");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<UserDtl>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.UserDetailId, e.LocationId }).HasName("PK_ACM_USER_DTL_1");

            entity.ToTable("USER_DTL");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.UserDetailId).HasColumnName("USER_DETAIL_ID");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("CITY");
            entity.Property(e => e.Country).HasColumnName("COUNTRY");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .HasColumnName("COUNTRY_CODE");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(150)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .HasColumnName("FAX_NO");
            entity.Property(e => e.FromRegDt)
                .HasMaxLength(50)
                .HasColumnName("FROM_REG_DT");
            entity.Property(e => e.HouseNo)
                .HasMaxLength(50)
                .HasColumnName("HOUSE_NO");
            entity.Property(e => e.MobileNum)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOBILE_NUM");
            entity.Property(e => e.PanNo)
                .HasMaxLength(50)
                .HasColumnName("PAN_NO");
            entity.Property(e => e.PhNo)
                .HasMaxLength(50)
                .HasColumnName("PH_NO");
            entity.Property(e => e.PincodeNo)
                .HasMaxLength(50)
                .HasColumnName("PINCODE_NO");
            entity.Property(e => e.PostOffice)
                .HasMaxLength(50)
                .HasColumnName("POST_OFFICE");
            entity.Property(e => e.SecAns)
                .HasMaxLength(100)
                .HasColumnName("SEC_ANS");
            entity.Property(e => e.SecQues)
                .HasMaxLength(150)
                .HasColumnName("SEC_QUES");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("STREET");
            entity.Property(e => e.Tehsil)
                .HasMaxLength(50)
                .HasColumnName("TEHSIL");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("TITLE");
            entity.Property(e => e.VillageTownCity)
                .HasMaxLength(50)
                .HasColumnName("VILLAGE_TOWN_CITY");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<UserMst>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.UserId, e.LocationId });

            entity.ToTable("USER_MST");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.AccLock)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACC_LOCK");
            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.Activeuser).HasColumnName("ACTIVEUSER");
            entity.Property(e => e.AdminRights).HasColumnName("admin_rights");
            entity.Property(e => e.ApprovalDt)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_DT");
            entity.Property(e => e.Avtar)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DateOfJoining).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EmployeePosition).HasMaxLength(50);
            entity.Property(e => e.EventApprovalUser)
                .HasMaxLength(50)
                .HasColumnName("event_approval_user");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.FirstName1)
                .HasMaxLength(50)
                .HasColumnName("FIRST_NAME1");
            entity.Property(e => e.FirstName2)
                .HasMaxLength(50)
                .HasColumnName("FIRST_NAME2");
            entity.Property(e => e.FirstTime)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FIRST_TIME");
            entity.Property(e => e.Img)
                .HasMaxLength(500)
                .HasColumnName("img");
            entity.Property(e => e.Language1).HasMaxLength(50);
            entity.Property(e => e.Language2).HasMaxLength(50);
            entity.Property(e => e.Language3).HasMaxLength(50);
            entity.Property(e => e.LastLoginDt)
                .HasColumnType("datetime")
                .HasColumnName("LAST_LOGIN_DT");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.LastName1)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME1");
            entity.Property(e => e.LastName2)
                .HasMaxLength(50)
                .HasColumnName("LAST_NAME2");
            entity.Property(e => e.LibraryMenu)
                .HasMaxLength(50)
                .HasColumnName("Library_menu");
            entity.Property(e => e.LibraryMenuDept)
                .HasMaxLength(500)
                .HasColumnName("Library_menu_dept");
            entity.Property(e => e.LibraryReader).HasColumnName("Library_reader");
            entity.Property(e => e.LoginId)
                .HasMaxLength(100)
                .HasColumnName("LOGIN_ID");
            entity.Property(e => e.MsproUserType).HasColumnName("MSPRO_UserType");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PasswordChng)
                .HasMaxLength(150)
                .HasColumnName("PASSWORD_CHNG");
            entity.Property(e => e.PersonId).HasColumnName("personID");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .HasColumnName("phone_no");
            entity.Property(e => e.Pincode)
                .HasMaxLength(50)
                .HasColumnName("pincode");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .HasColumnName("REMARKS");
            entity.Property(e => e.Salary)
                .HasMaxLength(50)
                .HasColumnName("salary");
            entity.Property(e => e.SecondaryApprovalPerson)
                .HasMaxLength(500)
                .HasColumnName("Secondary_approval_person");
            entity.Property(e => e.SecondaryApprovalRequired).HasColumnName("Secondary_approval_required");
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ThemeName)
                .HasMaxLength(50)
                .HasColumnName("THEME_NAME");
            entity.Property(e => e.TicketUser).HasColumnName("Ticket_User");
            entity.Property(e => e.TillDt)
                .HasComment("Ayo Till date")
                .HasColumnType("datetime")
                .HasColumnName("Till_DT");
            entity.Property(e => e.ToolTrialUserType).HasColumnName("Tool_Trial_UserTYpe");
            entity.Property(e => e.UserDetailId).HasColumnName("USER_DETAIL_ID");
            entity.Property(e => e.UserType).HasColumnName("USER_TYPE");
            entity.Property(e => e.Userdate).HasColumnName("USERDATE");
            entity.Property(e => e.VerificationCd)
                .HasMaxLength(40)
                .HasColumnName("VERIFICATION_CD");
        });

        modelBuilder.Entity<UserMstForShoulder>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("User_Mst_For_Shoulder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.AdminRights).HasColumnName("admin_rights");
            entity.Property(e => e.ApprovedByAdmin).HasColumnName("approved_by_admin");
            entity.Property(e => e.ConfirmPassword).HasColumnName("confirm_password");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .HasColumnName("mobile_number");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<UserRight>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.RightsId, e.LocationId }).HasName("PK_ACM_USER_RIGHTS");

            entity.ToTable("USER_RIGHTS");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.RightsId).HasColumnName("RIGHTS_ID");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.AddFlag).HasColumnName("ADD_FLAG");
            entity.Property(e => e.AllFlag).HasColumnName("ALL_FLAG");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.DeleteFlag).HasColumnName("DELETE_FLAG");
            entity.Property(e => e.ModifyFlag).HasColumnName("MODIFY_FLAG");
            entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");
            entity.Property(e => e.Sp1)
                .HasDefaultValue(false)
                .HasColumnName("SP1");
            entity.Property(e => e.Sp1name)
                .HasMaxLength(150)
                .HasColumnName("SP1Name");
            entity.Property(e => e.Sp2)
                .HasDefaultValue(false)
                .HasColumnName("SP2");
            entity.Property(e => e.Sp2name)
                .HasMaxLength(150)
                .HasColumnName("SP2Name");
            entity.Property(e => e.Sp3)
                .HasDefaultValue(false)
                .HasColumnName("SP3");
            entity.Property(e => e.Sp3name)
                .HasMaxLength(150)
                .HasColumnName("SP3Name");
            entity.Property(e => e.Sp4)
                .HasDefaultValue(false)
                .HasColumnName("SP4");
            entity.Property(e => e.Sp4name)
                .HasMaxLength(150)
                .HasColumnName("SP4Name");
            entity.Property(e => e.Sp5)
                .HasDefaultValue(false)
                .HasColumnName("SP5");
            entity.Property(e => e.Sp5name)
                .HasMaxLength(150)
                .HasColumnName("SP5Name");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.ViewFlag).HasColumnName("VIEW_FLAG");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => new { e.TenentId, e.UserRoleId, e.PrivilegeId, e.LocationId, e.UserId, e.RoleId });

            entity.ToTable("USER_ROLE");

            entity.Property(e => e.TenentId).HasColumnName("TenentID");
            entity.Property(e => e.UserRoleId).HasColumnName("USER_ROLE_ID");
            entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");
            entity.Property(e => e.ActiveFromDt)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_FROM_DT");
            entity.Property(e => e.ActiveToDt)
                .HasColumnType("datetime")
                .HasColumnName("ACTIVE_TO_DT");
            entity.Property(e => e.AddFlag)
                .HasDefaultValue(0)
                .HasColumnName("ADD_FLAG");
            entity.Property(e => e.AllFlag)
                .HasDefaultValue(0)
                .HasColumnName("ALL_FLAG");
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(500)
                .HasColumnName("Application_name");
            entity.Property(e => e.CrupId).HasColumnName("CRUP_ID");
            entity.Property(e => e.DeleteFlag)
                .HasDefaultValue(0)
                .HasColumnName("DELETE_FLAG");
            entity.Property(e => e.MenuIcon).HasColumnName("Menu_icon");
            entity.Property(e => e.MenuLink).HasColumnName("Menu_link");
            entity.Property(e => e.MenuName).HasColumnName("Menu_Name");
            entity.Property(e => e.MenuRole).HasColumnName("Menu_Role");
            entity.Property(e => e.ModifyFlag)
                .HasDefaultValue(0)
                .HasColumnName("MODIFY_FLAG");
            entity.Property(e => e.Sp1)
                .HasDefaultValue(0)
                .HasColumnName("SP1");
            entity.Property(e => e.Sp1name)
                .HasMaxLength(150)
                .HasColumnName("SP1Name");
            entity.Property(e => e.Sp2)
                .HasDefaultValue(0)
                .HasColumnName("SP2");
            entity.Property(e => e.Sp2name)
                .HasMaxLength(150)
                .HasColumnName("SP2Name");
            entity.Property(e => e.Sp3)
                .HasDefaultValue(0)
                .HasColumnName("SP3");
            entity.Property(e => e.Sp3name)
                .HasMaxLength(150)
                .HasColumnName("SP3Name");
            entity.Property(e => e.Sp4)
                .HasDefaultValue(0)
                .HasColumnName("SP4");
            entity.Property(e => e.Sp4name)
                .HasMaxLength(150)
                .HasColumnName("SP4Name");
            entity.Property(e => e.Sp5)
                .HasDefaultValue(0)
                .HasColumnName("SP5");
            entity.Property(e => e.Sp5name)
                .HasMaxLength(150)
                .HasColumnName("SP5Name");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
            entity.Property(e => e.ViewFlag)
                .HasDefaultValue(0)
                .HasColumnName("VIEW_FLAG");
        });

        modelBuilder.Entity<UserRolesForShoulderApp>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.UserId });

            entity.ToTable("User_roles_for_Shoulder_app");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.MenuIcon).HasColumnName("Menu_icon");
            entity.Property(e => e.MenuLink).HasColumnName("Menu_link");
            entity.Property(e => e.MenuName).HasColumnName("Menu_name");
            entity.Property(e => e.MenuRole).HasColumnName("Menu_Role");
            entity.Property(e => e.RoleActive).HasColumnName("role_active");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
        });

        modelBuilder.Entity<UserRolesWithOccupation>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.ShoulderId });

            entity.ToTable("User_roles_with_occupation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ShoulderId)
                .HasMaxLength(50)
                .HasColumnName("Shoulder_ID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.MenuIcon).HasColumnName("Menu_icon");
            entity.Property(e => e.MenuLink).HasColumnName("Menu_link");
            entity.Property(e => e.MenuName).HasColumnName("Menu_Name");
            entity.Property(e => e.MenuRole).HasColumnName("Menu_Role");
            entity.Property(e => e.OccupationName)
                .HasMaxLength(500)
                .HasColumnName("Occupation_name");
            entity.Property(e => e.RoleActive).HasColumnName("role_active");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
        });

        modelBuilder.Entity<UserWiseSholderImplantFvrt>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.UserId, e.ImplantId });

            entity.ToTable("User_Wise_Sholder_Implant_FVRT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.ImplantId)
                .HasMaxLength(50)
                .HasColumnName("Implant_ID");
            entity.Property(e => e.ImplantImg).HasColumnName("Implant_Img");
            entity.Property(e => e.ImplantName).HasColumnName("Implant_Name");
        });

        modelBuilder.Entity<UserWiseShoulderImplantHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.UserId, e.ImplantId });

            entity.ToTable("User_Wise_Shoulder_Implant_History");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.ImplantId)
                .HasMaxLength(50)
                .HasColumnName("Implant_ID");
            entity.Property(e => e.ImplantImg).HasColumnName("Implant_Img");
            entity.Property(e => e.ImplantName).HasColumnName("Implant_name");
        });

        modelBuilder.Entity<Userdatum1>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.Id });

            entity.ToTable("userdata");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .HasColumnName("active");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Utype)
                .HasMaxLength(50)
                .HasColumnName("utype");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => new { e.Tid, e.Id });

            entity.ToTable("Version");

            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Versionno).HasMaxLength(500);
        });

        modelBuilder.Entity<VideoTable>(entity =>
        {
            entity.HasKey(e => new { e.Mid, e.Vid, e.Id });

            entity.ToTable("video_table");

            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Vid).HasColumnName("VID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .HasColumnName("url");
        });

        modelBuilder.Entity<VisitorGatepassDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.Mid, e.VisitorId });

            entity.ToTable("Visitor_gatepass_data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.VisitorId).HasColumnName("visitorID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .HasColumnName("Contact_No");
            entity.Property(e => e.Department)
                .HasMaxLength(500)
                .HasColumnName("department");
            entity.Property(e => e.InTime)
                .HasColumnType("datetime")
                .HasColumnName("In_Time");
            entity.Property(e => e.InitiatorName)
                .HasMaxLength(200)
                .HasColumnName("initiator_name");
            entity.Property(e => e.NoOfPerson).HasColumnName("no_of_person");
            entity.Property(e => e.OutTime)
                .HasColumnType("datetime")
                .HasColumnName("Out_Time");
            entity.Property(e => e.PersonMeet)
                .HasMaxLength(500)
                .HasColumnName("person_meet");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Representing).HasMaxLength(1000);
            entity.Property(e => e.ThemeColor).HasMaxLength(10);
            entity.Property(e => e.Uploadby).HasColumnName("uploadby");
            entity.Property(e => e.Uploaddate)
                .HasColumnType("datetime")
                .HasColumnName("uploaddate");
            entity.Property(e => e.VGpno)
                .HasMaxLength(50)
                .HasColumnName("V_GPNO");
            entity.Property(e => e.VStatus)
                .HasMaxLength(50)
                .HasColumnName("V_Status");
            entity.Property(e => e.ValidUpto).HasColumnName("valid_upto");
            entity.Property(e => e.VisitingDate).HasColumnName("visiting_date");
            entity.Property(e => e.VisitingPersonName).HasColumnName("visiting_person_name");
            entity.Property(e => e.VisitingTime)
                .HasMaxLength(50)
                .HasColumnName("visiting_time");
            entity.Property(e => e.VisitingType)
                .HasMaxLength(500)
                .HasColumnName("visiting_type");
        });

        modelBuilder.Entity<VmsDataFromDashboard>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("VMS_DATA_FROM_DASHBOARD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Device).HasMaxLength(255);
            entity.Property(e => e.DeviceNo).HasMaxLength(255);
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("personId");
            entity.Property(e => e.PersonName).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<VmsFtoRequest>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PersonId });

            entity.ToTable("VMS_FTO_Request");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("PersonID");
            entity.Property(e => e.ELeaveType)
                .HasMaxLength(50)
                .HasColumnName("e_leave_type");
            entity.Property(e => e.EflBalance).HasColumnName("EFL_Balance");
            entity.Property(e => e.EflBalanceNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EFL_Balance_new");
            entity.Property(e => e.EflDaysGiven).HasColumnName("EFL_Days_given");
            entity.Property(e => e.EflDaysGivenNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EFL_Days_given_new");
            entity.Property(e => e.EflDaysRequested).HasColumnName("EFL_Days_Requested");
            entity.Property(e => e.EflDaysRequestedNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EFL_Days_Requested_new");
            entity.Property(e => e.EflDaysUsed).HasColumnName("EFL_Days_Used");
            entity.Property(e => e.EflDaysUsedNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EFL_Days_Used_new");
            entity.Property(e => e.EmployeeComment).HasColumnName("Employee_comment");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("enddate");
            entity.Property(e => e.EvlBalance).HasColumnName("EVL_Balance");
            entity.Property(e => e.EvlBalanceNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EVL_Balance_new");
            entity.Property(e => e.EvlDaysGiven).HasColumnName("EVL_Days_Given");
            entity.Property(e => e.EvlDaysGivenNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EVL_Days_Given_new");
            entity.Property(e => e.EvlDaysRequested).HasColumnName("EVL_Days_Requested");
            entity.Property(e => e.EvlDaysRequestedNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EVL_Days_Requested_new");
            entity.Property(e => e.EvlDaysUsed).HasColumnName("EVL_Days_Used");
            entity.Property(e => e.EvlDaysUsedNew)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EVL_Days_Used_new");
            entity.Property(e => e.HrApproval)
                .HasMaxLength(50)
                .HasColumnName("HR_approval");
            entity.Property(e => e.HrNotes).HasColumnName("HR_Notes");
            entity.Property(e => e.MpcApproval)
                .HasMaxLength(50)
                .HasColumnName("MPC_approval");
            entity.Property(e => e.OtherType)
                .HasMaxLength(500)
                .HasColumnName("other_type");
            entity.Property(e => e.Personname)
                .HasMaxLength(500)
                .HasColumnName("personname");
            entity.Property(e => e.SLeaveType)
                .HasMaxLength(50)
                .HasColumnName("s_leave_type");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("startdate");
            entity.Property(e => e.SupervisorApproval)
                .HasMaxLength(50)
                .HasColumnName("Supervisor_approval");
            entity.Property(e => e.SupervisorNotes).HasColumnName("Supervisor_Notes");
            entity.Property(e => e.TypeOfLeave)
                .HasMaxLength(100)
                .HasColumnName("Type_of_leave");
        });

        modelBuilder.Entity<VmsMonthlyDatum>(entity =>
        {
            entity.ToTable("VMS_Monthly_Data");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EightIn)
                .HasMaxLength(50)
                .HasColumnName("eight_in");
            entity.Property(e => e.EightOut)
                .HasMaxLength(50)
                .HasColumnName("eight_out");
            entity.Property(e => e.EightStatus)
                .HasMaxLength(20)
                .HasColumnName("eight_status");
            entity.Property(e => e.EighteenIn)
                .HasMaxLength(50)
                .HasColumnName("eighteen_in");
            entity.Property(e => e.EighteenOut)
                .HasMaxLength(50)
                .HasColumnName("eighteen_out");
            entity.Property(e => e.EighteenStatus)
                .HasMaxLength(20)
                .HasColumnName("eighteen_status");
            entity.Property(e => e.ElevenIn)
                .HasMaxLength(50)
                .HasColumnName("eleven_in");
            entity.Property(e => e.ElevenOut)
                .HasMaxLength(50)
                .HasColumnName("eleven_out");
            entity.Property(e => e.ElevenStatus)
                .HasMaxLength(20)
                .HasColumnName("eleven_status");
            entity.Property(e => e.FifteenIn)
                .HasMaxLength(50)
                .HasColumnName("fifteen_in");
            entity.Property(e => e.FifteenOut)
                .HasMaxLength(50)
                .HasColumnName("fifteen_out");
            entity.Property(e => e.FifteenStatus)
                .HasMaxLength(20)
                .HasColumnName("fifteen_status");
            entity.Property(e => e.FiveIn)
                .HasMaxLength(50)
                .HasColumnName("five_in");
            entity.Property(e => e.FiveOut)
                .HasMaxLength(50)
                .HasColumnName("five_out");
            entity.Property(e => e.FiveStatus)
                .HasMaxLength(20)
                .HasColumnName("five_status");
            entity.Property(e => e.FourIn)
                .HasMaxLength(50)
                .HasColumnName("four_in");
            entity.Property(e => e.FourOut)
                .HasMaxLength(50)
                .HasColumnName("four_out");
            entity.Property(e => e.FourStatus)
                .HasMaxLength(20)
                .HasColumnName("four_status");
            entity.Property(e => e.FourteenIn)
                .HasMaxLength(50)
                .HasColumnName("fourteen_in");
            entity.Property(e => e.FourteenOut)
                .HasMaxLength(50)
                .HasColumnName("fourteen_out");
            entity.Property(e => e.FourteenStatus)
                .HasMaxLength(20)
                .HasColumnName("fourteen_status");
            entity.Property(e => e.In01)
                .HasMaxLength(50)
                .HasColumnName("In_01");
            entity.Property(e => e.In02)
                .HasMaxLength(50)
                .HasColumnName("In_02");
            entity.Property(e => e.In03)
                .HasMaxLength(50)
                .HasColumnName("In_03");
            entity.Property(e => e.Month).HasMaxLength(50);
            entity.Property(e => e.NineIn)
                .HasMaxLength(50)
                .HasColumnName("nine_in");
            entity.Property(e => e.NineOut)
                .HasMaxLength(50)
                .HasColumnName("nine_out");
            entity.Property(e => e.NineStatus)
                .HasMaxLength(20)
                .HasColumnName("nine_status");
            entity.Property(e => e.NineteenIn)
                .HasMaxLength(50)
                .HasColumnName("nineteen_in");
            entity.Property(e => e.NineteenOut)
                .HasMaxLength(50)
                .HasColumnName("nineteen_out");
            entity.Property(e => e.NineteenStatus)
                .HasMaxLength(20)
                .HasColumnName("nineteen_status");
            entity.Property(e => e.OneIn)
                .HasMaxLength(50)
                .HasColumnName("one_in");
            entity.Property(e => e.OneOut)
                .HasMaxLength(50)
                .HasColumnName("one_out");
            entity.Property(e => e.OneStatus)
                .HasMaxLength(20)
                .HasColumnName("one_status");
            entity.Property(e => e.Organization).HasMaxLength(500);
            entity.Property(e => e.Out01)
                .HasMaxLength(50)
                .HasColumnName("Out_01");
            entity.Property(e => e.Out02)
                .HasMaxLength(50)
                .HasColumnName("Out_02");
            entity.Property(e => e.Out03)
                .HasMaxLength(50)
                .HasColumnName("Out_03");
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("Person_ID");
            entity.Property(e => e.PersonName)
                .HasMaxLength(500)
                .HasColumnName("Person_Name");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.SevenIn)
                .HasMaxLength(50)
                .HasColumnName("seven_in");
            entity.Property(e => e.SevenOut)
                .HasMaxLength(50)
                .HasColumnName("seven_out");
            entity.Property(e => e.SevenStatus)
                .HasMaxLength(20)
                .HasColumnName("seven_status");
            entity.Property(e => e.SeventeenIn)
                .HasMaxLength(50)
                .HasColumnName("seventeen_in");
            entity.Property(e => e.SeventeenOut)
                .HasMaxLength(50)
                .HasColumnName("seventeen_out");
            entity.Property(e => e.SeventeenStatus)
                .HasMaxLength(20)
                .HasColumnName("seventeen_status");
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .HasColumnName("shift");
            entity.Property(e => e.SixIn)
                .HasMaxLength(50)
                .HasColumnName("six_in");
            entity.Property(e => e.SixOut)
                .HasMaxLength(50)
                .HasColumnName("six_out");
            entity.Property(e => e.SixStatus)
                .HasMaxLength(20)
                .HasColumnName("six_status");
            entity.Property(e => e.SixteenIn)
                .HasMaxLength(50)
                .HasColumnName("sixteen_in");
            entity.Property(e => e.SixteenOut)
                .HasMaxLength(50)
                .HasColumnName("sixteen_out");
            entity.Property(e => e.SixteenStatus)
                .HasMaxLength(20)
                .HasColumnName("sixteen_status");
            entity.Property(e => e.Status01)
                .HasMaxLength(50)
                .HasColumnName("Status_01");
            entity.Property(e => e.Status02)
                .HasMaxLength(50)
                .HasColumnName("Status_02");
            entity.Property(e => e.Status03)
                .HasMaxLength(50)
                .HasColumnName("Status_03");
            entity.Property(e => e.TenIn)
                .HasMaxLength(50)
                .HasColumnName("ten_in");
            entity.Property(e => e.TenOut)
                .HasMaxLength(50)
                .HasColumnName("ten_out");
            entity.Property(e => e.TenStatus)
                .HasMaxLength(20)
                .HasColumnName("ten_status");
            entity.Property(e => e.ThirteenIn)
                .HasMaxLength(50)
                .HasColumnName("thirteen_in");
            entity.Property(e => e.ThirteenOut)
                .HasMaxLength(50)
                .HasColumnName("thirteen_out");
            entity.Property(e => e.ThirteenStatus)
                .HasMaxLength(20)
                .HasColumnName("thirteen_status");
            entity.Property(e => e.ThirtyIn)
                .HasMaxLength(50)
                .HasColumnName("thirty_in");
            entity.Property(e => e.ThirtyOneIn)
                .HasMaxLength(50)
                .HasColumnName("thirty_one_in");
            entity.Property(e => e.ThirtyOneOut)
                .HasMaxLength(50)
                .HasColumnName("thirty_one_out");
            entity.Property(e => e.ThirtyOneStatus)
                .HasMaxLength(20)
                .HasColumnName("thirty_one_status");
            entity.Property(e => e.ThirtyOut)
                .HasMaxLength(50)
                .HasColumnName("thirty_out");
            entity.Property(e => e.ThirtyStatus)
                .HasMaxLength(20)
                .HasColumnName("thirty_status");
            entity.Property(e => e.ThreeIn)
                .HasMaxLength(50)
                .HasColumnName("three_in");
            entity.Property(e => e.ThreeOut)
                .HasMaxLength(50)
                .HasColumnName("three_out");
            entity.Property(e => e.ThreeStatus)
                .HasMaxLength(20)
                .HasColumnName("three_status");
            entity.Property(e => e.TwelveIn)
                .HasMaxLength(50)
                .HasColumnName("twelve_in");
            entity.Property(e => e.TwelveOut)
                .HasMaxLength(50)
                .HasColumnName("twelve_out");
            entity.Property(e => e.TwelveStatus)
                .HasMaxLength(20)
                .HasColumnName("twelve_status");
            entity.Property(e => e.TwentyEightIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_eight_in");
            entity.Property(e => e.TwentyEightOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_eight_out");
            entity.Property(e => e.TwentyEightStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_eight_status");
            entity.Property(e => e.TwentyFiveIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_five_in");
            entity.Property(e => e.TwentyFiveOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_five_out");
            entity.Property(e => e.TwentyFiveStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_five_status");
            entity.Property(e => e.TwentyFourIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_four_in");
            entity.Property(e => e.TwentyFourOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_four_out");
            entity.Property(e => e.TwentyFourStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_four_status");
            entity.Property(e => e.TwentyIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_in");
            entity.Property(e => e.TwentyNineIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_nine_in");
            entity.Property(e => e.TwentyNineOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_nine_out");
            entity.Property(e => e.TwentyNineStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_nine_status");
            entity.Property(e => e.TwentyOneIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_one_in");
            entity.Property(e => e.TwentyOneOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_one_out");
            entity.Property(e => e.TwentyOneStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_one_status");
            entity.Property(e => e.TwentyOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_out");
            entity.Property(e => e.TwentySevenIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_seven_in");
            entity.Property(e => e.TwentySevenOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_seven_out");
            entity.Property(e => e.TwentySevenStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_seven_status");
            entity.Property(e => e.TwentySixIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_six_in");
            entity.Property(e => e.TwentySixOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_six_out");
            entity.Property(e => e.TwentySixStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_six_status");
            entity.Property(e => e.TwentyStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_status");
            entity.Property(e => e.TwentyThreeIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_three_in");
            entity.Property(e => e.TwentyThreeOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_three_out");
            entity.Property(e => e.TwentyThreeStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_three_status");
            entity.Property(e => e.TwentyTwoIn)
                .HasMaxLength(50)
                .HasColumnName("twenty_two_in");
            entity.Property(e => e.TwentyTwoOut)
                .HasMaxLength(50)
                .HasColumnName("twenty_two_out");
            entity.Property(e => e.TwentyTwoStatus)
                .HasMaxLength(20)
                .HasColumnName("twenty_two_status");
            entity.Property(e => e.TwoIn)
                .HasMaxLength(50)
                .HasColumnName("two_in");
            entity.Property(e => e.TwoOut)
                .HasMaxLength(50)
                .HasColumnName("two_out");
            entity.Property(e => e.TwoStatus)
                .HasMaxLength(20)
                .HasColumnName("two_status");
            entity.Property(e => e.Year)
                .HasMaxLength(20)
                .HasColumnName("year");
        });

        modelBuilder.Entity<Vmsattendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VMSAttendance");

            entity.Property(e => e.Approval).HasMaxLength(100);
            entity.Property(e => e.CardNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Device)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeviceNo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.PersonName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<VmsattendanceShiftDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid });

            entity.ToTable("VMSAttendanceShiftDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.OffdayApril)
                .HasMaxLength(50)
                .HasColumnName("Offday_April");
            entity.Property(e => e.OffdayAug)
                .HasMaxLength(50)
                .HasColumnName("Offday_Aug");
            entity.Property(e => e.OffdayDec)
                .HasMaxLength(50)
                .HasColumnName("Offday_Dec");
            entity.Property(e => e.OffdayFeb)
                .HasMaxLength(50)
                .HasColumnName("Offday_Feb");
            entity.Property(e => e.OffdayJan)
                .HasMaxLength(50)
                .HasColumnName("Offday_Jan");
            entity.Property(e => e.OffdayJuly)
                .HasMaxLength(50)
                .HasColumnName("Offday_July");
            entity.Property(e => e.OffdayJune)
                .HasMaxLength(50)
                .HasColumnName("Offday_June");
            entity.Property(e => e.OffdayMarch)
                .HasMaxLength(50)
                .HasColumnName("Offday_March");
            entity.Property(e => e.OffdayMay)
                .HasMaxLength(50)
                .HasColumnName("Offday_May");
            entity.Property(e => e.OffdayNov)
                .HasMaxLength(50)
                .HasColumnName("Offday_Nov");
            entity.Property(e => e.OffdayOct)
                .HasMaxLength(50)
                .HasColumnName("Offday_Oct");
            entity.Property(e => e.OffdaySep)
                .HasMaxLength(50)
                .HasColumnName("Offday_Sep");
            entity.Property(e => e.PersonId)
                .HasMaxLength(100)
                .HasColumnName("Person_ID");
            entity.Property(e => e.PersonName)
                .HasMaxLength(500)
                .HasColumnName("Person_Name");
            entity.Property(e => e.ShiftApril)
                .HasMaxLength(50)
                .HasColumnName("Shift_April");
            entity.Property(e => e.ShiftAug)
                .HasMaxLength(50)
                .HasColumnName("Shift_Aug");
            entity.Property(e => e.ShiftDec)
                .HasMaxLength(50)
                .HasColumnName("Shift_Dec");
            entity.Property(e => e.ShiftFeb)
                .HasMaxLength(50)
                .HasColumnName("Shift_Feb");
            entity.Property(e => e.ShiftJan)
                .HasMaxLength(50)
                .HasColumnName("Shift_Jan");
            entity.Property(e => e.ShiftJuly)
                .HasMaxLength(50)
                .HasColumnName("Shift_July");
            entity.Property(e => e.ShiftJune)
                .HasMaxLength(50)
                .HasColumnName("Shift_June");
            entity.Property(e => e.ShiftMarch)
                .HasMaxLength(50)
                .HasColumnName("Shift_March");
            entity.Property(e => e.ShiftMay)
                .HasMaxLength(50)
                .HasColumnName("Shift_May");
            entity.Property(e => e.ShiftNov)
                .HasMaxLength(50)
                .HasColumnName("Shift_Nov");
            entity.Property(e => e.ShiftOct)
                .HasMaxLength(50)
                .HasColumnName("Shift_Oct");
            entity.Property(e => e.ShiftSep)
                .HasMaxLength(50)
                .HasColumnName("Shift_Sep");
        });

        modelBuilder.Entity<VmsattendanceShiftchangedataHistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("VMSAttendanceShiftchangedata_History");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.History).HasMaxLength(50);
            entity.Property(e => e.Month).HasMaxLength(50);
            entity.Property(e => e.OffDay)
                .HasMaxLength(50)
                .HasColumnName("Off_day");
            entity.Property(e => e.Organization).HasMaxLength(500);
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("Person_ID");
            entity.Property(e => e.PersonName).HasColumnName("Person_Name");
            entity.Property(e => e.Shift).HasMaxLength(500);
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_date");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .HasColumnName("year");
        });

        modelBuilder.Entity<VmsattendanceShiftchangedatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("VMSAttendanceShiftchangedata");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.ApproveByHr).HasColumnName("Approve_By_HR");
            entity.Property(e => e.ApproveBySupervisor).HasColumnName("Approve_By_Supervisor");
            entity.Property(e => e.ApproveDateHr)
                .HasColumnType("datetime")
                .HasColumnName("Approve_Date_HR");
            entity.Property(e => e.ApproveDateSupervisor)
                .HasColumnType("datetime")
                .HasColumnName("Approve_Date_Supervisor");
            entity.Property(e => e.ChangeOffday)
                .HasMaxLength(50)
                .HasColumnName("Change_offday");
            entity.Property(e => e.ChangeShift)
                .HasMaxLength(500)
                .HasColumnName("Change_Shift");
            entity.Property(e => e.CurrentOffday)
                .HasMaxLength(50)
                .HasColumnName("Current_Offday");
            entity.Property(e => e.CurrentShift)
                .HasMaxLength(500)
                .HasColumnName("Current_Shift");
            entity.Property(e => e.Organization).HasMaxLength(500);
            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("Person_Id");
            entity.Property(e => e.PersonName).HasColumnName("Person_Name");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
        });

        modelBuilder.Entity<VmsemployeeDetail>(entity =>
        {
            entity.HasKey(e => e.PersonId);

            entity.ToTable("VMSEmployeeDetails");

            entity.Property(e => e.PersonId)
                .HasMaxLength(50)
                .HasColumnName("PersonID");
            entity.Property(e => e.Add1)
                .HasMaxLength(50)
                .HasColumnName("add1");
            entity.Property(e => e.Add2)
                .HasMaxLength(50)
                .HasColumnName("add2");
            entity.Property(e => e.ApprovalForDocument)
                .HasMaxLength(50)
                .HasColumnName("Approval_for_document");
            entity.Property(e => e.BdayCards)
                .HasMaxLength(500)
                .HasColumnName("bday_cards");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .HasColumnName("bloodgroup");
            entity.Property(e => e.Cardno)
                .HasMaxLength(500)
                .HasColumnName("cardno");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Doi).HasColumnName("DOI");
            entity.Property(e => e.Doj).HasColumnName("DOJ");
            entity.Property(e => e.EffectiveTime).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(500)
                .HasColumnName("email_address");
            entity.Property(e => e.EmpPosition)
                .HasMaxLength(500)
                .HasColumnName("emp_position");
            entity.Property(e => e.ExpiryTime).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("First_Name");
            entity.Property(e => e.Floorno)
                .HasMaxLength(500)
                .HasColumnName("floorno");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IssueIcard).HasColumnName("Issue_Icard");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Organization).HasMaxLength(500);
            entity.Property(e => e.PersonName).HasMaxLength(500);
            entity.Property(e => e.Picture)
                .HasMaxLength(500)
                .HasColumnName("picture");
            entity.Property(e => e.ReportingUnder)
                .HasMaxLength(500)
                .HasColumnName("reporting_under");
            entity.Property(e => e.Roomno)
                .HasMaxLength(500)
                .HasColumnName("roomno");
            entity.Property(e => e.Signature)
                .HasMaxLength(200)
                .HasColumnName("signature");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("upload_date");
        });

        modelBuilder.Entity<Vmsflexdatafilter>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("VMSFLEXDATAFilter");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Organization).HasMaxLength(50);
            entity.Property(e => e.Shift1)
                .HasMaxLength(100)
                .HasColumnName("Shift_1");
            entity.Property(e => e.Shift2)
                .HasMaxLength(100)
                .HasColumnName("Shift_2");
            entity.Property(e => e.Shift3)
                .HasMaxLength(100)
                .HasColumnName("Shift_3");
        });

        modelBuilder.Entity<Vmsforexport>(entity =>
        {
            entity.ToTable("VMSFORExport");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Chckin)
                .HasMaxLength(50)
                .HasColumnName("chckin");
            entity.Property(e => e.Checkout)
                .HasMaxLength(50)
                .HasColumnName("checkout");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Early)
                .HasMaxLength(50)
                .HasColumnName("early");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.Hours)
                .HasMaxLength(50)
                .HasColumnName("hours");
            entity.Property(e => e.Late)
                .HasMaxLength(50)
                .HasColumnName("late");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Overtime)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("overtime");
            entity.Property(e => e.Personid)
                .HasMaxLength(50)
                .HasColumnName("personid");
            entity.Property(e => e.Pid)
                .HasMaxLength(50)
                .HasColumnName("PID");
            entity.Property(e => e.Sltime)
                .HasMaxLength(50)
                .HasColumnName("SLTime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Totalworkinghours)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("totalworkinghours");
            entity.Property(e => e.Typeofemployee)
                .HasMaxLength(500)
                .HasColumnName("typeofemployee");
        });

        modelBuilder.Entity<Vmsforexportattend>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("VMSFOREXPORTATTEND");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Checkin)
                .HasMaxLength(50)
                .HasColumnName("checkin");
            entity.Property(e => e.Checkout)
                .HasMaxLength(50)
                .HasColumnName("checkout");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DayAttendance)
                .HasMaxLength(500)
                .HasColumnName("day_attendance");
            entity.Property(e => e.Early)
                .HasMaxLength(50)
                .HasColumnName("early");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.Hours)
                .HasMaxLength(50)
                .HasColumnName("hours");
            entity.Property(e => e.Late)
                .HasMaxLength(50)
                .HasColumnName("late");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Overtime)
                .HasMaxLength(50)
                .HasColumnName("overtime");
            entity.Property(e => e.Personid)
                .HasMaxLength(50)
                .HasColumnName("personid");
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .HasColumnName("shift");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Typeofemployee)
                .HasMaxLength(500)
                .HasColumnName("typeofemployee");
        });

        modelBuilder.Entity<Vmsview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VMSVIEW");

            entity.Property(e => e.CardNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Device)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeviceNo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Organization).HasMaxLength(500);
            entity.Property(e => e.PersonName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<Weather>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Uv).HasColumnName("UV");
        });

        modelBuilder.Entity<WhoIsInTheBuilding>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Pid, e.PersonId });

            entity.ToTable("who_Is_In_the_Building");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Personname)
                .HasMaxLength(500)
                .HasColumnName("personname");
            entity.Property(e => e.PictureEmp).HasColumnName("picture_emp");
            entity.Property(e => e.Status).HasMaxLength(500);
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .HasColumnName("time");
        });

        modelBuilder.Entity<WorkSamplingStudyAll>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EventId });

            entity.ToTable("Work_Sampling_Study_All");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EventId)
                .HasMaxLength(400)
                .HasColumnName("EventID");
            entity.Property(e => e.EventName).HasColumnName("Event_Name");
            entity.Property(e => e.MachineName)
                .HasMaxLength(500)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineNo).HasColumnName("Machine_No");
            entity.Property(e => e.MachineStatus)
                .HasMaxLength(50)
                .HasColumnName("Machine_Status");
            entity.Property(e => e.OperatorId)
                .HasMaxLength(500)
                .HasColumnName("Operator_ID");
            entity.Property(e => e.OperatorStatus)
                .HasMaxLength(50)
                .HasColumnName("Operator_Status");
            entity.Property(e => e.SamplingDate)
                .HasColumnType("datetime")
                .HasColumnName("Sampling_Date");
            entity.Property(e => e.SamplingTime).HasColumnName("Sampling_Time");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
            entity.Property(e => e.UploadedBy).HasColumnName("Uploaded_by");
        });

        modelBuilder.Entity<WorkSamplingStudyMachine>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid, e.EventId });

            entity.ToTable("Work_Sampling_Study_machine");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.EventId)
                .HasMaxLength(400)
                .HasColumnName("EventID");
            entity.Property(e => e.EventName).HasColumnName("Event_Name");
            entity.Property(e => e.MachineName)
                .HasMaxLength(500)
                .HasColumnName("Machine_Name");
            entity.Property(e => e.MachineNo).HasColumnName("Machine_No");
            entity.Property(e => e.MachineStatus)
                .HasMaxLength(50)
                .HasColumnName("Machine_Status");
            entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");
            entity.Property(e => e.OperatorStatus)
                .HasMaxLength(50)
                .HasColumnName("Operator_Status");
            entity.Property(e => e.SamplingDate)
                .HasColumnType("datetime")
                .HasColumnName("Sampling_Date");
            entity.Property(e => e.SamplingTime).HasColumnName("Sampling_Time");
            entity.Property(e => e.UploadDate)
                .HasColumnType("datetime")
                .HasColumnName("Upload_Date");
            entity.Property(e => e.UploadYn).HasColumnName("upload_YN");
            entity.Property(e => e.UplodBy).HasColumnName("Uplod_by");
        });

        modelBuilder.Entity<WorkingSamplingTime>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Mid, e.Pid });

            entity.ToTable("Working_Sampling_Time");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.MachineName)
                .HasMaxLength(500)
                .HasColumnName("Machine_name");
            entity.Property(e => e.MachineRecordDate).HasColumnName("Machine_Record_Date");
            entity.Property(e => e.MachineRecordTime).HasColumnName("machine_Record_Time");
            entity.Property(e => e.TMachine)
                .HasMaxLength(50)
                .HasColumnName("t_machine");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
