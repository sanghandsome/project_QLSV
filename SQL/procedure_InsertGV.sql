select * from tblGiaoVien

create procedure InsertGV
	@nguoitao varchar(30),
	@ho nvarchar(50),
	@tendem nvarchar(50),
	@ten nvarchar(50),
	@gioitinh tinyint,
	@ngaysinh date,
	@dienthoai varchar(50),
	@email varchar(50),
	@diachi nvarchar(50)
as
begin
	Insert into tblGiaoVien(
		nguoitao,ho,tendem,ten,gioitinh,dienthoai,
		email,ngaysinh,diachi
	)values(
		@nguoitao,@ho,@tendem,@ten,@gioitinh,@dienthoai,
		@email,@ngaysinh,@diachi
	);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end