-- ---
-- Globals
-- ---

-- SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
-- SET FOREIGN_KEY_CHECKS=0;

-- ---
-- Table 'Users'
-- 
-- ---


		
CREATE TABLE  Users  (
   Userid  INTEGER NULL identity  ,
   FirstName  VARCHAR(128) NOT NULL ,
   LastName  VARCHAR(128) NOT NULL,
   Group  VARCHAR(128) NULL  ,
  PRIMARY KEY ( Userid )
);

-- ---
-- Table 'Questions'
-- 
-- ---


		
CREATE TABLE  Questions  (
   Questionid  INTEGER NULL  ,
   QuestionText  INTEGER(128) NULL  ,
   Testsid  INTEGER NULL  ,
   Rate  INTEGER NULL  ,
  PRIMARY KEY ( Questionid )
);

-- ---
-- Table 'Tests'
-- 
-- ---


		
CREATE TABLE  Tests  (
   Testsid  INTEGER NULL  ,
   TestName  VARCHAR(128) NOT NULL DEFAULT 'NULL',
  PRIMARY KEY ( Testsid )
);

-- ---
-- Table 'Answers'
-- 
-- ---


		
CREATE TABLE  Answers  (
   id  INTEGER NULL  ,
   AnswerText  VARCHAR(128) NULL  ,
   isTrue  bit NULL  ,
   Questionid_Questions  INTEGER NULL  ,
  PRIMARY KEY ( id )
);

-- ---
-- Table 'Journal'
-- 
-- ---


		
CREATE TABLE  Journal  (
   id  INTEGER NULL identity  ,
   Userid_Users  INTEGER NULL  ,
   Testsid_Tests  INTEGER NULL  ,
   Score  INTEGER NULL  ,
  PRIMARY KEY ( id )
);

-- ---
-- Foreign Keys 
-- ---

ALTER TABLE  Questions  ADD FOREIGN KEY (Testsid) REFERENCES  Tests  ( Testsid );
ALTER TABLE  Answers  ADD FOREIGN KEY (Questionid_Questions) REFERENCES  Questions  ( Questionid );
ALTER TABLE  Journal  ADD FOREIGN KEY (Userid_Users) REFERENCES  Users  ( Userid );
ALTER TABLE  Journal  ADD FOREIGN KEY (Testsid_Tests) REFERENCES  Tests  ( Testsid );

-- ---
-- Table Properties
-- ---

-- ALTER TABLE  Users  ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE  Questions  ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE  Tests  ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE  Answers  ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE  Journal  ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ---
-- Test Data
-- ---

-- INSERT INTO  Users  ( Userid , FirstName , LastName , Group ) VALUES
-- ('','','','');
-- INSERT INTO  Questions  ( Questionid , QuestionText , Testsid , Rate ) VALUES
-- ('','','','');
-- INSERT INTO  Tests  ( Testsid , TestName ) VALUES
-- ('','');
-- INSERT INTO  Answers  ( id , AnswerText , isTrue , Questionid_Questions ) VALUES
-- ('','','','');
-- INSERT INTO  Journal  ( id , Userid_Users , Testsid_Tests , Score ) VALUES
-- ('','','','');