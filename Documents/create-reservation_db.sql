/* 処理件数の表示を無効 */
SET NOCOUNT ON;
GO

/* 暗黙のトランザクションを無効 */
SET IMPLICIT_TRANSACTIONS OFF;
GO

/* DB作成 */
USE [master];
IF (EXISTS(SELECT * FROM sysdatabases WHERE name IN('[reservation_db]','reservation_db')))
BEGIN
	ALTER DATABASE [reservation_db] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	ALTER DATABASE [reservation_db] SET MULTI_USER WITH NO_WAIT;
	DROP DATABASE reservation_db;
END
CREATE DATABASE [reservation_db] COLLATE Japanese_CI_AS;
GO

/* 暗黙のトランザクションを有効 */
SET IMPLICIT_TRANSACTIONS ON;
GO

/* ログインを作成 */
IF (EXISTS(SELECT name FROM sys.server_principals WHERE name = N'reservationU'))
	DROP LOGIN [reservationU];
CREATE LOGIN [reservationU] WITH PASSWORD=N'reservationP', DEFAULT_DATABASE=[reservation_db], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;
GO

/* データベースユーザを作成して権限を付与 */
USE [reservation_db];
IF (EXISTS (SELECT * FROM sys.database_principals WHERE name = N'reservationU'))
	DROP USER [reservationU];
CREATE USER [reservationU] FOR LOGIN [reservationU];
GRANT CONTROL TO [reservationU];
GO

/* 患者マスタ作成 */
/* 患者情報を管理するテーブル */
CREATE TABLE m_patient (
	patient_id	INT IDENTITY, -- 患者ＩＤ
	combined_id	AS 'EC' + RIGHT('00000' + CONVERT(VARCHAR, patient_id), 6), -- 患者ＩＤ
	name		NVARCHAR(48) NOT NULL, -- 氏名
	birth_date	DATE NOT NULL, -- 生年月日
	created		DATETIME2 DEFAULT GETDATE() NOT NULL, -- 作成日時
	updated		DATETIME2 DEFAULT GETDATE() NOT NULL, -- 更新日時
	CONSTRAINT pk_patient PRIMARY KEY(patient_id) WITH(IGNORE_DUP_KEY = ON),
);
GO

/* 患者マスタの更新日時のトリガー */
CREATE TRIGGER trg_patient_updated
ON m_patient
AFTER UPDATE
AS
UPDATE m_patient
SET updated = GETDATE()
WHERE patient_id IN (SELECT DISTINCT patient_id FROM inserted);
GO

/* 患者マスタINSERT */
INSERT INTO m_patient(name, birth_date) VALUES('Quang', CAST('1998-1-1' AS Date));
INSERT INTO m_patient(name, birth_date) VALUES('Hung', CAST('1998-4-1' AS Date));
INSERT INTO m_patient(name, birth_date) VALUES('Quynh', CAST('1998-7-1' AS Date));
INSERT INTO m_patient(name, birth_date) VALUES('Hanh', CAST('1998-10-1' AS Date));
GO

/* 状態マスタ作成 */
/* 状態情報を管理するテーブル */
CREATE TABLE m_status (
	status_id		INT NOT NULL, -- 状態ＩＤ
	status_name		NVARCHAR(5) NOT NULL, -- 状態名
	status_name_en	NVARCHAR(20) NOT NULL, -- 状態名（英語）
	CONSTRAINT pk_status PRIMARY KEY(status_id) WITH(IGNORE_DUP_KEY = ON),
);
GO

/* 状態マスタINSERT */
INSERT INTO m_status VALUES(1, '予約', 'Reserved');
INSERT INTO m_status VALUES(2, '受付完了', 'Reception completed');
INSERT INTO m_status VALUES(3, '診療完了', 'Treatment completed');
GO

