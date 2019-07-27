-- 1.1 pr master
-- select * FROM ASK_PRMASTER where billno like '1CEN-H5%';

-- 1.2 pr detail
-- select * FROM ASK_PRDETAIL where billno like '1CEN-H5%';

-- 2.1 po master
select count(1) from BUY_POMASTER where billno like '2CEN-H5%'

-- 2.2 po detail
-- select * from BUY_PODETAIL where billno like '2CEN-H5%'

-- 3.1 check master
-- select count(1) from EXPENSECTL.CHK_ACPMASTER where billno like '3INE-H5%';
-- select * from EXPENSECTL.CHK_ACPMASTER where billno like '3INE-H5%';

-- 3.2 check detail
-- select count(1) from EXPENSECTL.CHK_ACPDETAIL where billno like '3INE-H5%';
-- select * from EXPENSECTL.CHK_ACPDETAIL where billno like '3INE-H5%';

-- 3.3 check status
-- select count(1) from EXPENSECTL.CHK_ASKREC where CHKBILLNO like '3INE-H5%';
-- select * from EXPENSECTL.CHK_ASKREC where CHKBILLNO like '3INE-H5%';

-- 4.1 take master
-- select count(1) from EXPENSECTL.TKM_TAKEMASTER where BILLNO like '4CEN-H5%';
-- select * from EXPENSECTL.TKM_TAKEMASTER where BILLNO like '4CEN-H5%';

-- 4.2 take detail
-- select count(1) from EXPENSECTL.tkm_takeDetail where BILLNO like '4CEN-H5%';
-- select * from EXPENSECTL.tkm_takeDetail where BILLNO like '4CEN-H5%';