declare
  v_counter INT;
begin
  
  for i in 1..10 loop
    v_counter := i;
  end loop;
  
  forall i in 1..10
    select count(1) from EXPENSECTL.tkm_takeDetail;
    
  COMMIT; 
end;