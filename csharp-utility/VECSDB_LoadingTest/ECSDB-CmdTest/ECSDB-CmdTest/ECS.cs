using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace ECSDB_CmdTest
{
    class ECS
    {
        /// <summary>
        /// OleDB连接字符串
        /// </summary>
        public static string connStr = 
            "Provider=MSDAORA.1;Data Source=VECSDB;" + 
            "User Id=expensectl;Password=cfag$expense;" +
            "connection reset=false;connection lifetime=5;min pool size=1;max pool size=2";

        /// <summary>
        /// 依据编号生成待审核的结报单
        /// </summary>
        /// <param name="number">结报单编号</param>
        /// <returns>成功标志</returns>
        public static bool GenerateData(int number)
        {
            string sql = string.Format(
                "DECLARE " +
                "  v_Counter       NUMBER := {0}; " +
                "   " +
                "  /* 用于存储动态的各阶段的ID */ " +
                "  v_AskPrMasterId   VARCHAR2(20);" +
                "  v_AskPrDetailId   VARCHAR2(20);" +
                "  v_BuyPoMasterId   VARCHAR2(20);" +
                "  v_BuyPoDetailId   VARCHAR2(20);" +
                "  v_ChkAcpMasterId  VARCHAR2(20);" +
                "  v_ChkAcpDetailId  VARCHAR2(20);" +
                "  v_ChkAskrecId     VARCHAR2(20);" +
                "  v_TkmTakeMasterId VARCHAR2(20);" +
                "  v_TkmTakeDetialId VARCHAR2(20);" +
                "  v_Prefix          VARCHAR2(20);" +
                "BEGIN         " +
                "    IF v_Counter < 10 THEN " +
                "        v_Prefix := '000' || v_Counter; " +
                "    END IF; " +
                "         " +
                "    IF v_Counter >= 10 AND v_Counter < 100 THEN " +
                "        v_Prefix := '00' || v_Counter; " +
                "    END IF;  " +
                "         " +
                "    IF v_Counter >= 100 AND v_Counter < 1000 THEN " +
                "        v_Prefix := '0' || v_Counter; " +
                "    END IF; " +
                "         " +
                "    IF v_Counter >= 1000 AND v_Counter < 10000 THEN " +
                "        v_Prefix := '' || v_Counter; " +
                "    END IF;    " +
                "         " +
                "    /* Process prefix */ " +
                "    v_AskPrMasterId   := '1CEN-H5' || TO_CHAR(v_Prefix);" +
                "    v_AskPrDetailId   := '1CEN-H5' || TO_CHAR(v_Prefix);" +
                "    v_BuyPoMasterId   := '2CEN-H5' || TO_CHAR(v_Prefix);" +
                "    v_BuyPoDetailId   := '2CEN-H5' || TO_CHAR(v_Prefix);" +
                "    v_ChkAcpMasterId  := '3INE-H5' || TO_CHAR(v_Prefix);" +
                "    v_ChkAcpDetailId  := '3INE-H5' || TO_CHAR(v_Prefix);" +
                "    v_ChkAskrecId     := '3INE-H5' || TO_CHAR(v_Prefix);" +
                "    v_TkmTakeMasterId := '4CEN-H5' || TO_CHAR(v_Prefix);" +
                "    v_TkmTakeDetialId := '4CEN-H5' || TO_CHAR(v_Prefix);" +
                "                        " +
                "    Insert into EXPENSECTL.ASK_PRMASTER " +
                "       (BILLNO, BILLTYPE, ASKDATE, COMPANYID, ASKDEPT,  " +
                "        ASKUSER, PURDEPT, CURRCODE, BUDGETTYPE, ASKPHONE,  " +
                "        SIGNTYPE, FLAG, FIRSTCATCH, CREATEUSER, SECONDCATCH,  " +
                "        CREATEDATE, CONFIRMUSER, CONFIRMDATE, LOCKUSER, LOCKDATE,  " +
                "        ISLAWLOCK, SIGNFLAG, AREACODE, ISEQUIP, ISLOWCHECK,  " +
                "        FIXFLAG, ISSHROW, SOURCEMODE, ISCHANGE, TOSIDC,  " +
                "        TOIDSBG, GENERALPUR, ISTHREE, ISTAKEUSER, FEETYPE) " +
                "     Values " +
                "       (v_AskPrMasterId, '2',  " +
                "        TO_DATE('05/16/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), '000081', " +
                "        'DB4407', '曾飛', 'DB4407', 'RMB', '1', '74112',  " +
                "        '2', '5', '0', 'F3223842', '0',  " +
                "        TO_DATE('05/16/2017 09:02:48', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',  " +
                "        TO_DATE('05/16/2017 09:12:18', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',  " +
                "        TO_DATE('05/16/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', '3', 'LH', 'N', 'Y',  " +
                "        'N', 'N', '1', 'N', 'N',  " +
                "        'N', 'N', 'N', 'Y', '1'); " +
                "         " +

                "    Insert into EXPENSECTL.ASK_PRDETAIL " +
                "       (BILLNO, ITEM, POBILLNO, POITEM, PARTNUMBER,  " +
                "        PNAME, BRAND, SPEC, UNITCODE, PRICE,  " +
                "        ASKQTY, CURRQTY, ACCCODE, REQUESTDATE, CASEITEM,  " +
                "        VENCODE, SPAREBUDGET, SUMCHKQTY, ACCEPTQTY, SUMTAKEQTY,  " +
                "        RETURNQTY, TOPO, LOWFLAG, ISTHREE, BACKTAX,  " +
                "        JUDGEFLAG, FINALQTY, ISINVALID, LASTDATE) " +
                "     Values " +
                "       (v_AskPrDetailId, 1, v_BuyPoMasterId, 1, '1616005-0010058',  " +
                "        '間隙片/矽鋼片/泊片', 'H+S', 'L5000*W50*T0.02mm', '盒', 255,  " +
                "        1, 0, '21', TO_DATE('05/23/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 0,  " +
                "        'VCN0018965', 0, 1, 0, 1,  " +
                "        0, 'Y', 'N', 'N', 'N',  " +
                "        'N', 0, 'N', TO_DATE('05/16/2017 10:30:39', 'MM/DD/YYYY HH24:MI:SS')); " +
                " " +
                "    Insert into EXPENSECTL.ASK_PRDETAIL " +
                "       (BILLNO, ITEM, POBILLNO, POITEM, PARTNUMBER,  " +
                "        PNAME, BRAND, SPEC, UNITCODE, PRICE,  " +
                "        ASKQTY, CURRQTY, ACCCODE, REQUESTDATE, CASEITEM,  " +
                "        VENCODE, SPAREBUDGET, SUMCHKQTY, ACCEPTQTY, SUMTAKEQTY,  " +
                "        RETURNQTY, TOPO, LOWFLAG, ISTHREE, BACKTAX,  " +
                "        JUDGEFLAG, FINALQTY, ISINVALID, LASTDATE) " +
                "     Values " +
                "       (v_AskPrDetailId, 2, v_BuyPoMasterId, 2, '0207004-0140020',  " +
                "        '調速接頭', '氣立可/CHELIC', 'QSC10-02', '個', 23.3,  " +
                "        1, 0, '21', TO_DATE('05/23/2016 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 0,  " +
                "        'VCN0015486', 0, 1, 0, 1,  " +
                "        0, 'Y', 'N', 'N', 'N',  " +
                "        'N', 0, 'N', TO_DATE('05/16/2016 10:40:35', 'MM/DD/YYYY HH24:MI:SS')); " +
                "             " +
                "     /* Process 2.1 Po Master table */ " +
                "     Insert into EXPENSECTL.BUY_POMASTER " +
                "       (BILLNO, BILLTYPE, PURDATE, COMPANYID, PURDEPT,  " +
                "        VENCODE, PAYTYPE, TAXTYPE, TAXRATE, WARECODE,  " +
                "        BASECURRCODE, CURRRATE, ISTHREE, SIGNTYPE, PHONE,  " +
                "        FLAG, CREATEUSER, CREATEDATE, LOCKUSER, LOCKDATE,  " +
                "        CLOSEUSER, CLOSEDATE, ISSTOP, SIGNFLAG, AREACODE,  " +
                "        FIXFLAG, ISSHROW, ISADDTAX, KINDID, ACCEPTFLAG,  " +
                "        TOIDSBG, PAYKIND, BIDCODE, ISCHANGE, BANKTYPE,  " +
                "        VTAXRATE) " +
                "     Values " +
                "       (v_BuyPoMasterId, '2',  " +
                "        TO_DATE('05/16/2017 09:37:40', 'MM/DD/YYYY HH24:MI:SS'), " +
                "        '000081', 'DB4407',  " +
                "        'VCN0015486', 'M0909', 'G009', 17, 'LH05',  " +
                "        'RMB', 1, 'N', '2', '74112',  " +
                "        '5', 'F3223842', " +
                "        TO_DATE('05/16/2017 09:37:40', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 09:48:15', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:50:11', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', '3', 'LH',  " +
                "        'N', 'N', 'N', ' ', 'N',  " +
                "        'N', '1', 'G', 'N', 'RMB2',  " +
                "        0);   " +
                "         " +

                "    Insert into EXPENSECTL.BUY_PODETAIL " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, PRICE, BASEPRICE, ORIGIPRICE,  " +
                "        QTY, GATHERQTY, DELIVERYDATE, ORIGINPLACE, APPLYQTY,  " +
                "        SUBTAXRATE, RETURNFLAG, TAXPRICE) " +
                "     Values " +
                "       (v_BuyPoDetailId, 1, '0207004-0140020', '調速接頭', '氣立可/CHELIC',  " +
                "        'QSC10-02', '個', 23.3, 23.3, 0,  " +
                "        1, 1, TO_DATE('05/30/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), " +
                "        '中國', 0, 0, 'N', 27.261); " +
                "             " +
                "    Insert into EXPENSECTL.BUY_PODETAIL " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, PRICE, BASEPRICE, ORIGIPRICE,  " +
                "        QTY, GATHERQTY, DELIVERYDATE, ORIGINPLACE, APPLYQTY,  " +
                "        SUBTAXRATE, RETURNFLAG, TAXPRICE) " +
                "     Values " +
                "       (v_BuyPoDetailId, 2, '1616005-0010058', '間隙片/矽鋼片/泊片', 'H+S',  " +
                "        'L5000*W50*T0.02mm', '盒', 255, 255, 0,  " +
                "        1, 1, TO_DATE('05/30/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), " +
                "        '德國', 0, 0, 'N', 262.65);                    " +
                "         " +

                "    Insert into EXPENSECTL.CHK_ACPMASTER " +
                "       (BILLNO, POBILLNO, WARECODE, FLAG, CREATEUSER,  " +
                "        CREATEDATE, CONFIRMUSER, CONFIRMDATE, CHECKUSER, CHECKDATE,  " +
                "        ISSHROW, TOIDSBG, MATERIALCHKFLAG, ISCHANGE) " +
                "     Values " +
                "       (v_ChkAcpMasterId, v_BuyPoMasterId, 'LH05', '3', 'F3223842',  " +
                "        TO_DATE('05/16/2017 10:08:06', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:40:35', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:40:35', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', 'N', 'N', 'N'); " +
                "         " +

                "    Insert into EXPENSECTL.CHK_ACPDETAIL " +
                "       (BILLNO, ITEM, POITEM, PARTNUMBER, PNAME,  " +
                "        BRAND, SPEC, UNITCODE, PRICE, QTY,  " +
                "        REFUSEQTY, SUMRGQTY) " +
                "     Values " +
                "       (v_ChkAcpDetailId, 1, 1, '0207004-0140020', '調速接頭',  " +
                "        '氣立可/CHELIC', 'QSC10-02', '個', 23.3, 1,  " +
                "        0, 0); " +
                "             " +
                "    Insert into EXPENSECTL.CHK_ACPDETAIL " +
                "       (BILLNO, ITEM, POITEM, PARTNUMBER, PNAME,  " +
                "        BRAND, SPEC, UNITCODE, PRICE, QTY,  " +
                "        REFUSEQTY, SUMRGQTY) " +
                "     Values " +
                "       (v_ChkAcpDetailId, 2, 2, '1616005-0010058', '間隙片/矽鋼片/泊片',  " +
                "        'H+S', 'L5000*W50*T0.02mm', '盒', 255, 1,  " +
                "        0, 0); " +
                "         " +

                "    Insert into EXPENSECTL.CHK_ASKREC " +
                "       (CHKBILLNO, CHKBILLITEM, ASKBILLNO, ASKITEM, QTY) " +
                "     Values " +
                "       (v_ChkAskrecId, 1, '1CEN-H50001', 1, 1); " +
                "            " +
                "    Insert into EXPENSECTL.CHK_ASKREC " +
                "       (CHKBILLNO, CHKBILLITEM, ASKBILLNO, ASKITEM, QTY) " +
                "     Values " +
                "       (v_ChkAskrecId, 2, '1CEN-H50001', 2, 1); " +
                "         " +

                "    Insert into EXPENSECTL.TKM_TAKEMASTER " +
                "       (BILLNO, BILLTYPE, PRBILLNO, VENCODE, POBILLNO,  " +
                "        WARECODE, TAKEDEPT, SIGNTYPE, FLAG, CREATEUSER,  " +
                "        CREATEDATE, CONFIRMUSER, CONFIRMDATE, CHECKUSER, CHECKDATE,  " +
                "        CATCHFLAG, ISSHROW, TOVMI, TOVENDOR, INPUTTAX,  " +
                "        TOIDSBG, CATCHDATETIME, ISCHANGE, TOTIPTOP, LASTDATE,  " +
                "        TOFN) " +
                "     Values " +
                "       (v_TkmTakeMasterId, '2',  " +
                "        v_AskPrMasterId, 'VCN0015486', " +
                "        v_BuyPoMasterId,  " +
                "        'LH05', 'DB4407', '1', '3', 'F3223842',  " +
                "        TO_DATE('05/16/2017 10:43:14', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:49:35', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:49:38', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', 'N', 'N', 'N', 'N', 'N', " +
                "        TO_DATE('01/01/2010 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 'N', 'N', " +
                "        TO_DATE('05/16/2017 11:00:33', 'MM/DD/YYYY HH24:MI:SS'), 'N'); " +
                "         " +

                "    Insert into EXPENSECTL.tkm_takeDetail " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, QTY, PRITEM, BACKTAX, JUDGEFLAG) " +
                "     Values " +
                "       (v_TkmTakeDetialId, 1, '0207004-0140020', '調速接頭', '氣立可/CHELIC',  " +
                "        'QSC10-02', '個', 1, 1, 'N', 'N'); " +
                "    Insert into EXPENSECTL.tkm_takeDetail " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, QTY, PRITEM, BACKTAX, JUDGEFLAG) " +
                "     Values " +
                "       (v_TkmTakeDetialId, 2, '1616005-0010058', '間隙片/矽鋼片/泊片', 'H+S',  " +
                "        'L5000*W50*T0.02mm', '盒', 1, 2, 'N', 'N'); " +
                "         " +

                "    COMMIT; " +
                "END; ", number.ToString());

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                using (OleDbTransaction tran = conn.BeginTransaction())
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteScalar();
                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        return false;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 依据编号生成待审核的结报单
        /// </summary>
        /// <param name="number">结报单编号</param>
        /// <returns>成功标志</returns>
        public static bool GenerateData(int number, string prefix, string month)
        {
            string sql = string.Format(
                "DECLARE " +
                "  v_Counter       NUMBER := {0}; " +
                "   " +
                "  /* 用于存储动态的各阶段的ID */ " +
                "  v_AskPrMasterId   VARCHAR2(20);" +
                "  v_AskPrDetailId   VARCHAR2(20);" +
                "  v_BuyPoMasterId   VARCHAR2(20);" +
                "  v_BuyPoDetailId   VARCHAR2(20);" +
                "  v_ChkAcpMasterId  VARCHAR2(20);" +
                "  v_ChkAcpDetailId  VARCHAR2(20);" +
                "  v_ChkAskrecId     VARCHAR2(20);" +
                "  v_TkmTakeMasterId VARCHAR2(20);" +
                "  v_TkmTakeDetialId VARCHAR2(20);" +
                "  v_Prefix          VARCHAR2(20);" +
                "BEGIN         " +
                "    IF v_Counter < 10 THEN " +
                "        v_Prefix := '000' || v_Counter; " +
                "    END IF; " +
                "         " +
                "    IF v_Counter >= 10 AND v_Counter < 100 THEN " +
                "        v_Prefix := '00' || v_Counter; " +
                "    END IF;  " +
                "         " +
                "    IF v_Counter >= 100 AND v_Counter < 1000 THEN " +
                "        v_Prefix := '0' || v_Counter; " +
                "    END IF; " +
                "         " +
                "    IF v_Counter >= 1000 AND v_Counter < 10000 THEN " +
                "        v_Prefix := '' || v_Counter; " +
                "    END IF;    " +
                "         " +
                "    /* Process prefix */ " +
                "    v_AskPrMasterId   := '1CEN-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_AskPrDetailId   := '1CEN-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_BuyPoMasterId   := '2CEN-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_BuyPoDetailId   := '2CEN-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_ChkAcpMasterId  := '3INE-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_ChkAcpDetailId  := '3INE-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_ChkAskrecId     := '3INE-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_TkmTakeMasterId := '4CEN-{1}{2}' || TO_CHAR(v_Prefix);" +
                "    v_TkmTakeDetialId := '4CEN-{1}{2}' || TO_CHAR(v_Prefix);" +
                "                        " +
                "    Insert into EXPENSECTL.ASK_PRMASTER " +
                "       (BILLNO, BILLTYPE, ASKDATE, COMPANYID, ASKDEPT,  " +
                "        ASKUSER, PURDEPT, CURRCODE, BUDGETTYPE, ASKPHONE,  " +
                "        SIGNTYPE, FLAG, FIRSTCATCH, CREATEUSER, SECONDCATCH,  " +
                "        CREATEDATE, CONFIRMUSER, CONFIRMDATE, LOCKUSER, LOCKDATE,  " +
                "        ISLAWLOCK, SIGNFLAG, AREACODE, ISEQUIP, ISLOWCHECK,  " +
                "        FIXFLAG, ISSHROW, SOURCEMODE, ISCHANGE, TOSIDC,  " +
                "        TOIDSBG, GENERALPUR, ISTHREE, ISTAKEUSER, FEETYPE) " +
                "     Values " +
                "       (v_AskPrMasterId, '2',  " +
                "        TO_DATE('05/16/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), '000081', " +
                "        'DB4407', '曾飛', 'DB4407', 'RMB', '1', '74112',  " +
                "        '2', '5', '0', 'F3223842', '0',  " +
                "        TO_DATE('05/16/2017 09:02:48', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',  " +
                "        TO_DATE('05/16/2017 09:12:18', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',  " +
                "        TO_DATE('05/16/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', '3', 'LH', 'N', 'Y',  " +
                "        'N', 'N', '1', 'N', 'N',  " +
                "        'N', 'N', 'N', 'Y', '1'); " +
                "         " +

                "    Insert into EXPENSECTL.ASK_PRDETAIL " +
                "       (BILLNO, ITEM, POBILLNO, POITEM, PARTNUMBER,  " +
                "        PNAME, BRAND, SPEC, UNITCODE, PRICE,  " +
                "        ASKQTY, CURRQTY, ACCCODE, REQUESTDATE, CASEITEM,  " +
                "        VENCODE, SPAREBUDGET, SUMCHKQTY, ACCEPTQTY, SUMTAKEQTY,  " +
                "        RETURNQTY, TOPO, LOWFLAG, ISTHREE, BACKTAX,  " +
                "        JUDGEFLAG, FINALQTY, ISINVALID, LASTDATE) " +
                "     Values " +
                "       (v_AskPrDetailId, 1, v_BuyPoMasterId, 1, '1616005-0010058',  " +
                "        '間隙片/矽鋼片/泊片', 'H+S', 'L5000*W50*T0.02mm', '盒', 255,  " +
                "        1, 0, '21', TO_DATE('05/23/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 0,  " +
                "        'VCN0018965', 0, 1, 0, 1,  " +
                "        0, 'Y', 'N', 'N', 'N',  " +
                "        'N', 0, 'N', TO_DATE('05/16/2017 10:30:39', 'MM/DD/YYYY HH24:MI:SS')); " +
                " " +
                "    Insert into EXPENSECTL.ASK_PRDETAIL " +
                "       (BILLNO, ITEM, POBILLNO, POITEM, PARTNUMBER,  " +
                "        PNAME, BRAND, SPEC, UNITCODE, PRICE,  " +
                "        ASKQTY, CURRQTY, ACCCODE, REQUESTDATE, CASEITEM,  " +
                "        VENCODE, SPAREBUDGET, SUMCHKQTY, ACCEPTQTY, SUMTAKEQTY,  " +
                "        RETURNQTY, TOPO, LOWFLAG, ISTHREE, BACKTAX,  " +
                "        JUDGEFLAG, FINALQTY, ISINVALID, LASTDATE) " +
                "     Values " +
                "       (v_AskPrDetailId, 2, v_BuyPoMasterId, 2, '0207004-0140020',  " +
                "        '調速接頭', '氣立可/CHELIC', 'QSC10-02', '個', 23.3,  " +
                "        1, 0, '21', TO_DATE('05/23/2016 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 0,  " +
                "        'VCN0015486', 0, 1, 0, 1,  " +
                "        0, 'Y', 'N', 'N', 'N',  " +
                "        'N', 0, 'N', TO_DATE('05/16/2016 10:40:35', 'MM/DD/YYYY HH24:MI:SS')); " +
                "             " +
                "     /* Process 2.1 Po Master table */ " +
                "     Insert into EXPENSECTL.BUY_POMASTER " +
                "       (BILLNO, BILLTYPE, PURDATE, COMPANYID, PURDEPT,  " +
                "        VENCODE, PAYTYPE, TAXTYPE, TAXRATE, WARECODE,  " +
                "        BASECURRCODE, CURRRATE, ISTHREE, SIGNTYPE, PHONE,  " +
                "        FLAG, CREATEUSER, CREATEDATE, LOCKUSER, LOCKDATE,  " +
                "        CLOSEUSER, CLOSEDATE, ISSTOP, SIGNFLAG, AREACODE,  " +
                "        FIXFLAG, ISSHROW, ISADDTAX, KINDID, ACCEPTFLAG,  " +
                "        TOIDSBG, PAYKIND, BIDCODE, ISCHANGE, BANKTYPE,  " +
                "        VTAXRATE) " +
                "     Values " +
                "       (v_BuyPoMasterId, '2',  " +
                "        TO_DATE('05/16/2017 09:37:40', 'MM/DD/YYYY HH24:MI:SS'), " +
                "        '000081', 'DB4407',  " +
                "        'VCN0015486', 'M0909', 'G009', 17, 'LH05',  " +
                "        'RMB', 1, 'N', '2', '74112',  " +
                "        '5', 'F3223842', " +
                "        TO_DATE('05/16/2017 09:37:40', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 09:48:15', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:50:11', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', '3', 'LH',  " +
                "        'N', 'N', 'N', ' ', 'N',  " +
                "        'N', '1', 'G', 'N', 'RMB2',  " +
                "        0);   " +
                "         " +

                "    Insert into EXPENSECTL.BUY_PODETAIL " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, PRICE, BASEPRICE, ORIGIPRICE,  " +
                "        QTY, GATHERQTY, DELIVERYDATE, ORIGINPLACE, APPLYQTY,  " +
                "        SUBTAXRATE, RETURNFLAG, TAXPRICE) " +
                "     Values " +
                "       (v_BuyPoDetailId, 1, '0207004-0140020', '調速接頭', '氣立可/CHELIC',  " +
                "        'QSC10-02', '個', 23.3, 23.3, 0,  " +
                "        1, 1, TO_DATE('05/30/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), " +
                "        '中國', 0, 0, 'N', 27.261); " +
                "             " +
                "    Insert into EXPENSECTL.BUY_PODETAIL " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, PRICE, BASEPRICE, ORIGIPRICE,  " +
                "        QTY, GATHERQTY, DELIVERYDATE, ORIGINPLACE, APPLYQTY,  " +
                "        SUBTAXRATE, RETURNFLAG, TAXPRICE) " +
                "     Values " +
                "       (v_BuyPoDetailId, 2, '1616005-0010058', '間隙片/矽鋼片/泊片', 'H+S',  " +
                "        'L5000*W50*T0.02mm', '盒', 255, 255, 0,  " +
                "        1, 1, TO_DATE('05/30/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), " +
                "        '德國', 0, 0, 'N', 262.65);                    " +
                "         " +

                "    Insert into EXPENSECTL.CHK_ACPMASTER " +
                "       (BILLNO, POBILLNO, WARECODE, FLAG, CREATEUSER,  " +
                "        CREATEDATE, CONFIRMUSER, CONFIRMDATE, CHECKUSER, CHECKDATE,  " +
                "        ISSHROW, TOIDSBG, MATERIALCHKFLAG, ISCHANGE) " +
                "     Values " +
                "       (v_ChkAcpMasterId, v_BuyPoMasterId, 'LH05', '3', 'F3223842',  " +
                "        TO_DATE('05/16/2017 10:08:06', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:40:35', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:40:35', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', 'N', 'N', 'N'); " +
                "         " +

                "    Insert into EXPENSECTL.CHK_ACPDETAIL " +
                "       (BILLNO, ITEM, POITEM, PARTNUMBER, PNAME,  " +
                "        BRAND, SPEC, UNITCODE, PRICE, QTY,  " +
                "        REFUSEQTY, SUMRGQTY) " +
                "     Values " +
                "       (v_ChkAcpDetailId, 1, 1, '0207004-0140020', '調速接頭',  " +
                "        '氣立可/CHELIC', 'QSC10-02', '個', 23.3, 1,  " +
                "        0, 0); " +
                "             " +
                "    Insert into EXPENSECTL.CHK_ACPDETAIL " +
                "       (BILLNO, ITEM, POITEM, PARTNUMBER, PNAME,  " +
                "        BRAND, SPEC, UNITCODE, PRICE, QTY,  " +
                "        REFUSEQTY, SUMRGQTY) " +
                "     Values " +
                "       (v_ChkAcpDetailId, 2, 2, '1616005-0010058', '間隙片/矽鋼片/泊片',  " +
                "        'H+S', 'L5000*W50*T0.02mm', '盒', 255, 1,  " +
                "        0, 0); " +
                "         " +

                "    Insert into EXPENSECTL.CHK_ASKREC " +
                "       (CHKBILLNO, CHKBILLITEM, ASKBILLNO, ASKITEM, QTY) " +
                "     Values " +
                "       (v_ChkAskrecId, 1, '1CEN-H50001', 1, 1); " +
                "            " +
                "    Insert into EXPENSECTL.CHK_ASKREC " +
                "       (CHKBILLNO, CHKBILLITEM, ASKBILLNO, ASKITEM, QTY) " +
                "     Values " +
                "       (v_ChkAskrecId, 2, '1CEN-H50001', 2, 1); " +
                "         " +

                "    Insert into EXPENSECTL.TKM_TAKEMASTER " +
                "       (BILLNO, BILLTYPE, PRBILLNO, VENCODE, POBILLNO,  " +
                "        WARECODE, TAKEDEPT, SIGNTYPE, FLAG, CREATEUSER,  " +
                "        CREATEDATE, CONFIRMUSER, CONFIRMDATE, CHECKUSER, CHECKDATE,  " +
                "        CATCHFLAG, ISSHROW, TOVMI, TOVENDOR, INPUTTAX,  " +
                "        TOIDSBG, CATCHDATETIME, ISCHANGE, TOTIPTOP, LASTDATE,  " +
                "        TOFN) " +
                "     Values " +
                "       (v_TkmTakeMasterId, '2',  " +
                "        v_AskPrMasterId, 'VCN0015486', " +
                "        v_BuyPoMasterId,  " +
                "        'LH05', 'DB4407', '1', '3', 'F3223842',  " +
                "        TO_DATE('05/16/2017 10:43:14', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:49:35', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', " +
                "        TO_DATE('05/16/2017 10:49:38', 'MM/DD/YYYY HH24:MI:SS'),  " +
                "        'N', 'N', 'N', 'N', 'N', 'N', " +
                "        TO_DATE('01/01/2010 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 'N', 'N', " +
                "        TO_DATE('05/16/2017 11:00:33', 'MM/DD/YYYY HH24:MI:SS'), 'N'); " +
                "         " +

                "    Insert into EXPENSECTL.tkm_takeDetail " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, QTY, PRITEM, BACKTAX, JUDGEFLAG) " +
                "     Values " +
                "       (v_TkmTakeDetialId, 1, '0207004-0140020', '調速接頭', '氣立可/CHELIC',  " +
                "        'QSC10-02', '個', 1, 1, 'N', 'N'); " +
                "    Insert into EXPENSECTL.tkm_takeDetail " +
                "       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND,  " +
                "        SPEC, UNITCODE, QTY, PRITEM, BACKTAX, JUDGEFLAG) " +
                "     Values " +
                "       (v_TkmTakeDetialId, 2, '1616005-0010058', '間隙片/矽鋼片/泊片', 'H+S',  " +
                "        'L5000*W50*T0.02mm', '盒', 1, 2, 'N', 'N'); " +
                "         " +

                "    COMMIT; " +
                "END; ", number.ToString(), prefix, month);

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                using (OleDbTransaction tran = conn.BeginTransaction())
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteScalar();
                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        return false;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 批量删除测试数据
        /// </summary>
        public static void DeleteData()
        {
            // 列举所有的组合
            List<string> sqls = new List<string>();
            foreach (var prefix in ECStaicVar.Prefix)
            {
                foreach (var month in ECStaicVar.Month)
                {
                    var prmaster = string.Format("DELETE FROM EXPENSECTL.ASK_PRMASTER WHERE billno LIKE '1CEN-{0}{1}%'", prefix, month);
                    var prdetail = string.Format("DELETE FROM EXPENSECTL.ASK_PRDETAIL WHERE billno LIKE '1CEN-{0}{1}%'", prefix, month);
                    sqls.Add(prmaster);
                    sqls.Add(prdetail);

                    var pomaster = string.Format("DELETE FROM EXPENSECTL.BUY_POMASTER WHERE billno LIKE '2CEN-{0}{1}%'", prefix, month);
                    var podetail = string.Format("DELETE FROM EXPENSECTL.BUY_PODETAIL WHERE billno LIKE '2CEN-{0}{1}%'", prefix, month);
                    sqls.Add(pomaster);
                    sqls.Add(podetail);

                    var acmaster = string.Format("DELETE FROM EXPENSECTL.CHK_ACPMASTER WHERE billno LIKE '3INE-{0}{1}%'", prefix, month);
                    var acdetail = string.Format("DELETE FROM EXPENSECTL.CHK_ACPDETAIL WHERE billno LIKE '3INE-{0}{1}%'", prefix, month);
                    var askrec = string.Format("DELETE FROM EXPENSECTL.CHK_ASKREC WHERE chkbillno LIKE '3INE-{0}{1}%'", prefix, month);
                    sqls.Add(acmaster);
                    sqls.Add(acdetail);
                    sqls.Add(askrec);

                    var tkmaster = string.Format("DELETE FROM EXPENSECTL.TKM_TAKEMASTER WHERE billno LIKE '4CEN-{0}{1}%'", prefix, month);
                    var tkdetail = string.Format("DELETE FROM EXPENSECTL.tkm_takeDetail WHERE billno LIKE '4CEN-{0}{1}%'", prefix, month);
                    sqls.Add(tkmaster);
                    sqls.Add(tkdetail);
                }
            }

            foreach (var sql in sqls)
                DeleteDataBySql(sql);
        }

        /// <summary>
        /// 按SQL语句删除测试数据
        /// </summary>
        /// <returns>成功标志</returns>
        public static bool DeleteDataBySql(string sql)
        {
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connStr))
                {
                    connection.Open();
                    oledbAdapter.DeleteCommand = connection.CreateCommand();
                    oledbAdapter.DeleteCommand.CommandText = sql;
                    oledbAdapter.DeleteCommand.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// 消耗CPU的查询
        /// </summary>
        /// <returns>成功标志</returns>
        public static bool ExecuteMoreCPUQuery()
        {
            string sql = "select * from v$process where background is null;";

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                using (OleDbTransaction tran = conn.BeginTransaction())
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        return false;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 大查询
        /// </summary>
        /// <returns>成功标志</returns>
        public static bool ExecuteBigQuery()
        {
            string sql = "SELECT * FROM BUY_POMASTER;";

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                using (OleDbTransaction tran = conn.BeginTransaction())
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        return false;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
        }
    }
}