/* 診察大項目マスタ作成 */
/* 診察大項目を管理するテーブル */
CREATE TABLE m_major_examination (
	major_id		INT NOT NULL, -- 診察大項目ＩＤ
	major_name		NVARCHAR(5) NOT NULL, -- 診察大項目名
	major_name_en	NVARCHAR(15) NOT NULL, -- 診察大項目名（英語）
	CONSTRAINT pk_major_examination PRIMARY KEY(major_id) WITH(IGNORE_DUP_KEY = ON),
);
GO

/* 診察大項目マスタINSERT */
INSERT INTO m_major_examination VALUES(1, '花粉症', 'Hay Fever');
INSERT INTO m_major_examination VALUES(2, '予防接種', 'Vaccination');
INSERT INTO m_major_examination VALUES(3, '検査', 'Test');
GO

/* 診察小項目マスタ作成 */
/* 診察小項目を管理するテーブル */
CREATE TABLE m_sub_examination (
	sub_id		INT IDENTITY, -- 診察小項目ＩＤ
	sub_name	NVARCHAR(25) NOT NULL, -- 診察小項目名
	sub_name_en	NVARCHAR(40) NOT NULL, -- 診察小項目名（英語）
	major_id	INT NOT NULL, -- 診察大項目ＩＤ
	CONSTRAINT pk_sub_examination PRIMARY KEY(sub_id) WITH(IGNORE_DUP_KEY = ON),

	-- 参照テーブル
	CONSTRAINT fk_m_major_examination_major_id
	FOREIGN KEY (major_id)
	REFERENCES m_major_examination(major_id),
);
GO

/* 診察小項目マスタINSERT */
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'スギ', 'Cryptomeria japonica');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'ヒノキ', 'Chamaecyparis obtusa');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'ホソムギ', 'Lolium perenne');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'オオアワガエリ', 'Phleum pratense');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'カモガヤ', 'Dactylis glomerata');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'シラカバ', 'Betula platyphylla');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'ブタクサ', 'Ambrosia artemisiifolia');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'オオブタクサ', 'Ambrosia trifida');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'ヨモギ', 'Artemisia princeps');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'カナムグラ', 'Humulus scandens');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'セイタカアワダチソウ', 'Solidago canadensis');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(1, 'ハンノキ', 'Alnus japonica');

INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'BCG', 'BCG');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '麻疹・風疹混合 (MR)', 'Measles and Rubella (MR)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '麻疹', 'Measles');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '風疹', 'Rubella');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '水痘', 'Chickenpox');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'ロタウイルス', 'Virus rota');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '百日咳・ジフテリア・破傷風混合 (DPT)', 'Diphtheria, Pertussis and Tetanus (DPT)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'ポリオ (IPV)', 'Polio (IPV)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'ジフテリア・破傷風混合トキソイド (DT)', 'Diphtheria and Tetanus toxoid (DT)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '日本脳炎', 'Japanese encephalitis');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '肺炎球菌 (13価結合型)', 'Streptococcus pneumoniae (13-valent)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'インフルエンザ菌ｂ型 (Hib)', 'Haemophilus influenzae type b (Hib)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'Ｂ型肝炎', 'Hepatitis B');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'ヒトパピローマウイルス (HPV)', 'Human papilloma virus (HPV)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'インフルエンザ', 'Influenza');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '肺炎球菌 (23価莢膜ポリサッカライド)', 'Streptococcus pneumoniae (23-valent)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'コロナ', 'Corona');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '流行性耳下腺炎', 'Mumps');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '黄熱', 'Yellow fever');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '帯状疱疹(水痘ワクチンを使用)', 'Shingles (use varicella vaccine)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '破傷風トキソイド', 'Tetanus toxoid');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '成人用ジフテリアトキソイド', 'Adult diphtheria toxoid');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, 'Ａ型肝炎', 'Hepatitis A');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '狂犬病', 'Rabies');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '髄膜炎菌', 'Meningococcus');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(2, '帯状疱疹', 'Herpes zoster');

INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '中性脂肪(TG)', 'Triglyceride (TG)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'HDLコレステロール', 'HDL cholesterol');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'LDLコレステロール', 'LDL cholesterol');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '総コレステロール', 'Total cholesterol');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '血糖(BS)', 'Blood sugar (BS)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'ヘモグロビンA1c(HbA1c)', 'Hemoglobin A1c (HbA1c)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '赤血球数(RBC)', 'Red blood cell count (RBC)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '白血球数(WBC)', 'White blood cell count (WBC)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'ヘマトクリット(Ht)', 'Hematocrit (Ht)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '血色素(ヘモグロビン、Hb)', 'Hemoglobin (Hb)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '尿酸(UA)', 'Uric acid (UA)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'クレアチニン(CRE)', 'Creatinine (CRE)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '尿素窒素(BUN)', 'Blood urea nitrogen (BUN)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'AST(GOT)', 'AST(GOT)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'ALT(GPT)', 'ALT(GPT)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'γ-GT(γ-GTP)', 'γ-GT(γ-GTP)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '総ビリルビン(T-Bll)', 'Total bilirubin (T-Bll)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '総たんぱく(TP)', 'Total protein (TP)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'ALP(アルカリホスファターゼ)', 'ALP (Alkaline phosphatase)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'LDH(乳酸脱水素酵素)', 'LDH (Lactate dehydrogenase)');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'アミラーゼ', 'Amylase');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'HBs抗原', 'HBs Ag');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'HCV抗体', 'HCV Ab');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '尿糖', 'Diabetes');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '尿たんぱく', 'Proteinuria');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '尿潜血', 'Urine occult blood');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'ウロビリノーゲン', 'Urobilinogen');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '尿沈渣', 'Urine sediment');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '便潜血反応', 'Fecal occult blood');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, 'BMI', 'BMI');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '腹囲', 'Abdominal circumference');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '血圧', 'Blood pressure');
INSERT INTO m_sub_examination(major_id, sub_name, sub_name_en) VALUES(3, '心電図', 'Electrocardiogram');
GO

/* 予約マスタ作成 */
/* 予約情報を管理するテーブル */
CREATE TABLE m_reservation (
	reservation_id		INT IDENTITY, -- 予約ＩＤ
	patient_id			INT NOT NULL, -- 患者ＩＤ
	reservation_date	DATE NOT NULL, -- 予約日付
	status_id			INT DEFAULT 1, -- 状態ＩＤ
	sub_id				INT NOT NULL, -- 診察小項目ＩＤ
	created				DATETIME2 DEFAULT GETDATE() NOT NULL, -- 作成日時
	updated				DATETIME2 DEFAULT GETDATE() NOT NULL, -- 更新日時
	CONSTRAINT pk_reservation PRIMARY KEY(reservation_id) WITH(IGNORE_DUP_KEY = ON),

	-- 参照テーブル
	CONSTRAINT fk_m_patient_patient_id
	FOREIGN KEY (patient_id)
	REFERENCES m_patient(patient_id),

	CONSTRAINT fk_m_status_status_id
	FOREIGN KEY (status_id)
	REFERENCES m_status(status_id),

	CONSTRAINT fk_m_sub_examination_sub_id
	FOREIGN KEY (sub_id)
	REFERENCES m_sub_examination(sub_id),
);
GO

/* 予約マスタの更新日時のトリガー */
CREATE TRIGGER trg_reservation_updated
ON m_reservation
AFTER UPDATE
AS
UPDATE m_reservation
SET updated = GETDATE()
WHERE reservation_id IN (SELECT DISTINCT reservation_id FROM inserted);
GO

/* 予約マスタINSERT */
INSERT INTO m_reservation(patient_id, reservation_date, sub_id) VALUES(1, CAST('2021-1-1' AS Date), 9);
INSERT INTO m_reservation(patient_id, reservation_date, sub_id) VALUES(2, CAST('2021-4-1' AS Date), 45);
INSERT INTO m_reservation(patient_id, reservation_date, sub_id) VALUES(3, CAST('2021-7-1' AS Date), 25);
INSERT INTO m_reservation(patient_id, reservation_date, sub_id) VALUES(4, CAST('2021-10-1' AS Date), 70);
GO

/* トランザクションの確定 */
COMMIT;
GO