# ⛽ Petrol İstasyonu Yönetim Sistemi

Bu proje, **C# Windows Forms** ve **SQL Server** kullanılarak **eğitim amaçlı** geliştirilmiş bir otomasyon simülasyonudur. Sistem, bir akaryakıt istasyonunun satış ve envanter döngüsünü uçtan uca yönetmektedir.

## Eklediğim Özellikler

Eğitim içeriği üzerine şahsım tarafından entegre edilen fonksiyonel geliştirmeler:

* **Depo Stok Yönetimi:** İstasyonun dışarıdan yaptığı yakıt alımlarını yöneten "Petrol Alış" paneli eklenmiştir.
* **Finans & Stok Senkronizasyonu:** Alım yapıldığında; toplam tutar **Kasa (TBLKASA)** bakiyesinden düşerken, ilgili yakıtın **Stok (TBLBENZIN)** miktarı anlık olarak artırılır.
* **Görsel Takip:** Depo doluluk oranları `ProgressBar` bileşenleri üzerinden dinamik olarak görselleştirilmiştir.
* **Otomatik Hesaplama:** Alım fiyatı ve litre miktarı girildiği anda toplam tutar yazılımsal olarak hesaplanıp kullanıcıya sunulur.
* **Veri Arşivleme:** Tüm alım işlemleri, veritabanında tarafımdan oluşturulan **`TBLALIM`** tablosuna kaydedilmektedir.

---

## Kullanılan Teknolojiler
**Dil:** C# (Windows Forms)

**Veritabanı:** MS SQL Server

**Veri Erişimi:** ADO.NET

---
### Veritabanı Şeması (SQL)
Sistem, Microsoft SQL Server üzerinde **`PetrolSatış`** veritabanı altında çalışır:



```sql
-- Alım geçmişini tutan özgün tablo yapısı
CREATE TABLE TBLALIM (
    ID INT PRIMARY KEY IDENTITY(1,1),
    BENZINTURU VARCHAR(20),
    EKLENENLITRE DECIMAL(18,2),
    FIYAT DECIMAL(18,2),
    TARIH DATETIME DEFAULT GETDATE()
)

```
---

## 📁 Veritabanı Kurulumu ve Yapılandırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1. **SQL Sunucusuna Bağlanın:** * Projede **Microsoft SQL Server Management Studio (SSMS)** kullanılmıştır.

2. **Veritabanı Oluşturun:** * Sunucu üzerinde tam olarak **`PetrolSatış`** adında yeni bir veritabanı oluşturun.

3. **Scripti Çalıştırın:** * Proje klasöründeki `Database/Petrol.sql` dosyasını açın ve içeriğindeki sorguları oluşturduğunuz **`PetrolSatış`** veritabanı seçiliyken çalıştırın. Bu işlem; `TBLBENZIN`, `TBLKASA`, `TBLHAREKET` ve `TBLALIM` tablolarını otomatik olarak kuracaktır.

4. **Bağlantı Ayarı (Connection String):** * `Form1.cs` dosyasına giderek `SqlConnection` satırındaki `Data Source` (Sunucu Adı) kısmını kendi SQL sunucu adınıza göre güncellediğinizden emin olun.
