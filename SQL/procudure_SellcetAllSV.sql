alter procedure [dbo].[SellectAllSinhVien]
	@tukhoa varchar(50)
as 
	select 
		masinhvien,
		case
			when LEN(tendem) > 0 then
				concat(ho, ' ', tendem, ' ', ten)
			else concat(ho,' ',ten)
		end as hoten,
		convert(varchar(10),ngaysinh,103) as nsinh,
		case 
			when gioitinh = 1 then N'Nam'
			else N'Nữ'
		end as gtinh,
		quequan,
		diachi,
		dienthoai,
		email
	from tblSinhVien
	where 
		lower(ho) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(tendem) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(ten) like '%' + lower(trim(@tukhoa)) + '%'
		or dienthoai like '%' + lower(trim(@tukhoa)) + '%'
	order by hoten;

select * from tblSinhVien
exec [SellectAllSinhVien] 'mai'