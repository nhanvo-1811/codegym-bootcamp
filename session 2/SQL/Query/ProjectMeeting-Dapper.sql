CREATE TABLE [dbo].[Users](  
    [UserId][int] IDENTITY(1, 1) NOT NULL,
	[UserName][varchar](50) NULL, 
	[UserMobile][varchar](50) NULL,
	[UserEmail][varchar](50) NULL, 
	[FaceBookUrl][varchar](50) NULL,
	[LinkedInUrl][varchar](50) NULL, [TwitterUrl][varchar](50) NULL,
	[PersonalWebUrl][varchar](50) NULL, 
	[IsDeleted][bit] NULL) ON[PRIMARY]  
GO  
ALTER TABLE[dbo].[Users] ADD CONSTRAINT[DF_User_IsDeleted] DEFAULT((0)) FOR[IsDeleted]  
GO

CREATE PROCEDURE[dbo].[AddUser]  
@UserName varchar(50),  
    @UserMobile varchar(50),  
    @UserEmail varchar(50),  
    @FaceBookUrl varchar(50),  
    @LinkedInUrl varchar(50),  
    @TwitterUrl varchar(50),  
    @PersonalWebUrl varchar(50)  
AS  
BEGIN  
SET NOCOUNT ON 
INSERT INTO Users(UserName, UserMobile, UserEmail, FaceBookUrl, LinkedInUrl, TwitterUrl, PersonalWebUrl)  
values(@UserName, @UserMobile, @UserEmail, @FaceBookUrl, @LinkedInUrl, @TwitterUrl, @PersonalWebUrl)  
END  
GO   

CREATE PROCEDURE[dbo].[DeleteUser]  
@UserId int  
AS  
BEGIN  
SET NOCOUNT ON;  
update Users set IsDeleted = 1 where UserId = @UserId  
END  
 
CREATE PROCEDURE[dbo].[GetAllUsers]  
AS  
BEGIN  
SET NOCOUNT ON;  
select * from Users  
END   

CREATE PROCEDURE[dbo].[GetUserById]  
@UserId int  
AS  
BEGIN  
SET NOCOUNT ON;  
select * from Users where UserId = @UserId;  
END  
GO  