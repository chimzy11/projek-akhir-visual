-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Bulan Mei 2023 pada 17.33
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `equiter`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akun`
--

CREATE TABLE `akun` (
  `id_akun` int(11) NOT NULL,
  `namalengkap` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `psw` varchar(100) NOT NULL,
  `nohp` varchar(13) NOT NULL,
  `foto` varchar(255) NOT NULL,
  `status` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`id_akun`, `namalengkap`, `email`, `username`, `psw`, `nohp`, `foto`, `status`) VALUES
(82417320, 'Equiter The Teater', 'equiter@gmail.com', 'Equiter', 'equiter', '08123456789', 'Equiter.jpg', 'Admin'),
(82417321, 'Kania  Putri Ananda', 'Kania@gmail.com', 'Kpananda', '123', '085281888', 'Chimaa_musikal_1.jpeg', 'User'),
(82417322, 'Alif Maulana Setyawan', 'Alif@gmail.com', 'Alif', '123', 'null', 'null', 'User'),
(82417323, 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'Zyaan', '123', '08528174476', 'Monyet.jpg', 'User');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jadwalteater`
--

CREATE TABLE `jadwalteater` (
  `id_teater` int(11) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `kelompok` varchar(255) NOT NULL,
  `genre` varchar(10) NOT NULL,
  `hari` varchar(10) NOT NULL,
  `tanggal_pertunjukkan` varchar(50) NOT NULL,
  `waktu` varchar(50) NOT NULL,
  `tiket` int(11) NOT NULL,
  `harga_tiket` int(11) NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `jadwalteater`
--

INSERT INTO `jadwalteater` (`id_teater`, `judul`, `kelompok`, `genre`, `hari`, `tanggal_pertunjukkan`, `waktu`, `tiket`, `harga_tiket`, `gambar`) VALUES
(2109106020, 'Cinderella', 'Gyzsss', 'Drama', 'Saturday', '2023-05-27', '13.00 - 16.00 WITA', 23, 50000, 'Jadwal_Cinderella1.jpg'),
(2109106021, 'The Crubicle', 'Crubyc', 'Drama', 'Sunday', '2023-05-28', '13.00 - 16.00 WITA', 20, 35000, 'Jadwal_The Crubicle1.jpg'),
(2109106022, 'Hamilton', 'HamGroup', 'Musikal', 'Sunday', '2023-05-28', '19.00 - 22.00 WITA', 16, 50000, 'Jadwal_Hamilton1.jpeg'),
(2109106023, 'Les Miserables', 'Mise', 'Musikal', 'Tuesday', '2023-05-30', '19.00 - 22.00 WITA', 37, 60000, 'Jadwal_Les Miserables1.jpg'),
(2109106024, 'Blithe Spirit', 'Spirit', 'Komedi', 'Tuesday', '2023-05-30', '13.00 - 16.00 WITA', 40, 30000, 'Jadwal_Blithe Spirit1.jpg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `id_akun` int(11) NOT NULL,
  `id_teater` int(11) NOT NULL,
  `kode_pembayaran` varchar(12) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `judul` varchar(255) NOT NULL,
  `genre` varchar(100) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `total_transaksi` int(11) NOT NULL,
  `seat` varchar(255) NOT NULL,
  `tanggal` varchar(50) NOT NULL,
  `gambar_bukti` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `id_akun`, `id_teater`, `kode_pembayaran`, `nama`, `email`, `judul`, `genre`, `jumlah`, `harga`, `total_transaksi`, `seat`, `tanggal`, `gambar_bukti`) VALUES
(2109106061, 82417319, 2109106000, '003156506735', 'Rismayanti', 'chimaa@gmail.com', 'Frozen', 'Musikal', 2, 40000, 80000, 'A7, C7', '2023-05-23 00:00:00 ', 'Chimaa_musikal_5.png'),
(2109106062, 82417319, 2109106000, '320694737762', 'Rismayanti', 'chimaa@gmail.com', 'Moana', 'Musikal', 2, 30000, 60000, 'A2, B7', '2023-05-24 00:00:00 ', 'Chimaa_musikal_6.png'),
(2109106063, 82417319, 2109106000, '805751660304', 'Rismayanti', 'chimaa@gmail.com', 'Frozen', 'Musikal', 2, 40000, 80000, 'C8, C9', '2023-05-23 00:00:00 ', 'Chimaa_musikal_11.png'),
(2109106064, 82417319, 2109106000, '143877825994', 'Nurmedina Maulidiah', 'Dina@gmail.com', 'Moana', 'Musikal', 1, 30000, 30000, 'B8', '2023-05-23 00:00:00 ', 'DinaMauldiah_musikal_2.png'),
(2109106065, 82417318, 2109106000, '143877825994', 'Nurmedina Maulidiah', 'Dina@gmail.com', 'Moana', 'Musikal', 1, 30000, 30000, '3B', '2023-04-23 00:00:00 ', 'DinaMauldiah_musikal_3.png'),
(2109106066, 82417321, 2109106021, '951800440179', 'Kania  Putri Ananda', 'Kania@gmail.com', 'The Crubicle', 'Drama', 2, 35000, 70000, 'C6, C7', '2023-05-24 00:00:00 ', 'Kpananda_drama_1.jpeg'),
(2109106067, 82417323, 2109106022, '240549811122', 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'Hamilton', 'Musikal', 2, 50000, 100000, 'B7, B8', '2023-05-24 00:00:00 ', 'Zyaan_musikal_2.jpeg'),
(2109106068, 82417323, 2109106020, '532165823219', 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'Cinderella', 'Drama', 5, 50000, 250000, 'C7, C8, C9, D1, D2', '2023-05-24 00:00:00 ', 'Zyaan_drama_1.jpeg'),
(2109106069, 82417323, 2109106024, '242430278360', 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'Blithe Spirit', 'Musikal', 2, 30000, 60000, 'B6, B7', '2023-05-24 00:00:00 ', 'Zyaan_komedi_1.jpeg'),
(2109106070, 82417323, 2109106024, '417047180348', 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'Blithe Spirit', 'Musikal', 3, 30000, 90000, 'E4, E5, E6', '2023-05-24 00:00:00 ', 'Zyaan_komedi_2.jpeg'),
(2109106071, 82417323, 2109106022, '509604534264', 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'Hamilton', 'Musikal', 2, 50000, 100000, 'B6, B9', '2023-05-24 00:00:00 ', 'Zyaan_musikal_3.jpeg'),
(2109106072, 82417323, 2109106020, '828633438013', 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'Cinderella', 'Drama', 2, 50000, 100000, 'C5, C6', '2023-05-24 00:00:00 ', 'Zyaan_drama_2.jpeg'),
(2109106073, 82417323, 2109106021, '080872568802', 'Zyaan Gefariel ', 'Zyaan@gmail.com', 'The Crubicle', 'Drama', 3, 35000, 105000, 'C3, C4, C5', '2023-05-24 00:00:00 ', 'Zyaan_drama_3.jpeg');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`id_akun`);

--
-- Indeks untuk tabel `jadwalteater`
--
ALTER TABLE `jadwalteater`
  ADD PRIMARY KEY (`id_teater`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `akun`
--
ALTER TABLE `akun`
  MODIFY `id_akun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82417324;

--
-- AUTO_INCREMENT untuk tabel `jadwalteater`
--
ALTER TABLE `jadwalteater`
  MODIFY `id_teater` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2109106026;

--
-- AUTO_INCREMENT untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2109106074;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
