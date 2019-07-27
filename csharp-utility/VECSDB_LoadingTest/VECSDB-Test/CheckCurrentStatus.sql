/******************************************************************************
 * Filename: CheckCurrentStatus.sql
 * Description: Check Order Commit Status for loading test
 * Author: Jedi Chou
 * Date: 2016.5.27 11:48
 *****************************************************************************/

SET SERVEROUTPUT ON
DECLARE
  v_Processed NUMBER := 0;  -- �Ѵ����Ԥ�ᱨ����
  v_Untreated NUMBER := 0;  -- δ�����Ԥ�ᱨ����
BEGIN 

    /* ����Ѵ����Ԥ�ᱨ���� */
    SELECT COUNT(1) INTO v_Processed 
        FROM BUY_POMASTER 
        -- WHERE (billno LIKE '2CEN-H5%' OR billno like '2CEN-H6%') AND flag = 6 ;
        WHERE flag = 6 ;
    
    /* ���δ�����Ԥ�ᱨ���� */    
    SELECT COUNT(1) INTO v_Untreated 
        FROM BUY_POMASTER 
        -- WHERE (billno LIKE '2CEN-H5%' OR billno like '2CEN-H6%') AND flag = 5;
        WHERE flag = 5;
        
    /* ��� */
    DBMS_OUTPUT.PUT_LINE ('�Ѵ���:' || v_Processed );
    DBMS_OUTPUT.PUT_LINE ('δ����:' || v_Untreated );
    DBMS_OUTPUT.PUT_LINE ('�ϼ�  :' || (v_Processed + v_Untreated) );
    
    COMMIT;
END;
