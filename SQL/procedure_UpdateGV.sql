select * from tblGiaoVien

create procedure UpdateGV
	@nguoicapnhat nvarchar(50),
	@magiaovien int,
	@ho nvarchar(50),
	@tendem nvarchar(50),
	@ten nvarchar(50),
	@gioitinh tinyint,
	@dienthoai varchar(50),
	@email varchar(50),
	@diachi nvarchar(50),
	@ngaysinh date
as
begin
	update tblGiaoVien
	set 
		nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		ho = @ho,
		tendem = @tendem,
		ten = @ten,
		gioitinh = @gioitinh,
		dienthoai = @dienthoai,
		ngaysinh = @ngaysinh,
		diachi = @diachi,
		email = @email
	where
		magiaovien = @magiaovien
end