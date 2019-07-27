DECLARE
  v_v_Counter       NUMBER := {0}
  
  /* 用于存储动态的各阶段的ID */
  v_AskPrMasterId   VARCHAR2(20);               -- 请购单ID (单头)
  v_AskPrDetailId   VARCHAR2(20);               -- 请购单ID (单身)
  v_BuyPoMasterId   VARCHAR2(20);               -- 采购单ID (单头)
  v_BuyPoDetailId   VARCHAR2(20);               -- 采购单ID (单身)
  v_ChkAcpMasterId  VARCHAR2(20);               -- 验收单ID (单头)
  v_ChkAcpDetailId  VARCHAR2(20);               -- 验收单ID (单身)
  v_ChkAskrecId     VARCHAR2(20);               -- 验收单查检ID
  v_TkmTakeMasterId VARCHAR2(20);               -- 领用单ID (单头)
  v_TkmTakeDetialId VARCHAR2(20);               -- 领用单ID (单身)
  v_Prefix          VARCHAR2(20);                -- 前缀
BEGIN        
    /* process phase ID (prefix etc) */              
    IF v_Counter < 10 THEN
        v_Prefix := '000' || v_Counter;
    END IF;
        
    IF v_Counter >= 10 AND v_Counter < 100 THEN
        v_Prefix := '00' || v_Counter;
    END IF; 
        
    IF v_Counter >= 100 AND v_Counter < 1000 THEN
        v_Prefix := '0' || v_Counter;
    END IF;
        
    IF v_Counter >= 1000 AND v_Counter < 10000 THEN
        v_Prefix := '' || v_Counter;
    END IF;   
        
    /* Process prefix */
    v_AskPrMasterId   := '1CEN-H5' || TO_CHAR(v_Prefix); -- 请购单ID (单头)
    v_AskPrDetailId   := '1CEN-H5' || TO_CHAR(v_Prefix); -- 请购单ID (单身)
    v_BuyPoMasterId   := '2CEN-H5' || TO_CHAR(v_Prefix); -- 采购单ID (单头)
    v_BuyPoDetailId   := '2CEN-H5' || TO_CHAR(v_Prefix); -- 采购单ID (单身)
    v_ChkAcpMasterId  := '3INE-H5' || TO_CHAR(v_Prefix); -- 验收单ID (单头)
    v_ChkAcpDetailId  := '3INE-H5' || TO_CHAR(v_Prefix); -- 验收单ID (单身)
    v_ChkAskrecId     := '3INE-H5' || TO_CHAR(v_Prefix); -- 验收单查检ID
    v_TkmTakeMasterId := '4CEN-H5' || TO_CHAR(v_Prefix); -- 领用单ID (单头)
    v_TkmTakeDetialId := '4CEN-H5' || TO_CHAR(v_Prefix); -- 领用单ID (单身)
                       
    /* Process 1.1 - Insert Pr master table */
    Insert into EXPENSECTL.ASK_PRMASTER
       (BILLNO, BILLTYPE, ASKDATE, COMPANYID, ASKDEPT, 
        ASKUSER, PURDEPT, CURRCODE, BUDGETTYPE, ASKPHONE, 
        SIGNTYPE, FLAG, FIRSTCATCH, CREATEUSER, SECONDCATCH, 
        CREATEDATE, CONFIRMUSER, CONFIRMDATE, LOCKUSER, LOCKDATE, 
        ISLAWLOCK, SIGNFLAG, AREACODE, ISEQUIP, ISLOWCHECK, 
        FIXFLAG, ISSHROW, SOURCEMODE, ISCHANGE, TOSIDC, 
        TOIDSBG, GENERALPUR, ISTHREE, ISTAKEUSER, FEETYPE)
     Values
       (v_AskPrMasterId, '2', 
        TO_DATE('05/16/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), '000081',
        'DB4407', '曾飛', 'DB4407', 'RMB', '1', '74112', 
        '2', '5', '0', 'F3223842', '0', 
        TO_DATE('05/16/2017 09:02:48', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', 
        TO_DATE('05/16/2017 09:12:18', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842', 
        TO_DATE('05/16/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 
        'N', '3', 'LH', 'N', 'Y', 
        'N', 'N', '1', 'N', 'N', 
        'N', 'N', 'N', 'Y', '1');
        
    /* Insert 1.2 Pr Detail table */
    Insert into EXPENSECTL.ASK_PRDETAIL
       (BILLNO, ITEM, POBILLNO, POITEM, PARTNUMBER, 
        PNAME, BRAND, SPEC, UNITCODE, PRICE, 
        ASKQTY, CURRQTY, ACCCODE, REQUESTDATE, CASEITEM, 
        VENCODE, SPAREBUDGET, SUMCHKQTY, ACCEPTQTY, SUMTAKEQTY, 
        RETURNQTY, TOPO, LOWFLAG, ISTHREE, BACKTAX, 
        JUDGEFLAG, FINALQTY, ISINVALID, LASTDATE)
     Values
       (v_AskPrDetailId, 1, v_BuyPoMasterId, 1, '1616005-0010058', 
        '間隙片/矽鋼片/泊片', 'H+S', 'L5000*W50*T0.02mm', '盒', 255, 
        1, 0, '21', TO_DATE('05/23/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 0, 
        'VCN0018965', 0, 1, 0, 1, 
        0, 'Y', 'N', 'N', 'N', 
        'N', 0, 'N', TO_DATE('05/16/2017 10:30:39', 'MM/DD/YYYY HH24:MI:SS'));

    Insert into EXPENSECTL.ASK_PRDETAIL
       (BILLNO, ITEM, POBILLNO, POITEM, PARTNUMBER, 
        PNAME, BRAND, SPEC, UNITCODE, PRICE, 
        ASKQTY, CURRQTY, ACCCODE, REQUESTDATE, CASEITEM, 
        VENCODE, SPAREBUDGET, SUMCHKQTY, ACCEPTQTY, SUMTAKEQTY, 
        RETURNQTY, TOPO, LOWFLAG, ISTHREE, BACKTAX, 
        JUDGEFLAG, FINALQTY, ISINVALID, LASTDATE)
     Values
       (v_AskPrDetailId, 2, v_BuyPoMasterId, 2, '0207004-0140020', 
        '調速接頭', '氣立可/CHELIC', 'QSC10-02', '個', 23.3, 
        1, 0, '21', TO_DATE('05/23/2016 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 0, 
        'VCN0015486', 0, 1, 0, 1, 
        0, 'Y', 'N', 'N', 'N', 
        'N', 0, 'N', TO_DATE('05/16/2016 10:40:35', 'MM/DD/YYYY HH24:MI:SS'));
            
     /* Process 2.1 Po Master table */
     Insert into EXPENSECTL.BUY_POMASTER
       (BILLNO, BILLTYPE, PURDATE, COMPANYID, PURDEPT, 
        VENCODE, PAYTYPE, TAXTYPE, TAXRATE, WARECODE, 
        BASECURRCODE, CURRRATE, ISTHREE, SIGNTYPE, PHONE, 
        FLAG, CREATEUSER, CREATEDATE, LOCKUSER, LOCKDATE, 
        CLOSEUSER, CLOSEDATE, ISSTOP, SIGNFLAG, AREACODE, 
        FIXFLAG, ISSHROW, ISADDTAX, KINDID, ACCEPTFLAG, 
        TOIDSBG, PAYKIND, BIDCODE, ISCHANGE, BANKTYPE, 
        VTAXRATE)
     Values
       (v_BuyPoMasterId, '2', 
        TO_DATE('05/16/2017 09:37:40', 'MM/DD/YYYY HH24:MI:SS'),
        '000081', 'DB4407', 
        'VCN0015486', 'M0909', 'G009', 17, 'LH05', 
        'RMB', 1, 'N', '2', '74112', 
        '5', 'F3223842',
        TO_DATE('05/16/2017 09:37:40', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',
        TO_DATE('05/16/2017 09:48:15', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',
        TO_DATE('05/16/2017 10:50:11', 'MM/DD/YYYY HH24:MI:SS'), 
        'N', '3', 'LH', 
        'N', 'N', 'N', ' ', 'N', 
        'N', '1', 'G', 'N', 'RMB2', 
        0);  
        
    /* Process 2.2 Po Detail table */
    Insert into EXPENSECTL.BUY_PODETAIL
       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND, 
        SPEC, UNITCODE, PRICE, BASEPRICE, ORIGIPRICE, 
        QTY, GATHERQTY, DELIVERYDATE, ORIGINPLACE, APPLYQTY, 
        SUBTAXRATE, RETURNFLAG, TAXPRICE)
     Values
       (v_BuyPoDetailId, 1, '0207004-0140020', '調速接頭', '氣立可/CHELIC', 
        'QSC10-02', '個', 23.3, 23.3, 0, 
        1, 1, TO_DATE('05/30/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'),
        '中國', 0, 0, 'N', 27.261);
            
    Insert into EXPENSECTL.BUY_PODETAIL
       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND, 
        SPEC, UNITCODE, PRICE, BASEPRICE, ORIGIPRICE, 
        QTY, GATHERQTY, DELIVERYDATE, ORIGINPLACE, APPLYQTY, 
        SUBTAXRATE, RETURNFLAG, TAXPRICE)
     Values
       (v_BuyPoDetailId, 2, '1616005-0010058', '間隙片/矽鋼片/泊片', 'H+S', 
        'L5000*W50*T0.02mm', '盒', 255, 255, 0, 
        1, 1, TO_DATE('05/30/2017 00:00:00', 'MM/DD/YYYY HH24:MI:SS'),
        '德國', 0, 0, 'N', 262.65);                   
        
    /* Process 3.1 Check Master table */
    Insert into EXPENSECTL.CHK_ACPMASTER
       (BILLNO, POBILLNO, WARECODE, FLAG, CREATEUSER, 
        CREATEDATE, CONFIRMUSER, CONFIRMDATE, CHECKUSER, CHECKDATE, 
        ISSHROW, TOIDSBG, MATERIALCHKFLAG, ISCHANGE)
     Values
       (v_ChkAcpMasterId, v_BuyPoMasterId, 'LH05', '3', 'F3223842', 
        TO_DATE('05/16/2017 10:08:06', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',
        TO_DATE('05/16/2017 10:40:35', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',
        TO_DATE('05/16/2017 10:40:35', 'MM/DD/YYYY HH24:MI:SS'), 
        'N', 'N', 'N', 'N');
        
    /* Process 3.2 Check Detail table */
    Insert into EXPENSECTL.CHK_ACPDETAIL
       (BILLNO, ITEM, POITEM, PARTNUMBER, PNAME, 
        BRAND, SPEC, UNITCODE, PRICE, QTY, 
        REFUSEQTY, SUMRGQTY)
     Values
       (v_ChkAcpDetailId, 1, 1, '0207004-0140020', '調速接頭', 
        '氣立可/CHELIC', 'QSC10-02', '個', 23.3, 1, 
        0, 0);
            
    Insert into EXPENSECTL.CHK_ACPDETAIL
       (BILLNO, ITEM, POITEM, PARTNUMBER, PNAME, 
        BRAND, SPEC, UNITCODE, PRICE, QTY, 
        REFUSEQTY, SUMRGQTY)
     Values
       (v_ChkAcpDetailId, 2, 2, '1616005-0010058', '間隙片/矽鋼片/泊片', 
        'H+S', 'L5000*W50*T0.02mm', '盒', 255, 1, 
        0, 0);
        
    /* Process 3.3 Check status table */
    Insert into EXPENSECTL.CHK_ASKREC
       (CHKBILLNO, CHKBILLITEM, ASKBILLNO, ASKITEM, QTY)
     Values
       (v_ChkAskrecId, 1, '1CEN-H50001', 1, 1);
           
    Insert into EXPENSECTL.CHK_ASKREC
       (CHKBILLNO, CHKBILLITEM, ASKBILLNO, ASKITEM, QTY)
     Values
       (v_ChkAskrecId, 2, '1CEN-H50001', 2, 1);
        
    /* Process 4.1 Take Master Table */
    Insert into EXPENSECTL.TKM_TAKEMASTER
       (BILLNO, BILLTYPE, PRBILLNO, VENCODE, POBILLNO, 
        WARECODE, TAKEDEPT, SIGNTYPE, FLAG, CREATEUSER, 
        CREATEDATE, CONFIRMUSER, CONFIRMDATE, CHECKUSER, CHECKDATE, 
        CATCHFLAG, ISSHROW, TOVMI, TOVENDOR, INPUTTAX, 
        TOIDSBG, CATCHDATETIME, ISCHANGE, TOTIPTOP, LASTDATE, 
        TOFN)
     Values
       (v_TkmTakeMasterId, '2', 
        v_AskPrMasterId, 'VCN0015486',
        v_BuyPoMasterId, 
        'LH05', 'DB4407', '1', '3', 'F3223842', 
        TO_DATE('05/16/2017 10:43:14', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',
        TO_DATE('05/16/2017 10:49:35', 'MM/DD/YYYY HH24:MI:SS'), 'F3223842',
        TO_DATE('05/16/2017 10:49:38', 'MM/DD/YYYY HH24:MI:SS'), 
        'N', 'N', 'N', 'N', 'N', 'N',
        TO_DATE('01/01/2010 00:00:00', 'MM/DD/YYYY HH24:MI:SS'), 'N', 'N',
        TO_DATE('05/16/2017 11:00:33', 'MM/DD/YYYY HH24:MI:SS'), 'N');
        
    /* Process 4.2 Take Detail Table */
    Insert into EXPENSECTL.tkm_takeDetail
       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND, 
        SPEC, UNITCODE, QTY, PRITEM, BACKTAX, JUDGEFLAG)
     Values
       (v_TkmTakeDetialId, 1, '0207004-0140020', '調速接頭', '氣立可/CHELIC', 
        'QSC10-02', '個', 1, 1, 'N', 'N');
    Insert into EXPENSECTL.tkm_takeDetail
       (BILLNO, ITEM, PARTNUMBER, PNAME, BRAND, 
        SPEC, UNITCODE, QTY, PRITEM, BACKTAX, JUDGEFLAG)
     Values
       (v_TkmTakeDetialId, 2, '1616005-0010058', '間隙片/矽鋼片/泊片', 'H+S', 
        'L5000*W50*T0.02mm', '盒', 1, 2, 'N', 'N');
        
    /* COMMIT */
    COMMIT;
END;
