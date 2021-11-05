--a) Cho danh sách các hoá đơn lập trong năm 2020
select * 
from HoaDon
where YEAR(NgayLap) = 2020
--b) Cho danh sách các khách hàng ở TPHCM
select *
from KhachHang
where TPho = N'Thành phố Hồ Chí Minh'
--c) Cho danh sách các sản phẩm có giá trong một khoảng từ....đến
select *
from SanPham
where Gia between 1000 and 10000
--d) Cho danh sách các sản phẩm có số lượng tồn <100
select *
from SanPham
where SoLuongTon < 100
--e) Cho danh sách các sản phẩm bán chạy nhất (số lượng bán nhiều nhất)
select sp.MaSP 'Mã sản phẩm', sp.TenSP 'Tên sản phẩm', sum(ct.SoLuong) N'Số lượng bán'
from SanPham sp join CT_HoaDon ct on ct.MaSP = sp.MaSP
group by sp.MaSP, sp.TenSP
having sum(ct.SoLuong) >= all( select sum(ct1.SoLuong)
							   from SanPham sp1 join CT_HoaDon ct1 on sp1.MaSP=ct1.MaSP
							   group by sp1.MaSP )
--f) Cho danh sách các sản phẩm có doanh thu cao nhất
select sp.MaSP 'Mã sản phẩm', sp.TenSP 'Tên sản phẩm', sum(ct.ThanhTien) N'Doanh thu'
from SanPham sp join CT_HoaDon ct on ct.MaSP = sp.MaSP
group by sp.MaSP, sp.TenSP
having sum(ct.ThanhTien) >= all( select sum(ct1.ThanhTien)
							   from SanPham sp1 join CT_HoaDon ct1 on sp1.MaSP=ct1.MaSP
							   group by sp1.MaSP )
