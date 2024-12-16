# Evcil-Hayvan-Sahiplenme-Portal---2024-Visual-Studio-Forms
Evcil Hayvan Sahiplendirme Uygulaması

Bu proje, evcil hayvan sahiplenme sürecini kolaylaştırmak için tasarlanmış bir masaüstü uygulamasıdır. Kullanıcılar, evcil hayvan sahiplendirmek veya sahiplenmek için admin ile iletişime geçer ve süreç admin tarafından yönetilir. Projede kullanıcı, admin ve evcil hayvan sahiplenmek isteyen bireylerin etkileşimleri organize edilmiştir.

Uygulamanın Temel Özellikleri

Admin Paneli:

Kullanıcı adı: admin

Şifre: admin

Admin, evcil hayvan sahiplendirme ve sahiplenme taleplerini yönetir.

Evcil Hayvan Sahiplendirme Süreci:

Bir kullanıcı, sahip olduğu evcil hayvan için bilgilerini doldurarak admin'e sahiplendirme isteği gönderir.

Admin, bu isteği kabul eder veya reddeder.

Kabul edilen evcil hayvan bilgileri "Sahiplenme Paneli"ne eklenir.

Evcil Hayvan Sahiplenme Süreci:

"Sahiplenme Paneli"nde listelenen hayvanları gören kullanıcılar, sahiplendirme için admin'e talep gönderir.

Admin, sahiplenme taleplerini değerlendirerek kabul eder veya reddeder.

Uygulamanın Modülleri

1. Giriş Paneli

Kullanıcılar veya admin bu panelden giriş yapar.

Admin giriş bilgileri sabittir:

Kullanıcı adı: admin

Şifre: admin

2. Sahiplendirme Formu

Evcil hayvan bilgileri girilir (isim, tür, yaş, açıklama, vs.).

Admin'e sahiplendirme isteği gönderilir.

3. Admin Paneli

Admin'in tüm talepleri görebildiği ve yönetebildiği alandır:

Sahiplendirme isteklerini kabul veya reddetme.

Sahiplenme isteklerini kabul veya reddetme.

Kabul edilen evcil hayvanları "Sahiplenme Paneli"ne ekleme.

4. Sahiplenme Paneli

Kabul edilen evcil hayvanların listelendiği paneldir.

Kullanıcılar bu panelden sahiplenmek istedikleri hayvan için admin'e talepte bulunur.

Kurulum

Visual Studio 2022 veya daha yeni bir sürümü kurulu olmalıdır.

Proje dosyasını açın.

Veritabanı bağlantı ayarlarını kontrol edin ve gerekli düzenlemeleri yapın.

Uygulamayı derleyip çalıştırın.

Kullanım

Admin Girişi: Admin kullanıcı adı ve şifresiyle giriş yaparak talepleri yönetebilir.

Evcil Hayvan Sahiplendirme: Kullanıcılar sahiplendirmek istedikleri hayvan bilgilerini doldurup admin'e talep gönderir.

Evcil Hayvan Sahiplenme: Sahiplenmek isteyen kullanıcılar, "Sahiplenme Paneli"ndeki hayvanlar için talepte bulunur ve admin'in onayını bekler.

Notlar

Admin paneline yalnızca "admin" kullanıcı adı ve şifresiyle erişilebilir.

Tüm sahiplendirme ve sahiplenme işlemleri admin'in onayıyla gerçekleşir.

Kullanıcılar, işlemlerinin durumu hakkında bilgilendirilecektir.

