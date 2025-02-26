USE [ASM_MASTER_RPT_SDE]
GO

-- ASM_ZONING
/****** Object:  Index [S11_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[ASM_ZONING]') AND name = N'S11_idx')
DROP INDEX [S11_idx] ON [GIS].[ASM_ZONING]
GO

/****** Object:  Index [S11_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S11_idx] ON [GIS].[ASM_ZONING] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- DSC_ZINGERS
/****** Object:  Index [S9_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[DSC_ZINGERS]') AND name = N'S9_idx')
DROP INDEX [S9_idx] ON [GIS].[DSC_ZINGERS]
GO

/****** Object:  Index [S9_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S9_idx] ON [GIS].[DSC_ZINGERS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- DSCS
/****** Object:  Index [S8_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[DSCS]') AND name = N'S8_idx')
DROP INDEX [S8_idx] ON [GIS].[DSCS]
GO

/****** Object:  Index [S8_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S8_idx] ON [GIS].[DSCS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- LINKS
/****** Object:  Index [S7_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[LINKS]') AND name = N'S7_idx')
DROP INDEX [S7_idx] ON [GIS].[LINKS]
GO

/****** Object:  Index [S7_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S7_idx] ON [GIS].[LINKS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- NODES
/****** Object:  Index [S6_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[NODES]') AND name = N'S6_idx')
DROP INDEX [S6_idx] ON [GIS].[NODES]
GO

/****** Object:  Index [S6_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S6_idx] ON [GIS].[NODES] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- PARKING_TARGETS
/****** Object:  Index [S5_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[PARKING_TARGETS]') AND name = N'S5_idx')
DROP INDEX [S5_idx] ON [GIS].[PARKING_TARGETS]
GO

/****** Object:  Index [S5_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S5_idx] ON [GIS].[PARKING_TARGETS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- ROOF_TARGETS
/****** Object:  Index [S4_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[ROOF_TARGETS]') AND name = N'S4_idx')
DROP INDEX [S4_idx] ON [GIS].[ROOF_TARGETS]
GO

/****** Object:  Index [S4_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S4_idx] ON [GIS].[ROOF_TARGETS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- SSC_ZINGERS
/****** Object:  Index [S10_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[SSC_ZINGERS]') AND name = N'S10_idx')
DROP INDEX [S10_idx] ON [GIS].[SSC_ZINGERS]
GO

/****** Object:  Index [S10_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S10_idx] ON [GIS].[SSC_ZINGERS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- SSCS
/****** Object:  Index [S3_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[SSCS]') AND name = N'S3_idx')
DROP INDEX [S3_idx] ON [GIS].[SSCS]
GO

/****** Object:  Index [S3_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S3_idx] ON [GIS].[SSCS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

-- STREET_TARGETS
/****** Object:  Index [S2_idx]    Script Date: 10/10/2012 06:44:54 ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[GIS].[STREET_TARGETS]') AND name = N'S2_idx')
DROP INDEX [S2_idx] ON [GIS].[STREET_TARGETS]
GO

/****** Object:  Index [S2_idx]    Script Date: 10/10/2012 06:44:54 ******/
CREATE SPATIAL INDEX [S2_idx] ON [GIS].[STREET_TARGETS] 
(
	[SHAPE]
)USING  GEOMETRY_GRID 
WITH (
BOUNDING_BOX =(7593000, 626000, 7713000, 746000), GRIDS =(LEVEL_1 = HIGH,LEVEL_2 = HIGH,LEVEL_3 = HIGH,LEVEL_4 = HIGH), 
CELLS_PER_OBJECT = 16, PAD_INDEX  = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
