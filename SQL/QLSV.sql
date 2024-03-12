select * from tblSinhVien

create sequence sinhvienSeq
	start with 1
	increment by 1

select next value for sinhvienSeq
insert into tblSinhVien(masinhvien,ho,tendem,ten,gioitinh,ngaysinh)
values (
	'Tlu' + cast(next value for sinhvienSeq as varchar(30)),
	N'Nguyễn',
	N'Xuân',
	N'Mai',
	0,
	'2003-03-24'
)

Create procedure SellectAllSinhVien
As
	select masinhvien,
		case 
			when Len(tendem) > 0 then 
				Concat(ho,' ', tendem,' ',ten)
			else Concat(ho,' ',ten)
		end as hoten,
		Convert(varchar(10),ngaysinh,103) as NgaySinh,
		case 
			when gioitinh = 1 then N'Nam'
			else N'Nữ'
		end as GioiTinh,
		quequan,
		diachi,
		dienthoai,
		email
	from tblSinhVien
Go;

exec SellectAllSinhVien
drop  procedure SellectAllSinhVien