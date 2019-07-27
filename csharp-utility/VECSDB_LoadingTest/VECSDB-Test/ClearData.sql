/******************************************************************************
 * Filename: cleardata.sql
 * Description: Delete testing data of VECSDB loading test
 * Author: Jedi Chou
 * Date: 2016.5.23 17:38
 * Generate Detail Process : 1->2->3->4
 *   <1>. 删除生成请购单
 *   <2>. 删除生成采购单
 *   <3>. 删除生成验收单
 *   <4>. 删除生成领用单
 *****************************************************************************/

/***************************************************************************
 * clear 1.pr                                                              *
 *   Form Head:   ask_prMaster                                             *
 *   Form Detail: ask_prDetail                                             *
 ***************************************************************************
 * query head:   select * from ASK_PRMASTER where billno = '1CEN-H50001';  *
 * query detail: select * from ASK_PRDETAIL where billno = '1CEN-H50001';  *
 ***************************************************************************/
DELETE FROM ASK_PRMASTER where billno like '1CEN-H5%' or billno like '1CEN-H6%';
DELETE FROM ASK_PRDETAIL where billno like '1CEN-H5%' or billno like '1CEN-H6%';

/***************************************************************************
 * clear 2.po 
 *   Form Head:   buy_poMaster
 *   Form Detail: buy_poDetail
 ***************************************************************************
 * query head:   select * from BUY_POMASTER where billno = '2CEN-H50001';  *
 * query detail: select * from BUY_PODETAIL where billno = '2CEN-H50001';  *
 ***************************************************************************/
DELETE FROM BUY_POMASTER where billno like '2CEN-H5%' or billno like '2CEN-H6%'; 
DELETE FROM BUY_PODETAIL where billno like '2CEN-H5%' or billno like '2CEN-H6%';

/***************************************************************************
 * clear 3.check                                                           *
 *   Form Head:   chk_acpMaster                                            *
 *   Form Detail: chk_acpDetail                                            *
 *   Check Info:  chk_askrec                                               *
 ***************************************************************************
 * query head:   select * from CHK_ACPMASTER where billno = '3INE-H50001'; *
 * query detail: select * from CHK_ACPDETAIL where billno = '3INE-H50001'; *
 * query check:  select * from CHK_ASKREC where chkbillno = '3INE-H50001'; *
 ***************************************************************************/
DELETE FROM CHK_ACPMASTER where billno like '3INE-H5%' or billno like '3INE-H6%';
DELETE FROM CHK_ACPDETAIL where billno like '3INE-H5%' or billno like '3INE-H6%';
DELETE FROM CHK_ASKREC where chkbillno like '3INE-H5%' or chkbillno like '3INE-H6%';

/***************************************************************************
 * clear 4.take                                                            *
 *   Form Head:   tkm_takeMaster                                           *
 *   Form Detail: tkm_takeDetail                                           *
 ***************************************************************************
 * query head:  select * from TKM_TAKEMASTER where billno = '4CEN-H50001'; *
 * query detail:select * from tkm_takeDetail where billno = '4CEN-H50001'; * 
 ***************************************************************************/
DELETE FROM TKM_TAKEMASTER where billno like '4CEN-H5%' or billno like '4CEN-H6%';
DELETE FROM tkm_takeDetail where billno like '4CEN-H5%' or billno like '4CEN-H6%';

COMMIT;
