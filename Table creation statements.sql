CREATE TABLE TEAM
(
	ID NUMBER,
	NAME VARCHAR(70) UNIQUE NOT NULL,
	MAX_PLAYERS NUMBER NOT NULL,
	MIN_PLAYERS NUMBER NOT NULL,
	BONUS_POINTS NUMBER NOT NULL,
	PLACEMENT NUMBER NOT NULL,
	CONSTRAINT TEAM_PK PRIMARY KEY (ID)
);

CREATE TABLE PLAYER
(
	ID NUMBER,
	TEAM_ID NUMBER,
	NICKNAME VARCHAR(50) UNIQUE NOT NULL,
	PASSWORD VARCHAR(50) NOT NULL,
	NAME VARCHAR(50) NOT NULL,
	SURNAME VARCHAR(50) NOT NULL,
	GENDER CHAR(1) CHECK(GENDER IN('M','F')) NOT NULL,
	AGE NUMBER NOT NULL,
	CONSTRAINT PLAYER_PK PRIMARY KEY (ID),
	CONSTRAINT PLAYER_TEAM_FK FOREIGN KEY (TEAM_ID) REFERENCES TEAM(ID)
);

CREATE TABLE "SESSION"
(
	ID NUMBER,
	PLAYER_ID NUMBER NOT NULL,
	START_TIME TIMESTAMP NOT NULL,
	END_TIME TIMESTAMP NOT NULL,
	POINTS NUMBER NOT NULL,
	GOLD NUMBER NOT NULL,
	CONSTRAINT SESSION_PK PRIMARY KEY (ID),
	CONSTRAINT SESSION_PLAYER_FK FOREIGN KEY (PLAYER_ID) REFERENCES PLAYER(ID)
);

CREATE TABLE TRACK
(
	ID NUMBER,
	NAME VARCHAR(70) UNIQUE NOT NULL,
	TEAM CHAR(1) CHECK(TEAM IN('T','F')) NOT NULL,
	BONUS NUMBER NOT NULL,
	CONSTRAINT TRACK_PK PRIMARY KEY (ID)
);

CREATE TABLE TRANSIT
(
	ID NUMBER,
	PLAYER_ID NUMBER,
	TEAM_ID NUMBER,
	TRACK_ID NUMBER NOT NULL,
	"SUCCESSFUL" CHAR(1) CHECK("SUCCESSFUL" IN('T','F')) NOT NULL,
	ENEMIES_DEFEATED NUMBER NOT NULL,
	CONSTRAINT TRANSIT_PK PRIMARY KEY (ID),
	CONSTRAINT TRANSIT_PLAYER_FK FOREIGN KEY (PLAYER_ID) REFERENCES PLAYER(ID),
	CONSTRAINT TRANSIT_TEAM_FK FOREIGN KEY (TEAM_ID) REFERENCES TEAM(ID),
	CONSTRAINT TRANSIT_TRACK_FK FOREIGN KEY (TRACK_ID) REFERENCES TRACK(ID)
);

CREATE TABLE ITEM
(
	ID NUMBER,
	NAME VARCHAR(70) UNIQUE NOT NULL,
	BONUS_POINTS NUMBER NOT NULL,
	DESCRIPTION VARCHAR(200) NOT NULL,
	PRICE NUMBER NOT NULL,
	EXP_NEEDED NUMBER NOT NULL,
	F_WEAPON CHAR(1) CHECK(F_WEAPON IN('T','F')) NOT NULL,
	WEAPON_TYPE VARCHAR(30),
	ATTACK_POINTS NUMBER,
	F_ARMOUR CHAR(1) CHECK(F_ARMOUR IN('T','F')) NOT NULL,
	DEFENSE_POINTS NUMBER,
	CONSTRAINT ITEM_PK PRIMARY KEY (ID)
);

CREATE TABLE CHARACTER
(
	ID NUMBER,
	PLAYER_ID NUMBER NOT NULL,
	FATIGUE_LEVEL NUMBER NOT NULL,
	HEALTH_LEVEL NUMBER NOT NULL,
	EXPERIENCE NUMBER NOT NULL,
	GOLD NUMBER NOT NULL,
	RACE VARCHAR(50) CHECK(RACE IN ('ELF','DEMON','DWARF','ORC','HUMAN')) NOT NULL,
	ENERGY_LEVEL NUMBER,
	WEAPON_TYPE VARCHAR(30),
	HIDING_SKILL NUMBER,
	F_ASSISTANT CHAR(1) CHECK(F_ASSISTANT IN('T','F')) NOT NULL,
	NAME VARCHAR(50),
	BONUS NUMBER,
	CONSTRAINT CHARACTER_PK PRIMARY KEY (ID),
	CONSTRAINT CHARACTER_PLAYER_FK FOREIGN KEY (PLAYER_ID) REFERENCES PLAYER(ID)
);

