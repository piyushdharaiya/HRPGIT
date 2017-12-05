
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/30/2017 23:28:46
-- Generated from EDMX file: E:\Work\Piyush\PDHR\PDHR\Models\HRP1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HRP1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DeptMastEmployeeMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeMasts] DROP CONSTRAINT [FK_DeptMastEmployeeMast];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpLevelEmployeeMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeMasts] DROP CONSTRAINT [FK_EmpLevelEmployeeMast];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeMastEmpLeaves]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpLeaves] DROP CONSTRAINT [FK_EmployeeMastEmpLeaves];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeMastEmployeeSalaryMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeSalaryMasts] DROP CONSTRAINT [FK_EmployeeMastEmployeeSalaryMast];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeSalaryMastEmpMonthlySalary]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpMonthlySalaries] DROP CONSTRAINT [FK_EmployeeSalaryMastEmpMonthlySalary];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeSalaryMastEmpSalaryComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpSalaryComponents] DROP CONSTRAINT [FK_EmployeeSalaryMastEmpSalaryComponent];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployerMastEmployeeMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeMasts] DROP CONSTRAINT [FK_EmployerMastEmployeeMast];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployerMastHolidaysMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HolidaysMasts] DROP CONSTRAINT [FK_EmployerMastHolidaysMast];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployerMastLeaveMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LeaveMasts] DROP CONSTRAINT [FK_EmployerMastLeaveMast];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpMonthlySalaryEmpMonthlyComponet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpMonthlyComponets] DROP CONSTRAINT [FK_EmpMonthlySalaryEmpMonthlyComponet];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpSalaryComponentEmpMonthlyComponet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpMonthlyComponets] DROP CONSTRAINT [FK_EmpSalaryComponentEmpMonthlyComponet];
GO
IF OBJECT_ID(N'[dbo].[FK_FYMasterEmployeeMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeMasts] DROP CONSTRAINT [FK_FYMasterEmployeeMast];
GO
IF OBJECT_ID(N'[dbo].[FK_FYMasterEmployeeSalaryMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeSalaryMasts] DROP CONSTRAINT [FK_FYMasterEmployeeSalaryMast];
GO
IF OBJECT_ID(N'[dbo].[FK_FYMasterEmployerMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployerMasts] DROP CONSTRAINT [FK_FYMasterEmployerMast];
GO
IF OBJECT_ID(N'[dbo].[FK_FYMasterHolidaysMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HolidaysMasts] DROP CONSTRAINT [FK_FYMasterHolidaysMast];
GO
IF OBJECT_ID(N'[dbo].[FK_FYMasterLeaveMast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LeaveMasts] DROP CONSTRAINT [FK_FYMasterLeaveMast];
GO
IF OBJECT_ID(N'[dbo].[FK_LeaveMastEmpLeaves]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpLeaves] DROP CONSTRAINT [FK_LeaveMastEmpLeaves];
GO
IF OBJECT_ID(N'[dbo].[FK_SalaryComponentMastEmpSalaryComponent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpSalaryComponents] DROP CONSTRAINT [FK_SalaryComponentMastEmpSalaryComponent];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DeptMasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeptMasts];
GO
IF OBJECT_ID(N'[dbo].[EmpLeaves]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpLeaves];
GO
IF OBJECT_ID(N'[dbo].[EmpLevels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpLevels];
GO
IF OBJECT_ID(N'[dbo].[EmployeeMasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeMasts];
GO
IF OBJECT_ID(N'[dbo].[EmployeeSalaryMasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeSalaryMasts];
GO
IF OBJECT_ID(N'[dbo].[EmployerMasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployerMasts];
GO
IF OBJECT_ID(N'[dbo].[EmpMonthlyComponets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpMonthlyComponets];
GO
IF OBJECT_ID(N'[dbo].[EmpMonthlySalaries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpMonthlySalaries];
GO
IF OBJECT_ID(N'[dbo].[EmpSalaryComponents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpSalaryComponents];
GO
IF OBJECT_ID(N'[dbo].[FYMasters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FYMasters];
GO
IF OBJECT_ID(N'[dbo].[HolidaysMasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HolidaysMasts];
GO
IF OBJECT_ID(N'[dbo].[LeaveMasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LeaveMasts];
GO
IF OBJECT_ID(N'[dbo].[SalaryComponentMasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalaryComponentMasts];
GO
IF OBJECT_ID(N'[HRP1ModelStoreContainer].[View_2]', 'U') IS NOT NULL
    DROP TABLE [HRP1ModelStoreContainer].[View_2];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DeptMasts'
CREATE TABLE [dbo].[DeptMasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Dept_Name] varchar(50)  NOT NULL
);
GO

-- Creating table 'EmpLeaves'
CREATE TABLE [dbo].[EmpLeaves] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FromDate] datetime  NOT NULL,
    [Todate] datetime  NOT NULL,
    [Remarks] nvarchar(max)  NOT NULL,
    [LeaveDays] int  NOT NULL,
    [LeaveStatus] nvarchar(max)  NOT NULL,
    [EmployeeMastId] int  NOT NULL,
    [LeaveMastId] int  NOT NULL
);
GO

-- Creating table 'EmpLevels'
CREATE TABLE [dbo].[EmpLevels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LevelName] nvarchar(max)  NOT NULL,
    [wfd] datetime  NOT NULL
);
GO

-- Creating table 'EmployeeMasts'
CREATE TABLE [dbo].[EmployeeMasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fname] nvarchar(max)  NOT NULL,
    [MName] nvarchar(max)  NOT NULL,
    [Lname] nvarchar(max)  NOT NULL,
    [DOB] datetime  NOT NULL,
    [PANno] nvarchar(max)  NOT NULL,
    [UANNo] nvarchar(max)  NOT NULL,
    [ESINo] nvarchar(max)  NOT NULL,
    [PFNo] nvarchar(max)  NOT NULL,
    [JoinofDate] datetime  NOT NULL,
    [city] nvarchar(max)  NOT NULL,
    [State] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [pinCode] nvarchar(max)  NOT NULL,
    [Emailid] nvarchar(max)  NOT NULL,
    [BankName] nvarchar(max)  NOT NULL,
    [Accountno] nvarchar(max)  NOT NULL,
    [IFSCCode] nvarchar(max)  NOT NULL,
    [isactive] bit  NULL,
    [FYMasterFY] varchar(10)  NOT NULL,
    [DeptMastId] int  NOT NULL,
    [EmpLevelId] int  NOT NULL,
    [EmployerMast_cc1] int  NOT NULL
);
GO

-- Creating table 'EmployeeSalaryMasts'
CREATE TABLE [dbo].[EmployeeSalaryMasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [wfd] datetime  NOT NULL,
    [CTCMonthly] float  NOT NULL,
    [CTCYear] float  NOT NULL,
    [Fixcompamt] float  NOT NULL,
    [flexcompamt] float  NOT NULL,
    [EmployeeMastId] int  NOT NULL,
    [FYMasterFY] varchar(10)  NOT NULL
);
GO

-- Creating table 'EmployerMasts'
CREATE TABLE [dbo].[EmployerMasts] (
    [cc] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [PANNo] nvarchar(max)  NOT NULL,
    [remarks] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [State] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Pincode] nvarchar(max)  NOT NULL,
    [Emailid] nvarchar(max)  NOT NULL,
    [isactive] bit  NULL,
    [FYMasterFY] varchar(10)  NOT NULL
);
GO

-- Creating table 'EmpMonthlyComponets'
CREATE TABLE [dbo].[EmpMonthlyComponets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [amount] float  NOT NULL,
    [EmpMonthlySalaryId] int  NOT NULL,
    [EmpSalaryComponentId] int  NOT NULL
);
GO

-- Creating table 'EmpMonthlySalaries'
CREATE TABLE [dbo].[EmpMonthlySalaries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WorkingMonthDate] datetime  NOT NULL,
    [TotalDays] smallint  NOT NULL,
    [WorkingDays] smallint  NOT NULL,
    [LeaveDays] smallint  NOT NULL,
    [TotalSalaryAmount] float  NOT NULL,
    [OnhandAmount] float  NOT NULL,
    [Deductamount] float  NOT NULL,
    [EmployeeSalaryMastId] int  NOT NULL
);
GO

-- Creating table 'EmpSalaryComponents'
CREATE TABLE [dbo].[EmpSalaryComponents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] float  NOT NULL,
    [EmployeeSalaryMastId] int  NOT NULL,
    [SalaryComponentMastId] int  NOT NULL
);
GO

-- Creating table 'FYMasters'
CREATE TABLE [dbo].[FYMasters] (
    [FY] varchar(10)  NOT NULL
);
GO

-- Creating table 'HolidaysMasts'
CREATE TABLE [dbo].[HolidaysMasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HolidaysName] nvarchar(max)  NOT NULL,
    [HolidaysDate] datetime  NOT NULL,
    [wfd] datetime  NOT NULL,
    [FYMasterFY] varchar(10)  NOT NULL,
    [EmployerMast_cc] int  NOT NULL
);
GO

-- Creating table 'LeaveMasts'
CREATE TABLE [dbo].[LeaveMasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LeaveName] nvarchar(max)  NOT NULL,
    [NoofDays] int  NULL,
    [wfd] datetime  NOT NULL,
    [FYMasterFY] varchar(10)  NOT NULL,
    [EmployerMast_cc] int  NOT NULL
);
GO

-- Creating table 'SalaryComponentMasts'
CREATE TABLE [dbo].[SalaryComponentMasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [wfd] datetime  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CompType] int  NOT NULL,
    [TypeRsPer] int  NOT NULL,
    [amount] float  NOT NULL,
    [basedoncomponent] int  NULL,
    [Compcalcutiontype] int  NOT NULL
);
GO

-- Creating table 'View_2'
CREATE TABLE [dbo].[View_2] (
    [EmployeeSalaryMastsid] int  NOT NULL,
    [EmployeeSalaryMastswfd] datetime  NOT NULL,
    [CTCMonthly] float  NOT NULL,
    [CTCYear] float  NOT NULL,
    [Fixcompamt] float  NOT NULL,
    [flexcompamt] float  NOT NULL,
    [EmployeeMastId] int  NOT NULL,
    [FYMasterFY] varchar(10)  NOT NULL,
    [EmpSalaryComponentsid] int  NOT NULL,
    [EmpSalaryComponentsamount] float  NOT NULL,
    [EmployeeSalaryMastId] int  NOT NULL,
    [SalaryComponentMastId] int  NOT NULL,
    [SalaryComponentMastsid] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CompType] int  NOT NULL,
    [TypeRsPer] int  NOT NULL,
    [amount] float  NOT NULL,
    [basedoncomponent] int  NULL,
    [Compcalcutiontype] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DeptMasts'
ALTER TABLE [dbo].[DeptMasts]
ADD CONSTRAINT [PK_DeptMasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpLeaves'
ALTER TABLE [dbo].[EmpLeaves]
ADD CONSTRAINT [PK_EmpLeaves]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpLevels'
ALTER TABLE [dbo].[EmpLevels]
ADD CONSTRAINT [PK_EmpLevels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeMasts'
ALTER TABLE [dbo].[EmployeeMasts]
ADD CONSTRAINT [PK_EmployeeMasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeSalaryMasts'
ALTER TABLE [dbo].[EmployeeSalaryMasts]
ADD CONSTRAINT [PK_EmployeeSalaryMasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [cc] in table 'EmployerMasts'
ALTER TABLE [dbo].[EmployerMasts]
ADD CONSTRAINT [PK_EmployerMasts]
    PRIMARY KEY CLUSTERED ([cc] ASC);
GO

-- Creating primary key on [Id] in table 'EmpMonthlyComponets'
ALTER TABLE [dbo].[EmpMonthlyComponets]
ADD CONSTRAINT [PK_EmpMonthlyComponets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpMonthlySalaries'
ALTER TABLE [dbo].[EmpMonthlySalaries]
ADD CONSTRAINT [PK_EmpMonthlySalaries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpSalaryComponents'
ALTER TABLE [dbo].[EmpSalaryComponents]
ADD CONSTRAINT [PK_EmpSalaryComponents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [FY] in table 'FYMasters'
ALTER TABLE [dbo].[FYMasters]
ADD CONSTRAINT [PK_FYMasters]
    PRIMARY KEY CLUSTERED ([FY] ASC);
GO

-- Creating primary key on [Id] in table 'HolidaysMasts'
ALTER TABLE [dbo].[HolidaysMasts]
ADD CONSTRAINT [PK_HolidaysMasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LeaveMasts'
ALTER TABLE [dbo].[LeaveMasts]
ADD CONSTRAINT [PK_LeaveMasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SalaryComponentMasts'
ALTER TABLE [dbo].[SalaryComponentMasts]
ADD CONSTRAINT [PK_SalaryComponentMasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [EmployeeSalaryMastsid], [EmployeeSalaryMastswfd], [CTCMonthly], [CTCYear], [Fixcompamt], [flexcompamt], [EmployeeMastId], [FYMasterFY], [EmpSalaryComponentsid], [EmpSalaryComponentsamount], [EmployeeSalaryMastId], [SalaryComponentMastId], [SalaryComponentMastsid], [Name], [CompType], [TypeRsPer], [amount], [Compcalcutiontype] in table 'View_2'
ALTER TABLE [dbo].[View_2]
ADD CONSTRAINT [PK_View_2]
    PRIMARY KEY CLUSTERED ([EmployeeSalaryMastsid], [EmployeeSalaryMastswfd], [CTCMonthly], [CTCYear], [Fixcompamt], [flexcompamt], [EmployeeMastId], [FYMasterFY], [EmpSalaryComponentsid], [EmpSalaryComponentsamount], [EmployeeSalaryMastId], [SalaryComponentMastId], [SalaryComponentMastsid], [Name], [CompType], [TypeRsPer], [amount], [Compcalcutiontype] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptMastId] in table 'EmployeeMasts'
ALTER TABLE [dbo].[EmployeeMasts]
ADD CONSTRAINT [FK_DeptMastEmployeeMast]
    FOREIGN KEY ([DeptMastId])
    REFERENCES [dbo].[DeptMasts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptMastEmployeeMast'
CREATE INDEX [IX_FK_DeptMastEmployeeMast]
ON [dbo].[EmployeeMasts]
    ([DeptMastId]);
GO

-- Creating foreign key on [EmployeeMastId] in table 'EmpLeaves'
ALTER TABLE [dbo].[EmpLeaves]
ADD CONSTRAINT [FK_EmployeeMastEmpLeaves]
    FOREIGN KEY ([EmployeeMastId])
    REFERENCES [dbo].[EmployeeMasts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeMastEmpLeaves'
CREATE INDEX [IX_FK_EmployeeMastEmpLeaves]
ON [dbo].[EmpLeaves]
    ([EmployeeMastId]);
GO

-- Creating foreign key on [LeaveMastId] in table 'EmpLeaves'
ALTER TABLE [dbo].[EmpLeaves]
ADD CONSTRAINT [FK_LeaveMastEmpLeaves]
    FOREIGN KEY ([LeaveMastId])
    REFERENCES [dbo].[LeaveMasts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LeaveMastEmpLeaves'
CREATE INDEX [IX_FK_LeaveMastEmpLeaves]
ON [dbo].[EmpLeaves]
    ([LeaveMastId]);
GO

-- Creating foreign key on [EmpLevelId] in table 'EmployeeMasts'
ALTER TABLE [dbo].[EmployeeMasts]
ADD CONSTRAINT [FK_EmpLevelEmployeeMast]
    FOREIGN KEY ([EmpLevelId])
    REFERENCES [dbo].[EmpLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpLevelEmployeeMast'
CREATE INDEX [IX_FK_EmpLevelEmployeeMast]
ON [dbo].[EmployeeMasts]
    ([EmpLevelId]);
GO

-- Creating foreign key on [EmployeeMastId] in table 'EmployeeSalaryMasts'
ALTER TABLE [dbo].[EmployeeSalaryMasts]
ADD CONSTRAINT [FK_EmployeeMastEmployeeSalaryMast]
    FOREIGN KEY ([EmployeeMastId])
    REFERENCES [dbo].[EmployeeMasts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeMastEmployeeSalaryMast'
CREATE INDEX [IX_FK_EmployeeMastEmployeeSalaryMast]
ON [dbo].[EmployeeSalaryMasts]
    ([EmployeeMastId]);
GO

-- Creating foreign key on [EmployerMast_cc1] in table 'EmployeeMasts'
ALTER TABLE [dbo].[EmployeeMasts]
ADD CONSTRAINT [FK_EmployerMastEmployeeMast]
    FOREIGN KEY ([EmployerMast_cc1])
    REFERENCES [dbo].[EmployerMasts]
        ([cc])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployerMastEmployeeMast'
CREATE INDEX [IX_FK_EmployerMastEmployeeMast]
ON [dbo].[EmployeeMasts]
    ([EmployerMast_cc1]);
GO

-- Creating foreign key on [FYMasterFY] in table 'EmployeeMasts'
ALTER TABLE [dbo].[EmployeeMasts]
ADD CONSTRAINT [FK_FYMasterEmployeeMast]
    FOREIGN KEY ([FYMasterFY])
    REFERENCES [dbo].[FYMasters]
        ([FY])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FYMasterEmployeeMast'
CREATE INDEX [IX_FK_FYMasterEmployeeMast]
ON [dbo].[EmployeeMasts]
    ([FYMasterFY]);
GO

-- Creating foreign key on [EmployeeSalaryMastId] in table 'EmpMonthlySalaries'
ALTER TABLE [dbo].[EmpMonthlySalaries]
ADD CONSTRAINT [FK_EmployeeSalaryMastEmpMonthlySalary]
    FOREIGN KEY ([EmployeeSalaryMastId])
    REFERENCES [dbo].[EmployeeSalaryMasts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeSalaryMastEmpMonthlySalary'
CREATE INDEX [IX_FK_EmployeeSalaryMastEmpMonthlySalary]
ON [dbo].[EmpMonthlySalaries]
    ([EmployeeSalaryMastId]);
GO

-- Creating foreign key on [EmployeeSalaryMastId] in table 'EmpSalaryComponents'
ALTER TABLE [dbo].[EmpSalaryComponents]
ADD CONSTRAINT [FK_EmployeeSalaryMastEmpSalaryComponent]
    FOREIGN KEY ([EmployeeSalaryMastId])
    REFERENCES [dbo].[EmployeeSalaryMasts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeSalaryMastEmpSalaryComponent'
CREATE INDEX [IX_FK_EmployeeSalaryMastEmpSalaryComponent]
ON [dbo].[EmpSalaryComponents]
    ([EmployeeSalaryMastId]);
GO

-- Creating foreign key on [FYMasterFY] in table 'EmployeeSalaryMasts'
ALTER TABLE [dbo].[EmployeeSalaryMasts]
ADD CONSTRAINT [FK_FYMasterEmployeeSalaryMast]
    FOREIGN KEY ([FYMasterFY])
    REFERENCES [dbo].[FYMasters]
        ([FY])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FYMasterEmployeeSalaryMast'
CREATE INDEX [IX_FK_FYMasterEmployeeSalaryMast]
ON [dbo].[EmployeeSalaryMasts]
    ([FYMasterFY]);
GO

-- Creating foreign key on [EmployerMast_cc] in table 'HolidaysMasts'
ALTER TABLE [dbo].[HolidaysMasts]
ADD CONSTRAINT [FK_EmployerMastHolidaysMast]
    FOREIGN KEY ([EmployerMast_cc])
    REFERENCES [dbo].[EmployerMasts]
        ([cc])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployerMastHolidaysMast'
CREATE INDEX [IX_FK_EmployerMastHolidaysMast]
ON [dbo].[HolidaysMasts]
    ([EmployerMast_cc]);
GO

-- Creating foreign key on [EmployerMast_cc] in table 'LeaveMasts'
ALTER TABLE [dbo].[LeaveMasts]
ADD CONSTRAINT [FK_EmployerMastLeaveMast]
    FOREIGN KEY ([EmployerMast_cc])
    REFERENCES [dbo].[EmployerMasts]
        ([cc])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployerMastLeaveMast'
CREATE INDEX [IX_FK_EmployerMastLeaveMast]
ON [dbo].[LeaveMasts]
    ([EmployerMast_cc]);
GO

-- Creating foreign key on [FYMasterFY] in table 'EmployerMasts'
ALTER TABLE [dbo].[EmployerMasts]
ADD CONSTRAINT [FK_FYMasterEmployerMast]
    FOREIGN KEY ([FYMasterFY])
    REFERENCES [dbo].[FYMasters]
        ([FY])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FYMasterEmployerMast'
CREATE INDEX [IX_FK_FYMasterEmployerMast]
ON [dbo].[EmployerMasts]
    ([FYMasterFY]);
GO

-- Creating foreign key on [EmpMonthlySalaryId] in table 'EmpMonthlyComponets'
ALTER TABLE [dbo].[EmpMonthlyComponets]
ADD CONSTRAINT [FK_EmpMonthlySalaryEmpMonthlyComponet]
    FOREIGN KEY ([EmpMonthlySalaryId])
    REFERENCES [dbo].[EmpMonthlySalaries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpMonthlySalaryEmpMonthlyComponet'
CREATE INDEX [IX_FK_EmpMonthlySalaryEmpMonthlyComponet]
ON [dbo].[EmpMonthlyComponets]
    ([EmpMonthlySalaryId]);
GO

-- Creating foreign key on [EmpSalaryComponentId] in table 'EmpMonthlyComponets'
ALTER TABLE [dbo].[EmpMonthlyComponets]
ADD CONSTRAINT [FK_EmpSalaryComponentEmpMonthlyComponet]
    FOREIGN KEY ([EmpSalaryComponentId])
    REFERENCES [dbo].[EmpSalaryComponents]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpSalaryComponentEmpMonthlyComponet'
CREATE INDEX [IX_FK_EmpSalaryComponentEmpMonthlyComponet]
ON [dbo].[EmpMonthlyComponets]
    ([EmpSalaryComponentId]);
GO

-- Creating foreign key on [SalaryComponentMastId] in table 'EmpSalaryComponents'
ALTER TABLE [dbo].[EmpSalaryComponents]
ADD CONSTRAINT [FK_SalaryComponentMastEmpSalaryComponent]
    FOREIGN KEY ([SalaryComponentMastId])
    REFERENCES [dbo].[SalaryComponentMasts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalaryComponentMastEmpSalaryComponent'
CREATE INDEX [IX_FK_SalaryComponentMastEmpSalaryComponent]
ON [dbo].[EmpSalaryComponents]
    ([SalaryComponentMastId]);
GO

-- Creating foreign key on [FYMasterFY] in table 'HolidaysMasts'
ALTER TABLE [dbo].[HolidaysMasts]
ADD CONSTRAINT [FK_FYMasterHolidaysMast]
    FOREIGN KEY ([FYMasterFY])
    REFERENCES [dbo].[FYMasters]
        ([FY])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FYMasterHolidaysMast'
CREATE INDEX [IX_FK_FYMasterHolidaysMast]
ON [dbo].[HolidaysMasts]
    ([FYMasterFY]);
GO

-- Creating foreign key on [FYMasterFY] in table 'LeaveMasts'
ALTER TABLE [dbo].[LeaveMasts]
ADD CONSTRAINT [FK_FYMasterLeaveMast]
    FOREIGN KEY ([FYMasterFY])
    REFERENCES [dbo].[FYMasters]
        ([FY])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FYMasterLeaveMast'
CREATE INDEX [IX_FK_FYMasterLeaveMast]
ON [dbo].[LeaveMasts]
    ([FYMasterFY]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------