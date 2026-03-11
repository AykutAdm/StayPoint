## 🏨 StayPoint

> 🎓 Bu proje, **Murat Yücedağ** hocamızın hazırladığı  
> **"Asp.Net Core Api - Rapid Api ve Api Consume"** eğitim serisi kapsamında geliştirilmiştir.

[📺 Eğitim serisine buradan ulaşabilirsiniz](https://www.udemy.com/course/aspnet-core-api-rapid-api-ve-api-consume/)

---

## 📋 Proje Hakkında

**StayPoint**, **ASP.NET Core 6.0** ile geliştirilmiş bir otel rezervasyon ve yönetim platformudur. Uygulama, **N-Tier** mimari ile kurgulanmış olup Microsoft SQL Server veritabanı üzerinde çalışmaktadır.

Müşteriler ana sayfada odaları, hizmetleri, referansları ve hakkımızda içeriğini inceleyebilir; tarih ve kişi bilgisiyle rezervasyon oluşturabilir; iletişim formu gönderebilir ve bülten aboneliği yapabilir. Yöneticiler ise admin panelinden odaları, rezervasyonları, misafirleri, personeli, hizmetleri, referansları, hakkımızda metnini ve mesaj kutularını (Inbox / Sendbox) yönetebilir. Ayrıca kullanıcılara rol atama, çalışma lokasyonu yönetimi, SMTP ile mail gönderimi ve resim yükleme işlemleri desteklenmektedir.

Proje, **AutoMapper** ile entity–DTO dönüşümleri yapar, **FluentValidation** ile doğrulama kurallarını uygular. Kimlik doğrulama **ASP.NET Core Identity** ve **Cookie** tabanlı authentication ile yapılmaktadır. Ayrı bir **JWT** projesi token üretimi için kullanılır. **RapidAPI** entegrasyonu ile **Booking.com** üzerinden otel araması, IMDB film listesi, Instagram ve Twitter takipçi sayıları ile döviz kurları dashboard’da gösterilebilir.

Bu proje, otel/konaklama sektörü için rezervasyon ve içerik yönetimi uygulaması geliştirme ve **N-Tier** mimarisini ve Api ile katmanlar arası iletişimi öğrenme amacıyla geliştirilmiştir.

---

## 🛠️ Kullanılan Teknolojiler

### 🔧 Backend (Web API)
- ASP.NET Core 6.0 Web API
- Swagger (OpenAPI)
- AutoMapper
- Entity Framework Core 6.0
- Newtonsoft.Json

### 🎨 Frontend (Web UI)
- ASP.NET Core 6.0 MVC
- HTML5, CSS3, JavaScript
- Bootstrap
- jQuery
- FluentValidation (form doğrulama)
- MailKit (SMTP ile e-posta gönderimi)

### 🧩 Veri Yönetimi
- DTO katmanı
- AutoMapper ile entity–DTO eşlemesi

### 🗄️ Veritabanı
- SQL Server
- Entity Framework Core (Code First)
- ASP.NET Core Identity (AppUser, AppRole)
  
### 🔐 Kimlik Doğrulama
- JWT Bearer Authentication
- Cookie tabanlı token yönetimi

### 📡 Harici API Entegrasyonu
- RapidAPI (Booking.com otel araması, IMDB film listesi, Instagram/Twitter takipçi sayıları, döviz kurları)

## 🏗️ Mimari
N-Tier mimarisinde katmanlar sırasıyla aşağıdan yukarıya bağımlılık taşır. Entity katmanı temel varlıkları, DataAccess katmanı veri erişimini, Business katmanı iş kurallarını ve Dto katmanı veri transfer nesnelerini içerir. WebApi ve WebUI katmanları sunum katmanlarını oluşturur.

| Katman | Proje | Açıklama |
|--------|-------|----------|
| **Entity** | StayPoint.EntityLayer | Varlıklar (Room, Booking, Guest, Staff, Service, About, Contact vb.) |
| **Data Access** | StayPoint.DataAccessLayer | EF Core DbContext, repository implementasyonları |
| **Business** | StayPoint.BusinessLayer | Servis interface'leri ve business logic implementasyonları |
| **DTO** | StayPoint.DtoLayer | Veri transfer nesneleri (DTO) |
| **Presentation** | StayPoint.WebApi | REST API (Swagger) |
| **Frontend** | StayPoint.WebUI | MVC arayüzü |

---

## 🖼️ Ekran Görüntüleri

### 🏠 Kullanıcı Arayüzü

<div align="center">
  <img src="Images/AnaSayfa-1.png" alt="Kullanıcı Paneli-1" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-2.png" alt="Kullanıcı Paneli-2" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-3.png" alt="Kullanıcı Paneli-3" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-4.png" alt="Kullanıcı Paneli-4" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-5.png" alt="Kullanıcı Paneli-5" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-6.png" alt="Kullanıcı Paneli-6" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-7.png" alt="Kullanıcı Paneli-7" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-8.png" alt="Kullanıcı Paneli-8" width="800" style="margin: 10px;">
  <img src="Images/AnaSayfa-9.png" alt="Kullanıcı Paneli-9" width="800" style="margin: 10px;">
</div>


### 🔐 Admin Paneli

<div align="center">
  <img src="Images/AdminDashboard-1.png" alt="Admin Paneli-1" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-2.png" alt="Admin Paneli-2" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-3.png" alt="Admin Paneli-3" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-4.png" alt="Admin Paneli-4" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-5.png" alt="Admin Paneli-5" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-6.png" alt="Admin Paneli-6" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-7.png" alt="Admin Paneli-7" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-8.png" alt="Admin Paneli-8" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-9.png" alt="Admin Paneli-9" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-10.png" alt="Admin Paneli-10" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-11.png" alt="Admin Paneli-11" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-12.png" alt="Admin Paneli-12" width="800" style="margin: 10px;">
  <img src="Images/AdminDashboard-13.png" alt="Admin Paneli-13" width="800" style="margin: 10px;">
</div>

### 🔑 Login ve Register Sayfası

<div align="center">
  <img src="Images/Login.png" alt="Login Sayfası" width="800" style="margin: 10px;">
  <img src="Images/Register.png" alt="Register Sayfası" width="800" style="margin: 10px;">
</div>

### 🗄️ Database Diyagram

<div align="center">
  <img src="Images/Db.png" alt="Database Diyagram" width="800" style="margin: 10px;">
</div>
