READ ME !!!


Tools yang dibutuhkan :

1. Visual Studio 2015

2.SQL Server 2014 Management Studio





Untuk menjalankan Sistem Informasi Gereja HKBP Silahkan ikuti langkah-langkah berikut dengan kondisi Anda sudah me-restore Database Sigra_DB :


1. Buka Visual Studio 2015

2. Pada bagian pojok kiri atas pilih menu File -> Open -> Web Site

3. Cari Folder yang Anda download

4. Klik tombol "Open"

5. Pada bagian "Solution Explorer" pilih Web.config

6. Pada tag <ConnectionStrings> sesuaikan dengan potongan kode berikut
   

<add name="constr" connectionString="Data Source=(Nama Server Anda);Initial Catalog=(Nama Database);Integrated Security=True" providerName="System.Data.SqlClient"/>


7. Pada bagian "Solution Explorer" pilih Index.aspx

8. Klik kanan pada bagian editor kemudian pilih View in Browser atau tekan tombol Ctrl + Shift + W untuk me-Run Sistem informasi Gereja HKBP



Tambahan :

Untuk melakukan konfigurasi sistem silahkan copy link berikut : http://localhost:4647/Default




Daftar Akun :

1. Role = Pimpinan Gereja
	
Username = pimpinan
	
Password = pimpinan



2. Role = Tata usaha
	
Username = tatausaha
	
Password = tatausaha



3. Role = Bendahara
	
Username = bendahara
	
Password = bendahara



4. Role = Sintua Sektor
	
Username = sintua
	
Password = sintua



