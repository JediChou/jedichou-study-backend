-- For Oracle Express
set feedback off
set trimspool on
set linesize 120
set pagesize 2000
set newpage 1
set heading off
set term off

spool e:\otp.txt app
select Feature||','||Feature||','||page||'..' from newspaper;
spool off
