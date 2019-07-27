 
 -- 使用以下方式手工導入一張圖片, Jedi Chou 2017-10-17 18:34
 insert into [FoxconnCA2014].[dbo].[UsersLogo]
 ( [id], [IndividId], [Userid] ,[name], [value], [Logo], [isVisibl], [createdate], [rowguid])
 ( 
	select 802, newid(), N'B6C6B494-9346-4AB5-BABD-7DF38D5FA740', N'李平', 1, *, 1, '2017-10-17 17:28', newid()
	from OPENROWSET
            (BULK N'd:\LiPing-PersonalSign.jpg', SINGLE_BLOB)
        AS Picture
 )
 
 -- 在批處理中使用這種方式刪除表數據, Jedi Chou 2017-10-18 09:50
 mysql -uroot -p test_db -e "truncate table tbl_id"