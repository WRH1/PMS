USE [PMSData]
GO
/****** Object:  Table [dbo].[UNITS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UNITS](
	[CONSTNAME] [char](10) NULL,
	[UNITS] [numeric](5, 0) NULL,
	[UNITNAME] [char](20) NULL,
	[MTML_UOM] [char](12) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRACCOMP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRACCOMP](
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[REMARK] [char](254) NULL,
	[MDATE] [datetime] NULL,
	[SPNO] [char](20) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[TOTHRS] [numeric](7, 0) NULL,
	[HRSNET] [numeric](7, 0) NULL,
	[COMPHRS] [numeric](7, 0) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYSVUP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYSVUP](
	[VARNAME] [char](11) NULL,
	[TYPE] [char](1) NULL,
	[VALUE] [varchar](max) NULL,
	[COMMENT] [char](100) NULL,
	[FIXVALUE] [bit] NULL,
	[EDITED] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYSVAR]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYSVAR](
	[VARNAME] [char](11) NULL,
	[TYPE] [char](1) NULL,
	[VALUE] [varchar](max) NULL,
	[COMMENT] [char](100) NULL,
	[FIXVALUE] [bit] NULL,
	[EDITED] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYSCODE]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYSCODE](
	[CODEDATE] [datetime] NULL,
	[KEYS] [char](8) NULL,
	[MANUFCODE] [char](10) NULL,
	[CONNS] [char](8) NULL,
	[FILES] [char](8) NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[SMAINCODE] [char](10) NULL,
	[SSUBCODE] [char](10) NULL,
	[INSULCODE] [char](10) NULL,
	[SURVCODE] [char](10) NULL,
	[STMAINCODE] [char](10) NULL,
	[STMASTCODE] [char](10) NULL,
	[GRPMCODE] [char](10) NULL,
	[MEGGERCODE] [char](10) NULL,
	[GRPCODE] [char](10) NULL,
	[SUBGRPCODE] [char](10) NULL,
	[DRILLCODE] [char](10) NULL,
	[MSGID] [char](10) NULL,
	[MSGCONTID] [char](10) NULL,
	[COMPCODE] [char](10) NULL,
	[OFFDEFCODE] [char](10) NULL,
	[SHPDEFCODE] [char](10) NULL,
	[SRVCODE] [char](10) NULL,
	[TRANSCODE] [char](10) NULL,
	[SPREQID] [char](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SURVMAIN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SURVMAIN](
	[SMAINCODE] [int] IDENTITY(1,1) NOT NULL,
	[SNAME] [char](100) NULL,
	[SMCODE] [char](8) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[SMORD] [numeric](7, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_SURVMAIN] PRIMARY KEY CLUSTERED 
(
	[SMAINCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SURVSTAT]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SURVSTAT](
	[SLNO] [char](5) NULL,
	[ITEM] [char](65) NULL,
	[TYPE] [char](12) NULL,
	[NO] [char](20) NULL,
	[EXP] [datetime] NULL,
	[PLACE] [char](35) NULL,
	[DATES] [datetime] NULL,
	[REMARK] [char](30) NULL,
	[EXTN] [char](10) NULL,
	[SURVCODE] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[L_DEFA] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINBK]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINBK](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[MAINITEM] [char](40) NULL,
	[SURVTYPE] [char](1) NULL,
	[M_P] [char](1) NULL,
	[TOTHRS] [numeric](7, 0) NULL,
	[ME] [bit] NULL,
	[ORGDIA] [numeric](6, 2) NULL,
	[AE] [bit] NULL,
	[NUM] [numeric](2, 0) NULL,
	[THU_DATE] [datetime] NULL,
	[SEPA] [bit] NULL,
	[ACOMP] [bit] NULL,
	[AL] [bit] NULL,
	[PMPOHL] [bit] NULL,
	[PMPRTN] [bit] NULL,
	[MOTOHL] [bit] NULL,
	[MOTRTN] [bit] NULL,
	[EDITED] [bit] NULL,
	[L_MGROUP] [bit] NULL,
	[MTCODE] [char](8) NULL,
	[EDITDT] [datetime] NULL,
	[MES] [bit] NULL,
	[GRPMCODE] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[USERS] [char](35) NULL,
	[SLF] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MAINBK] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOGBOOK]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOGBOOK](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DT] [datetime] NULL,
	[TYPECODE] [char](10) NULL,
	[CATEGORY] [char](1) NULL,
	[DATA1] [char](15) NULL,
	[DATA2] [char](15) NULL,
	[DATA3] [char](15) NULL,
	[DATA4] [char](15) NULL,
	[DATA5] [char](15) NULL,
	[DATA6] [char](15) NULL,
	[DATA7] [char](15) NULL,
	[DATA8] [char](15) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_LOGBOOK] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LINERPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LINERPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[MES] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_LINERPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LINEREAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LINEREAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[LCLSID] [char](15) NULL,
	[LINRSINCE] [datetime] NULL,
	[LTOTHRS] [char](6) NULL,
	[LHRSNET] [char](6) NULL,
	[WITHDRAWN] [bit] NULL,
	[MAXOVAL] [char](6) NULL,
	[PERMOVAL] [char](6) NULL,
	[REMARK] [char](80) NULL,
	[COND] [char](80) NULL,
	[HIST] [char](254) NULL,
	[CHECKS] [bit] NULL,
	[NONRETURN] [bit] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[LINER] [numeric](1, 0) NULL,
	[IDTMARKS] [char](15) NULL,
	[MES] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_LINEREAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LINER]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LINER](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[PS1] [numeric](6, 2) NULL,
	[PS2] [numeric](6, 2) NULL,
	[PS3] [numeric](6, 2) NULL,
	[PS4] [numeric](6, 2) NULL,
	[PS5] [numeric](6, 2) NULL,
	[PS6] [numeric](6, 2) NULL,
	[PS7] [numeric](6, 2) NULL,
	[PS8] [numeric](6, 2) NULL,
	[PS9] [numeric](6, 2) NULL,
	[PS10] [numeric](6, 2) NULL,
	[PS11] [numeric](6, 2) NULL,
	[PS12] [numeric](6, 2) NULL,
	[FA1] [numeric](6, 2) NULL,
	[FA2] [numeric](6, 2) NULL,
	[FA3] [numeric](6, 2) NULL,
	[FA4] [numeric](6, 2) NULL,
	[FA5] [numeric](6, 2) NULL,
	[FA6] [numeric](6, 2) NULL,
	[FA7] [numeric](6, 2) NULL,
	[FA8] [numeric](6, 2) NULL,
	[FA9] [numeric](6, 2) NULL,
	[FA10] [numeric](6, 2) NULL,
	[FA11] [numeric](6, 2) NULL,
	[FA12] [numeric](6, 2) NULL,
	[LINERNOW] [numeric](6, 2) NULL,
	[TOTSH] [numeric](10, 0) NULL,
	[A_HRS] [numeric](6, 2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[MAXDIAPER] [numeric](6, 2) NULL,
	[CYLOIL] [char](20) NULL,
	[SPECCONS] [numeric](7, 4) NULL,
	[MES] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_LINER] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JOBPARTS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JOBPARTS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SCHED] [numeric](4, 0) NULL,
	[KEYS] [char](8) NULL,
	[CATEGORY] [char](1) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_JOBPARTS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INSUMAIN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INSUMAIN](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[INSULCODE] [char](10) NULL,
	[INSULATOR] [char](60) NULL,
	[PMSCODE] [char](10) NULL,
	[MAINCODE] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INSUMAIN] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INSUDONE]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INSUDONE](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[INSULCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[READING] [char](4) NULL,
	[RDATE] [datetime] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INSUDONE] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INJURYPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INJURYPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INJURYPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INJURYPERS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INJURYPERS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[CREWCODE] [char](10) NULL,
	[CREWNAME] [char](200) NULL,
	[JDATE] [datetime] NULL,
	[CDATE] [datetime] NULL,
	[REPATRIAT] [bit] NULL,
	[HOSPITAL] [bit] NULL,
	[RANK] [char](20) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INJURYPERS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INJURYOF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INJURYOF](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[OFFUSER] [char](60) NULL,
	[OFFCOMM] [varchar](max) NULL,
	[OFFCOMMDT] [datetime] NULL,
	[REFNO] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[UPDTREC] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INJURYOF] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INJURY]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INJURY](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[SEVERITY] [numeric](1, 0) NULL,
	[PROBABLE] [numeric](1, 0) NULL,
	[RISKFACTOR] [numeric](3, 0) NULL,
	[SUBJECT] [varchar](max) NULL,
	[ACCDATE] [datetime] NULL,
	[LT] [char](10) NULL,
	[GMT] [char](10) NULL,
	[DEPPORT] [char](30) NULL,
	[DEPDATE] [datetime] NULL,
	[DESTPORT] [char](30) NULL,
	[ARRDATE] [datetime] NULL,
	[PORTNAME] [char](30) NULL,
	[LATITUDE] [char](10) NULL,
	[LONGITUDE] [char](10) NULL,
	[PERSNAME] [char](30) NULL,
	[RANK] [char](10) NULL,
	[AGE] [numeric](3, 0) NULL,
	[TASKINVOL] [char](10) NULL,
	[LOCATION] [char](10) NULL,
	[ACCTYPE] [char](10) NULL,
	[PRIMCAUSE] [char](10) NULL,
	[SECONCAUS] [char](10) NULL,
	[PERSONAL] [char](10) NULL,
	[JOB] [char](10) NULL,
	[MAININJURY] [char](10) NULL,
	[SAFEWORKCO] [char](10) NULL,
	[DDAYS] [numeric](3, 0) NULL,
	[DHRS] [numeric](2, 0) NULL,
	[DMINS] [numeric](2, 0) NULL,
	[DREASON] [char](50) NULL,
	[MHOURWORKH] [numeric](2, 0) NULL,
	[MHOURWORKM] [numeric](2, 0) NULL,
	[PREVDAYH] [numeric](2, 0) NULL,
	[PREVDAYM] [numeric](2, 0) NULL,
	[RESTH] [numeric](2, 0) NULL,
	[RESTM] [numeric](2, 0) NULL,
	[MHOURLOSTD] [numeric](3, 0) NULL,
	[MHOURLOSTH] [numeric](2, 0) NULL,
	[MHOURLOSTM] [numeric](2, 0) NULL,
	[DEVIA] [bit] NULL,
	[OFFHIRE] [bit] NULL,
	[REPATRI] [bit] NULL,
	[EVACU] [bit] NULL,
	[HOSPITAL] [bit] NULL,
	[OCIMF1] [bit] NULL,
	[OCIMF2] [bit] NULL,
	[OCIMF3] [bit] NULL,
	[OCIMF4] [bit] NULL,
	[OCIMF5] [bit] NULL,
	[OCIMF6] [bit] NULL,
	[OCIMF7] [bit] NULL,
	[EVENTS] [varchar](max) NULL,
	[CAUSEWHY] [varchar](max) NULL,
	[REGULATION] [varchar](max) NULL,
	[ROUTVIOLAT] [varchar](max) NULL,
	[EXCEPVIOLA] [varchar](max) NULL,
	[SLIPLAPSE] [varchar](max) NULL,
	[MISTAKE] [varchar](max) NULL,
	[REMARK] [varchar](max) NULL,
	[FIRSTAID] [varchar](max) NULL,
	[MEDICOST] [numeric](7, 2) NULL,
	[DOCTCOST] [numeric](7, 2) NULL,
	[REPATCOST] [numeric](7, 2) NULL,
	[EVACCOST] [numeric](7, 2) NULL,
	[OFFHCOST] [numeric](7, 2) NULL,
	[VDELAYCOST] [numeric](7, 2) NULL,
	[MANHLCOST] [numeric](7, 2) NULL,
	[DEVIATCOST] [numeric](7, 2) NULL,
	[MISCEXPCOS] [numeric](7, 2) NULL,
	[TOTALS] [numeric](10, 2) NULL,
	[MISCREASON] [varchar](max) NULL,
	[ATTCHMAST] [bit] NULL,
	[ATTCHLOG] [bit] NULL,
	[ATTCHPHOTO] [bit] NULL,
	[MASTERNAME] [char](30) NULL,
	[CENAME] [char](30) NULL,
	[REPODATE] [datetime] NULL,
	[MASTERCOMM] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INJURY] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INCIDENTPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INCIDENTPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INCIDENTPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INCIDENTOF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INCIDENTOF](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[OFFUSER] [char](60) NULL,
	[OFFCOMM] [varchar](max) NULL,
	[OFFCOMMDT] [datetime] NULL,
	[REFNO] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[UPDTREC] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INCIDENTOF] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INCIDENT]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INCIDENT](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[PROP] [bit] NULL,
	[ENVI] [bit] NULL,
	[BUSI] [bit] NULL,
	[SEVERITY] [numeric](1, 0) NULL,
	[PROBABLE] [numeric](1, 0) NULL,
	[RISKFACTOR] [numeric](3, 0) NULL,
	[SUBJECT] [varchar](max) NULL,
	[ACCDATE] [datetime] NULL,
	[LT] [char](10) NULL,
	[GMT] [char](10) NULL,
	[DEPPORT] [char](30) NULL,
	[DEPDATE] [datetime] NULL,
	[DESTPORT] [char](30) NULL,
	[ARRDATE] [datetime] NULL,
	[PORTNAME] [char](30) NULL,
	[LATITUDE] [char](10) NULL,
	[LONGITUDE] [char](10) NULL,
	[TASKINVOL] [char](10) NULL,
	[LOCATION] [char](10) NULL,
	[ACCTYPE] [char](10) NULL,
	[PRIMCAUSE] [char](10) NULL,
	[SECONCAUS] [char](10) NULL,
	[PERSONAL] [char](10) NULL,
	[JOB] [char](10) NULL,
	[MAINCAT] [char](10) NULL,
	[SUBCAT] [char](10) NULL,
	[DDAYS] [numeric](3, 0) NULL,
	[DHRS] [numeric](2, 0) NULL,
	[DMINS] [numeric](2, 0) NULL,
	[DREASON] [char](100) NULL,
	[MHOURLOSTD] [numeric](3, 0) NULL,
	[MHOURLOSTH] [numeric](2, 0) NULL,
	[MHOURLOSTM] [numeric](2, 0) NULL,
	[DEVIA] [bit] NULL,
	[OFFHIRE] [bit] NULL,
	[SHOREA] [bit] NULL,
	[REPTYPE] [numeric](1, 0) NULL,
	[EVENTS] [varchar](max) NULL,
	[CAUSEWHY] [varchar](max) NULL,
	[REGULATION] [varchar](max) NULL,
	[ROUTVIOLAT] [varchar](max) NULL,
	[EXCEPVIOLA] [varchar](max) NULL,
	[SLIP] [varchar](max) NULL,
	[LAPSE] [varchar](max) NULL,
	[MISTAKE] [varchar](max) NULL,
	[REMARKDAMAGE] [varchar](max) NULL,
	[REPLACE] [varchar](max) NULL,
	[OFFHCOST] [numeric](7, 2) NULL,
	[VDELAYCOST] [numeric](7, 2) NULL,
	[MANHLCOST] [numeric](7, 2) NULL,
	[DEVIATCOST] [numeric](7, 2) NULL,
	[REPAIRS] [numeric](7, 2) NULL,
	[MISCEXPCOS] [numeric](7, 2) NULL,
	[TOTALS] [numeric](10, 2) NULL,
	[MISCREASON] [varchar](max) NULL,
	[DETLOVR] [varchar](max) NULL,
	[ATTCHSURV] [bit] NULL,
	[ATTCHMAST] [bit] NULL,
	[ATTCHLOG] [bit] NULL,
	[ATCHPHOTO] [bit] NULL,
	[MASTERNAME] [char](30) NULL,
	[CENAME] [char](30) NULL,
	[REPODATE] [datetime] NULL,
	[MASTERCOMM] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_INCIDENT] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_LOC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_LOC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DESCEND] [char](50) NULL,
	[TYPES] [char](2) NULL,
 CONSTRAINT [PK_IN_LOC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HATCHHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HATCHHEAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[TYPECODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[INSPBY] [char](30) NULL,
	[PACKING] [numeric](5, 2) NULL,
	[OPENS] [numeric](5, 2) NULL,
	[CLOSES] [numeric](5, 2) NULL,
	[REMARKS1] [varchar](max) NULL,
	[REMARKS2] [varchar](max) NULL,
	[REMARKS3] [varchar](max) NULL,
	[REMARKS4] [varchar](max) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_HATCHHEAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HATCHDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HATCHDETL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[TYPECODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[FLD1] [char](10) NULL,
	[FLD2] [char](10) NULL,
	[FLD3] [char](10) NULL,
	[FLD4] [char](10) NULL,
	[FLD5] [char](10) NULL,
	[FLD6] [char](10) NULL,
	[FLD7] [char](10) NULL,
	[FLD8] [char](10) NULL,
	[FLD9] [char](10) NULL,
	[NARRATIVE] [bit] NULL,
	[PHOTO] [bit] NULL,
	[REPAIRS] [bit] NULL,
	[REPAIRDOCK] [bit] NULL,
	[FOLLOWUP] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_HATCHDETL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GRPMAIN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GRPMAIN](
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[GRPMCODE] [int] IDENTITY(1,1) NOT NULL,
	[GRPMNAME] [char](60) NULL,
	[GRPMPARENT] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_GRPMAIN_1] PRIMARY KEY CLUSTERED 
(
	[GRPMCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GRPBK]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GRPBK](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[GRPMCODE] [char](10) NULL,
	[GRPMNAME] [char](60) NULL,
	[GRPMPARENT] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[USERS] [char](35) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_GRPBK] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GROOVPROF_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GROOVPROF_INSP](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPECODE] [char](8) NULL,
	[BUILDER] [char](50) NULL,
	[ENG_NO] [char](10) NULL,
	[CHECKEDBY] [char](50) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[ENG_TYPE] [char](50) NULL,
	[RED_RNG_H] [char](10) NULL,
	[ENG_HRS] [char](10) NULL,
	[ENTDATE] [char](10) NULL,
	[CYL_NO] [numeric](2, 0) NULL,
	[ROW_ID] [numeric](2, 0) NULL,
	[CL30] [char](20) NULL,
	[CL35] [char](20) NULL,
	[CL40] [char](20) NULL,
	[CL45] [char](20) NULL,
	[CL50] [char](20) NULL,
	[CL55] [char](20) NULL,
	[CL60] [char](20) NULL,
	[CL65] [char](20) NULL,
	[CL70] [char](20) NULL,
	[CL75] [char](20) NULL,
	[CL80] [char](20) NULL,
	[CL85] [char](20) NULL,
	[CL90] [char](20) NULL,
	[CL95] [char](20) NULL,
	[CL100] [char](20) NULL,
	[CL105] [char](20) NULL,
	[WEAR_RATE] [char](50) NULL,
	[REM_1_6] [char](200) NULL,
	[REM_7_12] [char](200) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_GROOVPROF_INSP] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GROOVE16_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GROOVE16_INSP](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPECODE] [char](8) NULL,
	[BUILDER] [char](50) NULL,
	[ENG_NO] [char](10) NULL,
	[CHECKEDBY] [char](50) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[ENG_TYPE] [char](50) NULL,
	[ENG_HRS] [char](10) NULL,
	[CROWN_HRS] [char](10) NULL,
	[UNITNO] [char](10) NULL,
	[ENTDATE] [char](10) NULL,
	[RNG_NO] [numeric](2, 0) NULL,
	[ROW_ID] [numeric](2, 0) NULL,
	[FORE] [char](20) NULL,
	[T23] [char](20) NULL,
	[T45] [char](20) NULL,
	[T68] [char](20) NULL,
	[EXH] [char](20) NULL,
	[T113] [char](20) NULL,
	[T135] [char](20) NULL,
	[T158] [char](20) NULL,
	[AFT] [char](20) NULL,
	[T203] [char](20) NULL,
	[T225] [char](20) NULL,
	[T248] [char](20) NULL,
	[MAN] [char](20) NULL,
	[T293] [char](20) NULL,
	[T315] [char](20) NULL,
	[T338] [char](20) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_GROOVE16_INSP] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FPLOGBK]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FPLOGBK](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPT] [char](50) NULL,
	[TYPECODE] [char](10) NULL,
	[SERIAL] [numeric](2, 0) NULL,
	[CATEGORY] [char](1) NULL,
 CONSTRAINT [PK_FPLOGBK] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FOXUSER]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FOXUSER](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPE] [char](12) NULL,
	[ID] [char](12) NULL,
	[NAME] [varchar](max) NULL,
	[READONLY] [bit] NULL,
	[CKVAL] [numeric](6, 0) NULL,
	[DATA] [varchar](max) NULL,
	[UPDATED] [datetime] NULL,
 CONSTRAINT [PK_FOXUSER] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FILEVAR]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FILEVAR](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DBF] [char](50) NULL,
	[VARNAME] [char](50) NULL,
 CONSTRAINT [PK_FILEVAR] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EX_VALVE_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EX_VALVE_INSP](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPECODE] [char](8) NULL,
	[BUILDER] [char](50) NULL,
	[ENG_NO] [char](10) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[ENG_TYPE] [char](50) NULL,
	[VALVE_NO] [char](10) NULL,
	[VALVE_HRS] [char](20) NULL,
	[SPARE] [char](10) NULL,
	[TEST] [char](10) NULL,
	[DIS_CYL_NO] [char](20) NULL,
	[DIS_DT] [char](10) NULL,
	[DIS_HRS] [char](10) NULL,
	[CHECK_OHL] [char](30) NULL,
	[CHK_OHL_DT] [char](10) NULL,
	[CHK_PLACE] [char](50) NULL,
	[MOUN_CYLNO] [char](20) NULL,
	[MOUN_DT] [char](10) NULL,
	[MOUN_HRS] [char](10) NULL,
	[REM] [char](200) NULL,
	[B_TYPE] [char](50) NULL,
	[B_MARK] [char](50) NULL,
	[B_S_MAT] [char](50) NULL,
	[B_DRAWNO] [char](50) NULL,
	[B_LST_OVL] [char](10) NULL,
	[B_HRS_TOT] [char](10) NULL,
	[B_CRACK] [char](10) NULL,
	[B_BLOW] [char](10) NULL,
	[B_ST_CON] [char](50) NULL,
	[B_DNT_MRK] [char](10) NULL,
	[B_STGRND] [char](10) NULL,
	[B_STGRND_H] [char](10) NULL,
	[B_DEP_CHM] [char](10) NULL,
	[B_MX_DTHIK] [char](10) NULL,
	[B_ANGDEP] [char](10) NULL,
	[B_D_W_F_V] [char](10) NULL,
	[B_REM] [char](10) NULL,
	[S_MARK] [char](50) NULL,
	[S_B_MAT] [char](50) NULL,
	[S_D_U_MAT] [char](50) NULL,
	[S_S_MAT] [char](50) NULL,
	[S_ST_SUR] [char](50) NULL,
	[S_DRAW] [char](50) NULL,
	[S_LST_OVL] [char](10) NULL,
	[S_HRS_TOT] [char](10) NULL,
	[S_CRACKS] [char](10) NULL,
	[S_BLOW] [char](10) NULL,
	[S_ST_CON] [char](50) NULL,
	[S_S_D_MAX] [char](50) NULL,
	[S_AT_POS] [char](10) NULL,
	[S_BRN_RATE] [char](50) NULL,
	[S_D_M_L] [char](10) NULL,
	[S_D_GRIND] [char](10) NULL,
	[S_D_HRS] [char](10) NULL,
	[S_S_D_A_S] [char](10) NULL,
	[S_M_S_D_S] [char](10) NULL,
	[S_W_S_R] [char](10) NULL,
	[S_REM] [char](200) NULL,
	[H_MARK] [char](50) NULL,
	[H_DRAW] [char](50) NULL,
	[H_LST_OVL] [char](10) NULL,
	[H_HRS_TOT] [char](10) NULL,
	[H_MINTOP] [char](10) NULL,
	[H_MAXTOP] [char](10) NULL,
	[H_MINBOT] [char](10) NULL,
	[H_MAXBOT] [char](10) NULL,
	[H_SP_G_H_T] [char](10) NULL,
	[C_MM_A_1] [char](10) NULL,
	[C_MM_A_2] [char](10) NULL,
	[C_MM_A_3] [char](10) NULL,
	[C_MM_B_1] [char](10) NULL,
	[C_MM_B_2] [char](10) NULL,
	[C_MM_B_3] [char](10) NULL,
	[C_MM_C_1] [char](10) NULL,
	[C_MM_C_2] [char](10) NULL,
	[C_MM_C_3] [char](10) NULL,
	[C_PO_A_1] [char](10) NULL,
	[C_PO_A_2] [char](10) NULL,
	[C_PO_A_3] [char](10) NULL,
	[C_PO_B_1] [char](10) NULL,
	[C_PO_B_2] [char](10) NULL,
	[C_PO_B_3] [char](10) NULL,
	[C_PO_C_1] [char](10) NULL,
	[C_PO_C_2] [char](10) NULL,
	[C_PO_C_3] [char](10) NULL,
	[C_REM] [char](200) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_EX_VALVE_INSP] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DRSUB]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DRSUB](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[ENV] [bit] NULL,
	[GRPCODE] [char](10) NULL,
	[SUBGRPCODE] [char](10) NULL,
	[SUBGRPNAME] [char](60) NULL,
	[SUBDETL] [bit] NULL,
	[FREQ] [numeric](3, 0) NULL,
	[SUBNO] [numeric](2, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DESCRIPT] [varchar](max) NULL,
	[REMARK] [varchar](max) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DRSUB] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DRMAIN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DRMAIN](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[GRPCODE] [char](10) NULL,
	[GRPNAME] [char](60) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DRMAIN] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DRITEMS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DRITEMS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[ENV] [bit] NULL,
	[DRILLITEM] [char](60) NULL,
	[ITEMNO] [numeric](2, 0) NULL,
	[DRILLCODE] [char](10) NULL,
	[GRPCODE] [char](10) NULL,
	[SUBGRPCODE] [char](10) NULL,
	[REMARK] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DESCRIPT] [varchar](max) NULL,
	[FREQ] [numeric](3, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DRITEMS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DRDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DRDETL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DRCODE] [char](10) NULL,
	[JAN] [datetime] NULL,
	[FEB] [datetime] NULL,
	[MAR] [datetime] NULL,
	[APR] [datetime] NULL,
	[MAY] [datetime] NULL,
	[JUN] [datetime] NULL,
	[JUL] [datetime] NULL,
	[AUG] [datetime] NULL,
	[SEP] [datetime] NULL,
	[OCT] [datetime] NULL,
	[NOV] [datetime] NULL,
	[DEC] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DRYEAR] [numeric](4, 0) NULL,
	[SLNO] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DRDETL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DELHIST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DELHIST](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DTABLE] [char](30) NULL,
	[DTYPE] [char](1) NULL,
	[DCOND] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DELHIST] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEFPST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEFPST](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SLNO] [numeric](5, 0) NULL,
	[REFNO] [char](12) NULL,
	[TARGETDT] [datetime] NULL,
	[PSTREM] [char](250) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[PSTUSER] [char](60) NULL,
	[PSTPND] [bit] NULL,
	[SENT] [bit] NULL,
	[ENTDT] [datetime] NULL,
	[OFFUPDT] [bit] NULL,
	[OLDTGDT] [datetime] NULL,
	[DEFPSTCODE] [char](20) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DEFPST] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEFPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEFPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[REFNO] [char](12) NULL,
	[PICPATH] [char](250) NULL,
	[REMARKS] [char](250) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[SLNO] [numeric](3, 0) NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DEFPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEFOFF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEFOFF](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[OFFUSER] [char](60) NULL,
	[OFFCOMM] [varchar](max) NULL,
	[OFFCOMMDT] [datetime] NULL,
	[REFNO] [char](12) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[UPDTREC] [bit] NULL,
	[OFFDEFCODE] [char](10) NULL,
	[SHPDEFCODE] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DEFOFF] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEFMALST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEFMALST](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[GRPCODE] [char](8) NULL,
	[DESCEND] [char](90) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DEFMALST] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEFLHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEFLHEAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[DRAFTFWD] [numeric](5, 2) NULL,
	[DRAFTAFT] [numeric](5, 2) NULL,
	[PORT] [char](30) NULL,
	[CRANKTMP] [numeric](4, 1) NULL,
	[DEFMEASBY] [char](30) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[REMARKS] [varchar](max) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DEFLHEAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEFLDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEFLDETL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[CYLNO1] [numeric](8, 3) NULL,
	[CYLNO2] [numeric](8, 3) NULL,
	[CYLNO3] [numeric](8, 3) NULL,
	[CYLNO4] [numeric](8, 3) NULL,
	[CYLNO5] [numeric](8, 3) NULL,
	[CYLNO6] [numeric](8, 3) NULL,
	[CYLNO7] [numeric](8, 3) NULL,
	[CYLNO8] [numeric](8, 3) NULL,
	[CYLNO9] [numeric](8, 3) NULL,
	[CYLNO10] [numeric](8, 3) NULL,
	[CYLNO11] [numeric](8, 3) NULL,
	[CYLNO12] [numeric](8, 3) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DEFLDETL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEFECTS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEFECTS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[USERCAT] [numeric](1, 0) NULL,
	[DMONTH] [char](2) NULL,
	[DYEAR] [numeric](4, 0) NULL,
	[CATEGORY] [numeric](1, 0) NULL,
	[SLNO] [numeric](3, 0) NULL,
	[REFNO] [char](12) NULL,
	[DTFOUND] [datetime] NULL,
	[ORDCAT] [numeric](1, 0) NULL,
	[REPORD] [char](20) NULL,
	[DEFECTIVE] [varchar](max) NULL,
	[RECTIFIED] [varchar](max) NULL,
	[DRYDOCK] [varchar](max) NULL,
	[REMARKS] [varchar](max) NULL,
	[DTRECTIFY] [datetime] NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[CANCELED] [bit] NULL,
	[USERNAME] [char](60) NULL,
	[PMS] [bit] NULL,
	[NONPMS] [bit] NULL,
	[CRITICAL] [bit] NULL,
	[SAFETY] [bit] NULL,
	[GRPCODE] [char](8) NULL,
	[OFFUNIQ] [char](10) NULL,
	[CAUSE] [varchar](max) NULL,
	[ASSIST] [bit] NULL,
	[ITEMNAME] [char](60) NULL,
	[DDSPEC] [char](2) NULL,
	[TARGETDT] [datetime] NULL,
	[MARPOL] [bit] NULL,
	[VESSEL] [bit] NULL,
	[SMS] [bit] NULL,
	[SIRE] [bit] NULL,
	[CDI] [bit] NULL,
	[PSC] [bit] NULL,
	[SOLAS] [bit] NULL,
	[TECCLASS] [bit] NULL,
	[OTHERS] [bit] NULL,
	[OFFUPDT] [bit] NULL,
	[SIRECODE] [char](3) NULL,
	[BKDT] [datetime] NULL,
	[MAJ_MIN] [bit] NULL,
	[PSTPND] [bit] NULL,
	[PSTREM] [char](250) NULL,
	[OLDTGDT] [datetime] NULL,
	[DEFTODD] [bit] NULL,
 CONSTRAINT [PK_DEFECTS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DBLTITEM]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DBLTITEM](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[CODE] [char](3) NULL,
	[NAME] [char](30) NULL,
	[UNDER] [char](3) NULL,
 CONSTRAINT [PK_DBLTITEM] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DBLTHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DBLTHEAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[INSPBY] [char](30) NULL,
	[ALLS] [char](2) NULL,
	[PORT] [char](2) NULL,
	[STBD] [char](2) NULL,
	[FWD] [char](2) NULL,
	[AFT] [char](2) NULL,
	[UPP] [char](2) NULL,
	[LWR] [char](2) NULL,
	[ENTINS] [char](2) NULL,
	[ENTNOTE] [char](30) NULL,
	[ACCINS] [char](2) NULL,
	[ACCNOTE] [char](30) NULL,
	[SOUINS] [char](2) NULL,
	[SOURNOTE] [char](30) NULL,
	[PIPINS] [char](2) NULL,
	[PIPNOTE] [char](30) NULL,
	[SUCINS] [char](2) NULL,
	[SUCNOTE] [char](30) NULL,
	[REMARKS] [varchar](max) NULL,
	[DETAIL] [varchar](max) NULL,
	[HOLDNO1] [char](20) NULL,
	[HOLDNO2] [char](20) NULL,
	[BKDT] [datetime] NULL,
	[TESTALL] [char](2) NULL,
 CONSTRAINT [PK_DBLTHEAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DBLTDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DBLTDETL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[INSPECTION] [char](2) NULL,
	[COATTING] [numeric](5, 2) NULL,
	[BLISTERING] [numeric](5, 2) NULL,
	[SCALETYPE] [char](1) NULL,
	[THICKNESS] [numeric](5, 2) NULL,
	[INTENSITY] [numeric](5, 2) NULL,
	[AVGDEPT] [numeric](5, 2) NULL,
	[ANODES] [numeric](5, 2) NULL,
	[FACTURES] [char](5) NULL,
	[BULCKING] [char](5) NULL,
	[WELDSEAMS] [char](5) NULL,
	[THINNING] [char](5) NULL,
	[RESIDUES] [char](5) NULL,
	[NARRATIVE] [bit] NULL,
	[PHOTO] [bit] NULL,
	[REPAIRS] [bit] NULL,
	[REPAIRDOCK] [bit] NULL,
	[FOLLOWUP] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_DBLTDETL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CYL_COND_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CYL_COND_INSP](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPECODE] [char](8) NULL,
	[BUILDER] [char](50) NULL,
	[ENG_NO] [char](10) NULL,
	[CHECKEDBY] [char](50) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[ENG_TYPE] [char](50) NULL,
	[MK] [char](10) NULL,
	[ENG_HRS] [char](10) NULL,
	[ENTDATE] [char](10) NULL,
	[UNITNO] [char](10) NULL,
	[WKS_PR_PL] [char](20) NULL,
	[MCR] [char](10) NULL,
	[LUB_P_CON] [char](20) NULL,
	[LUB_TYPE] [char](50) NULL,
	[CYLOIL_CON] [char](20) NULL,
	[AT_LOAD] [char](20) NULL,
	[COIL_TYPE] [char](20) NULL,
	[SULPH] [char](20) NULL,
	[SHIP_POS] [char](50) NULL,
	[WE_COND] [char](50) NULL,
	[SEA_W_TEMP] [char](20) NULL,
	[DEP_PORT] [char](50) NULL,
	[DEP_DT] [char](20) NULL,
	[DES_PORT] [char](50) NULL,
	[DES_DT] [char](20) NULL,
	[L_HOURS] [char](20) NULL,
	[INS_PIPE] [char](20) NULL,
	[PC_RING] [char](20) NULL,
	[LINE_MATE] [char](50) NULL,
	[DRAW_NO] [char](50) NULL,
	[FRAME_TYPE] [char](50) NULL,
	[LIN_COL_TY] [char](50) NULL,
	[PRO_MARK] [char](50) NULL,
	[WEAR_TYPE] [char](50) NULL,
	[LINE_HOND] [char](20) NULL,
	[CYL_COV_TD] [char](20) NULL,
	[TEMP_B_MT] [char](10) NULL,
	[SHIMS] [char](20) NULL,
	[DEPTH_0] [char](10) NULL,
	[DEPTH_1] [char](10) NULL,
	[DEPTH_2] [char](10) NULL,
	[DEPTH_3] [char](10) NULL,
	[DEPTH_4] [char](10) NULL,
	[DEPTH_5] [char](10) NULL,
	[DEPTH_6] [char](10) NULL,
	[DEPTH_7] [char](10) NULL,
	[DEPTH_8] [char](10) NULL,
	[DEPTH_9] [char](10) NULL,
	[DEPTH_10] [char](10) NULL,
	[DEPTH_11] [char](10) NULL,
	[DEPTH_A1] [char](10) NULL,
	[DEPTH_A2] [char](10) NULL,
	[DIAFA_0] [char](10) NULL,
	[DIAFA_1] [char](10) NULL,
	[DIAFA_2] [char](10) NULL,
	[DIAFA_3] [char](10) NULL,
	[DIAFA_4] [char](10) NULL,
	[DIAFA_5] [char](10) NULL,
	[DIAFA_6] [char](10) NULL,
	[DIAFA_7] [char](10) NULL,
	[DIAFA_8] [char](10) NULL,
	[DIAFA_9] [char](10) NULL,
	[DIAFA_10] [char](10) NULL,
	[DIAFA_11] [char](10) NULL,
	[DIAFA_A1] [char](10) NULL,
	[DIAFA_A2] [char](10) NULL,
	[DIAEM_0] [char](10) NULL,
	[DIAEM_1] [char](10) NULL,
	[DIAEM_2] [char](10) NULL,
	[DIAEM_3] [char](10) NULL,
	[DIAEM_4] [char](10) NULL,
	[DIAEM_5] [char](10) NULL,
	[DIAEM_6] [char](10) NULL,
	[DIAEM_7] [char](10) NULL,
	[DIAEM_8] [char](10) NULL,
	[DIAEM_9] [char](10) NULL,
	[DIAEM_10] [char](10) NULL,
	[DIAEM_11] [char](10) NULL,
	[DIAEM_A1] [char](10) NULL,
	[DIAEM_A2] [char](10) NULL,
	[LINE_REM] [char](200) NULL,
	[BMATE_R1] [char](50) NULL,
	[BMATE_R2] [char](50) NULL,
	[BMATE_R3] [char](50) NULL,
	[BMATE_R4] [char](50) NULL,
	[COAT_R1] [char](50) NULL,
	[COAT_R2] [char](50) NULL,
	[COAT_R3] [char](50) NULL,
	[COAT_R4] [char](50) NULL,
	[COATLS_R1] [char](50) NULL,
	[COATLS_R2] [char](50) NULL,
	[COATLS_R3] [char](50) NULL,
	[COATLS_R4] [char](50) NULL,
	[PROF_R1] [char](50) NULL,
	[PROF_R2] [char](50) NULL,
	[PROF_R3] [char](50) NULL,
	[PROF_R4] [char](50) NULL,
	[MANUF_R1] [char](50) NULL,
	[MANUF_R2] [char](50) NULL,
	[MANUF_R3] [char](50) NULL,
	[MANUF_R4] [char](50) NULL,
	[LKTYP_R1] [char](50) NULL,
	[LKTYP_R2] [char](50) NULL,
	[LKTYP_R3] [char](50) NULL,
	[LKTYP_R4] [char](50) NULL,
	[CLGROV_R1] [char](50) NULL,
	[CLGROV_R2] [char](50) NULL,
	[CLGROV_R3] [char](50) NULL,
	[CLGROV_R4] [char](50) NULL,
	[CLGRWD_R1] [char](50) NULL,
	[CLGRWD_R2] [char](50) NULL,
	[CLGRWD_R3] [char](50) NULL,
	[CLGRWD_R4] [char](50) NULL,
	[BRK_R1] [char](50) NULL,
	[BRK_R2] [char](50) NULL,
	[BRK_R3] [char](50) NULL,
	[BRK_R4] [char](50) NULL,
	[RNG_DEG_A] [char](20) NULL,
	[RNG_DEG_B] [char](20) NULL,
	[RNG_DEG_C] [char](20) NULL,
	[RNG_DEG_D] [char](20) NULL,
	[RNG_DEG_E] [char](20) NULL,
	[WDT_RNG1_A] [char](20) NULL,
	[WDT_RNG1_B] [char](20) NULL,
	[WDT_RNG1_C] [char](20) NULL,
	[WDT_RNG1_D] [char](20) NULL,
	[WDT_RNG1_E] [char](20) NULL,
	[GAP_RNG1] [char](20) NULL,
	[WDT_RNG2_A] [char](20) NULL,
	[WDT_RNG2_B] [char](20) NULL,
	[WDT_RNG2_C] [char](20) NULL,
	[WDT_RNG2_D] [char](20) NULL,
	[WDT_RNG2_E] [char](20) NULL,
	[GAP_RNG2] [char](20) NULL,
	[WDT_RNG3_A] [char](20) NULL,
	[WDT_RNG3_B] [char](20) NULL,
	[WDT_RNG3_C] [char](20) NULL,
	[WDT_RNG3_D] [char](20) NULL,
	[WDT_RNG3_E] [char](20) NULL,
	[GAP_RNG3] [char](20) NULL,
	[WDT_RNG4_A] [char](20) NULL,
	[WDT_RNG4_B] [char](20) NULL,
	[WDT_RNG4_C] [char](20) NULL,
	[WDT_RNG4_D] [char](20) NULL,
	[WDT_RNG4_E] [char](20) NULL,
	[GAP_RNG4] [char](20) NULL,
	[GRV_RNG1_F] [char](20) NULL,
	[GRV_RNG1_E] [char](20) NULL,
	[GRV_RNG1_A] [char](20) NULL,
	[GRV_RNG1_M] [char](20) NULL,
	[GRV_RNG2_F] [char](20) NULL,
	[GRV_RNG2_E] [char](20) NULL,
	[GRV_RNG2_A] [char](20) NULL,
	[GRV_RNG2_M] [char](20) NULL,
	[GRV_RNG3_F] [char](20) NULL,
	[GRV_RNG3_E] [char](20) NULL,
	[GRV_RNG3_A] [char](20) NULL,
	[GRV_RNG3_M] [char](20) NULL,
	[GRV_RNG4_F] [char](20) NULL,
	[GRV_RNG4_E] [char](20) NULL,
	[GRV_RNG4_A] [char](20) NULL,
	[GRV_RNG4_M] [char](20) NULL,
	[LST_OVL] [char](20) NULL,
	[CRWN_HRS] [char](20) NULL,
	[HI_TOPLOAD] [char](10) NULL,
	[R_PIS_OVL] [char](20) NULL,
	[TEST] [char](20) NULL,
	[BNZ_RING] [char](10) NULL,
	[OROS_PIST] [char](10) NULL,
	[CHK_LIN_CO] [char](10) NULL,
	[MAX_BURN1] [char](20) NULL,
	[PIST1] [char](20) NULL,
	[MAX_BURN2] [char](20) NULL,
	[PIST2] [char](20) NULL,
	[MAX_BURN3] [char](20) NULL,
	[PIST3] [char](20) NULL,
	[LIN_CRACK] [char](20) NULL,
	[LIN_SCUF] [char](20) NULL,
	[LIN_LEAK] [char](20) NULL,
	[PCRN_BURN] [char](20) NULL,
	[PCRN_CRACK] [char](20) NULL,
	[PCRM_LEAK] [char](20) NULL,
	[PCRM_HGW] [char](20) NULL,
	[PRING_BRK] [char](20) NULL,
	[PRING_COLL] [char](20) NULL,
	[PRING_SCUF] [char](20) NULL,
	[PRING_STIC] [char](20) NULL,
	[PSKRT_LEAK] [char](20) NULL,
	[PSKRT_SCUF] [char](20) NULL,
	[PROD_SBOX] [char](20) NULL,
	[PIS_REM] [char](20) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_CYL_COND_INSP] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CURRMAST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CURRMAST](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[CURCODE] [char](4) NULL,
	[CURNAME] [char](60) NULL,
	[CURNUM] [numeric](3, 0) NULL,
 CONSTRAINT [PK_CURRMAST] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CPMPLOGO]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CPMPLOGO](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[LOGO] [varchar](max) NULL,
 CONSTRAINT [PK_complogo] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COMPMST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COMPMST](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[COMPCODE] [char](10) NULL,
	[SUBCODE] [char](10) NULL,
	[MAINCAT] [char](3) NULL,
	[SUBCAT] [char](3) NULL,
	[PMSCODE] [char](10) NULL,
	[PMSDATE] [datetime] NULL,
	[DATES] [datetime] NULL,
	[OHAULAT] [numeric](7, 0) NULL,
	[RUNHRS] [numeric](10, 0) NULL,
	[TOTHRS] [numeric](10, 0) NULL,
	[MAKERID] [char](20) NULL,
	[SIMPLEID] [char](10) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[CANEDIT] [bit] NULL,
	[WORK] [varchar](max) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_COMPMST] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COMPITEM]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COMPITEM](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCAT] [char](3) NULL,
	[SUBCAT] [char](3) NULL,
	[NAME] [char](20) NULL,
	[CONDITION] [char](254) NULL,
	[TYPECODE] [char](10) NULL,
	[CONTROL] [char](20) NULL,
	[ORDCODE] [char](2) NULL,
 CONSTRAINT [PK_CompItem] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COMPDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COMPDETL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[COMPCODE] [char](10) NULL,
	[SUBCODE] [char](10) NULL,
	[MAINCAT] [char](3) NULL,
	[SUBCAT] [char](3) NULL,
	[PMSCODE] [char](10) NULL,
	[PMSDATE] [datetime] NULL,
	[DATES] [datetime] NULL,
	[OHAULAT] [numeric](7, 0) NULL,
	[RUNHRS] [numeric](10, 0) NULL,
	[TOTHRS] [numeric](10, 0) NULL,
	[MAKERID] [char](20) NULL,
	[SIMPLEID] [char](10) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[FROMDATE] [datetime] NULL,
	[UNITOHAUL] [numeric](10, 0) NULL,
	[UNITTOTHRS] [numeric](10, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_COMPDETL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BRKDOWN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BRKDOWN](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[BRKDATE] [datetime] NULL,
	[REASON] [varchar](max) NULL,
	[ACTION] [varchar](max) NULL,
	[DELAY] [bit] NULL,
	[DAY] [numeric](3, 0) NULL,
	[HOURS] [numeric](2, 0) NULL,
	[ASSIST] [bit] NULL,
	[REPAIRER] [char](60) NULL,
	[PORT] [char](60) NULL,
	[RUNHRS] [numeric](10, 0) NULL,
	[OVERHAUL] [datetime] NULL,
	[INTERVAL] [numeric](9, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_BRKDOWN] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BRKDNPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BRKDNPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_BRKDNPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BKIMGDBF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BKIMGDBF](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SLNO] [numeric](8, 0) NULL,
	[FROMDT] [datetime] NULL,
	[TODT] [datetime] NULL,
	[BKBY] [char](60) NULL,
	[BKFILENAME] [char](30) NULL,
	[BKPATH] [char](250) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_BKIMGDBF] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BER_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BER_INSP](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPECODE] [char](8) NULL,
	[BUILDER] [char](50) NULL,
	[ENG_NO] [char](10) NULL,
	[CHECKEDBY] [char](50) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[ENG_TYPE] [char](50) NULL,
	[CLOCKWISE] [char](10) NULL,
	[ENG_HRS] [char](10) NULL,
	[ENTDATE] [char](10) NULL,
	[BEARINGNO] [char](10) NULL,
	[BEARINGHRS] [char](10) NULL,
	[DRAWINGNO] [char](50) NULL,
	[MARKING] [char](50) NULL,
	[MATERIAL] [char](50) NULL,
	[OVERLAY] [char](50) NULL,
	[SN_FLASH] [char](10) NULL,
	[SHIMS] [char](10) NULL,
	[BER_HOUSE] [char](50) NULL,
	[BER_MAKER] [char](50) NULL,
	[OFFSET] [char](50) NULL,
	[THIK_SHELL] [char](50) NULL,
	[THIN_SHELL] [char](50) NULL,
	[CORROSION] [char](10) NULL,
	[LACQUERING] [char](10) NULL,
	[SCRATCHES] [char](10) NULL,
	[TEARING] [char](10) NULL,
	[CRACKS] [char](10) NULL,
	[LOOSEWHITE] [char](10) NULL,
	[SCUFFING] [char](10) NULL,
	[TRAPPED] [char](10) NULL,
	[DETACHMENT] [char](10) NULL,
	[MISALIGN] [char](10) NULL,
	[SEIZURES] [char](10) NULL,
	[WIPING] [char](10) NULL,
	[FRETTING] [char](10) NULL,
	[PEELINGOFF] [char](10) NULL,
	[SPARKERO] [char](10) NULL,
	[HARDCONT] [char](10) NULL,
	[POROSITES] [char](10) NULL,
	[SQUEEZED] [char](10) NULL,
	[DENTMARKS] [char](10) NULL,
	[HEATCRACKS] [char](10) NULL,
	[ROUGHSURFA] [char](10) NULL,
	[SCRA_JOUR] [char](10) NULL,
	[UNEVSURF] [char](10) NULL,
	[CONCAVE] [char](10) NULL,
	[WEAK_LIGHT] [char](10) NULL,
	[CONICAL] [char](10) NULL,
	[CONVEX] [char](10) NULL,
	[EVENTSUNEVEN] [char](10) NULL,
	[WIDE] [char](10) NULL,
	[ASSEMBLY] [char](10) NULL,
	[DIRT] [char](10) NULL,
	[MAT_DEF] [char](10) NULL,
	[BONDING] [char](10) NULL,
	[HARD_CONT] [char](10) NULL,
	[OTHER] [char](10) NULL,
	[CLEARANCE] [char](10) NULL,
	[HOU_GEO] [char](10) NULL,
	[SHEL_GEO] [char](10) NULL,
	[CONTAMIN] [char](10) NULL,
	[JOU_GEO] [char](10) NULL,
	[SPA_ERO] [char](10) NULL,
	[DESIGN] [char](10) NULL,
	[LUBRICA] [char](10) NULL,
	[WATER] [char](10) NULL,
	[SHEL_THICK] [char](10) NULL,
	[ST_ANG1] [char](20) NULL,
	[ST_ANG2] [char](20) NULL,
	[ST_ANG3] [char](20) NULL,
	[END_ANG1] [char](20) NULL,
	[END_ANG2] [char](20) NULL,
	[END_ANG3] [char](20) NULL,
	[PISTON1] [char](50) NULL,
	[PISTON2] [char](50) NULL,
	[PISTON3] [char](50) NULL,
	[DEPTH1] [char](50) NULL,
	[DEPTH2] [char](50) NULL,
	[DEPTH3] [char](50) NULL,
	[TOP_FORE] [char](20) NULL,
	[TOP_AFT] [char](20) NULL,
	[BOT_FORE] [char](20) NULL,
	[BOT_AFT] [char](20) NULL,
	[UP_EX_FORE] [char](20) NULL,
	[UP_EX_AF] [char](20) NULL,
	[LO_EX_FO] [char](20) NULL,
	[LO_EX_AF] [char](20) NULL,
	[UP_MAN_FO] [char](20) NULL,
	[UP_MAN_AF] [char](20) NULL,
	[LO_MAN_FO] [char](20) NULL,
	[LO_MAN_AF] [char](20) NULL,
	[REM] [char](254) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_BER_INSP] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BACKUPS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BACKUPS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[BUPFILE] [char](50) NULL,
	[BUPPATH] [varchar](max) NULL,
	[BUPTYPE] [char](1) NULL,
	[BUPDATE] [datetime] NULL,
	[BUPSRNUM] [numeric](4, 0) NULL,
	[BUPEDA] [char](1) NULL,
	[BUPREC] [numeric](20, 0) NULL,
 CONSTRAINT [PK_BACKUPS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AUXOHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUXOHEAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DATES] [datetime] NULL,
	[ENGTYPE] [char](10) NULL,
	[NOMBORE] [numeric](6, 2) NULL,
	[SINCELAST] [numeric](5, 0) NULL,
	[AUXENGNO] [numeric](2, 0) NULL,
	[AUXENGLOC] [char](30) NULL,
	[TOTRUN] [numeric](7, 0) NULL,
	[STDCLEAN] [char](5) NULL,
	[WEARLIMIT] [char](5) NULL,
	[REMARKS1] [varchar](max) NULL,
	[TURBOCHARG] [bit] NULL,
	[AIRCOOLER] [bit] NULL,
	[BUSHES] [bit] NULL,
	[CONDASFND] [char](100) NULL,
	[ANYREPAIR] [char](50) NULL,
	[STDDIA1] [numeric](5, 0) NULL,
	[OVALIMIT1] [numeric](5, 0) NULL,
	[STDDIA2] [numeric](5, 0) NULL,
	[OVALIMIT2] [numeric](5, 0) NULL,
	[STDTORQUE] [numeric](7, 2) NULL,
	[ANGROTA] [numeric](5, 2) NULL,
	[STDLENG] [numeric](5, 2) NULL,
	[CHKINTERV] [numeric](5, 0) NULL,
	[WRKHRLIMIT] [numeric](5, 0) NULL,
	[ELOLIMIT] [numeric](5, 2) NULL,
	[LASTRENEW] [datetime] NULL,
	[RUNHRSINCE] [numeric](7, 0) NULL,
	[REMARKS2] [varchar](max) NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AUXOHEAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AUXODET4]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUXODET4](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[CYLNO1] [char](10) NULL,
	[CYLNO2] [char](10) NULL,
	[CYLNO3] [char](10) NULL,
	[CYLNO4] [char](10) NULL,
	[CYLNO5] [char](10) NULL,
	[CYLNO6] [char](10) NULL,
	[CYLNO7] [char](10) NULL,
	[CYLNO8] [char](10) NULL,
	[CYLNO9] [char](10) NULL,
	[CYLNO10] [char](10) NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AUXODET4] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AUXODET3]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUXODET3](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[CYLNO1] [numeric](6, 2) NULL,
	[CYLNO2] [numeric](6, 2) NULL,
	[CYLNO3] [numeric](6, 2) NULL,
	[CYLNO4] [numeric](6, 2) NULL,
	[CYLNO5] [numeric](6, 2) NULL,
	[CYLNO6] [numeric](6, 2) NULL,
	[CYLNO7] [numeric](6, 2) NULL,
	[CYLNO8] [numeric](6, 2) NULL,
	[CYLNO9] [numeric](6, 2) NULL,
	[CYLNO10] [numeric](6, 2) NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AUXODET3] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AUXODET2]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUXODET2](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[CYLNO1] [numeric](5, 2) NULL,
	[CYLNO2] [numeric](5, 2) NULL,
	[CYLNO3] [numeric](5, 2) NULL,
	[CYLNO4] [numeric](5, 2) NULL,
	[CYLNO5] [numeric](5, 2) NULL,
	[CYLNO6] [numeric](5, 2) NULL,
	[CYLNO7] [numeric](5, 2) NULL,
	[CYLNO8] [numeric](5, 2) NULL,
	[CYLNO9] [numeric](5, 2) NULL,
	[CYLNO10] [numeric](5, 2) NULL,
	[STDCLEAN] [numeric](5, 2) NULL,
	[LIMIT] [numeric](5, 2) NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AUXODET2] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AUXODET1]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUXODET1](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[CYLNO1FA] [numeric](6, 2) NULL,
	[CYLNO1PS] [numeric](6, 2) NULL,
	[CYLNO2FA] [numeric](6, 2) NULL,
	[CYLNO2PS] [numeric](6, 2) NULL,
	[CYLNO3FA] [numeric](6, 2) NULL,
	[CYLNO3PS] [numeric](6, 2) NULL,
	[CYLNO4FA] [numeric](6, 2) NULL,
	[CYLNO4PS] [numeric](6, 2) NULL,
	[CYLNO5FA] [numeric](6, 2) NULL,
	[CYLNO5PS] [numeric](6, 2) NULL,
	[CYLNO6FA] [numeric](6, 2) NULL,
	[CYLNO6PS] [numeric](6, 2) NULL,
	[CYLNO7FA] [numeric](6, 2) NULL,
	[CYLNO7PS] [numeric](6, 2) NULL,
	[CYLNO8FA] [numeric](6, 2) NULL,
	[CYLNO8PS] [numeric](6, 2) NULL,
	[CYLNO9FA] [numeric](6, 2) NULL,
	[CYLNO9PS] [numeric](6, 2) NULL,
	[CYLNO10FA] [numeric](6, 2) NULL,
	[CYLNO10PS] [numeric](6, 2) NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AUXODET1] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AUDIT]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUDIT](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[USERS] [char](36) NULL,
	[DATES] [char](23) NULL,
	[MODULE] [char](21) NULL,
	[MODULECODE] [char](111) NULL,
	[MODE] [char](7) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[USERNAME] [char](60) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AUDIT] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AEPERHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AEPERHEAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DT] [datetime] NULL,
	[ENGNUM] [numeric](1, 0) NULL,
	[DTMEASURED] [datetime] NULL,
	[LOAD] [numeric](10, 2) NULL,
	[TCHRRPM] [numeric](6, 0) NULL,
	[SCAVPRES] [numeric](8, 2) NULL,
	[SCAVTEMP] [numeric](8, 2) NULL,
	[ACPRESDROP] [numeric](8, 2) NULL,
	[LOPRESS] [numeric](8, 2) NULL,
	[LOTEMPIN] [numeric](8, 2) NULL,
	[LOTEMPOUT] [numeric](8, 2) NULL,
	[GOVRLOADIN] [numeric](8, 2) NULL,
	[ELLOADKW] [numeric](8, 2) NULL,
	[ELLOADAMPS] [numeric](8, 2) NULL,
	[INJECTOR] [numeric](5, 0) NULL,
	[CYLHDOHAUL] [numeric](5, 0) NULL,
	[COMPDECARB] [numeric](5, 0) NULL,
	[REMARKS] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AEPERHEAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AEPERDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AEPERDETL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DT] [datetime] NOT NULL,
	[ENGNUM] [numeric](1, 0) NULL,
	[UNITNUM] [numeric](2, 0) NULL,
	[PMAX] [numeric](6, 1) NULL,
	[FUELRACK] [numeric](6, 0) NULL,
	[EXHTEMP] [numeric](6, 0) NULL,
	[JKTTEMP] [numeric](6, 1) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AEPERDETL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AECRPDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AECRPDTL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[CL_DATE] [datetime] NULL,
	[SLNO] [numeric](2, 0) NULL,
	[CP_CYL1] [numeric](6, 2) NULL,
	[CP_CYL2] [numeric](6, 2) NULL,
	[CP_CYL3] [numeric](6, 2) NULL,
	[CP_CYL4] [numeric](6, 2) NULL,
	[CP_CYL5] [numeric](6, 2) NULL,
	[CP_CYL6] [numeric](6, 2) NULL,
	[CP_CYL7] [numeric](6, 2) NULL,
	[CP_CYL8] [numeric](6, 2) NULL,
	[CP_CYL9] [numeric](6, 2) NULL,
	[CP_CYL10] [numeric](6, 2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AECRPDTL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AECPBEDT]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AECPBEDT](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[CL_DATE] [datetime] NULL,
	[SLNO] [numeric](2, 0) NULL,
	[REN_DATE1] [datetime] NULL,
	[REN_DATE2] [datetime] NULL,
	[REN_DATE3] [datetime] NULL,
	[REN_DATE4] [datetime] NULL,
	[REN_DATE5] [datetime] NULL,
	[REN_DATE6] [datetime] NULL,
	[REN_DATE7] [datetime] NULL,
	[REN_DATE8] [datetime] NULL,
	[REN_DATE9] [datetime] NULL,
	[REN_DATE10] [datetime] NULL,
	[REN_DATE11] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AECPBEDT] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AEBERHED]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AEBERHED](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[CL_DATE] [datetime] NULL,
	[ENG_TYPE] [char](30) NULL,
	[NORM_BORE] [numeric](10, 3) NULL,
	[LAST_OVER] [numeric](10, 0) NULL,
	[RUN_HRS] [numeric](10, 0) NULL,
	[ENG_NO] [numeric](3, 0) NULL,
	[ENG_LOCA] [char](30) NULL,
	[REMARKS] [varchar](max) NULL,
	[MEAS_BY] [char](30) NULL,
	[CHK_INTER1] [numeric](10, 2) NULL,
	[STD_CLE11] [numeric](6, 2) NULL,
	[STD_CLE12] [numeric](6, 2) NULL,
	[WER_LIMIT1] [numeric](6, 2) NULL,
	[CHK_INTER2] [numeric](10, 2) NULL,
	[STD_CLE21] [numeric](6, 2) NULL,
	[STD_CLE22] [numeric](6, 2) NULL,
	[WER_LIMIT2] [numeric](6, 2) NULL,
	[MAX_ALLOW] [numeric](10, 3) NULL,
	[CRANK_TEMP] [numeric](10, 2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[NUM] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_AEBERHED] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ACCPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ACCPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[DATES] [datetime] NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_ACCPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ACCIDENT]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ACCIDENT](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[SEVERITY] [numeric](1, 0) NULL,
	[PROBABLE] [numeric](1, 0) NULL,
	[SUBJECT] [char](250) NULL,
	[ARRDATE] [datetime] NULL,
	[CAUSE] [numeric](1, 0) NULL,
	[ACCDATE] [datetime] NULL,
	[LT] [char](10) NULL,
	[GMT] [char](10) NULL,
	[DEPPORT] [char](30) NULL,
	[DEPDATE] [datetime] NULL,
	[DESTPORT] [char](30) NULL,
	[LOCATION] [char](2) NULL,
	[ACCTYPE] [char](2) NULL,
	[PRIMCAUSE] [char](2) NULL,
	[SECONCAUS] [char](2) NULL,
	[PLACEINCI] [char](2) NULL,
	[DAMAGE1] [char](2) NULL,
	[DAMAGE2] [char](2) NULL,
	[COST] [numeric](10, 2) NULL,
	[DAYSLOST] [numeric](2, 0) NULL,
	[HRSLOST] [numeric](2, 0) NULL,
	[MINSLOST] [numeric](2, 0) NULL,
	[TOTALS] [numeric](10, 2) NULL,
	[EVENTS] [varchar](max) NULL,
	[CAUSDAM] [varchar](max) NULL,
	[REMARK] [varchar](max) NULL,
	[DDAYS] [numeric](3, 0) NULL,
	[DHRS] [numeric](2, 0) NULL,
	[DMINS] [numeric](2, 0) NULL,
	[EDAMAGE] [varchar](max) NULL,
	[DDAMAGE] [varchar](max) NULL,
	[TREPAIR] [varchar](max) NULL,
	[PREPAIR] [varchar](max) NULL,
	[DETAIL] [varchar](max) NULL,
	[PERSONAL] [char](2) NULL,
	[JOB] [char](2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_ACCIDENT] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STUNIT]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STUNIT](
	[UNITS] [char](12) NULL,
	[MTML_UOM] [char](12) NULL,
	[DESCEND] [char](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STREQHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STREQHEAD](
	[REQID] [char](10) NULL,
	[EAR] [char](4) NULL,
	[E_D] [char](1) NULL,
	[H_PRIORITY] [bit] NULL,
	[REQ_SUBJ] [char](100) NULL,
	[REQ_NO] [char](3) NULL,
	[REQ_DEP] [char](3) NULL,
	[REQ_DATE] [datetime] NULL,
	[REQ_STAT] [char](3) NULL,
	[REQ_BY] [char](100) NULL,
	[PHONE] [char](30) NULL,
	[EMAIL] [char](30) NULL,
	[NO_VES_ASS] [bit] NULL,
	[AC_CODE] [char](8) NULL,
	[OFF_CONT] [char](50) NULL,
	[CON_REQ_RE] [bit] NULL,
	[PORT_DELV] [char](40) NULL,
	[DELV_DATE] [datetime] NULL,
	[DELV_TIME] [char](6) NULL,
	[ETA] [datetime] NULL,
	[ETD] [datetime] NULL,
	[ADV_DATE] [datetime] NULL,
	[COMMENT] [char](254) NULL,
	[SEP_EQUIP] [bit] NULL,
	[EQUIPNAME] [char](50) NULL,
	[EQUIPMANUF] [char](50) NULL,
	[EQUIPMODEL] [char](50) NULL,
	[EQUIPDESC] [char](50) NULL,
	[EQUIPTYPE] [char](20) NULL,
	[EQUIPSLNO] [char](20) NULL,
	[EQUIPDRAWI] [char](20) NULL,
	[RATING] [char](20) NULL,
	[CURRENCY] [char](5) NULL,
	[SENT] [bit] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DELV_TERM] [char](5) NULL,
	[PACK_INST] [char](130) NULL,
	[FREIGHT] [char](130) NULL,
	[TRANS_MODE] [char](30) NULL,
	[CURR_INST] [char](130) NULL,
	[TAX_STATUS] [char](30) NULL,
	[PMT_TERM] [char](130) NULL,
	[GEN_TERM] [char](130) NULL,
	[SUG_SUPP] [char](130) NULL,
	[SUP_TRD_ID] [char](8) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STREQDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STREQDTL](
	[REQID] [char](10) NULL,
	[ROW_ID] [char](5) NULL,
	[CANCELLED] [bit] NULL,
	[DELETED] [bit] NULL,
	[STATUS] [bit] NULL,
	[QTY] [numeric](11, 2) NULL,
	[SANCTIONED] [numeric](11, 2) NULL,
	[ROB] [numeric](11, 2) NULL,
	[UOM] [char](12) NULL,
	[STMASTCODE] [char](10) NULL,
	[ITEM_DESC] [char](110) NULL,
	[ID_TYPE] [char](5) NULL,
	[PARTNO] [char](20) NULL,
	[ITEM_COMM] [char](254) NULL,
	[PRICE] [numeric](12, 0) NULL,
	[EQUIPNAME] [char](50) NULL,
	[EQUIPMANUF] [char](50) NULL,
	[EQUIPMODEL] [char](50) NULL,
	[EQUIPDESC] [char](50) NULL,
	[EQUIPTYPE] [char](20) NULL,
	[EQUIPSLNO] [char](20) NULL,
	[EQUIPDRAWI] [char](20) NULL,
	[RATING] [char](20) NULL,
	[PRIORITY] [char](1) NULL,
	[QUALITY] [char](1) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STREQ]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STREQ](
	[REQNO] [char](12) NULL,
	[REQDATE] [datetime] NULL,
	[REQPERIOD] [char](60) NULL,
	[STMAINCODE] [char](10) NULL,
	[MANUF] [char](60) NULL,
	[ADDRESS1] [char](50) NULL,
	[ADDRESS2] [char](50) NULL,
	[CITY] [char](30) NULL,
	[COUNTRY] [char](30) NULL,
	[PHONE] [char](50) NULL,
	[FAX] [char](50) NULL,
	[EMAIL] [char](60) NULL,
	[SLNO] [char](40) NULL,
	[TYPE] [char](30) NULL,
	[PREPBY] [char](80) NULL,
	[CHKBY] [char](80) NULL,
	[EDITED] [bit] NULL,
	[D_E] [char](1) NULL,
	[EDITDT] [datetime] NULL,
	[STPRD] [datetime] NULL,
	[ENPRD] [datetime] NULL,
	[ADHOC] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STNARRDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STNARRDTL](
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[TYPECODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[SRLNO] [numeric](3, 0) NULL,
	[LOCATION] [varchar](max) NULL,
	[DEFECT] [varchar](max) NULL,
	[CORRECTIVE] [varchar](max) NULL,
	[PHOTOS] [bit] NULL,
	[SKETCHES] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STMAST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STMAST](
	[STMAINCODE] [char](10) NULL,
	[STMASTCODE] [char](10) NULL,
	[STMASTITEM] [char](100) NULL,
	[ISSACODE] [char](10) NULL,
	[STORE] [char](50) NULL,
	[REMARK] [char](254) NULL,
	[D_E_C] [char](1) NULL,
	[UNITS] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[OPROB] [numeric](10, 2) NULL,
	[LEVEL_1] [char](45) NULL,
	[LEVEL_2] [char](110) NULL,
	[LEVEL_3] [char](90) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STMAIN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STMAIN](
	[STMAINCODE] [char](10) NULL,
	[STMAINITEM] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STINFPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STINFPIC](
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[TYPECODE] [char](10) NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STINFHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STINFHEAD](
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[TYPECODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[HOLDNO1] [char](45) NULL,
	[HOLDNO2] [char](45) NULL,
	[INSPBY] [char](30) NULL,
	[ALLS] [char](2) NULL,
	[PORT] [char](2) NULL,
	[STBD] [char](2) NULL,
	[FWD] [char](2) NULL,
	[AFT] [char](2) NULL,
	[UPP] [char](2) NULL,
	[LWR] [char](2) NULL,
	[REMARKS1] [varchar](max) NULL,
	[REMARKS2] [varchar](max) NULL,
	[REMARKS3] [varchar](max) NULL,
	[REMARKS4] [varchar](max) NULL,
	[REMARKS5] [varchar](max) NULL,
	[REMARKS6] [varchar](max) NULL,
	[REMARKS7] [varchar](max) NULL,
	[BKDT] [datetime] NULL,
	[TESTALL] [char](2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STINFDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STINFDETL](
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[TYPECODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[TYPE] [char](2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[INSPECTION] [char](2) NULL,
	[COATTING] [numeric](5, 2) NULL,
	[BLISTERING] [numeric](5, 2) NULL,
	[SCALETYPE] [char](1) NULL,
	[THICKNESS] [numeric](5, 2) NULL,
	[INTENSITY] [numeric](5, 2) NULL,
	[AVGDEPT] [numeric](5, 2) NULL,
	[ANODES] [numeric](5, 2) NULL,
	[FRACTURES] [char](5) NULL,
	[BUCKLING] [char](5) NULL,
	[WELDSEAMS] [char](5) NULL,
	[THINNING] [char](5) NULL,
	[RESIDUES] [char](5) NULL,
	[DEFORM] [char](5) NULL,
	[CORROSION] [char](5) NULL,
	[NARRATIVE] [bit] NULL,
	[PHOTO] [bit] NULL,
	[REPAIRS] [bit] NULL,
	[REPAIRDOCK] [bit] NULL,
	[FOLLOWUP] [bit] NULL,
	[CLASSINFO] [bit] NULL,
	[REMARKS] [char](200) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STDTLREQ]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STDTLREQ](
	[REQNO] [char](12) NULL,
	[REQDATE] [datetime] NULL,
	[STMAINCODE] [char](10) NULL,
	[STMASTCODE] [char](10) NULL,
	[ROB] [numeric](5, 0) NULL,
	[REQ] [numeric](5, 0) NULL,
	[SANC] [numeric](5, 0) NULL,
	[SUPLIED] [bit] NULL,
	[REC] [numeric](5, 0) NULL,
	[CANCELLED] [bit] NULL,
	[PORT] [char](60) NULL,
	[RECDATE] [datetime] NULL,
	[PORTCODE] [char](6) NULL,
	[EDITED] [bit] NULL,
	[PARTCODE] [char](20) NULL,
	[EDITDT] [datetime] NULL,
	[SUPPLIER] [char](60) NULL,
	[PAIDBY] [char](10) NULL,
	[PREAPPR] [bit] NULL,
	[AMT] [numeric](9, 2) NULL,
	[CURRENCY] [char](5) NULL,
	[EXRATE] [numeric](7, 2) NULL,
	[EQUSD] [numeric](9, 2) NULL,
	[ADHOC] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STDETL](
	[STMASTCODE] [char](10) NULL,
	[TRANDATE] [datetime] NULL,
	[QTY] [numeric](10, 2) NULL,
	[PORT] [char](60) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[ROW_ID] [char](10) NULL,
	[REQID] [char](10) NULL,
	[TRTY] [char](1) NULL,
	[COMMENTS] [char](254) NULL,
	[PRICE] [numeric](10, 2) NULL,
	[PREQNO] [char](10) NULL,
	[PSUPPLIER] [char](40) NULL,
	[PPAID_BY] [char](10) NULL,
	[PPRE_APP] [bit] NULL,
	[PAMOUNT] [numeric](12, 2) NULL,
	[PCURRENCY] [char](10) NULL,
	[PEX_RATE] [numeric](10, 2) NULL,
	[PEQUSD] [numeric](10, 2) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SRVLETTER]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SRVLETTER](
	[SRVCODE] [char](10) NULL,
	[MEMANUF] [char](2) NULL,
	[MACHTYPE] [char](250) NULL,
	[ME] [bit] NULL,
	[AE] [bit] NULL,
	[NUM] [numeric](2, 0) NULL,
	[TYPECODE] [char](10) NULL,
	[SRVFNAME] [char](50) NULL,
	[RELEASEDT] [datetime] NULL,
	[REMARKS] [char](254) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[STROKE] [char](5) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPREQHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPREQHEAD](
	[REQID] [char](10) NULL,
	[YR] [char](4) NULL,
	[D_E] [char](1) NULL,
	[H_PRIORITY] [bit] NULL,
	[REQ_SUBJ] [char](100) NULL,
	[REQ_NO] [char](3) NULL,
	[REQNO] [char](12) NULL,
	[REQ_DEP] [char](3) NULL,
	[REQDATE] [datetime] NULL,
	[REQ_STAT] [char](3) NULL,
	[REQ_BY] [char](100) NULL,
	[PHONE] [char](30) NULL,
	[EMAIL] [char](30) NULL,
	[NO_VES_ASS] [bit] NULL,
	[AC_CODE] [char](8) NULL,
	[OFF_CONT] [char](50) NULL,
	[CON_REQ_RE] [bit] NULL,
	[PORT_DELV] [char](40) NULL,
	[DELV_DATE] [datetime] NULL,
	[DELV_TIME] [char](6) NULL,
	[ETA] [datetime] NULL,
	[ETD] [datetime] NULL,
	[ADV_DATE] [datetime] NULL,
	[COMMENT] [char](254) NULL,
	[SEP_EQUIP] [bit] NULL,
	[EQUIPNAME] [char](50) NULL,
	[EQUIPMANUF] [char](50) NULL,
	[EQUIPMODEL] [char](50) NULL,
	[EQUIPDESC] [char](50) NULL,
	[EQUIPTYPE] [char](20) NULL,
	[EQUIPSLNO] [char](20) NULL,
	[EQUIPDRAWI] [char](20) NULL,
	[RATING] [char](20) NULL,
	[CURRENCY] [char](5) NULL,
	[SENT] [bit] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DELV_TERM] [char](5) NULL,
	[PACK_INST] [char](130) NULL,
	[FREIGHT] [char](130) NULL,
	[TRANS_MODE] [char](30) NULL,
	[CURR_INST] [char](130) NULL,
	[TAX_STATUS] [char](30) NULL,
	[PMT_TERM] [char](130) NULL,
	[GEN_TERM] [char](130) NULL,
	[SUG_SUPP] [char](130) NULL,
	[SUP_TRD_ID] [char](8) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPREQDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPREQDTL](
	[REQID] [char](10) NULL,
	[YR] [char](4) NULL,
	[REQNO] [char](12) NULL,
	[REQ_NO] [char](3) NULL,
	[REQDATE] [datetime] NULL,
	[REQ_DEP] [char](3) NULL,
	[ROW_ID] [char](5) NULL,
	[CANCELLED] [bit] NULL,
	[DELETED] [bit] NULL,
	[STATUS] [bit] NULL,
	[REQ] [numeric](5, 0) NULL,
	[SANC] [numeric](5, 0) NULL,
	[ROB] [numeric](5, 0) NULL,
	[UOM] [char](12) NULL,
	[CONNS] [char](8) NULL,
	[KEYS] [char](8) NULL,
	[ITEM_DESC] [char](110) NULL,
	[ID_TYPE] [char](5) NULL,
	[PARTNO] [char](20) NULL,
	[ITEM_COMM] [char](254) NULL,
	[PRICE] [numeric](12, 2) NULL,
	[EQUIPNAME] [char](50) NULL,
	[EQUIPMANUF] [char](50) NULL,
	[EQUIPMODEL] [char](50) NULL,
	[EQUIPDESC] [char](50) NULL,
	[EQUIPTYPE] [char](20) NULL,
	[EQUIPSLNO] [char](20) NULL,
	[EEQUIPDRAWI] [char](20) NULL,
	[RATING] [char](20) NULL,
	[PRIORITY] [char](1) NULL,
	[QUALITY] [char](1) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[REC] [numeric](5, 0) NULL,
	[PORT] [char](60) NULL,
	[RECDATE] [datetime] NULL,
	[PORTCODE] [char](6) NULL,
	[MANUFCODE] [char](10) NULL,
	[SUPPLIED] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPREQ]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPREQ](
	[REQNO] [char](12) NULL,
	[REQDATE] [datetime] NULL,
	[REQPERIOD] [char](60) NULL,
	[MAIN] [char](60) NULL,
	[MANUFCODE] [char](10) NULL,
	[TYPE] [char](30) NULL,
	[SLNO] [char](40) NULL,
	[PREPBY] [char](80) NULL,
	[CHKBY] [char](80) NULL,
	[EDITED] [bit] NULL,
	[D_E] [char](1) NULL,
	[EDITDT] [datetime] NULL,
	[STPRD] [datetime] NULL,
	[ENPRD] [datetime] NULL,
	[BULTDT] [datetime] NULL,
	[CONNS] [char](8) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPMAST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPMAST](
	[CODE] [numeric](10, 0) NULL,
	[CONNS] [char](8) NULL,
	[MAIN] [char](40) NULL,
	[UNIT] [char](4) NULL,
	[SUBMAIN] [char](40) NULL,
	[PARTNAME] [char](55) NULL,
	[PARTNUMBER] [char](20) NULL,
	[SCHED] [numeric](4, 0) NULL,
	[DRAWING] [char](20) NULL,
	[MAKER] [char](30) NULL,
	[MANUF] [char](20) NULL,
	[MRESTOR] [numeric](4, 0) NULL,
	[STORED] [char](15) NULL,
	[KEYS] [char](8) NULL,
	[ROB] [numeric](9, 0) NULL,
	[E_D] [char](1) NULL,
	[EDITED] [bit] NULL,
	[SPTYPE] [char](2) NULL,
	[SPMARKID] [char](50) NULL,
	[EDITDT] [datetime] NULL,
	[REMARKS] [char](250) NULL,
	[CRIT] [bit] NULL,
	[MANUFCODE] [char](10) NULL,
	[SP_MODEL] [char](50) NULL,
	[SP_TYPE] [char](20) NULL,
	[UNITS] [numeric](5, 0) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPDTLREQ]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPDTLREQ](
	[REQNO] [char](12) NULL,
	[REQDATE] [datetime] NULL,
	[CONNS] [char](8) NULL,
	[KEYS] [char](8) NULL,
	[ROB] [numeric](5, 0) NULL,
	[REQ] [numeric](5, 0) NULL,
	[SANC] [numeric](5, 0) NULL,
	[SUPPLIED] [bit] NULL,
	[EDITED] [bit] NULL,
	[REC] [numeric](5, 0) NULL,
	[CANCELLED] [bit] NULL,
	[PORT] [char](60) NULL,
	[RECDATE] [datetime] NULL,
	[PORTCODE] [char](6) NULL,
	[EDITDT] [datetime] NULL,
	[MANUFCODE] [char](10) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPDT]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPDT](
	[USERNAME] [char](20) NULL,
	[PASSWORD] [char](10) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[USERCODE] [char](10) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPDETL](
	[KEYS] [char](8) NULL,
	[TRANDATE] [datetime] NULL,
	[QTY] [numeric](5, 0) NULL,
	[EDITED] [bit] NULL,
	[PORT] [char](60) NULL,
	[PORTCODE] [char](6) NULL,
	[EDITDT] [datetime] NULL,
	[REQNO] [char](12) NULL,
	[TRANSCODE] [char](10) NULL,
	[TRANSTYPE] [char](1) NULL,
	[AMT] [numeric](10, 2) NULL,
	[CURCODE] [char](5) NULL,
	[EXCHRATE] [numeric](10, 4) NULL,
	[REMARKS] [char](254) NULL,
	[REQID] [char](10) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SPCHK]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SPCHK](
	[ENTRYDT] [datetime] NULL,
	[CHKDT] [datetime] NULL,
	[SLNO] [numeric](5, 0) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[NAME] [char](60) NULL,
	[COMMENTS] [varchar](max) NULL,
	[OFFUPDT] [bit] NULL,
	[CATEGORY] [char](1) NULL,
	[SPCOMRED] [bit] NULL,
	[MODDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
	[RUNHRS_CHK] [bit] NULL,
	[ME_CHK] [bit] NULL,
	[AE_CHK] [bit] NULL,
	[SAFTY_CHK] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SIREREFF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SIREREFF](
	[SIRECODE] [char](3) NULL,
	[SIREREFF] [char](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SHIPPART]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SHIPPART](
	[BOWHP] [char](10) NULL,
	[BREMOULD] [numeric](7, 3) NULL,
	[CALLSIGN] [char](10) NULL,
	[CREW] [numeric](3, 0) NULL,
	[DELIDATETIME] [datetime] NULL,
	[DEPMOULD] [numeric](7, 3) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EMAIL] [char](50) NULL,
	[ENGMAKER] [char](30) NULL,
	[EXNAME] [char](100) NULL,
	[FAX] [char](50) NULL,
	[FUELMCR] [numeric](7, 2) NULL,
	[FUELNCR] [numeric](7, 2) NULL,
	[GROSSTON] [numeric](7, 2) NULL,
	[HIGHCUBE] [char](50) NULL,
	[HOMOGEN] [char](30) NULL,
	[HULLNO] [numeric](4, 0) NULL,
	[IMONUM] [numeric](8, 0) NULL,
	[LASTCLSURV] [datetime] NULL,
	[LASTDDOCK] [datetime] NULL,
	[LENGTH] [numeric](9, 3) NULL,
	[LENGTHPER] [numeric](8, 3) NULL,
	[LIGHTSHIP] [numeric](10, 2) NULL,
	[MCRBHP] [numeric](9, 0) NULL,
	[MCRKW] [numeric](9, 0) NULL,
	[MGTADD1] [char](60) NULL,
	[MGTADD2] [char](60) NULL,
	[MGTADD3] [char](60) NULL,
	[MGTPHONE] [char](50) NULL,
	[NETTON] [numeric](7, 0) NULL,
	[NEXTCLSURV] [datetime] NULL,
	[NEXTDDOCK] [datetime] NULL,
	[OFFNUM] [numeric](8, 0) NULL,
	[PANAGROSS] [numeric](10, 2) NULL,
	[PANANET] [numeric](10, 2) NULL,
	[PHONE] [char](50) NULL,
	[PORTREG] [char](30) NULL,
	[REFFERPLUG] [char](30) NULL,
	[REGOWNER] [char](50) NULL,
	[RPMMCR] [numeric](4, 0) NULL,
	[RPMNCR] [numeric](4, 0) NULL,
	[SPECIAL] [varchar](max) NULL,
	[STACKWT] [varchar](max) NULL,
	[SUEZGROSS] [numeric](10, 2) NULL,
	[SUEZNET] [numeric](10, 2) NULL,
	[SUMDRAFT] [numeric](7, 3) NULL,
	[SUMMERDEAD] [numeric](10, 2) NULL,
	[SUMMERDISP] [numeric](10, 2) NULL,
	[TELEX] [char](50) NULL,
	[TEUNOM] [numeric](4, 0) NULL,
	[TOPTIERS] [char](50) NULL,
	[YARDCOUN] [char](50) NULL,
	[YEARBUILT] [numeric](4, 0) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SHIPMAST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SHIPMAST](
	[SHIPNAME] [char](80) NULL,
	[SHIPCODE] [char](10) NOT NULL,
 CONSTRAINT [PK_SHIPMAST] PRIMARY KEY CLUSTERED 
(
	[SHIPCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SHIPCOND]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SHIPCOND](
	[TABLE_NAME] [char](128) NULL,
	[TABLE_OPT] [char](1) NULL,
	[FLD_COND] [char](250) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SCHEDULE]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SCHEDULE](
	[SCHED] [numeric](4, 0) NULL,
	[SCHEDULE] [varchar](max) NULL,
	[NAME] [char](45) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[MANUF] [char](50) NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SCHEDATETIME]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SCHEDATETIME](
	[PMSCODE] [char](10) NULL,
	[DUE_MONTH] [datetime] NULL,
	[SCHED_DATETIME] [datetime] NULL,
	[DONE] [bit] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SCAVENGE_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SCAVENGE_INSP](
	[TYPECODE] [char](8) NULL,
	[BUILDER] [char](50) NULL,
	[ENG_NO] [char](10) NULL,
	[CHECKEDBY] [char](50) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[ENG_TYPE] [char](50) NULL,
	[ENG_HRS] [char](10) NULL,
	[ENTDATETIME] [char](10) NULL,
	[CYL_NO] [numeric](2, 0) NULL,
	[CL_1] [char](30) NULL,
	[CL_2] [char](30) NULL,
	[CL_3] [char](30) NULL,
	[CL_4] [char](30) NULL,
	[REM_YN] [char](10) NULL,
	[REM] [char](200) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SCAV_PORT_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SCAV_PORT_INSP](
	[TYPECODE] [char](8) NULL,
	[BUILDER] [char](50) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[ENG_TYPE] [char](50) NULL,
	[ENG_HRS] [char](10) NULL,
	[CHECKEDBY] [char](50) NULL,
	[ENTDATETIME] [char](10) NULL,
	[WK_PR_POCA] [char](20) NULL,
	[MCR] [char](10) NULL,
	[MEP] [char](10) NULL,
	[CYLOIL_CON] [char](10) NULL,
	[AT_LOAD] [char](10) NULL,
	[CYLOLI_TYP] [char](30) NULL,
	[POSITION] [char](10) NULL,
	[EXHAUST] [char](10) NULL,
	[ROW_ID] [numeric](2, 0) NULL,
	[CYLNO_1] [char](20) NULL,
	[CYLNO_2] [char](20) NULL,
	[CYLNO_3] [char](20) NULL,
	[CYLNO_4] [char](20) NULL,
	[CYLNO_5] [char](20) NULL,
	[CYLNO_6] [char](20) NULL,
	[CYLNO_7] [char](20) NULL,
	[CYLNO_8] [char](20) NULL,
	[CYLNO_9] [char](20) NULL,
	[CYLNO_10] [char](20) NULL,
	[CYLNO_11] [char](20) NULL,
	[CYLNO_12] [char](20) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SAFTYEQ]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SAFTYEQ](
	[DT] [datetime] NULL,
	[ERFIREDETC] [datetime] NULL,
	[QUICKCLVL] [datetime] NULL,
	[EMERTRIPS] [datetime] NULL,
	[CO2ALARM] [datetime] NULL,
	[ERFLAPSKY] [datetime] NULL,
	[LIFEBOATP] [datetime] NULL,
	[LIFEBOATS] [datetime] NULL,
	[PROVCRAN] [datetime] NULL,
	[ELEVSAFT] [datetime] NULL,
	[ACCLADER] [datetime] NULL,
	[BLACKOUT] [datetime] NULL,
	[BUNKOFLOW] [datetime] NULL,
	[FIREWATER] [datetime] NULL,
	[EMERBCFAIL] [datetime] NULL,
	[ERBALARM] [datetime] NULL,
	[ERCRANE] [datetime] NULL,
	[SWOBD] [datetime] NULL,
	[CLAYBOILER] [datetime] NULL,
	[TGTRIP] [datetime] NULL,
	[TGSAFETY] [datetime] NULL,
	[ADDGEN] [datetime] NULL,
	[FIREPUMP] [datetime] NULL,
	[AIRCOMP] [datetime] NULL,
	[STEERING] [datetime] NULL,
	[LIFEBOATEN] [datetime] NULL,
	[BOILER] [datetime] NULL,
	[MEMERCON] [datetime] NULL,
	[MESHUTDN] [datetime] NULL,
	[AE1SHUTDN] [datetime] NULL,
	[AE2SHUTDN] [datetime] NULL,
	[AE3SHUTDN] [datetime] NULL,
	[AE4SHUTDN] [datetime] NULL,
	[TASGSHUTDN] [datetime] NULL,
	[AE1OVERSP] [datetime] NULL,
	[AE2OVERSP] [datetime] NULL,
	[AE3OVERSP] [datetime] NULL,
	[AE4OVERSP] [datetime] NULL,
	[MEOVERSP] [datetime] NULL,
	[BHPMCR] [numeric](8, 0) NULL,
	[BHPDEVELOP] [numeric](8, 0) NULL,
	[HO] [numeric](8, 2) NULL,
	[SPECHO] [numeric](10, 4) NULL,
	[CYLOIL] [numeric](8, 2) NULL,
	[SPECCYLOIL] [numeric](10, 4) NULL,
	[TOTHO] [numeric](10, 2) NULL,
	[SLUDGEN] [numeric](6, 2) NULL,
	[SLUDROBLM] [numeric](7, 2) NULL,
	[SLUDINCI] [numeric](7, 2) NULL,
	[DISPASHORE] [numeric](5, 0) NULL,
	[LTDISPDT] [datetime] NULL,
	[SLUDROBNW] [numeric](7, 2) NULL,
	[OWSSTATUS] [char](15) NULL,
	[SEWSTATUS] [char](15) NULL,
	[FW] [numeric](6, 2) NULL,
	[EXHBOILW] [datetime] NULL,
	[SOOT] [char](5) NULL,
	[METURWW] [numeric](2, 0) NULL,
	[METURDW] [numeric](2, 0) NULL,
	[TOTRUNHRS] [numeric](10, 0) NULL,
	[MONRUNHRS] [numeric](10, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[PROVCRANST] [datetime] NULL,
	[EJECPPPRES] [numeric](5, 2) NULL,
	[FWGSHELL] [numeric](5, 1) NULL,
	[FOPUR1] [numeric](5, 1) NULL,
	[FOPUR2] [numeric](5, 1) NULL,
	[FOPUR3] [numeric](5, 1) NULL,
	[FOPUR4] [numeric](5, 1) NULL,
	[LOPUR1] [numeric](5, 1) NULL,
	[LOPUR2] [numeric](5, 1) NULL,
	[AELO] [numeric](5, 1) NULL,
	[MEATRM] [char](4) NULL,
	[FISHRRM] [char](4) NULL,
	[VEGRM] [char](4) NULL,
	[LOSAMPDT1] [datetime] NULL,
	[PORT] [char](25) NULL,
	[DEFLT1] [char](10) NULL,
	[DEFLT2] [char](10) NULL,
	[DEFLTVAL1] [numeric](5, 1) NULL,
	[DEFLTVAL2] [char](4) NULL,
	[AETURW] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RUNHRSDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RUNHRSDTL](
	[NUM] [numeric](2, 0) NULL,
	[TOTRUNHRS] [numeric](10, 0) NULL,
	[MONRUNHRS] [numeric](10, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RUNHRS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RUNHRS](
	[NUM] [numeric](2, 0) NULL,
	[TYPECODE] [char](10) NULL,
	[OHAUL] [numeric](10, 0) NULL,
	[RUNHRS1] [numeric](10, 0) NULL,
	[OHDATETIME1] [datetime] NULL,
	[RUNHRS2] [numeric](10, 0) NULL,
	[OHDATETIME2] [datetime] NULL,
	[RUNHRS3] [numeric](10, 0) NULL,
	[OHDATETIME3] [datetime] NULL,
	[RUNHRS4] [numeric](10, 0) NULL,
	[OHDATETIME4] [datetime] NULL,
	[RUNHRS5] [numeric](10, 0) NULL,
	[OHDATETIME5] [datetime] NULL,
	[RUNHRS6] [numeric](10, 0) NULL,
	[OHDATETIME6] [datetime] NULL,
	[RUNHRS7] [numeric](10, 0) NULL,
	[OHDATETIME7] [datetime] NULL,
	[RUNHRS8] [numeric](10, 0) NULL,
	[OHDATETIME8] [datetime] NULL,
	[RUNHRS9] [numeric](10, 0) NULL,
	[OHDATETIME9] [datetime] NULL,
	[RUNHRS10] [numeric](10, 0) NULL,
	[OHDATETIME10] [datetime] NULL,
	[RUNHRS11] [numeric](10, 0) NULL,
	[OHDATETIME11] [datetime] NULL,
	[RUNHRS12] [numeric](10, 0) NULL,
	[OHDATETIME12] [datetime] NULL,
	[DT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[RUNHRS13] [numeric](10, 0) NULL,
	[OHDATETIME13] [datetime] NULL,
	[RUNHRS14] [numeric](10, 0) NULL,
	[OHDATETIME14] [datetime] NULL,
	[RUNHRS15] [numeric](10, 0) NULL,
	[OHDATETIME15] [datetime] NULL,
	[RUNHRS16] [numeric](10, 0) NULL,
	[OHDATETIME16] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RSIMGDBF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RSIMGDBF](
	[SLNO] [numeric](8, 0) NULL,
	[RESTBY] [char](60) NULL,
	[RESTFROM] [char](20) NULL,
	[RESTPATH] [char](250) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RESTDBF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RESTDBF](
	[RESTON] [char](30) NULL,
	[RESTBY] [char](60) NULL,
	[RESTFROM] [char](20) NULL,
	[RESTPATH] [char](250) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REPORD_PIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REPORD_PIC](
	[REP_ON] [char](2) NULL,
	[VJOB_NO] [char](20) NULL,
	[EN_SLNO] [char](1) NULL,
	[PICPATH] [char](250) NULL,
	[REMARKS] [char](250) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[REPNO] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REPASPEC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REPASPEC](
	[REP_ON] [char](2) NULL,
	[REP_DATETIME] [datetime] NULL,
	[DATES] [datetime] NULL,
	[VJOB_NO] [char](20) NULL,
	[VPAGE_NO] [char](10) NULL,
	[YJOB_NO] [char](15) NULL,
	[OJOB_NO] [char](15) NULL,
	[GEN_DESC] [varchar](max) NULL,
	[ACT_JOB] [varchar](max) NULL,
	[STAG] [varchar](max) NULL,
	[CLS_SOC] [bit] NULL,
	[FLG_ADM] [bit] NULL,
	[OWNERS] [bit] NULL,
	[MANUF] [bit] NULL,
	[U_WRITERS] [bit] NULL,
	[EXTRA1] [bit] NULL,
	[EXTRA1_HED] [char](20) NULL,
	[G_CERTI] [bit] NULL,
	[L_VENT] [bit] NULL,
	[CL_BEFORE] [bit] NULL,
	[CL_AFTER] [bit] NULL,
	[STAGING] [bit] NULL,
	[C_SERIVICE] [bit] NULL,
	[TRANS_INTE] [bit] NULL,
	[TRANS_OUT] [bit] NULL,
	[AC_WORK] [bit] NULL,
	[CORR_PORT] [bit] NULL,
	[GALVA] [bit] NULL,
	[PAINT] [bit] NULL,
	[PRES_TEST] [bit] NULL,
	[FUNC_TEST] [bit] NULL,
	[N_DES_TEST] [bit] NULL,
	[COR_DRAW] [bit] NULL,
	[EXTRA2] [bit] NULL,
	[EXTRA2_HED] [char](20) NULL,
	[Y_SUPPLY] [bit] NULL,
	[O_SUPPLY] [bit] NULL,
	[EXTRA3] [bit] NULL,
	[EXTRA3_HED] [char](20) NULL,
	[EXTRA4] [bit] NULL,
	[EXTRA4_HED] [char](20) NULL,
	[EXTRA5] [bit] NULL,
	[EXTRA5_HED] [char](20) NULL,
	[SEXTRA1] [bit] NULL,
	[SEXTRA1_HE] [char](20) NULL,
	[SEXTRA2] [bit] NULL,
	[SEXTRA2_HE] [char](20) NULL,
	[SEXTRA3] [bit] NULL,
	[SEXTRA3_HE] [char](20) NULL,
	[SEXTRA4] [bit] NULL,
	[SEXTRA4_HE] [char](20) NULL,
	[SEXTRA5] [bit] NULL,
	[SEXTRA5_HE] [char](20) NULL,
	[SEXTRA6] [bit] NULL,
	[SEXTRA6_HE] [char](20) NULL,
	[SEXTRA7] [bit] NULL,
	[SEXTRA7_HE] [char](20) NULL,
	[SEXTRA8] [bit] NULL,
	[SEXTRA8_HE] [char](20) NULL,
	[YA_SUPPLY] [bit] NULL,
	[OW_SUPPLY] [bit] NULL,
	[MAK_SUPPLY] [bit] NULL,
	[MEXTRA1] [bit] NULL,
	[MEXTRA1_HE] [char](20) NULL,
	[MEXTRA2] [bit] NULL,
	[MEXTRA2_HE] [char](20) NULL,
	[DRAWING] [bit] NULL,
	[SKETCH] [bit] NULL,
	[PHOTOGRAPH] [bit] NULL,
	[SAMPLE] [bit] NULL,
	[ENEXTRA1] [bit] NULL,
	[ENEXTRA1_H] [char](20) NULL,
	[REFNO] [char](12) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[REPNO] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[DDYEAR] [numeric](4, 0) NULL,
	[PICT] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REP_PIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REP_PIC](
	[REP_ON] [char](2) NULL,
	[VJOB_NO] [char](20) NULL,
	[EN_SLNO] [char](1) NULL,
	[PICPATH] [char](250) NULL,
	[REMARKS] [char](250) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[REPNO] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REP_ORDER]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REP_ORDER](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[REP_ON] [char](2) NULL,
	[REPNO] [char](10) NULL,
	[OFFUPDT] [bit] NULL,
	[REFNO] [char](12) NULL,
	[ORDERNO] [char](20) NULL,
	[ORD_DATE] [datetime] NULL,
	[PORT] [char](30) NULL,
	[NAME] [char](30) NULL,
	[ADD1] [char](30) NULL,
	[ADD2] [char](30) NULL,
	[ADD3] [char](30) NULL,
	[DTL_DESC] [varchar](max) NULL,
	[SUPNAME] [char](30) NULL,
	[SUPDTAPPDT] [datetime] NULL,
	[PHOTO] [bit] NULL,
	[DRAWING] [bit] NULL,
	[SKETCH] [bit] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_REP_ORDER] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PUMPOVER]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PUMPOVER](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[PMSCODE] [char](10) NULL,
	[DESCRIPT] [char](200) NULL,
	[BEARINGNUM] [char](15) NULL,
	[OHLDATE] [datetime] NULL,
	[LASTSURV] [datetime] NULL,
	[REPODATE] [datetime] NULL,
	[REMARKS] [char](200) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PUMPOVER] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[POSTPOND]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POSTPOND](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[REASON] [char](254) NULL,
	[L_PSTPND] [bit] NULL,
	[DTPSTPND] [datetime] NULL,
	[NTPSTPND] [numeric](8, 0) NULL,
	[OHAULAT] [numeric](8, 0) NULL,
	[TOTHRS] [numeric](8, 0) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDTDT] [datetime] NULL,
	[POSTPNDBY] [char](100) NULL,
	[RESETBY] [char](100) NULL,
	[RESETDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_POSTPOND] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSTYPE]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSTYPE](
	[TYPECODE] [int] IDENTITY(1,1) NOT NULL,
	[PMSTYPE] [char](45) NULL,
	[L_DEFA] [bit] NULL,
	[HISTCODE1] [char](10) NULL,
	[HISTCODE2] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[MCAT] [char](1) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PMSTYPE_1] PRIMARY KEY CLUSTERED 
(
	[TYPECODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSJOB]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSJOB](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[PMSCODE] [char](10) NULL,
	[SCHED] [numeric](4, 0) NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PMSJOB] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSHIST]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSHIST](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[USERS] [char](36) NULL,
	[DATES] [datetime] NULL,
	[DESCRIPT1] [varchar](max) NULL,
	[ITEMCODE] [char](10) NULL,
	[MODE] [char](7) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[USERNAME] [char](60) NULL,
	[DESCRIPT2] [varchar](max) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PMSHIST] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSFLD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSFLD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[FIELD_NAME] [char](128) NULL,
	[FIELD_NEW] [char](10) NULL,
	[TABLE_NAME] [char](128) NULL,
	[FIELD_TYPE] [char](1) NULL,
	[FIELD_LEN] [numeric](3, 0) NULL,
	[FIELD_DEC] [numeric](3, 0) NULL,
	[FIELD_NULL] [bit] NULL,
	[FIELD_NOCP] [bit] NULL,
	[FIELD_DEFA] [varchar](max) NULL,
	[FIELD_RULE] [varchar](max) NULL,
	[FIELD_ERR] [varchar](max) NULL,
	[TABLE_RULE] [varchar](max) NULL,
	[TABLE_ERR] [varchar](max) NULL,
	[INS_TRIG] [varchar](max) NULL,
	[UPD_TRIG] [varchar](max) NULL,
	[DEL_TRIG] [varchar](max) NULL,
	[TABLE_CMT] [varchar](max) NULL,
	[TABLE_CAT] [char](1) NULL,
 CONSTRAINT [PK_pmsflds] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSDESC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSDESC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[PAGENO] [numeric](2, 0) NULL,
	[WIND_NO] [numeric](2, 0) NULL,
	[SLNO] [numeric](2, 0) NULL,
	[DESCRIPT] [char](100) NULL,
	[TYPECODE] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PMSDESC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSCOND]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSCOND](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[ITEMCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[COND] [numeric](1, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PMSCOND] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSBK]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSBK](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[PMSITEM] [char](45) NULL,
	[HEADR] [char](60) NULL,
	[EQCODE] [char](10) NULL,
	[PERIOD] [char](1) NULL,
	[INTERVAL] [numeric](6, 0) NULL,
	[SCHED] [numeric](4, 0) NULL,
	[OHAULAT] [numeric](7, 0) NULL,
	[HRSNET] [numeric](7, 0) NULL,
	[M_E_D] [char](1) NULL,
	[CRIT] [bit] NULL,
	[DATES] [datetime] NULL,
	[L_DCARB] [bit] NULL,
	[TYPECODE] [char](8) NULL,
	[NUM] [numeric](2, 0) NULL,
	[STPOINT] [numeric](7, 2) NULL,
	[STPOINT1] [numeric](7, 2) NULL,
	[UNITS] [char](10) NULL,
	[E_D_S] [char](1) NULL,
	[EDITED] [bit] NULL,
	[USERS] [char](35) NULL,
	[REASON] [char](254) NULL,
	[PTOTHRS] [numeric](7, 0) NULL,
	[L_PGROUP] [bit] NULL,
	[L_PSTPND] [bit] NULL,
	[DTPSTPND] [datetime] NULL,
	[NPSTPND] [numeric](8, 0) NULL,
	[UPSTPND] [char](8) NULL,
	[EO_ECO] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[RESPONSE] [char](5) NULL,
	[COMMENT] [char](254) NULL,
	[WARNPRD] [numeric](6, 0) NULL,
	[MANUFCODE] [char](10) NULL,
	[TYPE] [char](30) NULL,
	[SERIAL] [char](20) NULL,
	[DECOMM] [bit] NULL,
	[POSTPNDBY] [char](100) NULL,
	[STPOINT2] [numeric](7, 2) NULL,
	[STPOINT3] [numeric](7, 2) NULL,
	[STPOINT4] [numeric](7, 2) NULL,
	[SETRANGE] [char](20) NULL,
	[OFFUPDT] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PMSBK] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PISTREAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PISTREAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[GROVE] [numeric](1, 0) NULL,
	[GNO1] [char](7) NULL,
	[GNO2] [char](7) NULL,
	[GNO3] [char](7) NULL,
	[GNO4] [char](7) NULL,
	[GNO5] [char](7) NULL,
	[GNO6] [char](7) NULL,
	[GNO7] [char](7) NULL,
	[RING] [numeric](1, 0) NULL,
	[RNO1] [char](6) NULL,
	[RNO2] [char](6) NULL,
	[RNO3] [char](6) NULL,
	[RNO4] [char](6) NULL,
	[RNO5] [char](6) NULL,
	[RNO6] [char](6) NULL,
	[RNO7] [char](6) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[MES] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PISTREAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PISTON]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PISTON](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[PCLSID] [char](15) NULL,
	[PISTSINCE] [char](15) NULL,
	[PTOTHRS] [char](7) NULL,
	[CYLDCARB] [numeric](1, 0) NULL,
	[CONDROD] [char](15) NULL,
	[BURNMAX] [char](15) NULL,
	[PISTOPEN] [char](15) NULL,
	[PISTPTEST] [char](15) NULL,
	[PISTSPARE] [char](15) NULL,
	[STUFFBOX] [numeric](1, 0) NULL,
	[HEIGHT] [char](15) NULL,
	[OVERSIZE] [char](15) NULL,
	[SCRAPER] [char](15) NULL,
	[SCRHEIGHT] [char](15) NULL,
	[LEFTPIST] [char](6) NULL,
	[LEFTHEIGHT] [char](15) NULL,
	[RIGHTPIST] [char](15) NULL,
	[FUTURE] [char](100) NULL,
	[RIGHTHEIGH] [char](15) NULL,
	[PISTREPL] [char](15) NULL,
	[PISTOVAL] [char](15) NULL,
	[PISTHRS] [char](15) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[COMPRING1] [numeric](3, 0) NULL,
	[COMPRING2] [numeric](3, 0) NULL,
	[COMPRING3] [numeric](3, 0) NULL,
	[COMPRING4] [numeric](3, 0) NULL,
	[COMPRING5] [numeric](3, 0) NULL,
	[SCRARING1] [numeric](3, 0) NULL,
	[SCRARING2] [numeric](3, 0) NULL,
	[SEALRING1] [numeric](3, 0) NULL,
	[SEALRING2] [numeric](3, 0) NULL,
	[STUFFRING1] [numeric](3, 0) NULL,
	[STUFFRING2] [numeric](3, 0) NULL,
	[STUFFRING3] [numeric](3, 0) NULL,
	[STUFFRING4] [numeric](3, 0) NULL,
	[STUFFRING5] [numeric](3, 0) NULL,
	[MATERIAL1] [char](15) NULL,
	[MATERIAL2] [char](15) NULL,
	[MATERIAL3] [char](15) NULL,
	[MATERIAL4] [char](15) NULL,
	[MATERIAL5] [char](15) NULL,
	[MATERIAL6] [char](15) NULL,
	[MATERIAL7] [char](15) NULL,
	[PERINCHARG] [char](60) NULL,
	[REMARK] [varchar](max) NULL,
	[FURREPAIR] [varchar](max) NULL,
	[MAX1] [numeric](6, 2) NULL,
	[MAX2] [numeric](6, 2) NULL,
	[MAX3] [numeric](6, 2) NULL,
	[MAX4] [numeric](6, 2) NULL,
	[MAX5] [numeric](6, 2) NULL,
	[MIN1] [numeric](6, 2) NULL,
	[MIN2] [numeric](6, 2) NULL,
	[MIN3] [numeric](6, 2) NULL,
	[MIN4] [numeric](6, 2) NULL,
	[MIN5] [numeric](6, 2) NULL,
	[AVG1] [numeric](6, 2) NULL,
	[AVG2] [numeric](6, 2) NULL,
	[AVG3] [numeric](6, 2) NULL,
	[AVG4] [numeric](6, 2) NULL,
	[AVG5] [numeric](6, 2) NULL,
	[REASON] [varchar](max) NULL,
	[LPISTOPEN] [datetime] NULL,
	[EXVALVE] [numeric](1, 0) NULL,
	[FUELINJ] [numeric](1, 0) NULL,
	[MES] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PISTON] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PISTDETL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PISTDETL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[RUNHRS] [numeric](5, 0) NULL,
	[WEAR] [numeric](7, 4) NULL,
	[RADORIG] [numeric](5, 2) NULL,
	[RADIALA] [numeric](5, 2) NULL,
	[RADIALB] [numeric](5, 2) NULL,
	[RADIALC] [numeric](5, 2) NULL,
	[BUTTNOW] [numeric](5, 2) NULL,
	[BUTTALLOW] [numeric](5, 2) NULL,
	[AUXIALA] [numeric](5, 2) NULL,
	[AUXIALB] [numeric](5, 2) NULL,
	[AUXIALC] [numeric](5, 2) NULL,
	[AUXAVG] [numeric](5, 2) NULL,
	[GROVNOW] [numeric](5, 2) NULL,
	[GROVALLOW] [numeric](5, 2) NULL,
	[MATER] [char](30) NULL,
	[RINGCOND] [char](30) NULL,
	[RENEW] [numeric](1, 0) NULL,
	[RADIAL] [numeric](5, 2) NULL,
	[BUTT] [numeric](5, 2) NULL,
	[AUXIAL] [numeric](5, 2) NULL,
	[GROVCLEAR] [numeric](5, 2) NULL,
	[NEWMATE] [char](30) NULL,
	[SLNO] [numeric](1, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PISTDETL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PETPMS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PETPMS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[PMSITEM] [char](40) NULL,
	[HEADR] [char](60) NULL,
	[EQCODE] [char](10) NULL,
	[PERIOD] [char](1) NULL,
	[INTERVAL] [numeric](6, 0) NULL,
	[SCHED] [numeric](4, 0) NULL,
	[OHAULAT] [numeric](7, 0) NULL,
	[HRSNET] [numeric](7, 0) NULL,
	[M_E_D] [char](1) NULL,
	[DATES] [datetime] NULL,
	[E_D_S] [char](1) NULL,
	[EDITED] [bit] NULL,
	[CRIT] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[RESPONSE] [char](5) NULL,
	[MANUFCODE] [char](10) NULL,
	[TYPE] [char](30) NULL,
	[SERIAL] [char](20) NULL,
	[DECOMM] [bit] NULL,
	[STPOINT2] [numeric](7, 2) NULL,
	[STPOINT3] [numeric](7, 2) NULL,
	[STPOINT4] [numeric](7, 2) NULL,
	[SETRANGE] [char](20) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PETPMS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PETMAIN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PETMAIN](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[MAINITEM] [char](40) NULL,
	[M_P] [char](1) NULL,
	[TOTHRS] [numeric](7, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PETMAIN] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PASSWORD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PASSWORD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[USERS] [char](35) NULL,
	[PASSWORD] [char](10) NULL,
	[LEVEL] [char](2) NULL,
	[CATEGORY] [char](1) NULL,
	[PERSON] [char](60) NULL,
	[SHORTUSER] [char](5) NULL,
 CONSTRAINT [PK_PASSWORD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OVRPMS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OVRPMS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[TMAINCODE] [char](10) NULL,
	[TPMSCODE] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_OVRPMS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OFFEX]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OFFEX](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TABLE_NAME] [char](128) NULL,
	[TABLE_OPT] [char](1) NULL,
	[FLD_DATE] [char](20) NULL,
 CONSTRAINT [PK_OFFEX] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NKKTYPE]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NKKTYPE](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[NKKCODE] [numeric](2, 0) NULL,
	[NKKITEM] [char](5) NULL,
	[NKKDESC] [char](100) NULL,
 CONSTRAINT [PK_NkkType] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NEARPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NEARPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[SRNUMB] [char](10) NULL,
	[DATES] [datetime] NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_NEARPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NEAROFF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NEAROFF](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[OFFUSER] [char](60) NULL,
	[OFFCOMM] [varchar](max) NULL,
	[OFFCOMMDT] [datetime] NULL,
	[REFNO] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[UPDTREC] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_NEAROFF] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NEARMISS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NEARMISS](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[PEOPLE] [bit] NULL,
	[PROPERTY] [bit] NULL,
	[SRNUMB] [char](10) NULL,
	[MISSDT] [datetime] NULL,
	[TIMEMISS] [char](10) NULL,
	[DESCEND] [varchar](max) NULL,
	[LOCATION] [char](5) NULL,
	[SHASSIST] [bit] NULL,
	[LATITUDE] [char](10) NULL,
	[LONGITUDE] [char](10) NULL,
	[PORTNAME] [char](30) NULL,
	[NARRWHAT] [varchar](max) NULL,
	[NARRWHY] [varchar](max) NULL,
	[REGULATION] [varchar](max) NULL,
	[SLIP] [varchar](max) NULL,
	[LAPSE] [varchar](max) NULL,
	[MISTAKE] [varchar](max) NULL,
	[PREVENT] [varchar](max) NULL,
	[SEVERITY] [numeric](1, 0) NULL,
	[PROBABLE] [numeric](1, 0) NULL,
	[RISKFACTOR] [numeric](3, 0) NULL,
	[PRIMCAUSE] [char](10) NULL,
	[SECONCAUS] [char](10) NULL,
	[PERSONAL] [char](10) NULL,
	[JOB] [char](10) NULL,
	[MASTERCOMM] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[DEPPORT] [char](30) NULL,
	[DEPDATE] [datetime] NULL,
	[DESTPORT] [char](30) NULL,
	[ARRDATE] [datetime] NULL,
	[ROUTVIOLAT] [varchar](max) NULL,
	[EXCEPVIOLA] [varchar](max) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_NEARMISS] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MYMENU]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MYMENU](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[PARENTKEY] [char](3) NULL,
	[CHILDKEY] [char](3) NULL,
	[CATEGORY] [char](1) NULL,
	[ITEMS] [char](100) NULL,
	[KEYCODE] [char](30) NULL,
	[PIC] [char](50) NULL,
	[REMARKS] [char](150) NULL,
	[ICONFILE] [varchar](max) NULL,
	[APPRUN] [char](100) NULL,
	[DIS] [char](200) NULL,
 CONSTRAINT [PK_mymenu] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MSM]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MSM](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[CATAGORY] [char](1) NULL,
	[GRPCODE] [char](5) NULL,
	[GRPNAME] [char](60) NULL,
	[SUBGRPCODE] [char](5) NULL,
	[SUBGRPNAME] [char](50) NULL,
	[MSMCODE] [char](10) NULL,
	[MSMDESC] [char](85) NULL,
 CONSTRAINT [PK_MSM] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MSGDATA]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MSGDATA](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[FUSERCODE] [char](2) NULL,
	[TUSERCODE] [char](2) NULL,
	[ENTDT] [datetime] NULL,
	[REMARKS] [varchar](max) NULL,
	[READDT] [datetime] NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[MSGID] [char](10) NULL,
	[MSGCONTID] [char](10) NULL,
	[SUBJECT] [char](150) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MSGDATA] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOTMEG]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOTMEG](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[KWRATING] [char](10) NULL,
	[WPROOF] [bit] NULL,
	[BEARINGNUM] [char](20) NULL,
	[LASTDONE] [datetime] NULL,
	[OHLDATE] [datetime] NULL,
	[MEGGER] [char](10) NULL,
	[REPODATE] [datetime] NULL,
	[REMARKS] [char](200) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MOTMEG] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MESPITEM]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MESPITEM](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[SPID] [char](20) NULL,
	[SPUSERID] [char](5) NULL,
	[TOTHRS] [numeric](7, 0) NULL,
	[OHDATE] [datetime] NULL,
	[TYPECODE] [char](10) NULL,
	[SPARED] [bit] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MESPITEM] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MESPDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MESPDTL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[SPID] [char](20) NULL,
	[SPUSERID] [char](5) NULL,
	[OHHRS] [numeric](7, 0) NULL,
	[OHDATE] [datetime] NULL,
	[MEHRS] [numeric](7, 0) NULL,
	[REMARKS] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MESPDTL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MEPERFORM]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MEPERFORM](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DATES] [datetime] NULL,
	[ITZ] [numeric](1, 0) NULL,
	[TIME] [char](10) NULL,
	[FROMPORT] [char](60) NULL,
	[SLNO] [numeric](2, 0) NULL,
	[ENGMAKER] [char](80) NULL,
	[MCR] [numeric](6, 0) NULL,
	[MCRAT] [numeric](6, 0) NULL,
	[DEADWT] [numeric](7, 0) NULL,
	[DISPLACE] [numeric](7, 0) NULL,
	[BAROMETER] [char](10) NULL,
	[FUELUSE] [char](10) NULL,
	[FODAYTANK] [numeric](4, 0) NULL,
	[SULPHUR] [numeric](6, 2) NULL,
	[CYLOILGRAD] [char](30) NULL,
	[INDSPR1] [numeric](4, 0) NULL,
	[INDSPR2] [numeric](6, 0) NULL,
	[POWER] [numeric](6, 0) NULL,
	[SHAFTGEN] [numeric](6, 0) NULL,
	[SHAFTPOWER] [numeric](6, 0) NULL,
	[CYLCONST] [numeric](7, 4) NULL,
	[PITCHSET] [char](10) NULL,
	[SPEEDSETAR] [char](6) NULL,
	[SPCFUELCON] [numeric](8, 4) NULL,
	[FUELSGRAV] [numeric](7, 4) NULL,
	[FUELSGRAVT] [numeric](3, 0) NULL,
	[FOTEMPINJ] [numeric](5, 0) NULL,
	[FOVISINJ] [numeric](5, 0) NULL,
	[FQS] [char](10) NULL,
	[VIT] [char](10) NULL,
	[TCOVERH1] [numeric](6, 0) NULL,
	[TCOVERH2] [numeric](6, 0) NULL,
	[TCOVERH3] [numeric](6, 0) NULL,
	[EXTURBBE1] [numeric](3, 0) NULL,
	[EXTURBAT1] [numeric](3, 0) NULL,
	[EXTRUBBE2] [numeric](3, 0) NULL,
	[EXTURBAT2] [numeric](3, 0) NULL,
	[EXTRUBBE3] [numeric](3, 0) NULL,
	[EXTURBAT3] [numeric](3, 0) NULL,
	[AIRFILT1] [numeric](3, 0) NULL,
	[AIRFILT2] [numeric](3, 0) NULL,
	[AIRFILT3] [numeric](3, 0) NULL,
	[AIRCOOLBE1] [numeric](3, 0) NULL,
	[AIRCOOLAT1] [numeric](3, 0) NULL,
	[AIRCOOLBE2] [numeric](3, 0) NULL,
	[AIRCOOLAT2] [numeric](3, 0) NULL,
	[AIRCOOLBE3] [numeric](3, 0) NULL,
	[AIRCOOLAT3] [numeric](3, 0) NULL,
	[CWCOOLBE1] [numeric](3, 0) NULL,
	[CWCOOLAT1] [numeric](3, 0) NULL,
	[CWCOOLBE2] [numeric](3, 0) NULL,
	[CWCOOLAT2] [numeric](3, 0) NULL,
	[CWCOOLBE3] [numeric](3, 0) NULL,
	[CWCOOLAT3] [numeric](3, 0) NULL,
	[CWBLOWBE1] [numeric](3, 0) NULL,
	[CWBLOWAT1] [numeric](3, 0) NULL,
	[CWBLOWBE2] [numeric](3, 0) NULL,
	[CWBLOWAT2] [numeric](3, 0) NULL,
	[CWBLOWBE3] [numeric](3, 0) NULL,
	[CWBLOWAT3] [numeric](3, 0) NULL,
	[OILGAS1] [numeric](3, 0) NULL,
	[OILAIR1] [numeric](3, 0) NULL,
	[OILGAS2] [numeric](3, 0) NULL,
	[OILAIR2] [numeric](3, 0) NULL,
	[OILGAS3] [numeric](3, 0) NULL,
	[OILAIR3] [numeric](3, 0) NULL,
	[AIRFILPRE1] [numeric](3, 0) NULL,
	[AIRFILPRE2] [numeric](3, 0) NULL,
	[AIRFILPRE3] [numeric](3, 0) NULL,
	[AIRCOLPRE1] [numeric](3, 0) NULL,
	[AIRCOLPRE2] [numeric](3, 0) NULL,
	[AIRCOLPRE3] [numeric](3, 0) NULL,
	[GASINTUR1] [numeric](3, 0) NULL,
	[GASINTUR2] [numeric](3, 0) NULL,
	[GASINTUR3] [numeric](3, 0) NULL,
	[GASOUTTUR1] [numeric](3, 0) NULL,
	[GASOUTTUR2] [numeric](3, 0) NULL,
	[GASOUTTUR3] [numeric](3, 0) NULL,
	[RPM1] [numeric](6, 2) NULL,
	[RPM2] [numeric](6, 2) NULL,
	[RPM3] [numeric](6, 2) NULL,
	[LOPPBRG1] [numeric](6, 0) NULL,
	[LOPPBRG2] [numeric](6, 0) NULL,
	[LOPPBRG3] [numeric](6, 0) NULL,
	[LOPPRATE1] [numeric](6, 0) NULL,
	[LOPPRATE2] [numeric](6, 0) NULL,
	[LOPPRATE3] [numeric](6, 0) NULL,
	[PPBRGS1] [numeric](6, 0) NULL,
	[PPBRGS2] [numeric](6, 0) NULL,
	[PPBRGS3] [numeric](6, 0) NULL,
	[HRSAIRFIL1] [numeric](6, 0) NULL,
	[HRSAIRFIL2] [numeric](6, 0) NULL,
	[HRSAIRFIL3] [numeric](6, 0) NULL,
	[HRSAIRCOL1] [numeric](6, 0) NULL,
	[HRSAIRCOL2] [numeric](6, 0) NULL,
	[HRSAIRCOL3] [numeric](6, 0) NULL,
	[TUWASHAIR1] [numeric](6, 0) NULL,
	[TUWASHAIR2] [numeric](6, 0) NULL,
	[TUWASHAIR3] [numeric](6, 0) NULL,
	[TUWASHGAS1] [numeric](6, 0) NULL,
	[TUWASHGAS2] [numeric](6, 0) NULL,
	[TUWASHGAS3] [numeric](6, 0) NULL,
	[ENGROOMTB] [numeric](6, 0) NULL,
	[SEAWATER] [numeric](6, 0) NULL,
	[SCAVAIRBEL] [numeric](6, 0) NULL,
	[MEFWINLET] [numeric](6, 0) NULL,
	[MEFWOUTLET] [numeric](6, 0) NULL,
	[PISTCOLMAX] [numeric](6, 0) NULL,
	[PISTCOLMIN] [numeric](6, 0) NULL,
	[LOCOOLBF] [numeric](6, 0) NULL,
	[LOCOOLAT] [numeric](6, 0) NULL,
	[SWCOOLER] [numeric](3, 0) NULL,
	[SCAVAIRBP] [numeric](6, 2) NULL,
	[FWMEPRES] [numeric](6, 2) NULL,
	[PISTMEPRES] [numeric](6, 2) NULL,
	[LOMEPRES] [numeric](6, 2) NULL,
	[SWCOOLPRES] [numeric](7, 2) NULL,
	[CRANKPRESS] [numeric](8, 4) NULL,
	[GASBOILER] [numeric](8, 4) NULL,
	[CYLOILFEED] [numeric](8, 4) NULL,
	[COMMENTS] [varchar](max) NULL,
	[RPM] [numeric](6, 2) NULL,
	[SLIP] [numeric](7, 2) NULL,
	[SPEED] [numeric](5, 2) NULL,
	[LOADIND] [numeric](5, 1) NULL,
	[GOVIND] [numeric](5, 2) NULL,
	[FWD] [numeric](6, 2) NULL,
	[AFT] [numeric](6, 2) NULL,
	[WINDFORCE] [numeric](2, 0) NULL,
	[RELDIR] [char](10) NULL,
	[SEASTATE] [numeric](2, 0) NULL,
	[CURRENTS] [numeric](4, 2) NULL,
	[TOPORT] [char](60) NULL,
	[SWELL] [numeric](4, 1) NULL,
	[SWRELDIR] [char](10) NULL,
	[FOCONS] [numeric](6, 2) NULL,
	[CYLCON] [numeric](7, 2) NULL,
	[CYLOILSPE] [numeric](7, 4) NULL,
	[SYSTCONS] [numeric](5, 0) NULL,
	[TCOVERH4] [numeric](6, 0) NULL,
	[EXTURBBE4] [numeric](6, 0) NULL,
	[EXTURBAT4] [numeric](3, 0) NULL,
	[AIRFILT4] [numeric](3, 0) NULL,
	[AIRCOOLBE4] [numeric](3, 0) NULL,
	[AIRCOOLAT4] [numeric](3, 0) NULL,
	[CWCOOLBE4] [numeric](3, 0) NULL,
	[CWCOOLAT4] [numeric](3, 0) NULL,
	[CWBLOWBE4] [numeric](3, 0) NULL,
	[CWBLOWAT4] [numeric](3, 0) NULL,
	[OILGAS4] [numeric](3, 0) NULL,
	[OILAIR4] [numeric](3, 0) NULL,
	[AIRFILPRE4] [numeric](3, 0) NULL,
	[AIRCOLPRE4] [numeric](3, 0) NULL,
	[GASINTUR4] [numeric](3, 0) NULL,
	[GASOUTTUR4] [numeric](3, 0) NULL,
	[RPM4] [numeric](6, 2) NULL,
	[LOPPBRG4] [numeric](6, 0) NULL,
	[LOPPRATE4] [numeric](6, 0) NULL,
	[PPBRGS4] [numeric](6, 0) NULL,
	[HRSAIRFIL4] [numeric](6, 0) NULL,
	[HRSAIRCOL4] [numeric](6, 0) NULL,
	[TUWASHAIR4] [numeric](6, 0) NULL,
	[TUWASHGAS4] [numeric](6, 0) NULL,
	[EXHFOLD] [numeric](7, 2) NULL,
	[FAVOUR] [numeric](1, 0) NULL,
	[AGAINST] [numeric](1, 0) NULL,
	[ATMTEMP] [numeric](5, 2) NULL,
	[THRUSTBEAR] [numeric](5, 2) NULL,
	[FUELOIL] [numeric](7, 2) NULL,
	[NUM] [numeric](2, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MEPERFORM] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MEPERDET]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEPERDET](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[DATES] [datetime] NULL,
	[ITZ] [numeric](1, 0) NULL,
	[CYLNO] [numeric](2, 0) NULL,
	[PRESSMAX] [numeric](6, 2) NULL,
	[PRESSCOM] [numeric](6, 2) NULL,
	[PRESMAXCOM] [numeric](6, 2) NULL,
	[MIP] [numeric](6, 2) NULL,
	[FUELPINDEX] [numeric](6, 2) NULL,
	[FUELPVIT] [numeric](6, 2) NULL,
	[EXHTEMP] [numeric](4, 0) NULL,
	[IHP] [numeric](6, 0) NULL,
	[LASTOHAUL] [numeric](6, 2) NULL,
	[UNITOHAUL] [numeric](6, 0) NULL,
	[NEWLINER] [numeric](6, 0) NULL,
	[INJECHANGE] [numeric](6, 0) NULL,
	[EXHVALCHG] [numeric](6, 0) NULL,
	[NUM] [numeric](2, 0) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MEPERDET] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEEXOVR]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MEEXOVR](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[OHHAULDT] [datetime] NULL,
	[ENG_TYPE] [char](2) NULL,
	[EXUNITNO] [char](4) NULL,
	[HOUSID] [char](4) NULL,
	[SPINDID] [char](4) NULL,
	[SEATID] [char](4) NULL,
	[HOUSMAKE] [char](50) NULL,
	[SPINMAKE] [char](50) NULL,
	[SEATMAKE] [char](50) NULL,
	[HRRUNLAST] [numeric](6, 0) NULL,
	[HOUSNEW] [numeric](6, 0) NULL,
	[HOUSRECON] [numeric](6, 0) NULL,
	[HOUSTIMES] [numeric](6, 0) NULL,
	[SPINNEW] [numeric](6, 0) NULL,
	[SPINRECON] [numeric](6, 0) NULL,
	[SPINTIMES] [numeric](6, 0) NULL,
	[SEATNEW] [numeric](6, 0) NULL,
	[SEATRECON] [numeric](6, 0) NULL,
	[SEATTIMES] [numeric](6, 0) NULL,
	[STEMDIAE1] [numeric](9, 2) NULL,
	[STEMDIAE2] [numeric](9, 2) NULL,
	[STEMDIALT] [numeric](9, 2) NULL,
	[COMBUSF1] [numeric](9, 2) NULL,
	[COMBUSF2] [numeric](9, 2) NULL,
	[COMBUSF3] [numeric](9, 2) NULL,
	[COMBUSF4] [numeric](9, 2) NULL,
	[COMBUSLT] [numeric](9, 2) NULL,
	[SEALG1BE] [numeric](9, 2) NULL,
	[SEALG1AT] [numeric](9, 2) NULL,
	[SEALG1GR] [numeric](9, 2) NULL,
	[SEALG1LT] [numeric](9, 2) NULL,
	[SEATG2BE] [numeric](9, 2) NULL,
	[SEATG2AT] [numeric](9, 2) NULL,
	[SEATG2GR] [numeric](9, 2) NULL,
	[SEATG2LT] [numeric](9, 2) NULL,
	[RECEG3BE] [numeric](9, 2) NULL,
	[RECEG3AT] [numeric](9, 2) NULL,
	[RECEG3LT] [numeric](9, 2) NULL,
	[GYDBUSHC] [numeric](9, 2) NULL,
	[GYDBUSHD] [numeric](9, 2) NULL,
	[GYDBUSHREN] [bit] NULL,
	[BYDBUSHLT] [numeric](9, 2) NULL,
	[AIRCYLA] [numeric](9, 2) NULL,
	[AIRCYLB] [numeric](9, 2) NULL,
	[AIRCYLREN] [bit] NULL,
	[AIRCYLLT] [numeric](9, 2) NULL,
	[REMARKS] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MEEXOVR] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MECRSHED]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MECRSHED](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[ENG_TYPE] [char](2) NULL,
	[OHHAULDT] [datetime] NULL,
	[MEAS_AT] [char](40) NULL,
	[MEAS_ON] [datetime] NULL,
	[MEAS_BY] [char](40) NULL,
	[CRANK_TEMP] [char](10) NULL,
	[REMARK] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MECRSHED] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MECRSDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MECRSDTL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[OHHAULDT] [datetime] NULL,
	[SLNO] [numeric](2, 0) NULL,
	[CL_LIMIT1] [numeric](4, 2) NULL,
	[CL_LIMIT2] [numeric](4, 2) NULL,
	[CL_LIMIT3] [numeric](4, 2) NULL,
	[CL_LIMIT4] [numeric](4, 2) NULL,
	[CL_LIMIT5] [numeric](4, 2) NULL,
	[CL_LIMIT6] [numeric](4, 2) NULL,
	[CL_LIMIT7] [numeric](4, 2) NULL,
	[CL_LIMIT8] [numeric](4, 2) NULL,
	[CL_LIMIT9] [numeric](4, 2) NULL,
	[CL_LIMIT10] [numeric](4, 2) NULL,
	[CL_LIMIT11] [numeric](4, 2) NULL,
	[CL_LIMIT12] [numeric](4, 2) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MECRSDTL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MEBRHEAD]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MEBRHEAD](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[PMSCODE] [char](10) NULL,
	[AT] [char](25) NULL,
	[DATES] [datetime] NULL,
	[CRAKPINMIN] [numeric](9, 2) NULL,
	[CRAKPINMAX] [numeric](9, 2) NULL,
	[CROSPINMIN] [numeric](9, 2) NULL,
	[CROSPINMAX] [numeric](9, 2) NULL,
	[MAINJOUMIN] [numeric](9, 2) NULL,
	[MAINJOUMAX] [numeric](9, 2) NULL,
	[THRUSTPAD] [numeric](9, 2) NULL,
	[OHAULREQD] [numeric](9, 2) NULL,
	[REMARKS] [varchar](max) NULL,
	[MEASUREDBY] [char](70) NULL,
	[ENG] [char](10) NULL,
	[VAL1] [char](5) NULL,
	[VAL2] [char](5) NULL,
	[VAL3] [char](5) NULL,
	[VAL4] [char](5) NULL,
	[VAL5] [char](5) NULL,
	[VAL6] [char](5) NULL,
	[VAL7] [char](5) NULL,
	[VAL8] [char](5) NULL,
	[VAL9] [char](5) NULL,
	[VAL10] [char](5) NULL,
	[VAL11] [char](5) NULL,
	[VAL12] [char](5) NULL,
	[VAL13] [char](5) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MEBRHEAD] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MEBRDTL]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MEBRDTL](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[PMSCODE] [char](10) NULL,
	[DATES] [datetime] NULL,
	[TYPECODE] [char](10) NULL,
	[VAL1] [char](6) NULL,
	[VAL2] [char](6) NULL,
	[VAL3] [char](6) NULL,
	[VAL4] [char](6) NULL,
	[VAL5] [char](6) NULL,
	[VAL6] [char](6) NULL,
	[VAL7] [char](6) NULL,
	[VAL8] [char](6) NULL,
	[VAL9] [char](6) NULL,
	[VAL10] [char](6) NULL,
	[VAL11] [char](6) NULL,
	[VAL12] [char](6) NULL,
	[VAL13] [char](6) NULL,
	[VAL14] [char](6) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MEBRDTL] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ME_PERFORM_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ME_PERFORM_INSP](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPECODE] [char](8) NULL,
	[ENG_TYPE] [char](50) NULL,
	[BUILDER] [char](50) NULL,
	[ENG_NO] [char](10) NULL,
	[YARD] [char](50) NULL,
	[LAYOUT_KW] [char](30) NULL,
	[LAYOUT_RPM] [char](30) NULL,
	[SIGN] [char](80) NULL,
	[TEST_NO] [char](10) NULL,
	[NO_OF_TC] [char](10) NULL,
	[T_SRLNO_1] [char](30) NULL,
	[T_SRLNO_2] [char](30) NULL,
	[T_SRLNO_3] [char](30) NULL,
	[T_SRLNO_4] [char](30) NULL,
	[NO_OF_CYL] [char](10) NULL,
	[BORE_M] [char](10) NULL,
	[STROKE_M] [char](10) NULL,
	[T_MAKE] [char](50) NULL,
	[T_TYPE] [char](50) NULL,
	[CYL_MEAN] [char](20) NULL,
	[T_MAX_RPM] [char](20) NULL,
	[T_MAX_TEMP] [char](20) NULL,
	[C_SLIP_FAC] [char](30) NULL,
	[C_DIAM] [char](30) NULL,
	[CYL_INT] [char](10) NULL,
	[CL_EXFRMME] [char](10) NULL,
	[CL_EXFRMGT] [char](10) NULL,
	[TC_SPEC] [char](200) NULL,
	[OBS_NO] [char](10) NULL,
	[FOIL_VISCO] [char](20) NULL,
	[FVISCO_AT] [char](20) NULL,
	[BUNK_STA] [char](50) NULL,
	[CYLOIL_BRN] [char](50) NULL,
	[CYLOIL_TYP] [char](50) NULL,
	[OIL_BRAND] [char](50) NULL,
	[HEAT_VALVE] [char](20) NULL,
	[CIROIL_BRN] [char](50) NULL,
	[CIROIL_TYP] [char](50) NULL,
	[DENS_AT15] [char](20) NULL,
	[SUL_PER] [char](10) NULL,
	[TOIL_BRN] [char](50) NULL,
	[TOIL_TYP] [char](50) NULL,
	[TEST_DT] [char](10) NULL,
	[TEST_HOUR] [char](10) NULL,
	[LOAD_PER] [char](10) NULL,
	[AMB_PRE] [char](10) NULL,
	[ENG_RPM] [char](20) NULL,
	[T_RUN_HRS] [char](20) NULL,
	[GOV_INDX] [char](20) NULL,
	[SPD_SET] [char](20) NULL,
	[VIT_CONT] [char](20) NULL,
	[DRAFT_FORE] [char](20) NULL,
	[LOG_KNOTS] [char](20) NULL,
	[WIND_M_S] [char](20) NULL,
	[WIND_DIREC] [char](20) NULL,
	[EF_PWR_KW] [char](20) NULL,
	[IND_PWR_KW] [char](20) NULL,
	[EF_FUL_CON] [char](20) NULL,
	[IN_FUL_CON] [char](20) NULL,
	[DRAFT_AFT] [char](20) NULL,
	[OBS_KNOTS] [char](20) NULL,
	[WAVE_HIGHT] [char](20) NULL,
	[WAV_DIREC] [char](20) NULL,
	[AC_IN_1] [char](10) NULL,
	[AC_IN_2] [char](10) NULL,
	[AC_IN_3] [char](10) NULL,
	[AC_IN_4] [char](10) NULL,
	[AC_OUT_1] [char](10) NULL,
	[AC_OUT_2] [char](10) NULL,
	[AC_OUT_3] [char](10) NULL,
	[AC_OUT_4] [char](10) NULL,
	[ME_INLET] [char](10) NULL,
	[ME_S_W_TEM] [char](10) NULL,
	[ME_TO_1] [char](20) NULL,
	[ME_TO_2] [char](20) NULL,
	[ME_TO_3] [char](20) NULL,
	[ME_TO_4] [char](20) NULL,
	[EG_T_IN_1] [char](20) NULL,
	[EG_T_IN_2] [char](20) NULL,
	[EG_T_IN_3] [char](20) NULL,
	[EG_T_IN_4] [char](20) NULL,
	[EG_T_OU_1] [char](20) NULL,
	[EG_T_OU_2] [char](20) NULL,
	[EG_T_OU_3] [char](20) NULL,
	[EG_T_OU_4] [char](20) NULL,
	[EP_REC_BAR] [char](20) NULL,
	[EP_REC_MM] [char](20) NULL,
	[EP_TO_1] [char](20) NULL,
	[EP_TO_2] [char](20) NULL,
	[EP_TO_3] [char](20) NULL,
	[EP_TO_4] [char](20) NULL,
	[TC_RPM_1] [char](20) NULL,
	[TC_RPM_2] [char](20) NULL,
	[TC_RPM_3] [char](20) NULL,
	[TC_RPM_4] [char](20) NULL,
	[AU_BL_ONOF] [char](20) NULL,
	[AU_VI_MM] [char](20) NULL,
	[SC_FLT_1] [char](20) NULL,
	[SC_FLT_2] [char](20) NULL,
	[SC_FLT_3] [char](20) NULL,
	[SC_FLT_4] [char](20) NULL,
	[SC_COL_1] [char](20) NULL,
	[SC_COL_2] [char](20) NULL,
	[SC_COL_3] [char](20) NULL,
	[SC_COL_4] [char](20) NULL,
	[SC_REC_BAR] [char](20) NULL,
	[SC_REC_MM] [char](20) NULL,
	[SC_AIR_TEM] [char](20) NULL,
	[SCT_IB_1] [char](20) NULL,
	[SCT_IB_2] [char](20) NULL,
	[SCT_IB_3] [char](20) NULL,
	[SCT_IB_4] [char](20) NULL,
	[SCT_BC_1] [char](20) NULL,
	[SCT_BC_2] [char](20) NULL,
	[SCT_BC_3] [char](20) NULL,
	[SCT_BC_4] [char](20) NULL,
	[SCT_AC_1] [char](20) NULL,
	[SCT_AC_2] [char](20) NULL,
	[SCT_AC_3] [char](20) NULL,
	[SCT_AC_4] [char](20) NULL,
	[PRE_SYSOIL] [char](20) NULL,
	[PRE_COLOIL] [char](20) NULL,
	[PRE_CAMOIL] [char](20) NULL,
	[PRE_TUROIL] [char](20) NULL,
	[TEM_INENG] [char](20) NULL,
	[TEM_INCAM] [char](20) NULL,
	[TEM_OUTCAM] [char](20) NULL,
	[PRE_THUSEG] [char](20) NULL,
	[TC_IN_BL_1] [char](20) NULL,
	[TC_IN_BL_2] [char](20) NULL,
	[TC_IN_BL_3] [char](20) NULL,
	[TC_IN_BL_4] [char](20) NULL,
	[TC_OU_BL_1] [char](20) NULL,
	[TC_OU_BL_2] [char](20) NULL,
	[TC_OU_BL_3] [char](20) NULL,
	[TC_OU_BL_4] [char](20) NULL,
	[FO_PRE_BF] [char](20) NULL,
	[FO_PRE_AF] [char](20) NULL,
	[TEM_BP] [char](20) NULL,
	[REM] [char](200) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_ME_PERFORM_INSP] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ME_CYLINDER_INSP]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ME_CYLINDER_INSP](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[TYPECODE] [char](8) NULL,
	[ENG_NO] [char](10) NULL,
	[TEST_NO] [char](10) NULL,
	[OBS_NO] [char](10) NULL,
	[ROW_ID] [numeric](2, 0) NULL,
	[CYL_1] [char](20) NULL,
	[CYL_2] [char](20) NULL,
	[CYL_3] [char](20) NULL,
	[CYL_4] [char](20) NULL,
	[CYL_5] [char](20) NULL,
	[CYL_6] [char](20) NULL,
	[CYL_7] [char](20) NULL,
	[CYL_8] [char](20) NULL,
	[CYL_9] [char](20) NULL,
	[CYL_10] [char](20) NULL,
	[CYL_11] [char](20) NULL,
	[CYL_12] [char](20) NULL,
	[CYL_13] [char](20) NULL,
	[CYL_14] [char](20) NULL,
	[CYL_15] [char](20) NULL,
	[CYL_16] [char](20) NULL,
	[CYL_17] [char](20) NULL,
	[CYL_18] [char](20) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_ME_CYLINDER_INSP] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MANUF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MANUF](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[ADDRESS] [char](45) NULL,
	[ADDRESS2] [char](30) NULL,
	[ADDRESS3] [char](35) NULL,
	[CITY] [char](25) NULL,
	[COUNTRY] [char](25) NULL,
	[PHONE] [char](20) NULL,
	[TELEX] [char](15) NULL,
	[FAX] [char](30) NULL,
	[MANUFCODE] [char](10) NULL,
	[EMAIL] [char](50) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MANUF] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINTYPE]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINTYPE](
	[MTCODE] [int] IDENTITY(1,1) NOT NULL,
	[MAINTYPE] [char](45) NULL,
	[L_DEFA] [bit] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MAINTYPE_1] PRIMARY KEY CLUSTERED 
(
	[MTCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINTPIC]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINTPIC](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[MNTDATE] [datetime] NULL,
	[PICPATH] [char](254) NULL,
	[TOOLTEXT] [char](100) NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MAINTPIC] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINTEN]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINTEN](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MAINCODE] [char](10) NULL,
	[PMSCODE] [char](10) NULL,
	[WORK] [varchar](max) NULL,
	[DATES] [datetime] NULL,
	[TY] [char](1) NULL,
	[UNSCHDL] [bit] NULL,
	[PLANNED] [varchar](max) NULL,
	[REASON] [varchar](max) NULL,
	[HRSTAKEN] [numeric](6, 0) NULL,
	[OHAULAT] [numeric](7, 0) NULL,
	[HRSNET] [numeric](7, 0) NULL,
	[CRIT] [bit] NULL,
	[ADDBY] [char](80) NULL,
	[EDITED] [bit] NULL,
	[TOTHRS] [numeric](8, 0) NULL,
	[EDITDT] [datetime] NULL,
	[STFNAME] [char](60) NULL,
	[ABSESTOS] [bit] NULL,
	[ABSGVNBY] [char](60) NULL,
	[ABSDTL] [varchar](max) NULL,
	[HOTWORK] [bit] NULL,
	[HOTGVNBY] [char](60) NULL,
	[HOTDETL] [varchar](max) NULL,
	[RISK] [bit] NULL,
	[APPROVALDT] [datetime] NULL,
	[NKKCODE] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
	[NONSCH] [bit] NULL,
 CONSTRAINT [PK_MAINTEN] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINSUB]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINSUB](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[CONNS] [char](8) NULL,
	[CATEGORY] [char](1) NULL,
	[MAIN] [char](60) NULL,
	[SUBMAIN] [char](30) NULL,
	[PARTNAME] [char](55) NULL,
	[TYPE] [char](30) NULL,
	[SERIAL] [char](40) NULL,
	[HP] [numeric](5, 0) NULL,
	[CAPACITY] [char](17) NULL,
	[YEARB] [numeric](4, 0) NULL,
	[AMPS] [numeric](5, 0) NULL,
	[KVA] [numeric](7, 1) NULL,
	[RPM] [numeric](5, 0) NULL,
	[VOLTS] [numeric](5, 0) NULL,
	[HZ] [numeric](5, 0) NULL,
	[HEAD] [char](8) NULL,
	[SUCTHEAD] [char](8) NULL,
	[DISCHPRESS] [char](8) NULL,
	[CUFTPERMIN] [char](8) NULL,
	[SPECIFIC] [varchar](max) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[MODEL] [char](50) NULL,
	[EQUIPDESC] [char](50) NULL,
	[RATING] [char](20) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MAINSUB] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINMEG]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINMEG](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[MEGGERCODE] [char](10) NULL,
	[MEGGERITEM] [char](60) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[KWRATING] [char](10) NULL,
	[WPROOF] [bit] NULL,
	[BEARINGNUM] [char](20) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MAINMEG] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINMANUF]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINMANUF](
	[PK] [int] IDENTITY(1,1) NOT NULL,
	[CONNS] [char](8) NULL,
	[MANUFCODE] [char](10) NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MAINMANUF] PRIMARY KEY CLUSTERED 
(
	[PK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAINITEM]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MAINITEM](
	[MAINCODE] [int] IDENTITY(1,1) NOT NULL,
	[MAINITEM] [char](40) NULL,
	[SURVTYPE] [char](1) NULL,
	[M_P] [char](1) NULL,
	[TOTHRS] [numeric](7, 0) NULL,
	[ME] [bit] NULL,
	[ORGDIA] [numeric](6, 2) NULL,
	[AE] [bit] NULL,
	[NUM] [numeric](2, 0) NULL,
	[THU_DATE] [datetime] NULL,
	[SEPA] [bit] NULL,
	[ACOMP] [bit] NULL,
	[AL] [bit] NULL,
	[PMPOHL] [bit] NULL,
	[PMPRTN] [bit] NULL,
	[MOTOHL] [bit] NULL,
	[MOTRTN] [bit] NULL,
	[EDITED] [bit] NULL,
	[L_MGROUP] [bit] NULL,
	[MTCODE] [int] NULL,
	[EDITDT] [datetime] NULL,
	[MES] [bit] NULL,
	[GRPMCODE] [int] NULL,
	[OFFUPDT] [bit] NULL,
	[SLF] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_MAINITEM] PRIMARY KEY CLUSTERED 
(
	[MAINCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SURVPMS]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SURVPMS](
	[SMAINCODE] [int] NULL,
	[SSUBCODE] [int] IDENTITY(1,1) NOT NULL,
	[PMSCODE] [int] NULL,
	[MAINCODE] [int] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[SURVLINK] [bit] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_SURVPMS] PRIMARY KEY CLUSTERED 
(
	[SSUBCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SURVYEAR]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SURVYEAR](
	[SYEARCODE] [int] IDENTITY(1,1) NOT NULL,
	[YEAR] [numeric](4, 0) NULL,
	[SSUBCODE] [int] NULL,
	[SDATE] [datetime] NULL,
	[NDATE] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_SURVYEAR] PRIMARY KEY CLUSTERED 
(
	[SYEARCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SURVSUB]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SURVSUB](
	[SMAINCODE] [int] NULL,
	[SSUBCODE] [int] NULL,
	[SSUBNAME] [char](100) NULL,
	[SSCODE] [int] IDENTITY(1,1) NOT NULL,
	[SCHED] [numeric](4, 0) NULL,
	[EDITED] [bit] NULL,
	[CHFSURV] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[PRD] [numeric](5, 0) NULL,
	[LASTDONE] [datetime] NULL,
	[COCCOND] [numeric](1, 0) NULL,
	[COCMON] [numeric](2, 0) NULL,
	[COCREM] [varchar](max) NULL,
	[COCYEAR] [numeric](2, 0) NULL,
	[COCDAYS] [numeric](2, 0) NULL,
	[SURVTYPE] [numeric](1, 0) NULL,
	[NKKMON] [bit] NULL,
	[SSORD] [numeric](7, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_SURVSUB] PRIMARY KEY CLUSTERED 
(
	[SSCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SURVJOB]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SURVJOB](
	[SJOBCODE] [int] IDENTITY(1,1) NOT NULL,
	[EDITDT] [datetime] NULL,
	[EDITED] [bit] NULL,
	[SSUBCODE] [int] NULL,
	[SSHED] [numeric](4, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_SURVJOB] PRIMARY KEY CLUSTERED 
(
	[SJOBCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SURVDONE]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SURVDONE](
	[SDONECODE] [int] IDENTITY(1,1) NOT NULL,
	[SMAINCODE] [int] NULL,
	[SSUBCODE] [int] NULL,
	[MAINCODE] [int] NULL,
	[PMSCODE] [int] NULL,
	[DATES] [datetime] NULL,
	[LASTDONE] [datetime] NULL,
	[NEXTDUE] [datetime] NULL,
	[PORT] [char](30) NULL,
	[REMARK] [varchar](max) NULL,
	[WORKDONE] [varchar](max) NULL,
	[PERIOD] [numeric](10, 0) NULL,
	[LDUE] [datetime] NULL,
	[EDITED] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[COCCOND] [numeric](1, 0) NULL,
	[COCMON] [numeric](2, 0) NULL,
	[COCYEAR] [numeric](2, 0) NULL,
	[COCDAYS] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_SURVDONE] PRIMARY KEY CLUSTERED 
(
	[SDONECODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMSITEM]    Script Date: 03/07/2015 19:59:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PMSITEM](
	[MAINCODE] [int] NULL,
	[PMSCODE] [int] IDENTITY(1000,1) NOT NULL,
	[PMSITEM] [char](45) NULL,
	[HEADR] [char](60) NULL,
	[EQCODE] [char](10) NULL,
	[PERIOD] [char](1) NULL,
	[INTERVAL] [numeric](6, 0) NULL,
	[SCHED] [numeric](4, 0) NULL,
	[OHAULAT] [numeric](7, 0) NULL,
	[HRSNET] [numeric](7, 0) NULL,
	[M_E_D] [char](1) NULL,
	[CRIT] [bit] NULL,
	[DATES] [datetime] NULL,
	[L_DCARB] [bit] NULL,
	[TYPECODE] [int] NULL,
	[NUM] [numeric](2, 0) NULL,
	[STPOINT] [numeric](7, 2) NULL,
	[STPOINT1] [numeric](7, 2) NULL,
	[UNITS] [char](10) NULL,
	[E_D_S] [char](1) NULL,
	[EDITED] [bit] NULL,
	[USERS] [char](35) NULL,
	[REASON] [char](254) NULL,
	[PTOTHRS] [numeric](7, 0) NULL,
	[L_PGROUP] [bit] NULL,
	[L_PSTPND] [bit] NULL,
	[DTPSTPND] [datetime] NULL,
	[NPSTPND] [numeric](8, 0) NULL,
	[UPSTPND] [char](8) NULL,
	[EO_ECO] [bit] NULL,
	[EDITDT] [datetime] NULL,
	[RESPONSE] [char](5) NULL,
	[COMMENT] [char](254) NULL,
	[WARNPRD] [numeric](6, 0) NULL,
	[MANUFCODE] [char](10) NULL,
	[TYPE] [char](30) NULL,
	[SERIAL] [char](20) NULL,
	[DECOMM] [bit] NULL,
	[POSTPNDBY] [char](100) NULL,
	[STPOINT2] [numeric](7, 2) NULL,
	[STPOINT3] [numeric](7, 2) NULL,
	[STPOINT4] [numeric](7, 2) NULL,
	[SETRANGE] [char](20) NULL,
	[OFFUPDT] [bit] NULL,
	[NKKCODE] [numeric](2, 0) NULL,
	[BKDT] [datetime] NULL,
 CONSTRAINT [PK_PMSITEM] PRIMARY KEY CLUSTERED 
(
	[PMSCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_MAINITEM_GRPMAIN]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[MAINITEM]  WITH CHECK ADD  CONSTRAINT [FK_MAINITEM_GRPMAIN] FOREIGN KEY([GRPMCODE])
REFERENCES [dbo].[GRPMAIN] ([GRPMCODE])
GO
ALTER TABLE [dbo].[MAINITEM] CHECK CONSTRAINT [FK_MAINITEM_GRPMAIN]
GO
/****** Object:  ForeignKey [FK_MAINITEM_MAINTYPE]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[MAINITEM]  WITH CHECK ADD  CONSTRAINT [FK_MAINITEM_MAINTYPE] FOREIGN KEY([MTCODE])
REFERENCES [dbo].[MAINTYPE] ([MTCODE])
GO
ALTER TABLE [dbo].[MAINITEM] CHECK CONSTRAINT [FK_MAINITEM_MAINTYPE]
GO
/****** Object:  ForeignKey [FK_PMSITEM_MAINITEM]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[PMSITEM]  WITH CHECK ADD  CONSTRAINT [FK_PMSITEM_MAINITEM] FOREIGN KEY([MAINCODE])
REFERENCES [dbo].[MAINITEM] ([MAINCODE])
GO
ALTER TABLE [dbo].[PMSITEM] CHECK CONSTRAINT [FK_PMSITEM_MAINITEM]
GO
/****** Object:  ForeignKey [FK_PMSITEM_PMSTYPE]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[PMSITEM]  WITH CHECK ADD  CONSTRAINT [FK_PMSITEM_PMSTYPE] FOREIGN KEY([TYPECODE])
REFERENCES [dbo].[PMSTYPE] ([TYPECODE])
GO
ALTER TABLE [dbo].[PMSITEM] CHECK CONSTRAINT [FK_PMSITEM_PMSTYPE]
GO
/****** Object:  ForeignKey [FK_SURVDONE_SURVPMS]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[SURVDONE]  WITH CHECK ADD  CONSTRAINT [FK_SURVDONE_SURVPMS] FOREIGN KEY([SSUBCODE])
REFERENCES [dbo].[SURVPMS] ([SSUBCODE])
GO
ALTER TABLE [dbo].[SURVDONE] CHECK CONSTRAINT [FK_SURVDONE_SURVPMS]
GO
/****** Object:  ForeignKey [FK_SURVJOB_SURVPMS]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[SURVJOB]  WITH CHECK ADD  CONSTRAINT [FK_SURVJOB_SURVPMS] FOREIGN KEY([SSUBCODE])
REFERENCES [dbo].[SURVPMS] ([SSUBCODE])
GO
ALTER TABLE [dbo].[SURVJOB] CHECK CONSTRAINT [FK_SURVJOB_SURVPMS]
GO
/****** Object:  ForeignKey [FK_SURVPMS_SURVMAIN]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[SURVPMS]  WITH CHECK ADD  CONSTRAINT [FK_SURVPMS_SURVMAIN] FOREIGN KEY([SMAINCODE])
REFERENCES [dbo].[SURVMAIN] ([SMAINCODE])
GO
ALTER TABLE [dbo].[SURVPMS] CHECK CONSTRAINT [FK_SURVPMS_SURVMAIN]
GO
/****** Object:  ForeignKey [FK_SURVSUB_SURVPMS]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[SURVSUB]  WITH CHECK ADD  CONSTRAINT [FK_SURVSUB_SURVPMS] FOREIGN KEY([SSUBCODE])
REFERENCES [dbo].[SURVPMS] ([SSUBCODE])
GO
ALTER TABLE [dbo].[SURVSUB] CHECK CONSTRAINT [FK_SURVSUB_SURVPMS]
GO
/****** Object:  ForeignKey [FK_SURVYEAR_SURVPMS]    Script Date: 03/07/2015 19:59:23 ******/
ALTER TABLE [dbo].[SURVYEAR]  WITH CHECK ADD  CONSTRAINT [FK_SURVYEAR_SURVPMS] FOREIGN KEY([SSUBCODE])
REFERENCES [dbo].[SURVPMS] ([SSUBCODE])
GO
ALTER TABLE [dbo].[SURVYEAR] CHECK CONSTRAINT [FK_SURVYEAR_SURVPMS]
GO
