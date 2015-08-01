CREATE TABLE IF NOT EXISTS `ajt_collaborator` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `marital_status` enum('M','MLLE','MME') DEFAULT NULL,
  `address` text,
  `Nom` text,
  `Prenom` text,
  `id_user_fk` varchar(128) NOT NULL,
  `deletion_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`) 
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE IF NOT EXISTS `ajt_photo` (
  `id_photo` int(11) NOT NULL AUTO_INCREMENT,
  `id_user_fk` varchar(128) NOT NULL,
  `image` blob NOT NULL,
  PRIMARY KEY (`id_photo`) 
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE IF NOT EXISTS `aspnetroles` (
  `Id` varchar(128) NOT NULL,
  `Name` varchar(256) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. aspnetuserclaims
CREATE TABLE IF NOT EXISTS `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(128) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`) 
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. aspnetuserlogins
CREATE TABLE IF NOT EXISTS `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `UserId` varchar(128) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`,`UserId`) 
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.

-- Export de la structure de table ajtdev. aspnetuserroles
CREATE TABLE IF NOT EXISTS `aspnetuserroles` (
  `UserId` varchar(128) NOT NULL,
  `RoleId` varchar(128) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`) 
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.

-- Export de la structure de table ajtdev. aspnetusers
CREATE TABLE IF NOT EXISTS `aspnetusers` (
  `Id` varchar(128) NOT NULL,
  `Hometown` text,
  `Email` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(4) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` tinyint(4) NOT NULL,
  `TwoFactorEnabled` tinyint(4) NOT NULL,
  `LockoutEndDateUtc` datetime DEFAULT NULL,
  `LockoutEnabled` tinyint(4) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `UserName` varchar(256) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. aspnetusersext
CREATE TABLE IF NOT EXISTS `aspnetusersext` (
  `UserId` varchar(128) NOT NULL,
  `SecurityQuestion` varchar(256) DEFAULT NULL,
  `SecurityAnswer` varchar(128) DEFAULT NULL,
  `SecurityAnswerSalt` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`UserId`) 
 
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.

-- Export de la structure de table ajtdev. mysql_membership
CREATE TABLE IF NOT EXISTS `mysql_membership` (
  `PKID` varchar(36) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `ApplicationName` varchar(255) NOT NULL,
  `Email` varchar(128) DEFAULT NULL,
  `Comment` varchar(255) DEFAULT NULL,
  `Password` varchar(128) NOT NULL,
  `PasswordKey` char(32) DEFAULT NULL,
  `PasswordFormat` tinyint(4) DEFAULT NULL,
  `PasswordQuestion` varchar(255) DEFAULT NULL,
  `PasswordAnswer` varchar(255) DEFAULT NULL,
  `IsApproved` tinyint(1) DEFAULT NULL,
  `LastActivityDate` datetime DEFAULT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  `LastPasswordChangedDate` datetime DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `IsOnline` tinyint(1) DEFAULT NULL,
  `IsLockedOut` tinyint(1) DEFAULT NULL,
  `LastLockedOutDate` datetime DEFAULT NULL,
  `FailedPasswordAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAttemptWindowStart` datetime DEFAULT NULL,
  `FailedPasswordAnswerAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAnswerAttemptWindowStart` datetime DEFAULT NULL,
  PRIMARY KEY (`PKID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='2';

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. mysql_roles
CREATE TABLE IF NOT EXISTS `mysql_roles` (
  `Rolename` varchar(255) NOT NULL,
  `ApplicationName` varchar(255) NOT NULL,
  KEY `Rolename` (`Rolename`,`ApplicationName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. mysql_usersinroles
CREATE TABLE IF NOT EXISTS `mysql_usersinroles` (
  `Username` varchar(255) NOT NULL,
  `Rolename` varchar(255) NOT NULL,
  `ApplicationName` varchar(255) NOT NULL,
  KEY `Username` (`Username`,`Rolename`,`ApplicationName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_applications
CREATE TABLE IF NOT EXISTS `my_aspnet_applications` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(256) DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_membership
CREATE TABLE IF NOT EXISTS `my_aspnet_membership` (
  `userId` int(11) NOT NULL DEFAULT '0',
  `Email` varchar(128) DEFAULT NULL,
  `Comment` varchar(255) DEFAULT NULL,
  `Password` varchar(128) NOT NULL,
  `PasswordKey` char(32) DEFAULT NULL,
  `PasswordFormat` tinyint(4) DEFAULT NULL,
  `PasswordQuestion` varchar(255) DEFAULT NULL,
  `PasswordAnswer` varchar(255) DEFAULT NULL,
  `IsApproved` tinyint(1) DEFAULT NULL,
  `LastActivityDate` datetime DEFAULT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  `LastPasswordChangedDate` datetime DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `IsLockedOut` tinyint(1) DEFAULT NULL,
  `LastLockedOutDate` datetime DEFAULT NULL,
  `FailedPasswordAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAttemptWindowStart` datetime DEFAULT NULL,
  `FailedPasswordAnswerAttemptCount` int(10) unsigned DEFAULT NULL,
  `FailedPasswordAnswerAttemptWindowStart` datetime DEFAULT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='2';

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_paths
CREATE TABLE IF NOT EXISTS `my_aspnet_paths` (
  `applicationId` int(11) NOT NULL,
  `pathId` varchar(36) NOT NULL,
  `path` varchar(256) NOT NULL,
  `loweredPath` varchar(256) NOT NULL,
  PRIMARY KEY (`pathId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_personalizationallusers
CREATE TABLE IF NOT EXISTS `my_aspnet_personalizationallusers` (
  `pathId` varchar(36) NOT NULL,
  `pageSettings` blob NOT NULL,
  `lastUpdatedDate` datetime NOT NULL,
  PRIMARY KEY (`pathId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_personalizationperuser
CREATE TABLE IF NOT EXISTS `my_aspnet_personalizationperuser` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `applicationId` int(11) NOT NULL,
  `pathId` varchar(36) DEFAULT NULL,
  `userId` int(11) DEFAULT NULL,
  `pageSettings` blob NOT NULL,
  `lastUpdatedDate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_profiles
CREATE TABLE IF NOT EXISTS `my_aspnet_profiles` (
  `userId` int(11) NOT NULL,
  `valueindex` longtext,
  `stringdata` longtext,
  `binarydata` longblob,
  `lastUpdatedDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_roles
CREATE TABLE IF NOT EXISTS `my_aspnet_roles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `applicationId` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_schemaversion
CREATE TABLE IF NOT EXISTS `my_aspnet_schemaversion` (
  `version` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_sessioncleanup
CREATE TABLE IF NOT EXISTS `my_aspnet_sessioncleanup` (
  `LastRun` datetime NOT NULL,
  `IntervalMinutes` int(11) NOT NULL,
  `ApplicationId` int(11) NOT NULL,
  PRIMARY KEY (`ApplicationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_sessions
CREATE TABLE IF NOT EXISTS `my_aspnet_sessions` (
  `SessionId` varchar(191) NOT NULL,
  `ApplicationId` int(11) NOT NULL,
  `Created` datetime NOT NULL,
  `Expires` datetime NOT NULL,
  `LockDate` datetime NOT NULL,
  `LockId` int(11) NOT NULL,
  `Timeout` int(11) NOT NULL,
  `Locked` tinyint(1) NOT NULL,
  `SessionItems` longblob,
  `Flags` int(11) NOT NULL,
  PRIMARY KEY (`SessionId`,`ApplicationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_sitemap
CREATE TABLE IF NOT EXISTS `my_aspnet_sitemap` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) DEFAULT NULL,
  `Description` varchar(512) DEFAULT NULL,
  `Url` varchar(512) DEFAULT NULL,
  `Roles` varchar(1000) DEFAULT NULL,
  `ParentId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_users
CREATE TABLE IF NOT EXISTS `my_aspnet_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `applicationId` int(11) NOT NULL,
  `name` varchar(256) NOT NULL,
  `isAnonymous` tinyint(1) NOT NULL DEFAULT '1',
  `lastActivityDate` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- L'exportation de données n'était pas sélectionnée.


-- Export de la structure de table ajtdev. my_aspnet_usersinroles
CREATE TABLE IF NOT EXISTS `my_aspnet_usersinroles` (
  `userId` int(11) NOT NULL DEFAULT '0',
  `roleId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`userId`,`roleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

alter table `ajt_collaborator` add   CONSTRAINT `collaborator_user_fk` FOREIGN KEY (`id_user_fk`) REFERENCES `aspnetusers` (`Id`);
alter table `ajt_photo` add   CONSTRAINT `photo_user_fk` FOREIGN KEY (`id_user_fk`) REFERENCES `aspnetusers` (`Id`);
alter table `aspnetuserclaims` add  CONSTRAINT `FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
alter table `aspnetuserlogins` add CONSTRAINT `FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
alter table `aspnetuserroles` add  CONSTRAINT `FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
alter table `aspnetuserroles` add  CONSTRAINT `FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
alter table `aspnetusersext` add  CONSTRAINT `FK_AspNetUserExt_AspNetUsers` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

 INSERT INTO `my_aspnet_schemaversion` (`version`) VALUES (10);
 INSERT INTO `aspnetroles` (`Id`, `Name`) VALUES
	('1', 'admin'),
	('2', 'employe'),
	('3', 'superadmin'); 
    
    
    INSERT INTO `aspnetusers` (`Id`, `Hometown`, `Email`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEndDateUtc`, `LockoutEnabled`, `AccessFailedCount`, `UserName`) VALUES
 	('c25c4016-b6ab-40a7-97b4-4ad4ec5939c7', NULL, 'super@gmail.com', 0, 'ANyPb68Woy0svReRTWBfvgjzyD4s52M9Cj3ZH1l/ldc02FPChKF2q9VMmOe3AVg84w==', '5e3cd89b-45be-4276-80ef-927c82465f13', '25567160', 0, 0, NULL, 1, 0, 'super@gmail.com');
	 
     INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUE('c25c4016-b6ab-40a7-97b4-4ad4ec5939c7', '3'); 
     
	 INSERT INTO `ajt_photo` (`id_photo`, `id_user_fk`, `image`) VALUES
	(2, 'c25c4016-b6ab-40a7-97b4-4ad4ec5939c7', _binary 0x89504E470D0A1A0A0000000D494844520000001E0000001E08060000003B30AEA2000000097048597300000B1300000B1301009A9C1800000A4F6943435050686F746F73686F70204943432070726F66696C65000078DA9D53675453E9163DF7DEF4424B8880944B6F5215082052428B801491262A2109104A8821A1D91551C1114545041BC8A088038E8E808C15512C0C8A0AD807E421A28E83A3888ACAFBE17BA36BD6BCF7E6CDFEB5D73EE7ACF39DB3CF07C0080C9648335135800CA9421E11E083C7C4C6E1E42E40810A2470001008B3642173FD230100F87E3C3C2B22C007BE000178D30B0800C04D9BC0301C87FF0FEA42995C01808401C07491384B08801400407A8E42A600404601809D98265300A0040060CB6362E300502D0060277FE6D300809DF8997B01005B94211501A09100201365884400683B00ACCF568A450058300014664BC43900D82D00304957664800B0B700C0CE100BB200080C00305188852900047B0060C8232378008499001446F2573CF12BAE10E72A00007899B23CB9243945815B082D710757572E1E28CE49172B14366102619A402EC27999193281340FE0F3CC0000A0911511E083F3FD78CE0EAECECE368EB60E5F2DEABF06FF226262E3FEE5CFAB70400000E1747ED1FE2C2FB31A803B06806DFEA225EE04685E0BA075F78B66B20F40B500A0E9DA57F370F87E3C3C45A190B9D9D9E5E4E4D84AC4425B61CA577DFE67C25FC057FD6CF97E3CFCF7F5E0BEE22481325D814704F8E0C2CCF44CA51CCF92098462DCE68F47FCB70BFFFC1DD322C44962B9582A14E35112718E449A8CF332A52289429229C525D2FF64E2DF2CFB033EDF3500B06A3E017B912DA85D6303F64B27105874C0E2F70000F2BB6FC1D4280803806883E1CF77FFEF3FFD47A02500806649927100005E44242E54CAB33FC708000044A0812AB0411BF4C1182CC0061CC105DCC10BFC6036844224C4C24210420A64801C726029AC82422886CDB01D2A602FD4401D34C051688693700E2EC255B80E3D700FFA61089EC128BC81090441C808136121DA8801628A58238E08179985F821C14804128B2420C9881451224B91354831528A542055481DF23D720239875C46BA913BC8003282FC86BC47319481B2513DD40CB543B9A8371A8446A20BD06474319A8F16A09BD072B41A3D8C36A1E7D0AB680FDA8F3E43C730C0E8180733C46C302EC6C342B1382C099363CBB122AC0CABC61AB056AC03BB89F563CFB17704128145C0093604774220611E4148584C584ED848A8201C243411DA093709038451C2272293A84BB426BA11F9C4186232318758482C23D6128F132F107B8843C437241289433227B9900249B1A454D212D246D26E5223E92CA99B34481A2393C9DA646BB20739942C202BC885E49DE4C3E433E41BE421F25B0A9D624071A4F853E22852CA6A4A19E510E534E5066598324155A39A52DDA8A15411358F5A42ADA1B652AF5187A81334759A39CD8316494BA5ADA295D31A681768F769AFE874BA11DD951E4E97D057D2CBE947E897E803F4770C0D861583C7886728199B18071867197718AF984CA619D38B19C754303731EB98E7990F996F55582AB62A7C1591CA0A954A9526951B2A2F54A9AAA6AADEAA0B55F355CB548FA95E537DAE46553353E3A909D496AB55AA9D50EB531B5367A93BA887AA67A86F543FA47E59FD890659C34CC34F43A451A0B15FE3BCC6200B6319B3782C216B0DAB86758135C426B1CDD97C762ABB98FD1DBB8B3DAAA9A13943334A3357B352F394663F07E39871F89C744E09E728A797F37E8ADE14EF29E2291BA6344CB931655C6BAA96979658AB48AB51AB47EBBD36AEEDA79DA6BD45BB59FB810E41C74A275C2747678FCE059DE753D953DDA70AA7164D3D3AF5AE2EAA6BA51BA1BB4477BF6EA7EE989EBE5E809E4C6FA7DE79BDE7FA1C7D2FFD54FD6DFAA7F5470C5806B30C2406DB0CCE183CC535716F3C1D2FC7DBF151435DC34043A561956197E18491B9D13CA3D5468D460F8C69C65CE324E36DC66DC6A326062621264B4DEA4DEE9A524DB9A629A63B4C3B4CC7CDCCCDA2CDD699359B3D31D732E79BE79BD79BDFB7605A785A2CB6A8B6B86549B2E45AA659EEB6BC6E855A3959A558555A5DB346AD9DAD25D6BBADBBA711A7B94E934EAB9ED667C3B0F1B6C9B6A9B719B0E5D806DBAEB66DB67D6167621767B7C5AEC3EE93BD937DBA7D8DFD3D070D87D90EAB1D5A1D7E73B472143A563ADE9ACE9CEE3F7DC5F496E92F6758CF10CFD833E3B613CB29C4699D539BD347671767B97383F3888B894B82CB2E973E2E9B1BC6DDC8BDE44A74F5715DE17AD2F59D9BB39BC2EDA8DBAFEE36EE69EE87DC9FCC349F299E593373D0C3C843E051E5D13F0B9F95306BDFAC7E4F434F8167B5E7232F632F9157ADD7B0B7A577AAF761EF173EF63E729FE33EE33C37DE32DE595FCC37C0B7C8B7CB4FC36F9E5F85DF437F23FF64FF7AFFD100A78025016703898141815B02FBF87A7C21BF8E3F3ADB65F6B2D9ED418CA0B94115418F82AD82E5C1AD2168C8EC90AD21F7E798CE91CE690E85507EE8D6D00761E6618BC37E0C2785878557863F8E7088581AD131973577D1DC4373DF44FA449644DE9B67314F39AF2D4A352A3EAA2E6A3CDA37BA34BA3FC62E6659CCD5589D58496C4B1C392E2AAE366E6CBEDFFCEDF387E29DE20BE37B17982FC85D7079A1CEC2F485A716A92E122C3A96404C884E3894F041102AA8168C25F21377258E0A79C21DC267222FD136D188D8435C2A1E4EF2482A4D7A92EC91BC357924C533A52CE5B98427A990BC4C0D4CDD9B3A9E169A76206D323D3ABD31839291907142AA214D93B667EA67E66676CBAC6585B2FEC56E8BB72F1E9507C96BB390AC05592D0AB642A6E8545A28D72A07B267655766BFCD89CA3996AB9E2BCDEDCCB3CADB90379CEF9FFFED12C212E192B6A5864B572D1D58E6BDAC6A39B23C7179DB0AE315052B865606AC3CB88AB62A6DD54FABED5797AE7EBD267A4D6B815EC1CA82C1B5016BEB0B550AE5857DEBDCD7ED5D4F582F59DFB561FA869D1B3E15898AAE14DB1797157FD828DC78E51B876FCABF99DC94B4A9ABC4B964CF66D266E9E6DE2D9E5B0E96AA97E6970E6E0DD9DAB40DDF56B4EDF5F645DB2F97CD28DBBB83B643B9A3BF3CB8BC65A7C9CECD3B3F54A454F454FA5436EED2DDB561D7F86ED1EE1B7BBCF634ECD5DB5BBCF7FD3EC9BEDB5501554DD566D565FB49FBB3F73FAE89AAE9F896FB6D5DAD4E6D71EDC703D203FD07230EB6D7B9D4D51DD23D54528FD62BEB470EC71FBEFE9DEF772D0D360D558D9CC6E223704479E4E9F709DFF71E0D3ADA768C7BACE107D31F761D671D2F6A429AF29A469B539AFB5B625BBA4FCC3ED1D6EADE7AFC47DB1F0F9C343C59794AF354C969DAE982D39367F2CF8C9D959D7D7E2EF9DC60DBA2B67BE763CEDF6A0F6FEFBA1074E1D245FF8BE73BBC3BCE5CF2B874F2B2DBE51357B8579AAF3A5F6DEA74EA3CFE93D34FC7BB9CBB9AAEB95C6BB9EE7ABDB57B66F7E91B9E37CEDDF4BD79F116FFD6D59E393DDDBDF37A6FF7C5F7F5DF16DD7E7227FDCECBBBD97727EEADBC4FBC5FF440ED41D943DD87D53F5BFEDCD8EFDC7F6AC077A0F3D1DC47F7068583CFFE91F58F0F43058F998FCB860D86EB9E383E3939E23F72FDE9FCA743CF64CF269E17FEA2FECBAE17162F7EF8D5EBD7CED198D1A197F29793BF6D7CA5FDEAC0EB19AFDBC6C2C61EBEC97833315EF456FBEDC177DC771DEFA3DF0F4FE47C207F28FF68F9B1F553D0A7FB93199393FF040398F3FC63332DDB000000206348524D00007A25000080830000F9FF000080E9000075300000EA6000003A980000176F925FC546000002A14944415478DAC4973168136114C77FAD2593572110308B22B41717079B8C4AA05051BCABE062EFA60E121104856611854C2EB5391444D314E9E0E226F4221683F68293920FBA38580441F02A08829C2014421C7A57AEB1C97DD734F8C6E37BEF7FEFBDFF7BDFFF1B6AB7DBFC0F1B01C8E57232674F00578029E00890010E03EB400BA803AB404326D850BBDD8E029E04E681AC64323F8012F014D8EA7668B84780A3C02BE04D0C508014F018F808E4E3029F02DE03E7FB68E318F01A98EDDAE33D40DFF97DECD712C0B2CF8547BD324E01B503020DDB039F945D8197816303989E43C07320B917F02470312A82A228944A25D6D6D668369BACACAC50281464C093C09DBD7A3C1FE5393A3A4AA552219D4E635916AEEB6218C60E70B55A8D0A7103B0806F41C6599991D1340D5555B12C0BDBB61142502C1611426018068AA2C8906D365CEA69995AE5F3DB6369DBF6AEEF420814454155559930D361E033FD304708B15DB6ACD49EC90289003823E3E1BA6E1C805E0CCF8C84181769B55A0D5DD7999B9BA35AADE2791E994C86999999B8E0C9E150D3A54A5A2C1601585858607171114DD3701C2776D641C6BF64B3761CE71F205DD777F55AC27E07197FEAA769131313006C6C6CC8BA7C0E80D7F70BAAAA2ABAAE63DB369EE7C9B87C017E06A57E095C8FF2D0759DF1F1711A8DC60EBB0DC3C0F33C96969664FF7535BC32EBBE7248F5F2F03C0FD334314D7317E1CAE5F2CEA849D8B34EE973D3BFBE222F8960436D6E6EC6010CB2BDD0099CF0E5CAD88084650BC8057C0A5F8B5BC035FFC020CC0A93B85308BC056E0F00B40EDC8D127BF7815B0798F90BE052A7D4EDA6321F029ABFD1FAB17BC065E04F1C5DBD0A9CF485796B1FA53DDD595E596080EFC055E0B8FF3AF8D0E3EC57E00970163817B50D659E30DDDE51C9D098C45EB97F07007EF6C3914CACAB170000000049454E44AE426082);