CREATE TABLE THIEF
(
	CHARACTER_ID NUMBER,
	NOISE_LEVEL NUMBER NOT NULL,
	TRAP_REMOVAL CHAR(1) CHECK(TRAP_REMOVAL IN('T','F')) NOT NULL,
	CONSTRAINT THIEF_PK PRIMARY KEY (CHARACTER_ID),
	CONSTRAINT THIEF_CHARACTER_FK FOREIGN KEY (CHARACTER_ID) REFERENCES CHARACTER(ID)
	ON DELETE CASCADE
);

CREATE TABLE WIZARD
(
	CHARACTER_ID NUMBER,
	CONSTRAINT WIZARD_PK PRIMARY KEY (CHARACTER_ID),
	CONSTRAINT WIZARD_CHARACTER_FK FOREIGN KEY (CHARACTER_ID) REFERENCES CHARACTER(ID)
	ON DELETE CASCADE
);

CREATE TABLE FIGHTER
(
	CHARACTER_ID NUMBER,
	SHIELD CHAR(1) CHECK(SHIELD IN('T','F')) NOT NULL,
	TWOHANDED_WEAPON CHAR(1) CHECK(TWOHANDED_WEAPON IN('T','F')) NOT NULL,
	CONSTRAINT FIGHTER_PK PRIMARY KEY (CHARACTER_ID),
	CONSTRAINT FIGHTER_CHARACTER_FK FOREIGN KEY (CHARACTER_ID) REFERENCES CHARACTER(ID)
	ON DELETE CASCADE
);

CREATE TABLE PRIEST
(
	CHARACTER_ID NUMBER,
	RELIGION VARCHAR(50) NOT NULL,
	HEALS CHAR(1) CHECK(HEALS IN('T','F')) NOT NULL,
	CONSTRAINT PRIEST_PK PRIMARY KEY (CHARACTER_ID),
	CONSTRAINT PRIEST_CHARACTER_FK FOREIGN KEY (CHARACTER_ID) REFERENCES CHARACTER(ID)
	ON DELETE CASCADE
);

CREATE TABLE DEFENDER
(
	CHARACTER_ID NUMBER,
	MAX_ARMOUR_WEIGHT NUMBER NOT NULL,
	CONSTRAINT DEFENDER_PK PRIMARY KEY (CHARACTER_ID),
	CONSTRAINT DEFENDER_CHARACTER_FK FOREIGN KEY (CHARACTER_ID) REFERENCES CHARACTER(ID)
	ON DELETE CASCADE
);

CREATE TABLE ARCHER
(
	CHARACTER_ID NUMBER,
	BOW_CROSSBOW VARCHAR(50) CHECK(BOW_CROSSBOW IN('BOW','CROSSBOW')) NOT NULL,
	CONSTRAINT ARCHER_PK PRIMARY KEY (CHARACTER_ID),
	CONSTRAINT ARCHER_CHARACTER_FK FOREIGN KEY (CHARACTER_ID) REFERENCES CHARACTER(ID)
	ON DELETE CASCADE
);


CREATE TABLE OWNS
(
	ID NUMBER,
	PLAYER_ID NUMBER NOT NULL,
	ITEM_ID NUMBER NOT NULL,
	CONSTRAINT OWNS_PK PRIMARY KEY (ID),
	CONSTRAINT OWNS_ITEM_FK FOREIGN KEY (ITEM_ID) REFERENCES ITEM(ID),
	CONSTRAINT OWNS_PLAYER_FK FOREIGN KEY (PLAYER_ID) REFERENCES PLAYER(ID)
);

CREATE TABLE FIGHTS
(
	ID NUMBER,
	TEAM1_ID NUMBER NOT NULL,
	TEAM2_ID NUMBER NOT NULL,
	TIME_HELD TIMESTAMP NOT NULL,
	BONUS NUMBER NOT NULL,
	WINNING_TEAM NUMBER CHECK(WINNING_TEAM IN (0, 1, 2)),
	CONSTRAINT FIGHTS_PK PRIMARY KEY (ID),
	CONSTRAINT FIGHTS_TEAM1_FK FOREIGN KEY (TEAM1_ID) REFERENCES TEAM(ID),
	CONSTRAINT FIGHTS_TEAM2_FK FOREIGN KEY (TEAM2_ID) REFERENCES TEAM(ID)
);

CREATE TABLE SPELL
(
	ID NUMBER,
	NAME VARCHAR(100) NOT NULL,
	CONSTRAINT SPELL_PK PRIMARY KEY (ID)	
);

CREATE TABLE CASTS_SPELL
(
	ID NUMBER,
	SPELL_ID NUMBER NOT NULL,
	WIZARD_ID NUMBER NOT NULL,
	CONSTRAINT CASTS_SPELL_PK PRIMARY KEY (ID),
	CONSTRAINT WIZARD_FK FOREIGN KEY (WIZARD_ID) REFERENCES WIZARD(CHARACTER_ID) ON DELETE CASCADE,
	CONSTRAINT SPELL_FK FOREIGN KEY (SPELL_ID) REFERENCES SPELL(ID)
);

