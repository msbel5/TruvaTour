/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4206)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2012
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [TruvaTour]
GO
/****** Object:  Table [dbo].[CityTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityTable](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CityTable] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommentVoteTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommentVoteTable](
	[TourID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Vote] [int] NOT NULL,
	[Comment] [nvarchar](500) NULL,
 CONSTRAINT [PK_CommentVoteTable_1] PRIMARY KEY CLUSTERED 
(
	[TourID] ASC,
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTable](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[CustomerSurname] [nvarchar](50) NOT NULL,
	[CustomerUserName] [nvarchar](10) NOT NULL,
	[CustomerPassword] [nvarchar](4) NOT NULL,
	[CustomerTCNO] [nvarchar](11) NOT NULL,
	[CustomerTelNO] [nvarchar](14) NOT NULL,
 CONSTRAINT [PK_CustomerTable] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeRoleTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeRoleTable](
	[EmployeeRoleID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeRoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeRoleTable] PRIMARY KEY CLUSTERED 
(
	[EmployeeRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTable](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NOT NULL,
	[EmployeeSurname] [nvarchar](50) NOT NULL,
	[EmployeRoleID] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeTable] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PositionTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PositionTable](
	[PositionId] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PositionTable] PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesTable](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[TourID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_SalesTable] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TourCityTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourCityTable](
	[TourID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[PositionID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TourEmployeeTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourEmployeeTable](
	[TourID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tours]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tours](
	[TourID] [int] IDENTITY(1,1) NOT NULL,
	[TourName] [nvarchar](50) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[TypeID] [int] NOT NULL,
	[Price] [decimal](5, 2) NOT NULL,
	[Quota] [int] NOT NULL,
	[TourDetails] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tours] PRIMARY KEY CLUSTERED 
(
	[TourID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TourType]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourType](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TourType] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TourVehicleTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourVehicleTable](
	[TourID] [int] NOT NULL,
	[VehicleID] [int] NOT NULL,
 CONSTRAINT [PK_TourVehicleTable] PRIMARY KEY CLUSTERED 
(
	[TourID] ASC,
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleTable]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleTable](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleLicensePlate] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_VehicleTable] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CityTable] ON 

INSERT [dbo].[CityTable] ([CityID], [CityName]) VALUES (1, N'İstanbul')
INSERT [dbo].[CityTable] ([CityID], [CityName]) VALUES (2, N'Çanakkale')
INSERT [dbo].[CityTable] ([CityID], [CityName]) VALUES (3, N'İzmir')
SET IDENTITY_INSERT [dbo].[CityTable] OFF
INSERT [dbo].[CommentVoteTable] ([TourID], [CustomerID], [Vote], [Comment]) VALUES (1, 1, 3, N'bence de çok güzeldi')
INSERT [dbo].[CommentVoteTable] ([TourID], [CustomerID], [Vote], [Comment]) VALUES (1, 2, 5, N'Çok Güzeldi')
INSERT [dbo].[CommentVoteTable] ([TourID], [CustomerID], [Vote], [Comment]) VALUES (1, 3, 1, N'Çok Kötüydü')
SET IDENTITY_INSERT [dbo].[CustomerTable] ON 

INSERT [dbo].[CustomerTable] ([CustomerID], [CustomerName], [CustomerSurname], [CustomerUserName], [CustomerPassword], [CustomerTCNO], [CustomerTelNO]) VALUES (1, N'Müsteri', N'Mehmet', N'musteri', N'1234', N'12345678901', N'+905555555555')
INSERT [dbo].[CustomerTable] ([CustomerID], [CustomerName], [CustomerSurname], [CustomerUserName], [CustomerPassword], [CustomerTCNO], [CustomerTelNO]) VALUES (2, N'Birinci', N'Yorumcu', N'biryorum', N'1234', N'12345678901', N'+905555555555')
INSERT [dbo].[CustomerTable] ([CustomerID], [CustomerName], [CustomerSurname], [CustomerUserName], [CustomerPassword], [CustomerTCNO], [CustomerTelNO]) VALUES (3, N'İkinci', N'Yorumcu', N'ikiyorum', N'1234', N'12345678901', N'+905555555555')
SET IDENTITY_INSERT [dbo].[CustomerTable] OFF
SET IDENTITY_INSERT [dbo].[EmployeeRoleTable] ON 

INSERT [dbo].[EmployeeRoleTable] ([EmployeeRoleID], [EmployeeRoleName]) VALUES (1, N'Driver')
INSERT [dbo].[EmployeeRoleTable] ([EmployeeRoleID], [EmployeeRoleName]) VALUES (2, N'Host')
SET IDENTITY_INSERT [dbo].[EmployeeRoleTable] OFF
SET IDENTITY_INSERT [dbo].[EmployeeTable] ON 

INSERT [dbo].[EmployeeTable] ([EmployeeID], [EmployeeName], [EmployeeSurname], [EmployeRoleID]) VALUES (1, N'şöför', N'mehmet', 1)
INSERT [dbo].[EmployeeTable] ([EmployeeID], [EmployeeName], [EmployeeSurname], [EmployeRoleID]) VALUES (2, N'Muavin', N'ceren', 2)
SET IDENTITY_INSERT [dbo].[EmployeeTable] OFF
SET IDENTITY_INSERT [dbo].[PositionTable] ON 

INSERT [dbo].[PositionTable] ([PositionId], [PositionName]) VALUES (1, N'Başlangıç')
INSERT [dbo].[PositionTable] ([PositionId], [PositionName]) VALUES (2, N'Mola')
INSERT [dbo].[PositionTable] ([PositionId], [PositionName]) VALUES (3, N'Bitiş')
SET IDENTITY_INSERT [dbo].[PositionTable] OFF
SET IDENTITY_INSERT [dbo].[SalesTable] ON 

INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (1, 1, 1, 5)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (4, 1, 1, 5)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (11, 1, 1, 20)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (12, 1, 1, 10)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (13, 1, 1, 10)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (14, 1, 1, 10)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (16, 1, 1, 10)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (18, 1, 1, 10)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (20, 1, 1, 10)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (21, 1, 2, 5)
INSERT [dbo].[SalesTable] ([SaleID], [TourID], [CustomerID], [Quantity]) VALUES (22, 1, 3, 5)
SET IDENTITY_INSERT [dbo].[SalesTable] OFF
INSERT [dbo].[TourCityTable] ([TourID], [CityID], [PositionID]) VALUES (1, 1, 1)
INSERT [dbo].[TourCityTable] ([TourID], [CityID], [PositionID]) VALUES (1, 2, 2)
INSERT [dbo].[TourCityTable] ([TourID], [CityID], [PositionID]) VALUES (1, 3, 3)
INSERT [dbo].[TourEmployeeTable] ([TourID], [EmployeeID]) VALUES (1, 1)
INSERT [dbo].[TourEmployeeTable] ([TourID], [EmployeeID]) VALUES (1, 2)
SET IDENTITY_INSERT [dbo].[Tours] ON 

INSERT [dbo].[Tours] ([TourID], [TourName], [StartDate], [EndDate], [TypeID], [Price], [Quota], [TourDetails]) VALUES (1, N'İzmir Dağları', CAST(N'2017-07-28T15:00:00.000' AS DateTime), CAST(N'2017-07-31T15:00:00.000' AS DateTime), 1, CAST(350.00 AS Decimal(5, 2)), 0, N'İzmirin Dağlarındaki çiçekleri görmeye gidiyoruz')
INSERT [dbo].[Tours] ([TourID], [TourName], [StartDate], [EndDate], [TypeID], [Price], [Quota], [TourDetails]) VALUES (4, N'İstanbulun Tepeleri', CAST(N'2017-08-01T15:00:00.000' AS DateTime), CAST(N'2017-08-04T15:00:00.000' AS DateTime), 1, CAST(350.00 AS Decimal(5, 2)), 30, N'İstanbulun tepelerini gezmeye gidiyoruz.')
SET IDENTITY_INSERT [dbo].[Tours] OFF
SET IDENTITY_INSERT [dbo].[TourType] ON 

INSERT [dbo].[TourType] ([TypeID], [TypeName]) VALUES (1, N'Yurtiçi Kültür')
INSERT [dbo].[TourType] ([TypeID], [TypeName]) VALUES (2, N'YurtDışı Gezi')
SET IDENTITY_INSERT [dbo].[TourType] OFF
INSERT [dbo].[TourVehicleTable] ([TourID], [VehicleID]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[VehicleTable] ON 

INSERT [dbo].[VehicleTable] ([VehicleID], [VehicleLicensePlate]) VALUES (1, N'29aa29')
INSERT [dbo].[VehicleTable] ([VehicleID], [VehicleLicensePlate]) VALUES (2, N'30bb30')
SET IDENTITY_INSERT [dbo].[VehicleTable] OFF
ALTER TABLE [dbo].[CommentVoteTable]  WITH CHECK ADD  CONSTRAINT [FK_CommentVoteTable_CustomerTable] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[CustomerTable] ([CustomerID])
GO
ALTER TABLE [dbo].[CommentVoteTable] CHECK CONSTRAINT [FK_CommentVoteTable_CustomerTable]
GO
ALTER TABLE [dbo].[CommentVoteTable]  WITH CHECK ADD  CONSTRAINT [FK_CommentVoteTable_Tours] FOREIGN KEY([TourID])
REFERENCES [dbo].[Tours] ([TourID])
GO
ALTER TABLE [dbo].[CommentVoteTable] CHECK CONSTRAINT [FK_CommentVoteTable_Tours]
GO
ALTER TABLE [dbo].[EmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeTable_EmployeeRoleTable] FOREIGN KEY([EmployeRoleID])
REFERENCES [dbo].[EmployeeRoleTable] ([EmployeeRoleID])
GO
ALTER TABLE [dbo].[EmployeeTable] CHECK CONSTRAINT [FK_EmployeeTable_EmployeeRoleTable]
GO
ALTER TABLE [dbo].[SalesTable]  WITH CHECK ADD  CONSTRAINT [FK_SalesTable_CustomerTable] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[CustomerTable] ([CustomerID])
GO
ALTER TABLE [dbo].[SalesTable] CHECK CONSTRAINT [FK_SalesTable_CustomerTable]
GO
ALTER TABLE [dbo].[SalesTable]  WITH CHECK ADD  CONSTRAINT [FK_SalesTable_Tours] FOREIGN KEY([TourID])
REFERENCES [dbo].[Tours] ([TourID])
GO
ALTER TABLE [dbo].[SalesTable] CHECK CONSTRAINT [FK_SalesTable_Tours]
GO
ALTER TABLE [dbo].[TourCityTable]  WITH CHECK ADD  CONSTRAINT [FK_TourCityTable_CityTable] FOREIGN KEY([CityID])
REFERENCES [dbo].[CityTable] ([CityID])
GO
ALTER TABLE [dbo].[TourCityTable] CHECK CONSTRAINT [FK_TourCityTable_CityTable]
GO
ALTER TABLE [dbo].[TourCityTable]  WITH CHECK ADD  CONSTRAINT [FK_TourCityTable_PositionTable] FOREIGN KEY([PositionID])
REFERENCES [dbo].[PositionTable] ([PositionId])
GO
ALTER TABLE [dbo].[TourCityTable] CHECK CONSTRAINT [FK_TourCityTable_PositionTable]
GO
ALTER TABLE [dbo].[TourCityTable]  WITH CHECK ADD  CONSTRAINT [FK_TourCityTable_Tours] FOREIGN KEY([TourID])
REFERENCES [dbo].[Tours] ([TourID])
GO
ALTER TABLE [dbo].[TourCityTable] CHECK CONSTRAINT [FK_TourCityTable_Tours]
GO
ALTER TABLE [dbo].[TourEmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK_TourEmployeeTable_EmployeeTable] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EmployeeTable] ([EmployeeID])
GO
ALTER TABLE [dbo].[TourEmployeeTable] CHECK CONSTRAINT [FK_TourEmployeeTable_EmployeeTable]
GO
ALTER TABLE [dbo].[TourEmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK_TourEmployeeTable_Tours] FOREIGN KEY([TourID])
REFERENCES [dbo].[Tours] ([TourID])
GO
ALTER TABLE [dbo].[TourEmployeeTable] CHECK CONSTRAINT [FK_TourEmployeeTable_Tours]
GO
ALTER TABLE [dbo].[Tours]  WITH CHECK ADD  CONSTRAINT [FK_Tours_TourType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[TourType] ([TypeID])
GO
ALTER TABLE [dbo].[Tours] CHECK CONSTRAINT [FK_Tours_TourType]
GO
ALTER TABLE [dbo].[TourVehicleTable]  WITH CHECK ADD  CONSTRAINT [FK_TourVehicleTable_Tours] FOREIGN KEY([TourID])
REFERENCES [dbo].[Tours] ([TourID])
GO
ALTER TABLE [dbo].[TourVehicleTable] CHECK CONSTRAINT [FK_TourVehicleTable_Tours]
GO
ALTER TABLE [dbo].[TourVehicleTable]  WITH CHECK ADD  CONSTRAINT [FK_TourVehicleTable_VehicleTable] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[VehicleTable] ([VehicleID])
GO
ALTER TABLE [dbo].[TourVehicleTable] CHECK CONSTRAINT [FK_TourVehicleTable_VehicleTable]
GO
/****** Object:  StoredProcedure [dbo].[Buy]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Buy]
(
@CustomerID int,
@TourID int,
@Quantity int
)
as
begin 
declare @quota int
set @quota = (select Tours.Quota from Tours where TourID = @TourID)
begin tran
insert into SalesTable(TourID,CustomerID,Quantity) values(@TourID,@CustomerID,@Quantity)
update Tours set Quota=Quota-@Quantity where TourID=@TourID
 if(@Quantity<=@quota)
 begin
 commit tran
 end
 else
 begin
 rollback tran
 end  
end
GO
/****** Object:  StoredProcedure [dbo].[Evaluate]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Evaluate]
(
@TourID int,
@CustomerID int,
@Vote int,
@Comment nvarchar(500)
)
as
begin
if exists(select * from CommentVoteTable where CustomerID=@CustomerID and TourID=@TourID)
begin
update CommentVoteTable set Vote=@Vote, Comment=@Comment where TourID=@TourID and CustomerID=@CustomerID 
end
else
begin
  insert into CommentVoteTable(TourID,CustomerID,Vote,Comment) values (@TourID,@CustomerID,@Vote,@Comment)
 end
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllTourData]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllTourData]

as
begin
select distinct Tours.TourID,TourName,StartDate,EndDate,(select  TourType.TypeName as Baslangic from TourType left join TourCityTable on TourCityTable.PositionId=CityTable.CityID where TypeID=1) turismi,Price,Quota,TourDetails,
(select  CityTable.CityName as Baslangic from CityTable left join TourCityTable on TourCityTable.PositionId=CityTable.CityID where PositionId=1) baslangic,
(select  CityTable.CityName as turismi from CityTable left join TourCityTable on TourCityTable.PositionId=CityTable.CityID where PositionId=3) bitis,
(select  VehicleTable.VehicleLicensePlate  from VehicleTable left join TourCityTable on TourCityTable.PositionId=CityTable.CityID  left join TourVehicleTable on TourVehicleTable.VehicleID=VehicleTable.VehicleID
where VehicleTable.VehicleID=2) Plaka from Tours 
left join TourCityTable on Tours.TourID=TourCityTable.TourID
left join PositionTable on TourCityTable.PositionID=PositionTable.PositionId
left join CityTable on TourCityTable.CityID=CityTable.CityID 

end
GO
/****** Object:  StoredProcedure [dbo].[getCustomerData]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCustomerData]
@UserName nvarchar(10),
@Password nvarchar(4)
as
begin
select * from CustomerTable where CustomerUserName=@UserName and CustomerPassword = @Password
end
GO
/****** Object:  StoredProcedure [dbo].[getTourData]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getTourData]
@tourID int
as
begin


select distinct TourCityTable.TourID,TourName,StartDate,EndDate,(select  TourType.TypeName as Baslangic from TourType left join TourCityTable on TourCityTable.PositionId=CityTable.CityID where TypeID=1) turismi,Price,Quota,TourDetails,
(select  CityTable.CityName as Baslangic from CityTable left join TourCityTable on TourCityTable.PositionId=CityTable.CityID where PositionId=1) baslangic,
(select  CityTable.CityName as turismi from CityTable left join TourCityTable on TourCityTable.PositionId=CityTable.CityID where PositionId=3) bitis,
(select  VehicleTable.VehicleLicensePlate  from VehicleTable left join TourCityTable on TourCityTable.PositionId=CityTable.CityID  left join TourVehicleTable on TourVehicleTable.VehicleID=VehicleTable.VehicleID
where VehicleTable.VehicleID=2) Plaka from Tours 
left join TourCityTable on Tours.TourID=TourCityTable.TourID
left join PositionTable on TourCityTable.PositionID=PositionTable.PositionId
left join CityTable on TourCityTable.CityID=CityTable.CityID 
where Tours.TourID=@tourID

end
GO
/****** Object:  StoredProcedure [dbo].[getTourEvaluation]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getTourEvaluation]
@tourID int,
@customerID int
as
begin
select CustomerTable.CustomerName,CustomerTable.CustomerSurname,Vote,Comment from CommentVoteTable join CustomerTable on CustomerTable.CustomerID=CommentVoteTable.CustomerID where CommentVoteTable.TourID=@tourID and CommentVoteTable.CustomerID=@customerID
end
GO
/****** Object:  StoredProcedure [dbo].[getTourEvaluations]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getTourEvaluations]
@tourID int
as
begin
select CustomerID,Vote,Comment from CommentVoteTable where TourID=@tourID
end
GO
/****** Object:  StoredProcedure [dbo].[getTourVoteAvg]    Script Date: 27.10.2017 17:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getTourVoteAvg]
@tourID int
as
begin
if exists(select * from CommentVoteTable where TourID=@tourID)
begin
select ((select SUM(Vote) from CommentVoteTable where TourID=@tourID)/(select COUNT(*) from CommentVoteTable where TourID=@tourID))
end
else
select 0 
end
GO
