--5.a
SELECT*
FROM HoaDon join CT_HoaDon on HoaDon.MaHD=CT_HoaDon.MaHD join SanPham  on CT_HoaDon.MaSP=SanPham.MaSP
--
SELECT*
FROM HoaDon, CT_HoaDon, SanPham
WHERE HoaDon.MaHD=CT_HoaDon.MaHD
AND CT_HoaDon.MaSP=SanPham.MaSP
--5.b
SELECT*
FROM SanPham JOIN CT_HoaDon ON SanPham.MaSP=CT_HoaDon.MaSP
--
SELECT*
FROM CT_HoaDon JOIN SanPham ON CT_HoaDon.MaSP=SanPham.MaSP
--