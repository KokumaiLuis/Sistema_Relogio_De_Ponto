# Digital Clocking System
This is a digital clocking system for Windows. All user credentials and hour informations are encrypted and secure saved in a SQL Server Database.
See [Digital Clocking Video](https://encurtador.com.br/cdrJN)

## Application Images

### Login Screen
<img align="left" height="300px" src="https://user-images.githubusercontent.com/85628972/176007234-37ffa91d-a239-476f-aba6-e9113f835c88.png">


### Register Screen
<img align="center" height="250px" src="https://user-images.githubusercontent.com/85628972/176007507-a32e5e52-bfb2-4de7-bcba-e45ee7f4c2bd.png">

### Digital Clocking Screen

<img height="450px" src="https://user-images.githubusercontent.com/85628972/176007579-cb6b31f7-380d-475d-9b8b-29e523ecebcb.png">

</br>

## 👨‍💻Used Technologies

- VB.NET
- MVC Architecture
- T-SQL
- Microsoft SQL Server

</br>

## :heavy_check_mark: Project Status
:white_check_mark: Project Finished! :white_check_mark:

</br>

## ☕ Using Digital Clocking System
To use the Digital Clocking System you'll need the following prerequisites:
```
1. An Windows OS
2. An active instance/client of Microsoft SQL Server installed on the host machinne
3. Microsoft SQL Management Studio installed
```

Notes: 
* If you do not have an active instance of Microsoft SQL Server installed, follow [this.](https://docs.microsoft.com/pt-br/sql/database-engine/install-windows/install-sql-server?view=sql-server-ver16)
* If you do not have Microsoft SQL Management Studio installed, follow [this.](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

Follow the next steps:
1. Clone the repo
2. Open SSMS and conect to an active SQL Server
3. Open a new query and run the next statements:
```
/****** Object:  Table [dbo].[TB_LOGIN] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_LOGIN](
	[ID_LOG] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO_LOG] [nvarchar](20) NOT NULL,
	[SENHA_LOG] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TB_LOGIN] PRIMARY KEY CLUSTERED 
(
	[ID_LOG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```
```
/****** Object:  Table [dbo].[TB_HORAS] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_HORAS](
	[ID_HORAS] [int] IDENTITY(1,1) NOT NULL,
	[DATA] [datetime] NOT NULL,
	[ENTRADA] [nvarchar](20) NOT NULL,
	[INICIO_ALMOCO] [nvarchar](20) NULL,
	[FIM_ALMOCO] [nvarchar](20) NULL,
	[SAIDA] [nvarchar](20) NULL,
	[MODO] [nvarchar](20) NOT NULL,
	[ID_LOG] [int] NOT NULL,
 CONSTRAINT [PK_TB_HORAS] PRIMARY KEY CLUSTERED 
(
	[ID_HORAS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```
4. Inside the repo, find this path:
```
Sistema_Relogio_De_Ponto\Relogio_Ponto\Relogio_Ponto\bin\Debug\net5.0-windows
```
5. Run the .exe file
</br>

## 🛠️ Developed With
```
Microsoft Visual Studio Community 2022
Versão 17.2.5
VisualStudio.17.Release/17.2.5+32616.157
Microsoft .NET Framework
Versão 4.8.04161
```

## 📝 License
This project is under license. See the file [LICENÇA](LICENSE) for more details.

[⬆ Back to the top](https://github.com/KokumaiLuis/Sistema_Relogio_De_Ponto)<br>
