/******************************************************************************
 * Filename: CheckCurrentStatus.sql
 * Description: Check Order Commit Status for loading test
 * Author: Jedi Chou
 * Date: 2016.5.27 11:48
 *****************************************************************************/

SET SERVEROUTPUT ON
DECLARE
  v_Processed NUMBER := 0;  -- 已处理的预结报单数
  v_Untreated NUMBER := 0;  -- 未处理的预结报单数
BEGIN 

    /* 获得已处理的预结报单数 */
    SELECT COUNT(1) INTO v_Processed 
        FROM BUY_POMASTER 
        -- WHERE (billno LIKE '2CEN-H5%' OR billno like '2CEN-H6%') AND flag = 6 ;
        WHERE flag = 6 ;
    
    /* 获得未处理的预结报单数 */    
    SELECT COUNT(1) INTO v_Untreated 
        FROM BUY_POMASTER 
        -- WHERE (billno LIKE '2CEN-H5%' OR billno like '2CEN-H6%') AND flag = 5;
        WHERE flag = 5;
        
    /* 输出 */
    DBMS_OUTPUT.PUT_LINE ('已处理:' || v_Processed );
    DBMS_OUTPUT.PUT_LINE ('未处理:' || v_Untreated );
    DBMS_OUTPUT.PUT_LINE ('合计  :' || (v_Processed + v_Untreated) );
    
    COMMIT;
END;
