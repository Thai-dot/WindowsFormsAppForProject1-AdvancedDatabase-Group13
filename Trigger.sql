select * from CT_HoaDon

create trigger thanhTienCTHD 
on CT_HOADON
after INSERT,update
AS
begin

	update CT_HoaDon
	set ThanhTien = SoLuong * (GiaBan - GiaGiam)
	where exists(select * from inserted i where i.MaHD = CT_HoaDon.MaHD and i.MaSP = CT_HoaDon.MaSP)

end
go

create trigger TongTien on CT_HOADON
after insert, update
as
begin
	declare @sum float 
	declare @MAHD char(9)
	select @mahd = i.mahd from inserted i
	select @sum = sum(ThanhTien) from CT_HoaDon where exists(select * from inserted i where i.MaHD = CT_HoaDon.MaHD and i.MaSP = CT_HoaDon.MaSP) GROUP BY MAHD
	update HoaDon
	set TongTien = @sum
	where MaHD = @MAHD
end
GO

