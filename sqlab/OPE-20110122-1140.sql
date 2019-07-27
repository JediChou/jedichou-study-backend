SET SERVEROUPUT ON

DECLARE
    v_char1 CHAR;
    v_char2 CHAR;
BEGIN
    SELECT 1, 2 INTO v_char1, v_char2, FROM dual;
    DBMS_OUTPUT.PUT_LINE('Hello world!');
    DBMS_OUTPUT.PUT_LINE(v_char1 || ' ' || v_char2);
END;
    