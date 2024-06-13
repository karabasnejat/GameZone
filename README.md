# GameZone - ASP.NET Core using RAWG API

GameZone, RAWG API kullanarak oyun bilgilerini listeleyen ve oyun detaylarını görüntüleyen bir ASP.NET Core MVC web uygulamasıdır.

<div style="display: flex; flex-wrap: wrap; gap: 10px;">
 <img width="400" alt="1" src="![image](https://github.com/karabasnejat/GameZone/assets/62561906/eb3fc696-65fe-4888-97b7-7436cca5bddb)
![image](https://github.com/karabasnejat/GameZone/assets/62561906/eb3fc696-65fe-4888-97b7-7436cca5bddb)
">
</div>

## Özellikler

- Anasayfada trend oyunların listelenmesi
- Oyunun detay sayfasında oyunun açıklaması, görselleri, rating, platformlar ve mağazalar hakkında bilgi
- Lightbox entegrasyonu ile tıklanabilir oyun görselleri
- Responsive sidebar menüsü

## Teknolojiler

- **ASP.NET Core 7.0**: Backend services and API development.
- **Entity Framework Core**: Efficient data management and ORM.
- **Ocelot API Gateway**: Secure routing between microservices.
- **Tailwind CSS**: Modern, responsive design framework.
- **Node.js**: Additional backend services and utilities.
- **N-Tier Architecture**: Separates concerns across different layers, improving maintainability.

## Kurulum

Bu projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin.

### Gereksinimler

- .NET 7.0 SDK
- Visual Studio veya Visual Studio Code
- Git

### Adımlar

1. Depoyu klonlayın:

    ```bash
    git clone https://github.com/username/GameZone.git
    cd GameZone
    ```

2. Gerekli bağımlılıkları yükleyin:

    ```bash
    dotnet restore
    ```

3. Veritabanını ve gerekli konfigürasyonları güncelleyin:

    - `appsettings.json` dosyasını yapılandırın.
    - RAWG API anahtarını ayarlayın (`GameService.cs` dosyasında anahtarınızı kontrol edin).

4. Uygulamayı çalıştırın:

    ```bash
    dotnet run
    ```

5. Tarayıcınızda aşağıdaki URL'yi açın:

    ```
    https://localhost:5001
    ```

## Kullanım

- Anasayfada trend oyunları görebilirsiniz.
- Oyun başlıklarına tıklayarak oyunların detay sayfasına ulaşabilirsiniz.
- Detay sayfasında oyun görsellerine tıklayarak büyük boyutta görebilirsiniz.

## Katkıda Bulunma

Katkıda bulunmak isterseniz lütfen bir pull request gönderin. Herhangi bir hata veya öneri için issue açabilirsiniz.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

## Ekran Görüntüleri

### Ana Sayfa

![Ana Sayfa](./screenshots/home.png)

### Oyun Detay Sayfası

![Oyun Detay Sayfası](./screenshots/details.png)
