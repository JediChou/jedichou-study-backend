-- export sql

SET DEFINE OFF;
--SQL Statement which produced this data:
--
--  select * from pay_askmaster where billno = '6CEN-G50329';
--

Insert into EXPENSECTL.PAY_ASKMASTER
   (BILLNO, OVERMODE, COMPANYID, MANAGEDEPT, CURRCODE, 
    VENCODE, PAYCODE, CURRRATE, PHONE, CREATEUSER, 
    CREATEDATE, FLAG, PAYFLAG, COSTFLAG, ISCATCH, 
    TOTIPTOP, ISCASE, ISTHREE, TAXCODE, PAYCASETYPE, 
    TOVMI, ISGAGE, ISCHANGE, BANKTYPE, VTAXRATE)
 Values
   ('6CEN-H50001', '1', '000081', 'DB4407', 'RMB', 
    'VCN0015486', 'M0909', 1, '74112', 'F3223842', 
    TO_DATE('05/30/2016 16:03:18', 'MM/DD/YYYY HH24:MI:SS'), '1', 'N', 'N', 'N', 
    'Y', 'Y', 'N', 'G009', '3', 
    'N', 'N', 'N', 'RMB2', 0);
    
COMMIT;

Insert into EXPENSECTL.PAY_ASKDETAIL
   (BILLNO, ITEM, PAYDESC, PAYDEPT, ACCCODE, 
    ACCOUNTCODE, UNITCODE, AMOUNT, TAXAMOUNT, CUTAMOUNT, 
    CASECODE, ADJUSTAMOUNT, CATCHFLAG)
 Values
   ('6CEN-H50001', 1, '調速接頭等物品一批', 'DB4407', '21', 
    'ZT79', '批', (select sum(baseprice * qty) from buy_podetail where billno in ('2CEN-H50001')), 0, 0, 
    '0', 0, 'N');
    
COMMIT;

update BUY_POMASTER set flag = 6, paybillno = '6CEN-H50001' where billno = '2CEN-H50001';
commit;