CREATE TABLE BLESSING
(
	ID NUMBER,
	NAME VARCHAR(100) NOT NULL,
	CONSTRAINT BLESSING_PK PRIMARY KEY (ID)
);

CREATE TABLE USES_BLESSING
(
	ID NUMBER,
	BLESSING_ID NUMBER NOT NULL,
	PRIEST_ID NUMBER NOT NULL,
	CONSTRAINT USES_BLESSING_PK PRIMARY KEY (ID),
	CONSTRAINT PRIEST_FK FOREIGN KEY (PRIEST_ID) REFERENCES PRIEST(CHARACTER_ID) ON DELETE CASCADE,
	CONSTRAINT BLESSING_FK FOREIGN KEY (BLESSING_ID) REFERENCES BLESSING(ID)
);

CREATE TABLE ALLOWED_RACE
(
	ID NUMBER,
	ITEM_ID NUMBER,
	RACE_NAME VARCHAR(50) NOT NULL,
	CONSTRAINT ALLOWED_RACE_PK PRIMARY KEY (ID),
	CONSTRAINT RACE_ITEM_FK FOREIGN KEY (ITEM_ID) REFERENCES ITEM(ID)
);

CREATE TABLE ALLOWED_CLASS
(
	ID NUMBER,
	ITEM_ID NUMBER,
	CLASS_NAME VARCHAR(50) NOT NULL,
	CONSTRAINT ALLOWED_CLASS_PK PRIMARY KEY (ID),
	CONSTRAINT CLASS_ITEM_FK FOREIGN KEY (ITEM_ID) REFERENCES ITEM(ID)
);

CREATE TABLE REQUIRED_RACE
(
	ID NUMBER,
	TRACK_ID NUMBER,
	RACE_NAME VARCHAR(50) NOT NULL,
	CONSTRAINT REQUIRED_RACE_PK PRIMARY KEY (ID),
	CONSTRAINT RACE_TRACK_FK FOREIGN KEY (TRACK_ID) REFERENCES TRACK(ID)
);

CREATE TABLE REQUIRED_CLASS
(
	ID NUMBER,
	TRACK_ID NUMBER,
	CLASS_NAME VARCHAR(50) NOT NULL,
	CONSTRAINT REQUIRED_CLASS_PK PRIMARY KEY (ID),
	CONSTRAINT CLASS_TRACK_FK FOREIGN KEY (TRACK_ID) REFERENCES TRACK(ID)
);

CREATE SEQUENCE TEAM_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER TEAM_AUTO_ID
    BEFORE INSERT
    ON TEAM
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT TEAM_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE PLAYER_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER PLAYER_AUTO_ID
    BEFORE INSERT
    ON PLAYER
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT PLAYER_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE SESSION_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER SESSION_AUTO_ID
    BEFORE INSERT
    ON "SESSION"
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT SESSION_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE TRACK_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER TRACK_AUTO_ID
    BEFORE INSERT
    ON TRACK
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT TRACK_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE TRANSIT_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER TRANSIT_AUTO_ID
    BEFORE INSERT
    ON TRANSIT
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT TRANSIT_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE ITEM_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER ITEM_AUTO_ID
    BEFORE INSERT
    ON ITEM
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT ITEM_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE CHARACTER_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER CHARACTER_AUTO_ID
    BEFORE INSERT
    ON CHARACTER
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT CHARACTER_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE OWNS_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER OWNS_AUTO_ID
    BEFORE INSERT
    ON OWNS
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT OWNS_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE FIGHTS_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER FIGHTS_AUTO_ID
    BEFORE INSERT
    ON FIGHTS
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT FIGHTS_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE SPELL_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER SPELL_AUTO_ID
    BEFORE INSERT
    ON SPELL
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT SPELL_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE BLESSING_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER BLESSING_AUTO_ID
    BEFORE INSERT
    ON BLESSING
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT BLESSING_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE ALLOWED_RACE_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER ALLOWED_RACE_AUTO_ID
    BEFORE INSERT
    ON ALLOWED_RACE
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT ALLOWED_RACE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE ALLOWED_CLASS_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER ALLOWED_CLASS_AUTO_ID
    BEFORE INSERT
    ON ALLOWED_CLASS
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT ALLOWED_CLASS_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE REQUIRED_RACE_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER REQUIRED_RACE_AUTO_ID
    BEFORE INSERT
    ON REQUIRED_RACE
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT REQUIRED_RACE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE REQUIRED_CLASS_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER REQUIRED_CLASS_AUTO_ID
    BEFORE INSERT
    ON REQUIRED_CLASS
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT REQUIRED_CLASS_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE CASTS_SPELL_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER CASTS_SPELL_AUTO_ID
    BEFORE INSERT
    ON CASTS_SPELL
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT CASTS_SPELL_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;

/

CREATE SEQUENCE USES_BLESSING_ID_SEQ MINVALUE 1 INCREMENT BY 1 START WITH 1 CACHE 20 ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER USES_BLESSING_AUTO_ID
    BEFORE INSERT
    ON USES_BLESSING
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT USES_BLESSING_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
