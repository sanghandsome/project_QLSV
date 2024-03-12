

alter procedure SellectAllGV
	@tukhoa nvarchar(50)
as
begin
	select 
		magiaovien,
		case
			when Len(tendem) > 0 then concat(ho,' ',tendem,' ',ten)
			else concat(ho,' ' ,ten)
		end as hoten,
		convert(varchar(30),ngaysinh,103) as nsinh,
		case
			when gioitinh = 1 then N'Nam'
			else N'Nữ'
		end as gt,
		dienthoai,
		email,
		diachi
	from tblGiaoVien
	where 
		lower(concat(ho,' ',tendem,' ',ten)) like'%' + lower(trim(@tukhoa)) + '%'
		or dienthoai like '%' + lower(trim(@tukhoa)) + '%'
		or cast(magiaovien as varchar(30)) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(email) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(ho) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(tendem) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(ten) like '%' + lower(trim(@tukhoa)) + '%'
	order by hoten
end

select *from tblGiaoVien

exec SellectAllGV N'sáng'