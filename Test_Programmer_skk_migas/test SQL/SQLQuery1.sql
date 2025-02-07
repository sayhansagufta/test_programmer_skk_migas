--create database penjualan;

--use penjualan;

--create table transaksi(
--	KODE varchar(256),
--	TANGGAL date,
--	KODE_PELANGGAN varchar(255),
--	KODE_BARANG varchar(256),
--	JUMLAH_BARANG decimal(10,0)
--);

--CREATE TABLE pelanggan (
--    KODE VARCHAR(11) PRIMARY KEY,
--    NAMA VARCHAR(256),
--    ALAMAT VARCHAR(256)
--);


--CREATE TABLE barang (
--    KODE VARCHAR(256) PRIMARY KEY,
--    NAMA VARCHAR(256),
--    HARGA DECIMAL(10, 2)
--);

--CREATE TABLE transaksi (
--    KODE VARCHAR(256),
--    TANGGAL DATE,
--    KODE_PELANGGAN VARCHAR(11),
--    KODE_BARANG VARCHAR(256),
--    JUMLAH_BARANG DECIMAL(10, 0),
--    PRIMARY KEY (KODE),  -- Menambahkan primary key untuk tabel transaksi
--    FOREIGN KEY (KODE_PELANGGAN) REFERENCES pelanggan(KODE),
--    FOREIGN KEY (KODE_BARANG) REFERENCES barang(KODE)
--);

--INSERT INTO pelanggan (KODE, NAMA, ALAMAT) VALUES
--('P1', 'Yogi', 'JAKARTA'),
--('P2', 'Anggi', 'BANDUNG'),
--('P3', 'Rahma', 'BANDUNG');

--select * from pelanggan;

--INSERT INTO barang (KODE, NAMA, HARGA) VALUES
--('B1', 'Baju', 12000),
--('B2', 'Celana', 10000),
--('B3', 'Sepatu', 30000);

--select * from barang;

--INSERT INTO transaksi (KODE, TANGGAL, KODE_PELANGGAN, KODE_BARANG, JUMLAH_BARANG) VALUES
--('TRX001', '2019-10-01', 'P1', 'B1', 3),
--('TRX002', '2019-10-02', 'P2', 'B2', 2),
--('TRX003', '2019-10-08', 'P2', 'B1', 5),
--('TRX004', '2019-10-10', 'P1', 'B1', 1),
--('TRX005', '2019-10-17', 'P3', 'B2', 2),
--('TRX006', '2019-10-17', 'P2', 'B2', 1),
--('TRX007', '2019-10-18', 'P3', 'B1', 4),
--('TRX008', '2019-10-18', 'P2', 'B2', 2);

--Select * from transaksi;

--SELECT * 
--FROM barang 
--WHERE HARGA > 10000 
--ORDER BY HARGA ASC;

--SELECT * 
--FROM pelanggan 
--WHERE NAMA LIKE '%g%' 
--AND ALAMAT = 'BANDUNG';

--SELECT 
--    t.KODE AS KODE,
--    t.TANGGAL AS TANGGAL,
--    p.NAMA AS NAMA_PELANGGAN,
--    b.NAMA AS NAMA_BARANG,
--    t.JUMLAH_BARANG AS JUMLAH,
--    b.HARGA AS HARGA_SATUAN,
--    (t.JUMLAH_BARANG * b.HARGA) AS TOTAL
--FROM 
--    transaksi t
--JOIN 
--    pelanggan p ON t.KODE_PELANGGAN = p.KODE
--JOIN 
--    barang b ON t.KODE_BARANG = b.KODE
--WHERE 
--    t.KODE IN ('TRX002', 'TRX003', 'TRX006', 'TRX008', 'TRX005', 'TRX007', 'TRX001', 'TRX004')
--ORDER BY 
--    CASE t.KODE
--        WHEN 'TRX002' THEN 1
--        WHEN 'TRX003' THEN 2
--        WHEN 'TRX006' THEN 3
--        WHEN 'TRX008' THEN 4
--        WHEN 'TRX005' THEN 5
--        WHEN 'TRX007' THEN 6
--        WHEN 'TRX001' THEN 7
--        WHEN 'TRX004' THEN 8
--        ELSE 9  
--    END;

SELECT 
    p.NAMA AS NAMA,
    SUM(t.JUMLAH_BARANG) AS JUMLAH,
    SUM(t.JUMLAH_BARANG * b.HARGA) AS TOTAL_HARGA
FROM 
    transaksi t
JOIN 
    pelanggan p ON t.KODE_PELANGGAN = p.KODE
JOIN 
    barang b ON t.KODE_BARANG = b.KODE
GROUP BY 
    p.NAMA
ORDER BY 
    p.NAMA;  -- Mengurutkan berdasarkan nama pelanggan (opsional)